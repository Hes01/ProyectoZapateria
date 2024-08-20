Imports System.IO

Public Class Productos
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AddProducto.Show()
        Me.Hide()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductosEnGrid()
    End Sub

    Private Sub CargarProductosEnGrid()
        Dim listaProductos As New List(Of Object)()

        ' Cargar datos de Producto
        Dim productos As List(Of Producto) = Producto.LeerProductos()

        ' Filtrar solo las personas con estado True (no eliminadas)
        productos = productos.Where(Function(p) p.Estado = True).ToList()


        ' Cargar datos de Categoria
        Dim categorias As List(Of Categoria) = Categoria.LeerCategorias()

        ' Cargar datos de Marcas
        Dim marcas As List(Of Marca) = Marca.LeerMarcas()

        ' Unir los datos de Persona con PersonaNatural y PersonaJuridica
        For Each producto In productos
            Dim categoriaDProducto = categorias.FirstOrDefault(Function(p) p.IdCategoria = producto.IdCategoria)
            Dim marcaDProducto = marcas.FirstOrDefault(Function(p) p.IdMarca = producto.IdMarca)

            listaProductos.Add(New With {

                    .Id = Persona.IdPersona,
                    .Nombre = "",
                    .RazonSocial = PersonaJuridica.RazonSocial,
                    .Dni = "",
                    .Ruc = Persona.Ruc,
                    .Telefono = Persona.Telefono,
                    .Correo = Persona.Correo,
                    .Direccion = Persona.Direccion,
                    .TipoPersona = "Jurídica"
                })

        Next

        ' Mostrar en el DataGridView
        tablaProductos.DataSource = listaPersonas
    End Sub

    Private Sub txt_codigoProducto_TextChanged(sender As Object, e As EventArgs) Handles txt_codigoProducto.TextChanged
        If String.IsNullOrWhiteSpace(txt_codigoProducto.Text) Then
            ' Si el campo de búsqueda está vacío, recarga todos los datos
            CargarPersonasEnGrid()
        Else
            ' Si hay texto en el campo de búsqueda, realiza la búsqueda
            BuscarProveedor(txt_codigoProducto.Text)
        End If
    End Sub









    Private Sub BuscarProveedor(criterio As String)
        criterio = criterio.ToLower()
        Dim listaFiltrada As New List(Of Object)()

        ' Cargar la lista completa para filtrar
        Dim listaPersonas As List(Of Object) = CType(tablaProductos.DataSource, List(Of Object))

        ' Filtrar por coincidencias en nombre, razón social, ID, DNI o RUC
        listaFiltrada = (From cliente In listaPersonas
                         Where cliente.Nombre.ToLower().Contains(criterio) OrElse
                               cliente.RazonSocial.ToLower().Contains(criterio) OrElse
                               cliente.Dni.ToLower().Contains(criterio) OrElse
                               cliente.Ruc.ToLower().Contains(criterio) OrElse
                               cliente.Id.ToString().Contains(criterio)
                         Select cliente).ToList()

        tablaProductos.DataSource = listaFiltrada
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        ' Verifica que haya una fila seleccionada
        If tablaProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Pregunta al usuario si realmente quiere eliminar el cliente
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Obtén el ID de la persona seleccionada
            Dim idPersona As Integer = CInt(tablaProductos.SelectedRows(0).Cells("Id").Value)

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


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        ' Verifica que haya una fila seleccionada
        If tablaProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un proveedor para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Obtén el ID de la persona seleccionada
        Dim idPersona As Integer = CInt(tablaProductos.SelectedRows(0).Cells("Id").Value)

        ' Crea una nueva instancia del formulario EditProveedor
        Dim editForm As New EditProducto(idPersona)
        editForm.ShowDialog()

        ' Después de cerrar el formulario de edición, recarga los datos en el grid
        CargarPersonasEnGrid()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class