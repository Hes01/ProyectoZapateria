Public Class Home
    Private Sub btnCerrarS_Click(sender As Object, e As EventArgs) Handles btnCerrarS.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Venta.Show()

    End Sub

    Private Sub btnHomeProveedor_Click(sender As Object, e As EventArgs) Handles btnHomeProveedor.Click

        Proveedor.Show()
        Me.Hide()

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Cliente.Show()
        Me.Hide()

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Proveedor.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class