Public Class AddProveedor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click


        Me.Hide()
        Proveedor.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        ' Asegurarse de que se haya seleccionado un elemento

        If cmbTipo.SelectedItem IsNot Nothing Then
            ' Obtener el valor seleccionado
            Dim selectedValue As String = cmbTipo.SelectedItem.ToString()

            btnRegistrar.Visible = True
            ' Mostrar u ocultar botones según el valor seleccionado
            Select Case selectedValue
                Case "Juridica" ' Reemplaza "Valor1" con el valor real que quieres verificar
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
End Class