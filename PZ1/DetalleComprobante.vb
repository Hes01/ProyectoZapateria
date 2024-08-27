Public Class DetalleComprobante
    Public Property IdDetalle As Integer
    Public Property Cantidad As Integer
    Public Property PrecioVenta As Decimal
    Public Property IdProducto As Integer
    Public Property IdComprobante As Integer
    Public Property Estado As Boolean

    Public Sub GuardarDetalle()
        Dim line As String = $"{IdDetalle}|{Cantidad}|{PrecioVenta}|{IdProducto}|{IdComprobante}|{Estado}"
        System.IO.File.AppendAllText("Datos\detalles_comprobantes.txt", line & Environment.NewLine)
    End Sub


    Public Shared Function LeerDetallesComprobantes() As List(Of DetalleComprobante)
        Dim detalles As New List(Of DetalleComprobante)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\detalles_comprobantes.txt")
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


    ' Método para generar un nuevo ID de detalle de comprobante
    Public Shared Function GenerarNuevoIdDetalle() As Integer
        Dim ultimoId As Integer = 0
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\detalles_comprobantes.txt")
            If lines.Length > 0 Then
                ultimoId = Integer.Parse(lines.Last().Split("|"c)(0))
            End If
        Catch ex As Exception
            Console.WriteLine($"Error al generar nuevo ID de detalle: {ex.Message}")
        End Try
        Return ultimoId + 1
    End Function

    Public Shared Sub CompactarDetalles()
        Dim rutaArchivoDetalles As String = "Datos\detalles_comprobantes.txt"
        Dim rutaArchivoTemporal As String = "Datos\detalles_comprobantes_temp.txt"
        Dim detallesFiltrados As New List(Of String)()

        ' Leer todas las líneas del archivo
        Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoDetalles)

        ' Verificar si hay al menos una línea para evitar errores
        If lines.Length > 0 Then
            ' La primera línea es la cabecera, agregarla al archivo temporal sin modificarla
            detallesFiltrados.Add(lines(0))

            ' Procesar las líneas restantes
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim fields() As String = line.Split("|"c)

                If fields.Length >= 6 Then
                    Dim idComprobanteStr As String = fields(4).Trim()
                    Dim estadoDetalleStr As String = fields(5).Trim()

                    ' Validar y convertir el campo idComprobante
                    Dim idComprobante As Integer
                    If Not Integer.TryParse(idComprobanteStr, idComprobante) Then
                        Continue For ' Si no es un número válido, continuar con la siguiente línea
                    End If

                    ' Validar y convertir el campo estadoDetalle
                    Dim estadoDetalle As Boolean
                    If Not Boolean.TryParse(estadoDetalleStr, estadoDetalle) Then
                        Continue For ' Si no es un valor booleano válido, continuar con la siguiente línea
                    End If

                    ' Verificar el estado del comprobante correspondiente
                    If Comprobante.EsComprobanteActivo(idComprobante) AndAlso estadoDetalle Then
                        detallesFiltrados.Add(line)
                    End If
                End If
            Next

            ' Guardar los detalles filtrados en un archivo temporal
            System.IO.File.WriteAllLines(rutaArchivoTemporal, detallesFiltrados)

            ' Reemplazar el archivo original con el archivo temporal
            System.IO.File.Delete(rutaArchivoDetalles)
            System.IO.File.Move(rutaArchivoTemporal, rutaArchivoDetalles)
        Else
            MessageBox.Show("El archivo de detalles está vacío.")
        End If

        MessageBox.Show("Compactación de detalles completada con éxito.")
    End Sub

    Public Shared Sub CompactarDetallesInSitu()
        Dim rutaArchivoDetalles As String = "Datos\detalles_comprobantes.txt"
        Dim lineasFiltradas As New List(Of String)()

        Try
            ' Leer todas las líneas del archivo
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoDetalles)

            ' Asegurarse de que hay al menos una línea (la cabecera)
            If lines.Length > 0 Then
                ' Agregar la cabecera a la lista de líneas filtradas
                lineasFiltradas.Add(lines(0))

                ' Iterar desde la segunda línea para omitir la cabecera
                For i As Integer = 1 To lines.Length - 1
                    Dim line As String = lines(i)
                    Dim fields() As String = line.Split("|"c)
                    If fields.Length >= 6 Then
                        Dim idComprobante As Integer
                        Dim estadoDetalle As Boolean

                        ' Validar y convertir el campo idComprobante
                        If Integer.TryParse(fields(4).Trim(), idComprobante) AndAlso
                       Boolean.TryParse(fields(5).Trim(), estadoDetalle) AndAlso
                       estadoDetalle AndAlso Comprobante.EsComprobanteActivo(idComprobante) Then
                            ' Agregar solo los detalles cuyo comprobante asociado está activo a la lista filtrada
                            lineasFiltradas.Add(line)
                        End If
                    End If
                Next

                ' Sobrescribir el archivo original con las líneas filtradas
                System.IO.File.WriteAllLines(rutaArchivoDetalles, lineasFiltradas)
                MessageBox.Show("Compactación in situ de detalles completada con éxito.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al compactar in situ los detalles. Error: {ex.Message}")
        End Try
    End Sub


End Class