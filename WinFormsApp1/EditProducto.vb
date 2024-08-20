Public Class EditProducto
    Private ReadOnly _idPersona As Integer
    ' Constructor que recibe el ID de la persona
    Public Sub New(idPersona As Integer)
        InitializeComponent()
        _idPersona = idPersona
    End Sub

    Private Sub EditProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos según el tipo de persona
        CargarDatosProveedor(_idPersona)
    End Sub

    Public Sub CargarDatosProveedor(idPersona As Integer)
        ' Primero, verificamos si el idPersona existe en PersonaNatural
        Dim persona As Persona = Persona.BuscarPersonaPorId(idPersona)
        If persona IsNot Nothing And persona.Estado = True Then
            'cargar los datos comunes de persona 
            txtID.Text = persona.IdPersona.ToString()
            txtTelefono.Text = persona.Telefono
            txtRuc.Text = persona.Ruc
            txtDirección.Text = persona.Direccion
            txtEmail.Text = persona.Correo

            Dim personaNatural As PersonaNatural = PersonaNatural.BuscarPersonaNaturalPorId(idPersona)

            If personaNatural IsNot Nothing Then
                ' Es una PersonaNatural
                MostrarCamposPersonaNatural()

                ' Cargar los datos en los campos correspondientes
                'txtID.Text = personaNatural.IdPersonaNatural.ToString()
                txtNombres.Text = personaNatural.Nombre
                txtApellidos.Text = personaNatural.Apellido
                txtDni.Text = personaNatural.Dni

                lblRazonSocial.Visible = False
                txtRazonSocial.Visible = False
            Else
                ' Si no es PersonaNatural, debe ser PersonaJuridica
                Dim personaJuridica As PersonaJuridica = PersonaJuridica.BuscarPersonaJuridicaPorId(idPersona)

                If personaJuridica IsNot Nothing Then
                    ' Es una PersonaJuridica
                    MostrarCamposPersonaJuridica()

                    ' Cargar los datos en los campos correspondientes
                    'txtID.Text = personaJuridica.IdPersona.ToString()
                    txtRazonSocial.Text = personaJuridica.RazonSocial

                    lblNombres.Visible = False
                    lblApellidos.Visible = False
                    lblDni.Visible = False
                    txtNombres.Visible = False
                    txtApellidos.Visible = False
                    txtDni.Visible = False

                Else
                    MessageBox.Show("No se encontró la persona con el ID especificado.")
                End If
            End If
        End If
    End Sub

    Private Sub MostrarCamposPersonaNatural()
        ' Mostrar campos de PersonaNatural
        txtNombres.Visible = True
        txtApellidos.Visible = True
        txtDni.Visible = True

        ' Ocultar campos de PersonaJuridica
        txtRazonSocial.Visible = False
    End Sub

    Private Sub MostrarCamposPersonaJuridica()
        ' Mostrar campos de PersonaJuridica
        txtRazonSocial.Visible = True

        ' Ocultar campos de PersonaNatural
        txtNombres.Visible = False
        txtApellidos.Visible = False
        txtDni.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Actualizar los datos en los archivos correspondientes según el tipo de persona

        If txtNombres.Enabled Then
            ' Guardar cambios para PersonaNatural
            Dim personaNatural As New PersonaNatural With {
            .IdPersonaNatural = Integer.Parse(txtID.Text),
            .Nombre = txtNombres.Text,
            .Apellido = txtApellidos.Text,
            .Dni = txtDni.Text,
            .IdPersona = _idPersona,
            .Estado = True
        }
            personaNatural.ModificarPersonaNatural(personaNatural)
        ElseIf txtRazonSocial.Enabled Then
            ' Guardar cambios para PersonaJuridica
            Dim personaJuridica As New PersonaJuridica With {
            .IdPersonaJuridica = Integer.Parse(txtID.Text),
            .RazonSocial = txtRazonSocial.Text,
            .IdPersona = _idPersona,
            .Estado = True
        }
            personaJuridica.ModificarPersonaJuridica(personaJuridica)
        End If

        ' Actualizar datos comunes en Persona
        Dim persona As New Persona With {
        .IdPersona = _idPersona,
        .Telefono = txtTelefono.Text,
        .Correo = txtEmail.Text,
        .Direccion = txtDirección.Text,
        .Ruc = txtRuc.Text,
        .TipoPersona = "Proveedor",
        .Estado = True
    }
        persona.ModificarPersona(persona)

        MessageBox.Show("Los cambios se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Cierra el formulario sin guardar cambios
        Me.Close()
    End Sub

End Class