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

    'Método para leer productos desde el archivo
    'Public Shared Function LeerProductos() As List(Of Producto)
    '    Dim productos As New List(Of Producto)
    '    Try
    '        Dim lines() As String = System.IO.File.ReadAllLines(RutaArchivo)

    '        For Each line As String In lines
    '            Dim fields() As String = line.Split("|"c)
    '            Dim producto As New Producto() With {
    '                .IdProducto = Integer.Parse(fields(0)),
    '                .Codigo = fields(1),
    '                .Nombre = fields(2),
    '                .Talla = fields(3),
    '                .Precio = Decimal.Parse(fields(4)),
    '                .StockActual = Integer.Parse(fields(5)),
    '                .IdCategoria = Integer.Parse(fields(6)),
    '                .IdMarca = Integer.Parse(fields(7)),
    '                .Estado = Boolean.Parse(fields(8))
    '            }
    '            productos.Add(producto)
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show($"Error al leer los productos: {ex.Message}")
    '    End Try
    '    Return productos
    'End Function


    Public Shared Function LeerProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines(RutaArchivo)

            ' Comenzar desde la segunda línea para ignorar la cabecera
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i).Trim()

                ' Ignorar líneas en blanco
                If String.IsNullOrWhiteSpace(line) Then
                    Continue For
                End If

                Dim fields() As String = line.Split("|"c)

                ' Validar que hay exactamente 9 campos en cada línea
                If fields.Length = 9 Then
                    Dim idProducto As Integer
                    Dim precio As Decimal
                    Dim stockActual As Integer
                    Dim idCategoria As Integer
                    Dim idMarca As Integer
                    Dim estado As Boolean

                    ' Validar cada campo que necesita conversión de tipo
                    If Integer.TryParse(fields(0).Trim(), idProducto) AndAlso
                   Decimal.TryParse(fields(4).Trim(), precio) AndAlso
                   Integer.TryParse(fields(5).Trim(), stockActual) AndAlso
                   Integer.TryParse(fields(6).Trim(), idCategoria) AndAlso
                   Integer.TryParse(fields(7).Trim(), idMarca) AndAlso
                   Boolean.TryParse(fields(8).Trim(), estado) Then

                        ' Si todos los campos son válidos, agregar el producto a la lista
                        Dim producto As New Producto() With {
                        .IdProducto = idProducto,
                        .Codigo = fields(1).Trim(),
                        .Nombre = fields(2).Trim(),
                        .Talla = fields(3).Trim(),
                        .Precio = precio,
                        .StockActual = stockActual,
                        .IdCategoria = idCategoria,
                        .IdMarca = idMarca,
                        .Estado = estado
                    }
                        productos.Add(producto)
                    Else
                        ' Si algún campo no es válido, registrar un mensaje de advertencia
                        MessageBox.Show($"Campos inválidos en la línea {i + 1}: {line}")
                    End If
                Else
                    ' Si la línea no tiene exactamente 9 campos, registrar un mensaje de advertencia con más detalles
                    MessageBox.Show($"Línea {i + 1} mal formateada (esperados 9 campos, encontrados {fields.Length}): {line}")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer los productos: {ex.Message}")
        End Try
        Return productos
    End Function















    'Método para actualizar el stock del producto en el archivo


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

    Public Shared Sub CompactarProductoPorCopia()
        Dim rutaArchivoProducto As String = "Datos\producto.txt"
        Dim rutaArchivoTemporal As String = "Datos\producto_temp.txt"
        Dim lineasFiltradas As New List(Of String)()

        Try
            ' Leer todas las líneas del archivo
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoProducto)

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
                        If Boolean.TryParse(fields(8).Trim(), estado) AndAlso estado Then
                            ' Agregar solo los registros con estado activo a la lista filtrada
                            lineasFiltradas.Add(line)
                        End If
                    End If
                Next

                ' Guardar los detalles filtrados en un archivo temporal
                System.IO.File.WriteAllLines(rutaArchivoTemporal, lineasFiltradas)

                ' Reemplazar el archivo original con el archivo temporal
                System.IO.File.Delete(rutaArchivoProducto)
                System.IO.File.Move(rutaArchivoTemporal, rutaArchivoProducto)

                MessageBox.Show("Compactación por copia de archivo Producto completada con éxito.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al compactar por copia el archivo Producto. Error: {ex.Message}")
        End Try
    End Sub

    Public Shared Sub CompactarProductoInSitu()
        Dim rutaArchivoProducto As String = "Datos\producto.txt"
        Dim lineasFiltradas As New List(Of String)()

        Try
            ' Leer todas las líneas del archivo
            Dim lines() As String = System.IO.File.ReadAllLines(rutaArchivoProducto)

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
                        If Boolean.TryParse(fields(8).Trim(), estado) AndAlso estado Then
                            ' Agregar solo los registros con estado activo a la lista filtrada
                            lineasFiltradas.Add(line)
                        End If
                    End If
                Next

                ' Sobrescribir el archivo original con las líneas filtradas
                System.IO.File.WriteAllLines(rutaArchivoProducto, lineasFiltradas)
                MessageBox.Show("Compactación in situ del archivo producto completada con éxito.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error al compactar in situ el archivo producto. Error: {ex.Message}")
        End Try
    End Sub

End Class

