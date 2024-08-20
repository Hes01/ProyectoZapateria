
Public Class Comprobante
    Public Property IdComprobante As Integer
    Public Property Fecha As Date
    Public Property Total As Decimal
    Public Property TipoPago As String
    Public Property IdPersona As Integer
    Public Property IdVendedor As Integer
    Public Property Estado As Boolean

    ' Método para guardar un comprobante
    Public Sub GuardarComprobante()
        Dim line As String = $"{IdComprobante}|{Fecha:yyyy-MM-dd}|{Total}|{TipoPago}|{IdPersona}|{IdVendedor}|{Estado}"
        System.IO.File.AppendAllText("Datos\comprobantes.txt", line & Environment.NewLine)
    End Sub

    ' Método para generar un nuevo ID de comprobante
    Public Shared Function GenerarNuevoIdComprobante() As Integer
        Dim ultimoId As Integer = 0
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\comprobantes.txt")
            If lines.Length > 0 Then
                ultimoId = Integer.Parse(lines.Last().Split("|"c)(0))
            End If
        Catch ex As Exception
            Console.WriteLine($"Error al generar nuevo ID de comprobante: {ex.Message}")
        End Try
        Return ultimoId + 1
    End Function

    ' Método para leer todos los comprobantes
    Public Shared Function LeerComprobantes() As List(Of Comprobante)
        Dim comprobantes As New List(Of Comprobante)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\comprobantes.txt")
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