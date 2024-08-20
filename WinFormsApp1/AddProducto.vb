Imports System.IO

Public Class AddProducto
    Private Sub RegistrarProducto()

        Dim idProducto As Integer = ObtenerUltimoIdProducto() + 1

        ' Registrar los datos comunes en el archivo Persona
        'IdPersona|Telefono|Correo|Direccion|Ruc|TipoPersona|Estado
        Dim productoData As String = $"{idProducto}|{txt_codigo.Text}|{txt_nombre.Text}|{txt_talla.Text}|{txt_precio.Text}|{txt_stock.Text}|{txt_categoria.Text}|{txt_marca.Text}|True"
        Using sw As StreamWriter = New StreamWriter(Persona.RutaArchivo, True)
            sw.WriteLine(productoData)
        End Using

        MessageBox.Show("Producto registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ObtenerUltimoIdProducto() As Integer
        Dim ultimoId As Integer = 0

        If File.Exists(Producto.RutaArchivo) Then
            Using sr As New StreamReader(Producto.RutaArchivo)
                Dim linea As String
                While Not sr.EndOfStream
                    linea = sr.ReadLine()
                    Dim datos() As String = linea.Split("|"c)
                    Dim id As Integer
                    If Integer.TryParse(datos(0), id) Then
                        ultimoId = Math.Max(ultimoId, id)
                    End If
                End While
            End Using
        End If

        Return ultimoId
    End Function

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
        Proveedor.Show()
    End Sub
End Class