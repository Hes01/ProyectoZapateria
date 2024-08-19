Imports System.IO

Public Class AddCliente
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
        RegistrarCliente()
        Me.Hide()
        Cliente.Show()
    End Sub

    Private Sub AddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub RegistrarCliente()
        Dim tipoPersona As String = cmbTipo.SelectedItem.ToString()
        Dim idPersona As Integer = GetNextIdPersona()
        Dim personaData As String
        Dim detalleData As String = ""

        'IdPersona|Telefono|Correo|Direccion|Ruc|TipoPersona|Estado
        ' Registrar la información común en el archivo persona.txt
        personaData = $"{idPersona}|{txtTelefono.Text}|{txtEmail.Text}|{txtDirección.Text}|{txtRuc.Text}|{"Cliente"}|1"
        Using sw As StreamWriter = New StreamWriter("persona.txt", True)
            sw.WriteLine(personaData)
        End Using


        Select Case tipoPersona
            Case "Juridica"
                'IdPersonaJuridica|RazonSocial|IdPersona|Estado
                detalleData = $"{idPersonaJuridica}|{txtRazonSocial.Text}|{idPersona}"
                Using sw As StreamWriter = New StreamWriter("personaJuridica.txt", True)
                    sw.WriteLine(detalleData)
                End Using

            Case "Natural"
                'IdPersonaNatural|Nombre|Apellido|Dni|IdPersona|Estado
                detalleData = $"{idPersonaNatural}|{txtNombres.Text}|{txtApellidos.Text}|{txtDni.Text}|{idPersona}"
                Using sw As StreamWriter = New StreamWriter("personaNatural.txt", True)
                    sw.WriteLine(detalleData)
                End Using
        End Select

        MessageBox.Show("Cliente registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetNextIdPersona() As Integer
        ' Obtener el siguiente ID disponible para la nueva persona
        Dim maxId As Integer = 0
        If File.Exists("persona.txt") Then
            Dim lines() As String = File.ReadAllLines("persona.txt")
            If lines.Length > 0 Then
                maxId = lines.Select(Function(line) Integer.Parse(line.Split("|"c)(0))).Max()
            End If
        End If
        Return maxId + 1
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class

