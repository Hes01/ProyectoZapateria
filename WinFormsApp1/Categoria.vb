Public Class Categoria
    Public Property IdCategoria As Integer
    Public Property Nombre As String

    ' Método para guardar la categoría en un archivo
    Public Sub GuardarCategoria()
        Dim line As String = $"{IdCategoria}|{Nombre}"
        System.IO.File.AppendAllText("categorias.txt", line & Environment.NewLine)
    End Sub

    ' Método para leer todas las categorías desde el archivo
    Public Shared Function LeerCategorias() As List(Of Categoria)
        Dim categorias As New List(Of Categoria)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("categorias.txt")
            For Each line As String In lines
                Dim fields() As String = line.Split("|"c)
                Dim categoria As New Categoria With {
                    .IdCategoria = Integer.Parse(fields(0)),
                    .Nombre = fields(1)
                }
                categorias.Add(categoria)
            Next
        Catch ex As Exception
            Console.WriteLine($"Error al leer categorías: {ex.Message}")
        End Try
        Return categorias
    End Function
End Class
