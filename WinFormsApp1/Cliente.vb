Imports System.IO

Public Class Cliente
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        AddCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarCliente(txtBuscar.Text)
    End Sub

    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    BuscarCliente(txtBuscar.Text)
    'End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        ' Aquí podrías cargar los datos del cliente seleccionado para su edición
    End Sub

    Private Sub CargarClientes()
        dgvClientes.Rows.Clear()
        Using sr As StreamReader = New StreamReader("clientes.txt")
            While Not sr.EndOfStream
                Dim linea As String = sr.ReadLine()
                Dim datos As String() = linea.Split("|"c)
                dgvClientes.Rows.Add(datos)
            End While
        End Using
    End Sub

    Private Sub BuscarCliente(idBuscar As String)
        dgvClientes.Rows.Clear()
        Dim encontrado As Boolean = False
        Using sr As StreamReader = New StreamReader("clientes.txt")
            While Not sr.EndOfStream
                Dim linea As String = sr.ReadLine()
                Dim datos As String() = linea.Split("|"c)
                If datos(0).Contains(idBuscar) OrElse datos(4).Contains(idBuscar) Then ' Búsqueda por ID o nombre/razón social
                    dgvClientes.Rows.Add(datos)
                    encontrado = True
                End If
            End While
        End Using
        If Not encontrado Then
            MessageBox.Show("Cliente no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    '---------------------------------


    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPersonasEnGrid()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim criterio As String = txtBuscar.Text.ToLower()
        Dim listaFiltrada As New List(Of Object)()

        ' Filtrar por coincidencias en nombre, razón social, ID, DNI o RUC
        listaFiltrada = (From cliente In CType(dgvClientes.DataSource, List(Of Object))
                         Where cliente.Nombre.ToLower().Contains(criterio) OrElse
                           cliente.RazonSocial.ToLower().Contains(criterio) OrElse
                           cliente.Dni.ToLower().Contains(criterio) OrElse
                           cliente.Ruc.ToLower().Contains(criterio) OrElse
                           cliente.Id.ToString().Contains(criterio)
                         Select cliente).ToList()

        dgvClientes.DataSource = listaFiltrada
    End Sub

    '--

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

    Private Sub ActualizarDatos()
        CargarPersonasEnGrid()
    End Sub



End Class