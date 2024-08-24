Imports System.IO

Public Class AddProveedor



    Private Sub cmbTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedItem IsNot Nothing Then
            Dim selectedValue As String = cmbTipo.SelectedItem.ToString()
            btnRegistrar.Visible = True
            'tipo segun el valor del cmb
            Select Case selectedValue
                Case "Juridica"
                    lblRazonSocial.Visible = True
                    txtRazonSocial.Visible = True
                    lblNombres.Visible = False
                    lblApellidos.Visible = False
                    lblDni.Visible = False
                    txtNombres.Visible = False
                    txtApellidos.Visible = False
                    txtDni.Visible = False

                Case "Natural"
                    lblNombres.Visible = True
                    lblApellidos.Visible = True
                    lblDni.Visible = True
                    txtNombres.Visible = True
                    txtApellidos.Visible = True
                    txtDni.Visible = True
                    lblRazonSocial.Visible = False
                    txtRazonSocial.Visible = False
            End Select
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        RegistrarProveedor()
        Me.Hide()
        Proveedor.Show()
    End Sub
    Private Sub RegistrarProveedor()
        Dim tipoPersona As String = cmbTipo.SelectedItem.ToString()
        Dim idPersona As Integer = ObtenerUltimoIdPersona() + 1
        Dim idPersonaNatural As Integer = ObtenerUltimoIdPersonaNatural() + 1
        Dim idPersonaJuridica As Integer = ObtenerUltimoIdPersonaJuridica() + 1
        Dim detalleData As String = ""

        Select Case tipoPersona
            Case "Juridica"
                'IdPersonaJuridica|RazonSocial|IdPersona|Estado
                detalleData = $"{idPersonaJuridica}|{txtRazonSocial.Text}|{idPersona}|True"
                Using sw As StreamWriter = New StreamWriter(PersonaJuridica.RutaArchivo, True)
                    sw.WriteLine(detalleData)
                End Using

            Case "Natural"
                'IdPersonaNatural|Nombre|Apellido|Dni|IdPersona|Estado
                detalleData = $"{idPersonaNatural}|{txtNombres.Text}|{txtApellidos.Text}|{txtDni.Text}|{idPersona}|True"
                Using sw As StreamWriter = New StreamWriter(PersonaNatural.RutaArchivo, True)
                    sw.WriteLine(detalleData)
                End Using
        End Select

        ' Registrar los datos comunes en el archivo Persona
        'IdPersona|Telefono|Correo|Direccion|Ruc|TipoPersona|Estado
        Dim personaData As String = $"{idPersona}|{txtTelefono.Text}|{txtEmail.Text}|{txtDirección.Text}|{txtRuc.Text}|{"Proveedor"}|True"
        Using sw As StreamWriter = New StreamWriter(Persona.RutaArchivo, True)
            sw.WriteLine(personaData)
        End Using

        MessageBox.Show("Cliente registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Function ObtenerUltimoIdPersona() As Integer
        Dim ultimoId As Integer = 0

        If File.Exists(Persona.RutaArchivo) Then
            Using sr As New StreamReader(Persona.RutaArchivo)
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

    Private Function ObtenerUltimoIdPersonaNatural() As Integer
        Dim ultimoId As Integer = 0

        If File.Exists(PersonaNatural.RutaArchivo) Then
            Using sr As New StreamReader(PersonaNatural.RutaArchivo)
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

    Private Function ObtenerUltimoIdPersonaJuridica() As Integer
        Dim ultimoId As Integer = 0

        If File.Exists(PersonaJuridica.RutaArchivo) Then
            Using sr As New StreamReader(PersonaJuridica.RutaArchivo)
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




    Private Sub AddProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRazonSocial.Visible = False
        txtRazonSocial.Visible = False
        lblNombres.Visible = False
        lblApellidos.Visible = False
        lblDni.Visible = False
        txtNombres.Visible = False
        txtApellidos.Visible = False
        txtDni.Visible = False
        btnRegistrar.Visible = False

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Proveedor.Show()

    End Sub
End Class