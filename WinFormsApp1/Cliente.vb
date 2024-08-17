Imports System.IO

Public Class Cliente
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        AddCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarCliente(txtBuscar.Text)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarCliente(txtBuscar.Text)
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        ' Aquí podrías cargar los datos del cliente seleccionado para su edición
    End Sub

    Private Sub CargarClientes()
        dgvClientes.Rows.Clear()
        Using sr As StreamReader = New StreamReader("clientes.txt")
            While Not sr.EndOfStream
                Dim linea As String = sr.ReadLine()
                Dim datos As String() = linea.Split("|"c)
                dgvClientes.Rows.Add(datos)
            End While
        End Using
    End Sub

    Private Sub BuscarCliente(idBuscar As String)
        dgvClientes.Rows.Clear()
        Dim encontrado As Boolean = False
        Using sr As StreamReader = New StreamReader("clientes.txt")
            While Not sr.EndOfStream
                Dim linea As String = sr.ReadLine()
                Dim datos As String() = linea.Split("|"c)
                If datos(0).Contains(idBuscar) OrElse datos(4).Contains(idBuscar) Then ' Búsqueda por ID o nombre/razón social
                    dgvClientes.Rows.Add(datos)
                    encontrado = True
                End If
            End While
        End Using
        If Not encontrado Then
            MessageBox.Show("Cliente no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class