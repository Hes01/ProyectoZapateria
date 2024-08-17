Public Class Proveedor
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        AddProveedor.Show()
        Me.Hide()


    End Sub

    Private Sub btnSalirProveedor_Click(sender As Object, e As EventArgs) Handles btnSalirProveedor.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Estado_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class