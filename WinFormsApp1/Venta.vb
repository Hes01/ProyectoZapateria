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
            lblNombre.Text = producto.Nombre
            lblTalla.Text = producto.Talla
            lblPrecio.Text = producto.Precio.ToString("C")
            lblStockActual.Text = producto.StockActual.
                ToString()

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

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    ' Método para mostrar los datos de la persona en los controles
    Private Sub MostrarDatosPersona(persona As Persona, personaTipo As Object)
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



    Private Sub btnBusBoleta_Click_1(sender As Object, e As EventArgs) Handles btnBusBoleta.Click
        ' Limpiar los campos antes de la búsqueda
        lblNomCliente.Text = ""
        lblApellido.Text = ""
        lblTelefono.Text = ""
        lblRazonSocial.Text = ""
        lblCorreo.Text = ""
        lblDireccion.Text = ""
        lblRuc.Text = ""

        Dim documento As String = txtDocumento.Text.Trim()

        If String.IsNullOrEmpty(documento) Then
            MessageBox.Show("Por favor, ingrese un documento.")
            Return
        End If

        If documento.Length = 8 Then
            ' Buscar Persona Natural por DNI
            Dim personaNatural As PersonaNatural = PersonaNatural.BuscarPersonaNaturalPorDni(documento)
            If personaNatural IsNot Nothing Then
                ' Buscar la Persona asociada a la Persona Natural
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
            ' Buscar Persona por RUC
            Dim persona As Persona = Persona.BuscarPersonaPorRuc(documento)
            If persona IsNot Nothing Then
                ' Dependiendo del tipo de persona, buscar en la tabla correspondiente
                If persona.TipoPersona = "Natural" Then
                    ' Buscar Persona Natural
                    Dim personaNatural As PersonaNatural = personaNatural.BuscarPersonaNaturalPorId(persona.IdPersona)
                    If personaNatural IsNot Nothing Then
                        MostrarDatosPersona(persona, personaNatural)
                    Else
                        MessageBox.Show("No se encontró una persona natural asociada.")
                    End If
                ElseIf persona.TipoPersona = "Juridica" Then
                    ' Buscar Persona Jurídica
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
        Else
            MessageBox.Show("El documento debe tener 8 caracteres (DNI) o 11 caracteres (RUC).")
        End If
    End Sub

End Class