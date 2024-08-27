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
        Dim rutaArchivo As String = "Datos\kardex.txt"

        Try
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivo)

            ' Empezamos desde el índice 1 para ignorar la cabecera
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim fields() As String = line.Split("|"c)
                If Integer.Parse(fields(5)) = idProducto Then
                    Dim tipoOperacion As String = fields(3)
                    Dim cantidad As Integer = Integer.Parse(fields(4))

                    ' Si la operación es de tipo "Entrada", se suma la cantidad; si es "Salida", se resta
                    If tipoOperacion = "Entrada" Then
                        stockActual += cantidad
                    ElseIf tipoOperacion = "Salida" Then
                        stockActual -= cantidad
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al calcular el stock actual. Error: {ex.Message}")
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

    Public Shared Sub CompactarKardexInSitu()
        Dim rutaArchivoKardex As String = "Datos\kardex.txt"
        Dim lineasFiltradas As New List(Of String)()

        Try
            ' Leer todas las líneas del archivo
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoKardex)

            ' Asegurarse de que hay al menos una línea (la cabecera)
            If lines.Length > 0 Then
                ' Agregar la cabecera a la lista de líneas filtradas
                lineasFiltradas.Add(lines(0))

                ' Iterar desde la segunda línea para omitir la cabecera
                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i)
                    Dim fields() As String = line.Split("|"c)
                    If fields.Length >= 8 Then
                        Dim estado As Boolean

                        ' Validar y convertir el campo estado
                        If Boolean.TryParse(fields(7).Trim(), estado) AndAlso estado Then
                            ' Agregar solo los registros con estado activo a la lista filtrada
                            lineasFiltradas.Add(line)
                        End If
                    End If
                Next

                ' Sobrescribir el archivo original con las líneas filtradas
                System.IO.File.WriteAllLines(rutaArchivoKardex, lineasFiltradas)
                MessageBox.Show("Compactación in situ del Kardex completada con éxito.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al compactar in situ el Kardex. Error: {ex.Message}")
        End Try
    End Sub

    Public Shared Sub CompactarKardexPorCopia()
        Dim rutaArchivoKardex As String = "Datos\kardex.txt"
        Dim rutaArchivoTemporal As String = "Datos\kardex_temp.txt"
        Dim lineasFiltradas As New List(Of String)()

        Try
            ' Leer todas las líneas del archivo
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoKardex)

            ' Asegurarse de que hay al menos una línea (la cabecera)
            If lines.Length > 0 Then
                ' Agregar la cabecera a la lista de líneas filtradas
                lineasFiltradas.Add(lines(0))

                ' Iterar desde la segunda línea para omitir la cabecera
                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i)
                    Dim fields() As String = line.Split("|"c)
                    If fields.Length >= 8 Then
                        Dim estado As Boolean

                        ' Validar y convertir el campo estado
                        If Boolean.TryParse(fields(7).Trim(), estado) AndAlso estado Then
                            ' Agregar solo los registros con estado activo a la lista filtrada
                            lineasFiltradas.Add(line)
                        End If
                    End If
                Next

                ' Guardar los detalles filtrados en un archivo temporal
                System.IO.File.WriteAllLines(rutaArchivoTemporal, lineasFiltradas)

                ' Reemplazar el archivo original con el archivo temporal
                System.IO.File.Delete(rutaArchivoKardex)
                System.IO.File.Move(rutaArchivoTemporal, rutaArchivoKardex)

                MessageBox.Show("Compactación por copia del Kardex completada con éxito.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al compactar por copia el Kardex. Error: {ex.Message}")
        End Try
    End Sub
End Class