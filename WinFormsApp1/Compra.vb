Public Class Compra

    ' Método para manejar el clic en el botón de búsqueda
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btn_buscarCodigo.Click
        Dim codigoProducto As String = txt_codigo.Text

        If String.IsNullOrWhiteSpace(codigoProducto) Then
            MessageBox.Show("Por favor ingrese un código de producto válido.")
            Return
        End If

        Dim producto As Producto = BuscarProductoPorCodigo(codigoProducto)
        MostrarDatosProducto(producto)
    End Sub


    ' Método para buscar un producto por su código en el archivo
    Private Function BuscarProductoPorCodigo(codigo As String) As Producto
        Dim producto As Producto = Nothing
        Dim rutaArchivo As String = "Datos\producto.txt" ' Ruta relativa

        Try
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivo)
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)
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


    ' Método para mostrar los datos del producto en el formulario
    Private Sub MostrarDatosProducto(producto As Producto)
        If producto IsNot Nothing Then
            txt_nombre.Text = producto.Nombre
            txt_talla.Text = producto.Talla
            txt_precioProducto.Text = producto.Precio.ToString("C")
            txt_stock.Text = producto.StockActual.
                ToString()

            ' Buscar la marca
            Dim marca As Marca = Marca.LeerMarcas().FirstOrDefault(Function(m) m.IdMarca = producto.IdMarca)
            If marca IsNot Nothing Then
                txt_marca.Text = marca.Nombre
            Else
                txt_marca.Text = "-"
            End If
        Else
            txt_nombre.Text = "-"
            txt_talla.Text = "-"
            txt_precioProducto.Text = "-"
            txt_stock.Text = "-"
            txt_marca.Text = "-"
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim producto As Producto = BuscarProductoPorCodigo(txt_codigo.Text)
        Try
            If producto IsNot Nothing Then
                ' Crear una nueva fila en el DataGridView
                Dim fila As DataGridViewRow = CType(tablaCompra.Rows(0).Clone(), DataGridViewRow)

                ' Asignar los valores de los TextBox a las celdas de la fila
                fila.Cells(0).Value = txt_codigo.Text
                fila.Cells(1).Value = txt_marca.Text
                fila.Cells(2).Value = txt_nombre.Text
                fila.Cells(3).Value = txt_talla.Text
                fila.Cells(4).Value = txt_cantidad.Text
                ' Suponiendo que el subtotal es cantidad * precio compra
                fila.Cells(5).Value = CDec(txt_cantidad.Text) * CDec(txt_precioProducto.Text)

                ' Agregar la fila al DataGridView
                tablaCompra.Rows.Add(fila)

                ' Limpiar los TextBox después de agregar la fila
                txt_codigo.Clear()
                txt_nombre.Clear()
                txt_marca.Clear()
                txt_talla.Clear()
                txt_stock.Clear()
                txt_cantidad.Clear()
                txt_precioProducto.Clear()
            Else
                MessageBox.Show($"Error al tratar de agregar producto, debido a que este no existe. Intente con un nuevo código de producto")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al tratar de agregar producto, debido a que este no existe. Intente con un nuevo código de producto")
        End Try


    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            ' Verificar si el campo txtCodigo no está vacío
            If txt_codigo.Text.Trim() <> String.Empty Then
                ' Variable para determinar si se encontró el código
                Dim encontrado As Boolean = False

                ' Recorrer las filas del DataGridView
                For Each fila As DataGridViewRow In tablaCompra.Rows
                    ' Verificar si el valor de la celda "Código" coincide con el valor en txtCodigo
                    If fila.Cells("Codigo").Value IsNot Nothing AndAlso fila.Cells("Codigo").Value.ToString() = txt_codigo.Text Then
                        ' Eliminar la fila
                        tablaCompra.Rows.Remove(fila)
                        encontrado = True
                        Exit For ' Salir del bucle una vez que se elimine la fila
                    End If
                Next

                ' Mostrar mensaje si no se encontró el código
                If Not encontrado Then
                    MessageBox.Show("No se encontró ninguna fila con el código ingresado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                ' Mostrar mensaje si el campo de código está vacío
                MessageBox.Show("Por favor, ingrese un código para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Ocurrió un error al intentar eliminar la fila. Detalles del error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_generaCompra_Click(sender As Object, e As EventArgs) Handles btn_generaCompra.Click

    End Sub
End Class