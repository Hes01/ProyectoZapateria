Public Class EditProducto
    Private ReadOnly _idProducto As Integer
    ' Constructor que recibe el ID de la persona
    Public Sub New(idProducto As Integer)
        InitializeComponent()
        _idProducto = idProducto
    End Sub

    Private Sub EditProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos según el tipo de persona
        CargarDatosProducto(_idProducto)
    End Sub

    Public Sub CargarDatosProducto(idProducto As Integer)
        ' Primero, verificamos si el idPersona existe en PersonaNatural
        Dim producto As Producto = Producto.BuscarProductoPorId(idProducto)
        If producto IsNot Nothing And producto.Estado = True Then
            'cargar los datos comunes de persona 
            txt_id.Text = producto.IdProducto.ToString()
            txt_codigo.Text = producto.Codigo
            txt_nombre.Text = producto.Nombre
            txt_talla.Text = producto.Talla
            txt_precio.Text = producto.Precio
            txt_stock.Text = producto.StockActual

            ' Buscar la marca
            Dim marca As Marca = Marca.LeerMarcas().FirstOrDefault(Function(m) m.IdMarca = producto.IdMarca)
            If marca IsNot Nothing Then
                txt_marca.Text = marca.Nombre
            Else
                txt_marca.Text = "-"
            End If


            ' Buscar la categoria
            Dim categoria As Categoria = Categoria.LeerCategorias().FirstOrDefault(Function(m) m.IdCategoria = producto.IdCategoria)
            If categoria IsNot Nothing Then
                txt_categoria.Text = categoria.Nombre
            Else
                txt_categoria.Text = "-"
            End If
        Else
            MessageBox.Show("Este producto no existe")
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        ' Actualizar los datos en los archivos correspondientes

        ' Actualizar datos en Productos
        Dim productoAGuardar As New Producto With {
        .IdProducto = _idProducto,
        .Codigo = productoAGuardar.Codigo,
        .Nombre = productoAGuardar.Nombre,
        .Talla = productoAGuardar.Talla,
        .Precio = productoAGuardar.Precio,
        .StockActual = productoAGuardar.StockActual,
        .IdMarca = productoAGuardar.IdMarca,
        .IdCategoria = productoAGuardar.IdCategoria,
        .Estado = True
    }
        Producto.ModificarProducto(productoAGuardar)

        MessageBox.Show("Los cambios se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        ' Cierra el formulario sin guardar cambios
        Me.Close()
    End Sub
End Class