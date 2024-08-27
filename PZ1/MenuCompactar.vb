Public Class MenuCompactar
    Private Sub MenuCompactar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnCopia, "Con esta opción se crea un archivo temporal donde se copian los registros activos, se elimina el original y se renombra el temporal en reemplazo del original.")
        ToolTip2.SetToolTip(btnSitu, "Con esta opción se sobreescribe el archivo original con los registros activos.")
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btnCopia_Click(sender As Object, e As EventArgs) Handles btnCopia.Click
        CompactarPersonas()
    End Sub

    Private Sub btnSitu_Click(sender As Object, e As EventArgs) Handles btnSitu.Click
        CompactarPersonasInSitu()
    End Sub

    Public Shared Sub CompactarPersonasInSitu()
        Dim rutaArchivoPersonas As String = "Datos\persona.txt"

        Try
            ' Leer todas las líneas del archivo persona.txt
            Dim lineasPersona() As String = System.IO.File.ReadAllLines(rutaArchivoPersonas)
            Dim lineasPersonaFiltradas As New List(Of String)()

            ' Verificar si hay líneas en el archivo
            If lineasPersona.Length > 0 Then
                ' Agregar el encabezado al archivo filtrado
                lineasPersonaFiltradas.Add(lineasPersona(0))

                ' Procesar cada línea de persona.txt (excluyendo el encabezado)
                For i As Integer = 1 To lineasPersona.Length - 1
                    Dim linea As String = lineasPersona(i)
                    Dim campos() As String = linea.Split("|"c)

                    ' Asegurarse de que hay suficientes campos en la línea
                    If campos.Length >= 7 Then
                        Dim idPersona As Integer
                        Dim estado As Boolean

                        ' Validar y convertir el campo idPersona y estado
                        If Integer.TryParse(campos(0).Trim(), idPersona) AndAlso
                       Boolean.TryParse(campos(6).Trim(), estado) Then

                            If estado Then
                                ' Si la persona está activa, se agrega al archivo filtrado
                                lineasPersonaFiltradas.Add(linea)
                            Else
                                ' Si la persona está eliminada, elimina sus referencias en otras tablas
                                EliminarReferenciasDePersona(idPersona)
                            End If
                        End If
                    End If
                Next

                ' Sobrescribir el archivo original con las líneas filtradas
                System.IO.File.WriteAllLines(rutaArchivoPersonas, lineasPersonaFiltradas)

                MessageBox.Show("Compactación in situ de personas completada con éxito.")
            Else
                MessageBox.Show("El archivo está vacío o no se pudo leer.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error durante la compactación in situ: {ex.Message}")
        End Try
    End Sub


    Public Shared Sub CompactarPersonas()
        Dim rutaArchivoPersonas As String = "Datos\persona.txt"
        Dim rutaArchivoPersonasTemp As String = rutaArchivoPersonas.Replace(".txt", "_temp.txt")

        Try
            ' Leer todas las líneas del archivo persona.txt
            Dim lineasPersona() As String = System.IO.File.ReadAllLines(rutaArchivoPersonas)
            Dim lineasPersonaFiltradas As New List(Of String)()

            ' Verificar si hay líneas en el archivo
            If lineasPersona.Length > 0 Then
                ' Agregar el encabezado al archivo temporal
                lineasPersonaFiltradas.Add(lineasPersona(0))

                ' Procesar cada línea de persona.txt (excluyendo el encabezado)
                For i As Integer = 1 To lineasPersona.Length - 1
                    Dim linea As String = lineasPersona(i)
                    Dim campos() As String = linea.Split("|"c)

                    ' Asegurarse de que hay suficientes campos en la línea
                    If campos.Length >= 7 Then
                        Dim idPersona As Integer
                        Dim estado As Boolean

                        ' Validar y convertir el campo idPersona y estado
                        If Integer.TryParse(campos(0).Trim(), idPersona) AndAlso
                           Boolean.TryParse(campos(6).Trim(), estado) Then

                            If estado Then
                                ' Si la persona está activa, se agrega al archivo temporal
                                lineasPersonaFiltradas.Add(linea)
                            Else
                                ' Si la persona está eliminada, elimina sus referencias en otras tablas
                                EliminarReferenciasDePersona(idPersona)
                            End If
                        End If
                    End If
                Next

                ' Escribir las líneas filtradas en el archivo temporal
                System.IO.File.WriteAllLines(rutaArchivoPersonasTemp, lineasPersonaFiltradas)

                ' Eliminar el archivo original y renombrar el archivo temporal
                System.IO.File.Delete(rutaArchivoPersonas)
                System.IO.File.Move(rutaArchivoPersonasTemp, rutaArchivoPersonas)

                MessageBox.Show("Compactación de personas completada con éxito.")
            Else
                MessageBox.Show("El archivo está vacío o no se pudo leer.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error durante la compactación: {ex.Message}")
        End Try
    End Sub

    Private Shared Sub EliminarReferenciasDePersona(idPersona As Integer)
        ' Eliminar registros en persona_juridica.txt
        EliminarRegistroEnArchivo("Datos\persona_juridica.txt", idPersona, 2)

        ' Eliminar registros en persona_natural.txt
        EliminarRegistroEnArchivo("Datos\persona_natural.txt", idPersona, 4)

        ' Eliminar registros en comprobante.txt y sus detalles
        Dim idComprobantesEliminados As List(Of Integer) = EliminarRegistrosEnComprobantes(idPersona)

        ' Eliminar registros en detalle_comprobante.txt relacionados con los IdComprobante eliminados
        EliminarDetallesComprobante(idComprobantesEliminados)
    End Sub

    Private Shared Sub EliminarRegistroEnArchivo(rutaArchivo As String, idPersona As Integer, indexIdPersona As Integer)
        Dim lineas() As String = System.IO.File.ReadAllLines(rutaArchivo)
        Dim lineasFiltradas As New List(Of String)()

        ' Verificar si hay líneas en el archivo
        If lineas.Length > 0 Then
            ' Agregar el encabezado al archivo temporal
            lineasFiltradas.Add(lineas(0))

            ' Filtrar las líneas que no corresponden al IdPersona
            For i As Integer = 1 To lineas.Length - 1
                Dim linea As String = lineas(i)
                Dim campos() As String = linea.Split("|"c)
                If campos.Length > indexIdPersona Then
                    Dim idEnArchivo As Integer
                    ' Validar y convertir el campo idPersona
                    If Integer.TryParse(campos(indexIdPersona).Trim(), idEnArchivo) AndAlso idEnArchivo <> idPersona Then
                        lineasFiltradas.Add(linea)
                    End If
                End If
            Next

            ' Sobrescribir el archivo con las líneas filtradas
            System.IO.File.WriteAllLines(rutaArchivo, lineasFiltradas)
        End If
    End Sub

    Private Shared Function EliminarRegistrosEnComprobantes(idPersona As Integer) As List(Of Integer)
        Dim rutaArchivoComprobantes As String = "Datos\comprobantes.txt"
        Dim lineas() As String = System.IO.File.ReadAllLines(rutaArchivoComprobantes)
        Dim lineasFiltradas As New List(Of String)()
        Dim idComprobantesEliminados As New List(Of Integer)()

        ' Filtrar las líneas y almacenar los IdComprobante eliminados
        For i As Integer = 0 To lineas.Length - 1
            Dim linea As String = lineas(i)
            Dim campos() As String = linea.Split("|"c)
            If campos.Length > 4 Then
                Dim idPersonaEnComprobante As Integer
                ' Validar y convertir el campo idPersona
                If Integer.TryParse(campos(4).Trim(), idPersonaEnComprobante) AndAlso idPersonaEnComprobante = idPersona Then
                    idComprobantesEliminados.Add(Integer.Parse(campos(0).Trim()))
                Else
                    lineasFiltradas.Add(linea)
                End If
            End If
        Next

        ' Sobrescribir comprobante.txt
        System.IO.File.WriteAllLines(rutaArchivoComprobantes, lineasFiltradas)

        Return idComprobantesEliminados
    End Function

    Private Shared Sub EliminarDetallesComprobante(idComprobantes As List(Of Integer))
        Dim rutaArchivoDetalleComprobante As String = "Datos\detalles_comprobantes.txt"
        Dim lineas() As String = System.IO.File.ReadAllLines(rutaArchivoDetalleComprobante)
        Dim lineasFiltradas As New List(Of String)()

        ' Filtrar las líneas en detalle_comprobante.txt que no correspondan a los IdComprobante eliminados
        For i As Integer = 0 To lineas.Length - 1
            Dim linea As String = lineas(i)
            Dim campos() As String = linea.Split("|"c)
            If campos.Length > 4 Then
                Dim idComprobanteEnDetalle As Integer
                ' Validar y convertir el campo idComprobante
                If Integer.TryParse(campos(4).Trim(), idComprobanteEnDetalle) AndAlso Not idComprobantes.Contains(idComprobanteEnDetalle) Then
                    lineasFiltradas.Add(linea)
                End If
            End If
        Next

        ' Sobrescribir detalle_comprobante.txt
        System.IO.File.WriteAllLines(rutaArchivoDetalleComprobante, lineasFiltradas)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DetalleComprobante.CompactarDetalles()
        Comprobante.CompactarPorCopia()
        Kardex.CompactarKardexPorCopia()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DetalleComprobante.CompactarDetallesInSitu()
        Comprobante.CompactarComprobantesInSitu()
        Kardex.CompactarKardexInSitu()
    End Sub
End Class
