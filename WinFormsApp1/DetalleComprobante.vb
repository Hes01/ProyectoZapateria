Public Class DetalleComprobante
    Public Property IdDetalle As Integer
    Public Property Cantidad As Integer
    Public Property PrecioVenta As Decimal
    Public Property IdProducto As Integer
    Public Property IdComprobante As Integer
    Public Property Estado As Boolean

    Public Sub GuardarDetalle()
        Dim line As String = $"{IdDetalle}|{Cantidad}|{PrecioVenta}|{IdProducto}|{IdComprobante}|{Estado}"
        System.IO.File.AppendAllText("detalles_comprobantes.txt", line & Environment.NewLine)
    End Sub

    Public Shared Function LeerDetallesComprobantes() As List(Of DetalleComprobante)
        Dim detalles As New List(Of DetalleComprobante)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("detalles_comprobantes.txt")
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)
                Dim detalle As New DetalleComprobante With {
                    .IdDetalle = Integer.Parse(fields(0)),
                    .Cantidad = Integer.Parse(fields(1)),
                    .PrecioVenta = Decimal.Parse(fields(2)),
                    .IdProducto = Integer.Parse(fields(3)),
                    .IdComprobante = Integer.Parse(fields(4)),
                    .Estado = Boolean.Parse(fields(5))
                }
                detalles.Add(detalle)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error al leer detalles de comprobantes: {ex.Message}")
        End Try
        Return detalles
    End Function
End Class
