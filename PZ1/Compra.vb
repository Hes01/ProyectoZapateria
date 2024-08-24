Public Class Compra

    ' Método para manejar el clic en el botón de búsqueda
    Private Sub btn_buscarCodigo_Click(sender As Object, e As EventArgs) Handles btn_buscarCodigo.Click
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
                Console.WriteLine(line)
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
            txt_precioProducto.Text = producto.Precio.ToString("0.00")
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
        txt_cantida.Value = "0"

        ' Obtener el precio del producto
        Dim precio As Decimal
        If Not Decimal.TryParse(txt_precioProducto.Text.Replace("C", "").Trim(), precio) Then
            MessageBox.Show("Error al obtener el precio del producto.")
            Return
        End If
        ' Calcular el precio total
        Dim precioTotal As Decimal = precio * CInt(txt_cantida.Value)

        ' Mostrar el precio total en txtSubtotal
        txt_subTotal.Text = precioTotal.ToString("0.00")

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click


        If String.IsNullOrWhiteSpace(txt_codigo.Text) Then
            MessageBox.Show("Por favor busque un producto primero.")
            Return
        End If

        ' Obtener la cantidad ingresada desde el NumericUpDown
        Dim cantidad As Integer = CInt(txt_cantida.Value)

        ' Verificar que la cantidad sea mayor a 0
        If cantidad <= 0 Then
            MessageBox.Show("Por favor ingrese una cantidad válida.")
            Return
        End If

        ' Obtener el precio del producto
        Dim precio As Decimal
        If Not Decimal.TryParse(txt_precioProducto.Text.Replace("C", "").Trim(), precio) Then
            MessageBox.Show("Error al obtener el precio del producto.")
            Return
        End If

        ' Calcular el precio total
        Dim precioTotal As Decimal = precio * cantidad

        ' Mostrar el precio total en txtSubtotal
        txt_subTotal.Text = precioTotal.ToString("0.00")



        ' Agregar el producto al grid de ventas
        tablaCompra.Rows.Add(txt_codigo.Text, txt_marca.Text, txt_nombre.Text, txt_talla.Text, cantidad, precioTotal.ToString("0.00"))

        ' Limpiar los campos
        txt_codigo.Text = ""
        txt_cantida.Value = 0
        txt_nombre.Text = "-"
        txt_talla.Text = "-"
        txt_precioProducto.Text = "-"
        txt_stock.Text = "-"
        txt_marca.Text = "-"
        txt_subTotal.Text = ""

        ActualizarTotal()



    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        ' Verificar si hay una fila seleccionada
        If tablaCompra.SelectedRows.Count > 0 Then
            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Eliminar la fila seleccionada
                tablaCompra.Rows.Remove(tablaCompra.SelectedRows(0))
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila para eliminar.")
        End If
        ActualizarTotal()

    End Sub

    Public Sub ActualizarTotal()
        Dim total As Decimal = 0.00
        Dim cultureInfo As Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture

        For Each row As DataGridViewRow In tablaCompra.Rows
            ' Verificar si la fila es una fila de datos (no una fila nueva)
            If Not row.IsNewRow Then
                Dim subtotalText As String = row.Cells(5).Value.ToString()
                Dim subtotal As Decimal
                ' Intentar convertir el texto del subtotal a Decimal
                If Decimal.TryParse(subtotalText.Replace("S/", "").Trim(), Globalization.NumberStyles.Number, cultureInfo, subtotal) Then
                    total += subtotal
                End If
            End If
        Next

        ' Mostrar el total en txtTotal
        txt_total.Text = total.ToString("0.00")
    End Sub


    Private Sub btn_generaCompra_Click(sender As Object, e As EventArgs) Handles btn_generaCompra.Click
        ' Verificar que haya productos en el DataGridView
        If tablaCompra.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la venta. Por favor agregue productos antes de generar la venta.")
            Return
        End If

        ' Obtener los datos del cliente
        Dim idPersona As Integer = 0
        If Not Integer.TryParse(txt_idProveedor.Text, idPersona) Then
            MessageBox.Show("Debe ingresar un ID de proveedor válido.")
            Return
        End If


        ' Verificar que se va a llamar al método GenerarVenta
        MessageBox.Show("A punto de llamar a GenerarCompra")

        ' Generar la venta
        Try
            Dim nuevaCompra As New Compra()
            nuevaCompra.GenerarCompra(idPersona, idPersona, txt_total.Text)

            ' Limpiar el DataGridView y los campos
            tablaCompra.Rows.Clear()

            MessageBox.Show("Compra generada exitosamente.")
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al generar la compra: {ex.Message}")
        End Try


    End Sub



    Public Sub GenerarCompra(idPersona As Integer, idVendedor As Integer, text As String)
        Dim total As Decimal
        total = Decimal.Parse(text)
        ' Mostrar el valor de txtTotal para depuración
        MessageBox.Show($"Valor del total: " + total.ToString())
        Dim nuevoComprobante As New Comprobante With {
        .IdComprobante = Comprobante.GenerarNuevoIdComprobante(),
        .Fecha = Date.Now,
        .Total = total,
        .TipoPago = "Efectivo",
        .IdPersona = idPersona,
        .IdVendedor = idVendedor,
        .Estado = True
    }
        nuevoComprobante.GuardarComprobante()

        ' Guardar detalles de la compra
        For Each row As DataGridViewRow In tablaCompra.Rows
            If Not row.IsNewRow Then
                Dim codigoProductoStr As String = row.Cells(0).Value.ToString()
                Dim cantidadStr As String = row.Cells(4).Value.ToString()
                Dim precioVentaStr As String = row.Cells(5).Value.ToString()

                Dim codigoProducto As Integer
                Dim cantidad As Integer
                Dim precioVenta As Decimal

                If Not Integer.TryParse(codigoProductoStr, codigoProducto) Then
                    MessageBox.Show($"El formato del ID del producto '{codigoProductoStr}' es incorrecto.")
                    Return
                End If

                If Not Integer.TryParse(cantidadStr, cantidad) Then
                    MessageBox.Show($"El formato de la cantidad '{cantidadStr}' es incorrecto.")
                    Return
                End If

                If Not Decimal.TryParse(precioVentaStr.Replace("S/", "").Trim(), Globalization.NumberStyles.Number, Globalization.CultureInfo.CurrentCulture, precioVenta) Then
                    MessageBox.Show($"El formato del precio de venta '{precioVentaStr}' es incorrecto.")
                    Return
                End If

                Dim nuevoDetalle As New DetalleComprobante With {
                .IdDetalle = DetalleComprobante.GenerarNuevoIdDetalle(),
                .Cantidad = cantidad,
                .PrecioVenta = precioVenta,
                .IdProducto = codigoProducto,
                .IdComprobante = nuevoComprobante.IdComprobante,
                .Estado = True
            }
                nuevoDetalle.GuardarDetalle()

                ' Registrar la operación en el Kardex
                Dim kardex As New Kardex With {
                .IdKardex = Kardex.CalcularSiguienteId(),
                .FechaReg = Date.Now,
                .Operacion = "Compra",
                .TipoOperacion = "Entrada",
                .Cantidad = cantidad,
                .IdProducto = codigoProducto,
                .Saldo = Kardex.CalcularStockActual(codigoProducto) + cantidad,
                .Estado = True
            }
                kardex.RegistrarOperacion()
            End If
        Next

        MessageBox.Show("Compra generada exitosamente.")
    End Sub

    Private Sub txt_cantida_ValueChanged(sender As Object, e As EventArgs) Handles txt_cantida.ValueChanged
        Dim precioUnitario As Decimal
        If Decimal.TryParse(txt_precioProducto.Text, precioUnitario) Then
            Dim cantidad As Integer = Convert.ToInt32(CInt(txt_cantida.Value))
            Dim subtotal As Decimal = precioUnitario * cantidad
            txt_subTotal.Text = subtotal.ToString()
        Else
            MessageBox.Show("El precio del producto no es válido.")
        End If

    End Sub

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class