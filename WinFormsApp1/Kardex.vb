Public Class Kardex
    Public Property IdKardex As Integer
    Public Property FechaReg As Date
    Public Property Operacion As String ' Descripción de la operación
    Public Property TipoOperacion As String ' Entrada o Salida
    Public Property Cantidad As Integer
    Public Property IdProducto As Integer
    Public Property Saldo As Integer ' Stock después de la operación
    Public Property Estado As Boolean

    ' Método para registrar una operación en el kardex
    Public Sub RegistrarOperacion()
        Dim line As String = $"{IdKardex}|{FechaReg:yyyy-MM-dd}|{Operacion}|{TipoOperacion}|{Cantidad}|{IdProducto}|{Saldo}|{Estado}"
        System.IO.File.AppendAllText("Datos\kardex.txt", line & Environment.NewLine)
    End Sub


    ' Método para calcular el stock actual de un producto
    Public Shared Function CalcularStockActual(idProducto As Integer) As Integer
        Dim stockActual As Integer = 0
        Try
            Dim rutaArchivo As String = "Datos\kardex.txt"
            If Not System.IO.File.Exists(rutaArchivo) Then
                Return stockActual
            End If

            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivo)
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)
                Dim idProductoActual As Integer = Integer.Parse(fields(5))
                If idProductoActual = idProducto Then
                    Dim cantidad As Integer = Integer.Parse(fields(4))
                    Dim tipoOperacion As String = fields(3)
                    If tipoOperacion = "Entrada" Then
                        stockActual += cantidad
                    ElseIf tipoOperacion = "Salida" Then
                        stockActual -= cantidad
                    End If
                End If
            Next
        Catch ex As Exception
            Console.WriteLine($"Error al calcular stock: {ex.Message}")
        End Try
        Return stockActual
    End Function


    ' Método para calcular el siguiente ID de Kardex
    Public Shared Function CalcularSiguienteId() As Integer
        Dim ultimoId As Integer = 0
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\kardex.txt")
            If lines.Length > 0 Then
                ultimoId = Integer.Parse(lines.Last().Split("|"c)(0))
            End If
        Catch ex As Exception
            Console.WriteLine($"Error al calcular el siguiente ID de Kardex: {ex.Message}")
        End Try
        Return ultimoId + 1
    End Function
End Class