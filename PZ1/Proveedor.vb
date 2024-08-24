Imports System.IO

Public Class Proveedor

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        AddProveedor.Show()
        Me.Hide()
    End Sub

    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPersonasEnGrid()
    End Sub

    Private Sub CargarPersonasEnGrid()
        Dim listaPersonas As New List(Of Object)()

        ' Cargar datos de Persona
        Dim personas As List(Of Persona) = Persona.LeerPersonas()

        ' Filtrar solo las personas con estado True (no eliminadas)
        personas = personas.Where(Function(p) p.Estado = True).ToList()

        ' Filtara solo las personas con tipoPersona (Cliente)
        personas = personas.Where(Function(p) p.TipoPersona = "Proveedor").ToList()

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
        dgvProveedor.DataSource = listaPersonas
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If String.IsNullOrWhiteSpace(txtBuscar.Text) Then
            ' Si el campo de búsqueda está vacío, recarga todos los datos
            CargarPersonasEnGrid()
        Else
            ' Si hay texto en el campo de búsqueda, realiza la búsqueda
            BuscarProveedor(txtBuscar.Text)
        End If
    End Sub

    Private Sub BuscarProveedor(criterio As String)
        criterio = criterio.ToLower()
        Dim listaFiltrada As New List(Of Object)()

        ' Cargar la lista completa para filtrar
        Dim listaPersonas As List(Of Object) = CType(dgvProveedor.DataSource, List(Of Object))

        ' Filtrar por coincidencias en nombre, razón social, ID, DNI o RUC
        listaFiltrada = (From cliente In listaPersonas
                         Where cliente.Nombre.ToLower().Contains(criterio) OrElse
                               cliente.RazonSocial.ToLower().Contains(criterio) OrElse
                               cliente.Dni.ToLower().Contains(criterio) OrElse
                               cliente.Ruc.ToLower().Contains(criterio) OrElse
                               cliente.Id.ToString().Contains(criterio)
                         Select cliente).ToList()

        dgvProveedor.DataSource = listaFiltrada
    End Sub

    Private Sub ActualizarDatos()
        CargarPersonasEnGrid()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Verifica que haya una fila seleccionada
        If dgvProveedor.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un proveedor para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Obtén el ID de la persona seleccionada
        Dim idPersona As Integer = CInt(dgvProveedor.SelectedRows(0).Cells("Id").Value)

        ' Crea una nueva instancia del formulario EditProveedor
        Dim editForm As New EditProveedor(idPersona)
        editForm.ShowDialog()

        ' Después de cerrar el formulario de edición, recarga los datos en el grid
        CargarPersonasEnGrid()
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verifica que haya una fila seleccionada
        If dgvProveedor.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Pregunta al usuario si realmente quiere eliminar el cliente
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Obtén el ID de la persona seleccionada
            Dim idPersona As Integer = CInt(dgvProveedor.SelectedRows(0).Cells("Id").Value)

            ' Busca y elimina lógicamente a la persona
            Dim persona As Persona = Persona.BuscarPersonaPorId(idPersona)
            If persona IsNot Nothing Then
                persona.Estado = False
                ActualizarPersona(persona)
            End If

            ' Recargar datos en el grid
            CargarPersonasEnGrid()
        End If
    End Sub

    Private Sub ActualizarPersona(persona As Persona)
        ' Leer todas las personas del archivo
        Dim personas As List(Of Persona) = Persona.LeerPersonas()

        ' Actualizar el estado de la persona seleccionada
        Dim index As Integer = personas.FindIndex(Function(p) p.IdPersona = persona.IdPersona)
        If index >= 0 Then
            personas(index) = persona
        End If

        ' Guardar los datos actualizados en el archivo
        GuardarPersonasEnArchivo(personas)
    End Sub

    Private Sub GuardarPersonasEnArchivo(personas As List(Of Persona))
        Try
            Using sw As New StreamWriter(Persona.RutaArchivo, False)
                ' Escribir encabezado (opcional)
                sw.WriteLine("IdPersona|Telefono|Correo|Direccion|Ruc|TipoPersona|Estado")

                ' Escribir cada persona en una nueva línea
                For Each persona In personas
                    sw.WriteLine($"{persona.IdPersona}|{persona.Telefono}|{persona.Correo}|{persona.Direccion}|{persona.Ruc}|{persona.TipoPersona}|{persona.Estado}")
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al guardar las personas: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSalirProveedor_Click(sender As Object, e As EventArgs) Handles btnSalirProveedor.Click
        Me.Hide()
        Home.Show()
    End Sub



End Class