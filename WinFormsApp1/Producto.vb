Public Class Producto
    Public Property IdProducto As Integer
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Talla As String
    Public Property Precio As Decimal
    Public Property StockActual As Integer
    Public Property IdCategoria As Integer
    Public Property IdMarca As Integer
    Public Property Estado As Boolean

    ' Ruta del archivo de productos relativa al directorio base de la aplicación
    Private Shared ReadOnly RutaArchivo As String = "Datos\producto.txt"

    ' Método para leer productos desde el archivo
    Public Shared Function LeerProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines(RutaArchivo)
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)
                Dim producto As New Producto() With {
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
                productos.Add(producto)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer los productos: {ex.Message}")
        End Try
        Return productos
    End Function

    Public Shared Sub ModificarProducto(productoModificado As Producto)
        Dim productos As List(Of Producto) = LeerProductos()

        ' Encuentra el índice de la persona a modificar
        Dim indice As Integer = productos.FindIndex(Function(p) p.IdProducto = productoModificado.IdProducto)

        If indice <> -1 Then
            ' Actualiza los datos de la persona en la lista
            productos(indice) = productoModificado

            ' Guarda los cambios en el archivo
            GuardarProductos(productos)
        Else
            MessageBox.Show("El producto no fue encontrado para modificar.")
        End If
    End Sub

    Private Shared Sub GuardarProductos(productos As List(Of Producto))
        Try
            ' Escribe los encabezados y luego las personas en el archivo
            Dim lines As New List(Of String)
            lines.Add("IdProducto|Codigo|Nombre|Talla|Precio|StockActual|IdCategoria|IdMarca|Estado")
            For Each producto As Producto In productos
                lines.Add($"{producto.IdProducto}|{producto.Codigo}|{producto.Nombre}|{producto.Talla}|{producto.Precio}|{producto.StockActual}|{producto.IdCategoria}|{producto.IdMarca}")
            Next
            System.IO.File.WriteAllLines(RutaArchivo, lines)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar los productos: {ex.Message}")
        End Try
    End Sub

    ' Método para actualizar el stock del producto en el archivo
    Public Sub ActualizarStock(nuevoStock As Integer)
        Dim productos As List(Of Producto) = LeerProductos()
        Dim producto As Producto = productos.FirstOrDefault(Function(p) p.IdProducto = IdProducto)

        If producto IsNot Nothing Then
            producto.StockActual = nuevoStock
            ' Actualizar el archivo con el nuevo stock
            Dim newLines As New List(Of String)
            For Each p As Producto In productos
                Dim line As String = $"{p.IdProducto}|{p.Codigo}|{p.Nombre}|{p.Talla}|{p.Precio}|{p.StockActual}|{p.IdCategoria}|{p.IdMarca}|{p.Estado}"
                newLines.Add(line)
            Next
            System.IO.File.WriteAllLines(RutaArchivo, newLines)
        End If
    End Sub


    Public Shared Function BuscarProductoPorId(idProducto As Integer) As Producto
        Dim productos As List(Of Producto) = LeerProductos()
        Return productos.FirstOrDefault(Function(p) p.IdProducto = idProducto)
    End Function


End Class
