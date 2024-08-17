Imports System.IO

Public Class AddCliente
    Private Sub cmbTipoProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedItem IsNot Nothing Then
            Dim selectedValue As String = cmbTipo.SelectedItem.ToString()
            btnRegistrar.Visible = True

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
        Dim id As String = Guid.NewGuid().ToString() ' Generar un ID único para el cliente
        Dim clienteData As String = ""

        Select Case tipoPersona
            Case "Juridica"
                clienteData = $"{id}|{txtRazonSocial.Text}||{txtRuc.Text}|{txtDirección.Text}|{txtTelefono.Text}|{txtEmail.Text}|1|1"
            Case "Natural"
                clienteData = $"{id}|{txtNombres.Text} {txtApellidos.Text}|{txtDni.Text}||{txtDirección.Text}|{txtTelefono.Text}|{txtEmail.Text}|0|1"
        End Select

        Using sw As StreamWriter = New StreamWriter("clientes.txt", True)
            sw.WriteLine(clienteData)
        End Using

        MessageBox.Show("Cliente registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

'ademas aqui tengo los lblid , lblruc, lbldireccion,lbltelefono,lblemail,lblrazonsocial,lblnombre,lblapellidos,lbldni
'y cuando seleciono un tipo si es persona juridica se desaparecen algunos elementos para almacenar solo datos de clientes 
'juridicas si es natural igual pasa se ocultan los elementos para persona juridica y aparecen los de natural