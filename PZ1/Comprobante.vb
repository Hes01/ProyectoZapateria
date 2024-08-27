
Imports System.IO

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

    Public Shared Sub CompactarPorCopia()
        ' Definir las rutas de archivo para el original y el temporal
        Dim rutaArchivoOriginal As String = "Datos\comprobantes.txt"
        Dim rutaArchivoTemporal As String = "Datos\comprobantes_temp.txt"

        Try
            ' Abrir el archivo temporal para escritura
            Using escritor As New StreamWriter(rutaArchivoTemporal)
                ' Leer todas las líneas del archivo original
                Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoOriginal)

                ' Escribir la cabecera en el archivo temporal
                If lines.Length > 0 Then
                    escritor.WriteLine(lines(0)) ' Escribir la cabecera
                End If

                ' Procesar cada línea después de la cabecera
                For i As Integer = 1 To lines.Length - 1
                    Dim campos() As String = lines(i).Split("|"c)
                    Dim estado As Boolean = Boolean.Parse(campos(6).Trim())

                    ' Copiar solo los registros donde Estado es True
                    If estado Then
                        escritor.WriteLine(lines(i))
                    End If
                Next
            End Using

            ' Eliminar el archivo original y renombrar el archivo temporal
            File.Delete(rutaArchivoOriginal)
            File.Move(rutaArchivoTemporal, rutaArchivoOriginal)

            MessageBox.Show("Compactación por copia completada exitosamente.")
        Catch ex As Exception
            MessageBox.Show($"Error durante la compactación: {ex.Message}")
        End Try
    End Sub

    ' Método para verificar si un comprobante está activo
    Public Shared Function EsComprobanteActivo(idComprobante As Integer) As Boolean
        Dim rutaArchivoComprobantes As String = "Datos\comprobantes.txt"

        Try
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoComprobantes)

            ' Verificar si hay al menos una línea para evitar errores
            If lines.Length > 0 Then
                ' Iterar desde la segunda línea para saltar la cabecera
                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i)
                    Dim fields() As String = line.Split("|"c)

                    If fields.Length >= 7 Then
                        Dim id As Integer
                        Dim estado As Boolean

                        ' Validar y convertir el campo id
                        If Integer.TryParse(fields(0).Trim(), id) AndAlso id = idComprobante Then
                            ' Validar y convertir el campo estado
                            If Boolean.TryParse(fields(6).Trim(), estado) Then
                                Return estado ' Retorna True si el comprobante está activo, False si no lo está
                            End If
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al verificar el estado del comprobante. Error: {ex.Message}")
        End Try

        Return False ' Si no se encuentra el comprobante o ocurre un error, se asume que no está activo
    End Function
    Public Shared Sub CompactarComprobantesInSitu()
        Dim rutaArchivoComprobantes As String = "Datos\comprobantes.txt"
        Dim lineasFiltradas As New List(Of String)()

        Try
            ' Leer todas las líneas del archivo
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoComprobantes)

            ' Asegurarse de que hay al menos una línea (la cabecera)
            If lines.Length > 0 Then
                ' Agregar la cabecera a la lista de líneas filtradas
                lineasFiltradas.Add(lines(0))

                ' Iterar desde la segunda línea para omitir la cabecera
                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i)
                    Dim fields() As String = line.Split("|"c)
                    If fields.Length >= 7 Then
                        Dim idComprobante As Integer
                        Dim estado As Boolean

                        ' Validar y convertir el campo id
                        If Integer.TryParse(fields(0).Trim(), idComprobante) AndAlso
                       Boolean.TryParse(fields(6).Trim(), estado) AndAlso
                       estado Then
                            ' Agregar solo los comprobantes activos a la lista filtrada
                            lineasFiltradas.Add(line)
                        End If
                    End If
                Next

                ' Sobrescribir el archivo original con las líneas filtradas
                System.IO.File.WriteAllLines(rutaArchivoComprobantes, lineasFiltradas)
                MessageBox.Show("Compactación in situ de comprobantes completada con éxito.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al compactar in situ los comprobantes. Error: {ex.Message}")
        End Try
    End Sub

End Class