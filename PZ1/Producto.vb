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
    Public Shared ReadOnly RutaArchivo As String = "Datos\producto.txt"

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
    Public Sub ActualizarStock(idProducto As Integer, nuevoStock As Integer)
        Dim rutaArchivo As String = "Datos\producto.txt"
        Dim lineas As List(Of String) = System.IO.File.ReadAllLines(rutaArchivo).ToList()
        Dim encontrado As Boolean = False

        For i As Integer = 1 To lineas.Count - 1
            Dim campos() As String = lineas(i).Split("|"c)
            If Integer.Parse(campos(0)) = idProducto Then
                ' Actualizar el stock en la línea correspondiente
                campos(5) = nuevoStock.ToString()
                lineas(i) = String.Join("|", campos)
                encontrado = True
                Exit For
            End If
        Next

        If encontrado Then
            System.IO.File.WriteAllLines(rutaArchivo, lineas)
        Else
            MessageBox.Show($"Producto con ID {idProducto} no encontrado.")
        End If
    End Sub

End Class
