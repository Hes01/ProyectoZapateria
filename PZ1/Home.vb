Public Class Home
    Private Sub btnCerrarS_Click(sender As Object, e As EventArgs) Handles btnCerrarS.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Venta.Show()
        Me.Hide()

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
        Reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Compra.Show()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Inventario.Show()

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

    End Sub

    Private Sub timerActualizacion_Tick(sender As Object, e As EventArgs) Handles timerActualizacion.Tick
        lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        Me.Hide()
        MenuCompactar.Show()

    End Sub
End Class