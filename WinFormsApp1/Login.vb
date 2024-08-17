Imports System.IO

Public Class Login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

    End Sub

    Private archivoUsuarios As String = "C:\Users\PAUL\Documents\2024 - I\proyecto MA\archivos\Usuarios.csv" ' Ruta al archivo CSV o JSON

    Private Function ValidarCredenciales(username As String, password As String) As Boolean
        ' Lee el archivo y verifica las credenciales
        Try
            Dim lineas As String() = File.ReadAllLines(archivoUsuarios)

            For Each linea As String In lineas
                Dim campos As String() = linea.Split(";"c) ' Separador en caso de CSV

                If campos.Length = 2 AndAlso campos(0) = username AndAlso campos(1) = password Then
                    Return True ' Credenciales válidas
                End If
            Next

            Return False ' Credenciales inválidas
        Catch ex As Exception
            MessageBox.Show("Error al leer el archivo de usuarios: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim username As String = txtUsuario.Text.Trim()
        Dim password As String = txtContraseña.Text.Trim()

        If ValidarCredenciales(username, password) Then
            MessageBox.Show("¡Inicio de sesión exitoso!")
            txtContraseña.Text = ""
            Home.Show()
            Me.Hide()

            ' Aquí puedes abrir el formulario principal o realizar otras acciones después del login
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.")
        End If
    End Sub




End Class
