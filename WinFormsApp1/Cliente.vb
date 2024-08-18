Imports System.IO

Public Class Cliente
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        AddCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPersonasEnGrid()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarCliente(txtBuscar.Text)
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        ' Aquí podrías cargar los datos del cliente seleccionado para su edición
    End Sub

    Private Sub CargarPersonasEnGrid()
        Dim listaPersonas As New List(Of Object)()

        ' Cargar datos de Persona
        Dim personas As List(Of Persona) = Persona.LeerPersonas()

        ' Cargar datos de PersonaNatural
        Dim personasNaturales As List(Of PersonaNatural) = PersonaNatural.LeerPersonasNaturales()

        ' Cargar datos de PersonaJuridica
        Dim personasJuridicas As List(Of PersonaJuridica) = PersonaJuridica.LeerPersonasJuridicas()

        ' Unir los datos de Persona con PersonaNatural y PersonaJuridica
        For Each persona In personas
            Dim personaNatural = personasNaturales.FirstOrDefault(Function(p) p.IdPersona = persona.IdPersona)
            Dim personaJuridica = personasJuridicas.FirstOrDefault(Function(p) p.IdPersona = persona.IdPersona)

            If personaNatural IsNot Nothing Then
                listaPersonas.Add(New With {
                .Id = persona.IdPersona,
                .Nombre = personaNatural.Nombre,
                .RazonSocial = "",
                .Dni = personaNatural.Dni,
                .Ruc = persona.Ruc,
                .Telefono = persona.Telefono,
                .Correo = persona.Correo,
                .Direccion = persona.Direccion,
                .TipoPersona = "Natural"
            })
            ElseIf personaJuridica IsNot Nothing Then
                listaPersonas.Add(New With {
                .Id = persona.IdPersona,
                .Nombre = "",
                .RazonSocial = personaJuridica.RazonSocial,
                .Dni = "",
                .Ruc = persona.Ruc,
                .Telefono = persona.Telefono,
                .Correo = persona.Correo,
                .Direccion = persona.Direccion,
                .TipoPersona = "Jurídica"
            })
            End If
        Next

        ' Mostrar en el DataGridView
        dgvClientes.DataSource = listaPersonas
    End Sub

    Private Sub BuscarCliente(criterio As String)
        criterio = criterio.ToLower()
        Dim listaFiltrada As New List(Of Object)()

        ' Cargar la lista completa para filtrar
        Dim listaPersonas As List(Of Object) = CType(dgvClientes.DataSource, List(Of Object))

        ' Filtrar por coincidencias en nombre, razón social, ID, DNI o RUC
        listaFiltrada = (From cliente In listaPersonas
                         Where cliente.Nombre.ToLower().Contains(criterio) OrElse
                               cliente.RazonSocial.ToLower().Contains(criterio) OrElse
                               cliente.Dni.ToLower().Contains(criterio) OrElse
                               cliente.Ruc.ToLower().Contains(criterio) OrElse
                               cliente.Id.ToString().Contains(criterio)
                         Select cliente).ToList()

        dgvClientes.DataSource = listaFiltrada

        If listaFiltrada.Count = 0 Then
            MessageBox.Show("Cliente no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ActualizarDatos()
        CargarPersonasEnGrid()
    End Sub

End Class
