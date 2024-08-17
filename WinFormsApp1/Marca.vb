Public Class Marca
    Public Property IdMarca As Integer
    Public Property Nombre As String

    ' Ruta del archivo de marcas relativa al directorio base de la aplicación
    Private Shared ReadOnly RutaArchivo As String = "Datos\marca.txt"

    ' Método para leer todas las marcas desde el archivo
    Public Shared Function LeerMarcas() As List(Of Marca)
        Dim marcas As New List(Of Marca)()
        Try
            ' Leer todas las líneas y omitir la primera (encabezado)
            Dim lines() As String = System.IO.File.ReadAllLines(RutaArchivo).Skip(1).ToArray()

            ' Procesar cada línea del archivo
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)

                ' Verificar que la línea tenga exactamente dos campos
                If fields.Length <> 2 Then Continue For

                Dim idMarca As Integer
                If Integer.TryParse(fields(0).Trim(), idMarca) Then
                    marcas.Add(New Marca() With {
                        .IdMarca = idMarca,
                        .Nombre = fields(1).Trim()
                    })
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer el archivo de marcas: {ex.Message}")
        End Try

        Return marcas
    End Function
End Class
