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
End Class
