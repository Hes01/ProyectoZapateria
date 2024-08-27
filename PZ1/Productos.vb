Public Class Productos
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ' Filtrar los productos mientras se escribe en la barra de búsqueda
        CargarProductos(txtBuscar.Text.Trim())
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Filtrar los productos al hacer clic en el botón buscar
        CargarProductos(txtBuscar.Text.Trim())
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        ' Cuando se haga clic en una celda, podrías manejar acciones adicionales aquí si es necesario

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AddProducto.Show()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay una fila seleccionada
        If dgvProductos.CurrentRow IsNot Nothing Then
            ' Obtener el IdProducto de la fila seleccionada
            Dim idProducto As Integer = Integer.Parse(dgvProductos.CurrentRow.Cells("IdProducto").Value.ToString())

            ' Confirmar eliminación
            Dim confirmacion As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo)
            If confirmacion = DialogResult.Yes Then
                ' Eliminar el producto lógicamente
                EliminarProductoLogicamente(idProducto)
            End If
        Else
            MessageBox.Show("No se ha seleccionado ningún producto para eliminar.")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ' Salir del formulario
        Me.Hide()

        Home.Show()

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Definir las columnas del DataGridView
        With dgvProductos
            .Columns.Clear()
            .Columns.Add("IdProducto", "ID Producto")
            .Columns.Add("Codigo", "Código")
            .Columns.Add("Nombre", "Nombre")
            .Columns.Add("Marca", "Marca")
            .Columns.Add("Talla", "Talla")
            .Columns.Add("Precio", "Precio")
            .Columns.Add("StockActual", "Stock Actual")
            .Columns.Add("Estado", "Estado")
        End With

        ' Cargar los productos en el DataGridView al iniciar el formulario
        CargarProductos("")
    End Sub



    Private Function LeerMarcas() As Dictionary(Of Integer, String)
        Dim marcas As New Dictionary(Of Integer, String)
        Dim lines() As String = System.IO.File.ReadAllLines("Datos\marca.txt")
        For Each line As String In lines.Skip(1) ' Saltar la cabecera
            Dim campos() As String = line.Split("|"c)
            If campos.Length = 2 Then
                marcas.Add(Integer.Parse(campos(0).Trim()), campos(1).Trim())
            End If
        Next
        Return marcas
    End Function



    Private Sub CargarProductos(filtro As String)
        ' Leer los productos y las marcas
        Dim productos As List(Of Producto) = Producto.LeerProductos()
        Dim marcas As Dictionary(Of Integer, String) = LeerMarcas()

        ' Filtrar los productos según el texto de búsqueda
        Dim productosFiltrados = productos.Where(Function(p) p.Estado = True AndAlso
                                                    (p.Nombre.ToLower().Contains(filtro.ToLower()) OrElse
                                                     p.Codigo.ToLower().Contains(filtro.ToLower()) OrElse
                                                     p.Talla.ToLower().Contains(filtro.ToLower()) OrElse
                                                     marcas(p.IdMarca).ToLower().Contains(filtro.ToLower()))).ToList()

        ' Llenar el DataGridView
        dgvProductos.Rows.Clear()
        For Each producto In productosFiltrados
            dgvProductos.Rows.Add(producto.IdProducto, producto.Codigo, producto.Nombre, marcas(producto.IdMarca), producto.Talla, producto.Precio, producto.StockActual, producto.Estado)
        Next
    End Sub

    Private Sub EliminarProductoLogicamente(idProducto As Integer)
        Dim productos As List(Of Producto) = Producto.LeerProductos()
        Dim productoAEliminar As Producto = productos.FirstOrDefault(Function(p) p.IdProducto = idProducto)

        If productoAEliminar IsNot Nothing Then
            ' Cambiar el estado del producto a False
            productoAEliminar.Estado = False

            ' Guardar los cambios en el archivo
            GuardarProductos(productos)

            ' Recargar el grid después de la eliminación lógica
            CargarProductos(txtBuscar.Text.Trim())
        Else
            MessageBox.Show("El producto no se encontró.")
        End If
    End Sub
    Private Sub GuardarProductos(productos As List(Of Producto))
        Dim lineas As New List(Of String)()
        lineas.Add("IdProducto|Codigo|Nombre|Talla|Precio|StockActual|IdCategoria|IdMarca|Estado") ' Re-agregar la cabecera
        For Each producto In productos
            lineas.Add($"{producto.IdProducto}|{producto.Codigo}|{producto.Nombre}|{producto.Talla}|{producto.Precio}|{producto.StockActual}|{producto.IdCategoria}|{producto.IdMarca}|{producto.Estado}")
        Next
        System.IO.File.WriteAllLines(Producto.RutaArchivo, lineas)
    End Sub

End Class