Public Class Inventario

    ' Método para buscar un producto por su código en el archivo de productos
    Private Function BuscarProductoPorCodigo(codigo As String) As Producto
        Dim producto As Producto = Nothing
        Dim rutaArchivo As String = "Datos\producto.txt" ' Ruta relativa

        Try
            ' Verificar si el archivo existe
            If Not System.IO.File.Exists(rutaArchivo) Then
                MessageBox.Show($"El archivo {rutaArchivo} no existe.")
                Return producto
            End If

            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivo)

            ' Asegurarse de ignorar la primera línea (encabezado)
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim fields() As String = line.Split("|"c)

                ' Validar que la línea tenga el número correcto de campos
                If fields.Length <> 9 Then
                    MessageBox.Show($"La línea '{line}' no tiene el número correcto de campos.")
                    Continue For
                End If

                ' Comprobar si el código del producto coincide
                If fields(1) = codigo Then
                    producto = New Producto() With {
                        .IdProducto = Integer.Parse(fields(0)),
                        .Codigo = fields(1),
                        .Nombre = fields(2),
                        .Talla = fields(3),
                        .Precio = Decimal.Parse(fields(4)),
                        .StockActual = Integer.Parse(fields(5)),
                        .IdCategoria = Integer.Parse(fields(6)),
                        .IdMarca = Integer.Parse(fields(7)),
                        .Estado = Boolean.Parse(fields(8))
                    }
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al buscar el producto. Ruta del archivo: {rutaArchivo}. Error: {ex.Message}")
        End Try

        Return producto
    End Function

    ' Método para leer las operaciones del Kardex por IdProducto y convertir IdProducto a su código
    Private Function LeerOperacionesKardexPorIdProducto(idProducto As Integer) As List(Of Kardex)
        Dim operaciones As New List(Of Kardex)
        Dim rutaArchivo As String = "Datos\kardex.txt" ' Ruta relativa al archivo Kardex
        Dim rutaArchivoProducto As String = "Datos\producto.txt" ' Ruta relativa al archivo Producto

        Try
            ' Verificar si el archivo Kardex existe
            If Not System.IO.File.Exists(rutaArchivo) Then
                MessageBox.Show($"El archivo {rutaArchivo} no existe.")
                Return operaciones
            End If

            Dim linesKardex() As String = System.IO.File.ReadAllLines(rutaArchivo)
            Dim codigoProductoMap As New Dictionary(Of Integer, String)

            ' Leer el archivo de productos para obtener un mapa de IdProducto a Código
            If System.IO.File.Exists(rutaArchivoProducto) Then
                Dim linesProducto() As String = System.IO.File.ReadAllLines(rutaArchivoProducto)
                For i As Integer = 1 To linesProducto.Length - 1
                    Dim line As String = linesProducto(i)
                    Dim fields() As String = line.Split("|"c)
                    If fields.Length = 9 Then
                        Dim idProductoMap As Integer
                        If Integer.TryParse(fields(0), idProductoMap) Then
                            codigoProductoMap(idProductoMap) = fields(1)
                        End If
                    End If
                Next
            End If

            ' Asegurarse de ignorar la primera línea (encabezado)
            For i As Integer = 1 To linesKardex.Length - 1
                Dim line As String = linesKardex(i)
                Dim fields() As String = line.Split("|"c)

                ' Validar que la línea tenga el número correcto de campos
                If fields.Length <> 8 Then
                    MessageBox.Show($"La línea '{line}' no tiene el número correcto de campos.")
                    Continue For
                End If

                Dim idProductoActual As Integer
                If Not Integer.TryParse(fields(5), idProductoActual) Then
                    MessageBox.Show($"Error al convertir IdProducto: {fields(5)}")
                    Continue For
                End If

                If idProductoActual = idProducto Then
                    Dim operacionKardex As New Kardex()
                    Try
                        operacionKardex.IdKardex = Integer.Parse(fields(0))
                        operacionKardex.FechaReg = Date.Parse(fields(1))
                        operacionKardex.Operacion = fields(2)
                        operacionKardex.TipoOperacion = fields(3)
                        operacionKardex.Cantidad = Integer.Parse(fields(4))
                        operacionKardex.IdProducto = idProductoActual
                        operacionKardex.Saldo = Integer.Parse(fields(6))
                        operacionKardex.Estado = Boolean.Parse(fields(7))
                    Catch ex As Exception
                        MessageBox.Show($"Error al procesar la línea: {line}. Error: {ex.Message}")
                        Continue For
                    End Try

                    operaciones.Add(operacionKardex)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer las operaciones del Kardex. Ruta del archivo: {rutaArchivo}. Error: {ex.Message}")
        End Try

        Return operaciones
    End Function

    ' Método para buscar y mostrar las operaciones del Kardex para un producto específico
    Private Sub MostrarOperacionesKardexPorCodigo(codigoProducto As String)
        Dim producto As Producto = BuscarProductoPorCodigo(codigoProducto)
        If producto Is Nothing Then
            MessageBox.Show("Producto no encontrado.")
            Return
        End If

        Dim operaciones As List(Of Kardex) = LeerOperacionesKardexPorIdProducto(producto.IdProducto)

        ' Limpiar el DataGridView antes de agregar nuevas filas
        dgvProductoKardex.Rows.Clear()

        For Each operacion As Kardex In operaciones
            dgvProductoKardex.Rows.Add(
                operacion.IdKardex,
                operacion.FechaReg.ToString("yyyy-MM-dd"),
                operacion.Operacion,
                operacion.TipoOperacion,
                operacion.Cantidad,
                producto.Codigo, ' Aquí se muestra el código del producto
                operacion.Saldo
            )
        Next
    End Sub

    ' Ejemplo de uso en el evento Click de un botón
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim codigoProducto As String = txtCodigoProducto.Text
        MostrarOperacionesKardexPorCodigo(codigoProducto)
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Home.Show()
        Me.Hide()

    End Sub
End Class
