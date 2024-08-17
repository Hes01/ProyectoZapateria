Public Class Comprobante
    Public Property IdComprobante As Integer
    Public Property Fecha As Date
    Public Property Total As Decimal
    Public Property TipoPago As String
    Public Property IdPersona As Integer
    Public Property IdVendedor As Integer
    Public Property Estado As Boolean
    Public Property DetalleComprobanteList As New List(Of DetalleComprobante)

    Public Sub AgregarDetalle(detalle As DetalleComprobante)
        DetalleComprobanteList.Add(detalle)
    End Sub

    Public Sub GuardarComprobante()
        Dim line As String = $"{IdComprobante}|{Fecha:yyyy-MM-dd}|{Total}|{TipoPago}|{IdPersona}|{IdVendedor}|{Estado}"
        System.IO.File.AppendAllText("comprobantes.txt", line & Environment.NewLine)

        For Each detalle In DetalleComprobanteList
            detalle.GuardarDetalle()
        Next
    End Sub

    Public Shared Function LeerComprobantes() As List(Of Comprobante)
        Dim comprobantes As New List(Of Comprobante)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("comprobantes.txt")
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)
                Dim comprobante As New Comprobante With {
                    .IdComprobante = Integer.Parse(fields(0)),
                    .Fecha = Date.Parse(fields(1)),
                    .Total = Decimal.Parse(fields(2)),
                    .TipoPago = fields(3),
                    .IdPersona = Integer.Parse(fields(4)),
                    .IdVendedor = Integer.Parse(fields(5)),
                    .Estado = Boolean.Parse(fields(6))
                }
                comprobantes.Add(comprobante)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error al leer comprobantes: {ex.Message}")
        End Try
        Return comprobantes
    End Function
End Class
