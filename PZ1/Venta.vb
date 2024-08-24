Public Class Venta

    ' Método para manejar el clic en el botón de búsqueda
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim codigoProducto As String = txtCodigoProducto.Text

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
        Dim rutaArchivo As String = Producto.RutaArchivo ' Ruta relativa

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
            lblIdProducto.Text = producto.IdProducto.ToString()
            lblNombre.Text = producto.Nombre
            lblTalla.Text = producto.Talla
            lblPrecio.Text = producto.Precio.ToString()
            lblStockActual.Text = producto.StockActual.ToString()

            ' Buscar la marca
            Dim marca As Marca = Marca.LeerMarcas().FirstOrDefault(Function(m) m.IdMarca = producto.IdMarca)
            If marca IsNot Nothing Then
                lblMarca.Text = marca.Nombre
            Else
                lblMarca.Text = "-"
            End If

        Else
            lblNombre.Text = "-"
            lblTalla.Text = "-"
            lblPrecio.Text = "-"
            lblStockActual.Text = "-"
            lblMarca.Text = "-"
        End If
    End Sub
    Public Sub ActualizarTotal()
        Dim total As Decimal = 0.00
        Dim cultureInfo As Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture

        For Each row As DataGridViewRow In dgvVenta.Rows
            ' Verificar si la fila es una fila de datos (no una fila nueva)
            If Not row.IsNewRow Then
                Dim subtotalText As String = row.Cells(7).Value.ToString()
                Dim subtotal As Decimal
                ' Intentar convertir el texto del subtotal a Decimal
                If Decimal.TryParse(subtotalText.Replace("S/", "").Trim(), Globalization.NumberStyles.Number, cultureInfo, subtotal) Then
                    total += subtotal
                End If
            End If
        Next

        ' Mostrar el total en txtTotal
        txtTotal.Text = total.ToString("0.00")
    End Sub


    ' Método para agregar el producto al grid de ventas
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If String.IsNullOrWhiteSpace(lblNombre.Text) Then
            MessageBox.Show("Por favor busque un producto primero.")
            Return
        End If

        ' Obtener la cantidad ingresada desde el NumericUpDown
        Dim cantidad As Integer = CInt(txtCantidad.Value)

        ' Verificar que la cantidad sea mayor a 0
        If cantidad <= 0 Then
            MessageBox.Show("Por favor ingrese una cantidad válida.")
            Return
        End If

        ' Obtener el precio del producto
        Dim precio As Decimal
        If Not Decimal.TryParse(lblPrecio.Text.Replace("C", "").Trim(), precio) Then
            MessageBox.Show("Error al obtener el precio del producto.")
            Return
        End If

        ' Calcular el precio total
        Dim precioTotal As Decimal = precio * cantidad

        ' Mostrar el precio total en txtSubtotal
        txtSubtotal.Text = precioTotal.ToString("0.00")



        ' Agregar el producto al grid de ventas
        dgvVenta.Rows.Add(lblIdProducto.Text, txtCodigoProducto.Text, lblNombre.Text, lblMarca.Text, lblTalla.Text, cantidad, precio.ToString("0.00"), precioTotal.ToString("0.00"))

        ' Limpiar los campos
        lblIdProducto.Text = ""
        txtCodigoProducto.Text = ""
        txtCantidad.Value = 1
        lblNombre.Text = "-"
        lblTalla.Text = "-"
        lblPrecio.Text = "-"
        lblStockActual.Text = "-"
        lblMarca.Text = "-"
        txtSubtotal.Text = ""
        ActualizarTotal()
    End Sub

    ' Metodo para mostrar los datos de la persona en los label
    Private Sub MostrarDatosPersona(persona As Persona, personaTipo As Object)
        lblIdPersona.Text = persona.IdPersona.ToString()
        lblTelefono.Text = "Teléfono: " & persona.Telefono
        lblCorreo.Text = "Correo: " & persona.Correo
        lblDireccion.Text = "Dirección: " & persona.Direccion

        If TypeOf personaTipo Is PersonaNatural Then
            lblNomCliente.Text = "Nombre: " & CType(personaTipo, PersonaNatural).Nombre
            lblApellido.Text = "Apellido: " & CType(personaTipo, PersonaNatural).Apellido
        ElseIf TypeOf personaTipo Is PersonaJuridica Then
            lblRazonSocial.Text = "Razón Social: " & CType(personaTipo, PersonaJuridica).RazonSocial
        End If
    End Sub

    Private Sub limpiar()
        lblNomCliente.Text = ""
        lblApellido.Text = ""
        lblTelefono.Text = ""
        lblRazonSocial.Text = ""
        lblCorreo.Text = ""
        lblDireccion.Text = ""
        lblRuc.Text = ""
    End Sub


    Private Sub btnBusBoleta_Click_1(sender As Object, e As EventArgs) Handles btnBusBoleta.Click
        limpiar()

        Dim documento As String = txtDocumento.Text.Trim()

        If String.IsNullOrEmpty(documento) Then
            MessageBox.Show("Por favor, ingrese un documento.")
            Return
        End If

        If rbtnBoleta.Checked Then
            If documento.Length <> 8 Then
                MessageBox.Show("Para boleta, el DNI debe tener 8 dígitos.")
                Return
            End If
        ElseIf rbtnFactura.Checked Then
            If documento.Length <> 11 Then
                MessageBox.Show("Para factura, el RUC debe tener 11 dígitos.")
                Return
            End If
        Else
            MessageBox.Show("Por favor, seleccione boleta o factura.")
            Return
        End If

        If documento.Length = 8 Then
            Dim personaNatural As PersonaNatural = PersonaNatural.BuscarPersonaNaturalPorDni(documento)
            If personaNatural IsNot Nothing Then
                Dim persona As Persona = Persona.BuscarPersonaPorId(personaNatural.IdPersona)
                If persona IsNot Nothing Then
                    MostrarDatosPersona(persona, personaNatural)
                Else
                    MessageBox.Show("No se encontró la persona asociada.")
                End If
            Else
                MessageBox.Show("No se encontró una persona natural con el DNI ingresado.")
            End If
        ElseIf documento.Length = 11 Then
            Dim persona As Persona = Persona.BuscarPersonaPorRuc(documento)
            If persona IsNot Nothing Then
                If persona.TipoPersona = "Natural" Then
                    Dim personaNatural As PersonaNatural = PersonaNatural.BuscarPersonaNaturalPorId(persona.IdPersona)
                    If personaNatural IsNot Nothing Then
                        MostrarDatosPersona(persona, personaNatural)
                    Else
                        MessageBox.Show("No se encontró una persona natural asociada.")
                    End If
                ElseIf persona.TipoPersona = "Juridica" Then
                    Dim personaJuridica As PersonaJuridica = PersonaJuridica.BuscarPersonaJuridicaPorId(persona.IdPersona)
                    If personaJuridica IsNot Nothing Then
                        MostrarDatosPersona(persona, personaJuridica)
                    Else
                        MessageBox.Show("No se encontró una persona jurídica asociada.")
                    End If
                Else
                    MessageBox.Show("Tipo de persona no reconocido.")
                End If
            Else
                MessageBox.Show("No se encontró ninguna persona con el RUC ingresado.")
            End If
        End If
    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Dim precioUnitario As Decimal
        If Decimal.TryParse(lblPrecio.Text, precioUnitario) Then
            Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Value)
            Dim subtotal As Decimal = precioUnitario * cantidad
            txtSubtotal.Text = subtotal.ToString()
        Else
            MessageBox.Show("El precio del producto no es válido.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay una fila seleccionada
        If dgvVenta.SelectedRows.Count > 0 Then
            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Eliminar la fila seleccionada
                dgvVenta.Rows.Remove(dgvVenta.SelectedRows(0))
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila para eliminar.")
        End If
        ActualizarTotal()
    End Sub

    Public Sub GenerarVenta(idPersona As Integer, idVendedor As Integer, text As String, tablaDetalle As DataGridView)

        Dim nuevoComprobante As New Comprobante With {
        .IdComprobante = Comprobante.GenerarNuevoIdComprobante(),
        .Fecha = Date.Now,
        .Total = Decimal.Parse(text),
        .TipoPago = "Efectivo",
        .IdPersona = idPersona,
        .IdVendedor = idVendedor,
        .Estado = True
    }
        nuevoComprobante.GuardarComprobante()

        ' Guardar detalles de la venta
        For Each row As DataGridViewRow In tablaDetalle.Rows
            If Not row.IsNewRow Then
                Dim idProductoStr As String = row.Cells(0).Value.ToString()
                MessageBox.Show(idProductoStr)
                Dim cantidadStr As String = row.Cells(5).Value.ToString()
                MessageBox.Show(cantidadStr)
                Dim precioVentaStr As String = row.Cells(7).Value.ToString()
                MessageBox.Show(precioVentaStr)

                Dim idProducto As Integer
                Dim cantidad As Integer
                Dim precioVenta As Decimal

                If Not Integer.TryParse(idProductoStr, idProducto) Then
                    MessageBox.Show($"El formato del ID del producto '{idProductoStr}' es incorrecto.")
                    Return
                End If
                MessageBox.Show(idProducto)
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
                .IdProducto = idProducto,
                .IdComprobante = nuevoComprobante.IdComprobante,
                .Estado = True
            }
                nuevoDetalle.GuardarDetalle()

                ' Registrar la operación en el Kardex
                Dim kardex As New Kardex With {
                .IdKardex = Kardex.CalcularSiguienteId(),
                .FechaReg = Date.Now,
                .Operacion = "Venta",
                .TipoOperacion = "Salida",
                .Cantidad = cantidad,
                .IdProducto = idProducto,
                .Saldo = Kardex.CalcularStockActual(idProducto) - cantidad,
                .Estado = True
            }

                kardex.RegistrarOperacion()
                Dim nuevoStock As Integer = Kardex.CalcularStockActual(idProducto)
                Dim producto As New Producto()

                producto.ActualizarStock(idProducto, nuevoStock)
            End If
        Next

        MessageBox.Show("Venta generada exitosamente.")
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Verificar que haya productos en el DataGridView
        If dgvVenta.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la venta. Por favor agregue productos antes de generar la venta.")
            Return
        End If

        ' Obtener los datos del cliente
        Dim idPersona As Integer = 0
        If Not Integer.TryParse(lblIdPersona.Text, idPersona) Then
            MessageBox.Show("Debe ingresar un ID de persona válido.")
            Return
        End If

        ' Obtener los datos del vendedor
        Dim idVendedor As Integer = 0
        If Not Integer.TryParse(lblIdVendedor.Text, idVendedor) Then
            MessageBox.Show("Debe ingresar un ID de vendedor válido.")
            Return
        End If

        ' Verificar que se va a llamar al método GenerarVenta
        MessageBox.Show("A punto de llamar a GenerarVenta")

        ' Generar la venta
        Try
            Dim nuevaVenta As New Venta()
            nuevaVenta.GenerarVenta(idPersona, idVendedor, txtTotal.Text, dgvVenta)

            ' Limpiar el DataGridView y los campos
            dgvVenta.Rows.Clear()

            MessageBox.Show("Venta generada exitosamente.")
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al generar la venta: {ex.Message}")
        End Try

        limpiar()
    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class