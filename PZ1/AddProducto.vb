Public Class AddProducto
    Private Sub AddProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar categorías y marcas en los ComboBox
        CargarCategorias()
        CargarMarcas()

        ' Asignar IdProducto automáticamente
        txtCodigo.Focus()
    End Sub

    Private Sub CargarCategorias()
        Dim categorias As Dictionary(Of Integer, String) = LeerCategorias()
        cmbCategoria.Items.Clear()
        For Each categoria In categorias
            cmbCategoria.Items.Add(New With {.Id = categoria.Key, .Nombre = categoria.Value})
        Next
        cmbCategoria.DisplayMember = "Nombre"
        cmbCategoria.ValueMember = "Id"
    End Sub

    Private Sub CargarMarcas()
        Dim marcas As Dictionary(Of Integer, String) = LeerMarcas()
        cmbMarca.Items.Clear()
        For Each marca In marcas
            cmbMarca.Items.Add(New With {.Id = marca.Key, .Nombre = marca.Value})
        Next
        cmbMarca.DisplayMember = "Nombre"
        cmbMarca.ValueMember = "Id"
    End Sub

    Private Function LeerCategorias() As Dictionary(Of Integer, String)
        Dim categorias As New Dictionary(Of Integer, String)
        Dim lines() As String = System.IO.File.ReadAllLines("Datos\categoria.txt")
        For Each line As String In lines.Skip(1) ' Saltar la cabecera
            Dim campos() As String = line.Split("|"c)
            If campos.Length = 2 Then
                categorias.Add(Integer.Parse(campos(0).Trim()), campos(1).Trim())
            End If
        Next
        Return categorias
    End Function

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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Validar campos
        If String.IsNullOrEmpty(txtCodigo.Text) OrElse
           String.IsNullOrEmpty(txtNombre.Text) OrElse
           String.IsNullOrEmpty(txtTalla.Text) OrElse
           Not Decimal.TryParse(txtPrecio.Text, Nothing) OrElse
           Not Integer.TryParse(txtStock.Text, Nothing) OrElse
           cmbCategoria.SelectedIndex < 0 OrElse
           cmbMarca.SelectedIndex < 0 Then
            MessageBox.Show("Por favor, complete todos los campos correctamente.")
            Return
        End If

        ' Obtener el próximo IdProducto
        Dim nuevoIdProducto As Integer = ObtenerSiguienteIdProducto()

        ' Obtener el Id de la categoría y marca seleccionadas
        Dim idCategoria As Integer = CType(cmbCategoria.SelectedItem, Object).Id
        Dim idMarca As Integer = CType(cmbMarca.SelectedItem, Object).Id

        ' Crear nuevo producto
        Dim nuevoProducto As New Producto() With {
            .IdProducto = nuevoIdProducto,
            .Codigo = txtCodigo.Text.Trim(),
            .Nombre = txtNombre.Text.Trim(),
            .Talla = txtTalla.Text.Trim(),
            .Precio = Decimal.Parse(txtPrecio.Text.Trim()),
            .StockActual = Integer.Parse(txtStock.Text.Trim()),
            .IdCategoria = idCategoria,
            .IdMarca = idMarca,
            .Estado = True
        }

        ' Agregar producto al archivo
        AgregarProducto(nuevoProducto)

        ' Confirmar y cerrar formulario
        MessageBox.Show("Producto agregado exitosamente.")

    End Sub

    Private Function ObtenerSiguienteIdProducto() As Integer
        Dim lineas As String() = System.IO.File.ReadAllLines(Producto.RutaArchivo)
        If lineas.Length > 1 Then
            Dim ultimoId As Integer = Integer.Parse(lineas.Last().Split("|"c)(0))
            Return ultimoId + 1
        End If
        Return 1 ' Si no hay productos, comenzar con 1
    End Function

    Private Sub AgregarProducto(producto As Producto)
        Dim lineas As New List(Of String)(System.IO.File.ReadAllLines(Producto.RutaArchivo))
        lineas.Add($"{producto.IdProducto}|{producto.Codigo}|{producto.Nombre}|{producto.Talla}|{producto.Precio}|{producto.StockActual}|{producto.IdCategoria}|{producto.IdMarca}|{producto.Estado}")
        System.IO.File.WriteAllLines(Producto.RutaArchivo, lineas)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Productos.Show()
    End Sub


End Class
