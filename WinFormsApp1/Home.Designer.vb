<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnVentas = New Button()
        btnCompra = New Button()
        btnProductos = New Button()
        btnInventario = New Button()
        btnClientes = New Button()
        btnReportes = New Button()
        btnCerrarS = New Button()
        btnHomeProveedor = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' btnVentas
        ' 
        btnVentas.Location = New Point(114, 135)
        btnVentas.Margin = New Padding(3, 4, 3, 4)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(135, 72)
        btnVentas.TabIndex = 0
        btnVentas.Text = "Venta"
        btnVentas.UseVisualStyleBackColor = True
        ' 
        ' btnCompra
        ' 
        btnCompra.Location = New Point(318, 135)
        btnCompra.Margin = New Padding(3, 4, 3, 4)
        btnCompra.Name = "btnCompra"
        btnCompra.Size = New Size(135, 72)
        btnCompra.TabIndex = 1
        btnCompra.Text = "Compra"
        btnCompra.UseVisualStyleBackColor = True
        ' 
        ' btnProductos
        ' 
        btnProductos.Location = New Point(525, 135)
        btnProductos.Margin = New Padding(3, 4, 3, 4)
        btnProductos.Name = "btnProductos"
        btnProductos.Size = New Size(135, 72)
        btnProductos.TabIndex = 2
        btnProductos.Text = "Productos"
        btnProductos.UseVisualStyleBackColor = True
        ' 
        ' btnInventario
        ' 
        btnInventario.Location = New Point(27, 319)
        btnInventario.Margin = New Padding(3, 4, 3, 4)
        btnInventario.Name = "btnInventario"
        btnInventario.Size = New Size(135, 72)
        btnInventario.TabIndex = 3
        btnInventario.Text = "Inventario"
        btnInventario.UseVisualStyleBackColor = True
        ' 
        ' btnClientes
        ' 
        btnClientes.Location = New Point(218, 319)
        btnClientes.Margin = New Padding(3, 4, 3, 4)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(135, 72)
        btnClientes.TabIndex = 4
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = True
        ' 
        ' btnReportes
        ' 
        btnReportes.Location = New Point(413, 319)
        btnReportes.Margin = New Padding(3, 4, 3, 4)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(135, 72)
        btnReportes.TabIndex = 5
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = True
        ' 
        ' btnCerrarS
        ' 
        btnCerrarS.Location = New Point(318, 479)
        btnCerrarS.Margin = New Padding(3, 4, 3, 4)
        btnCerrarS.Name = "btnCerrarS"
        btnCerrarS.Size = New Size(101, 43)
        btnCerrarS.TabIndex = 6
        btnCerrarS.Text = "Cerrar Sesión"
        btnCerrarS.UseVisualStyleBackColor = True
        ' 
        ' btnHomeProveedor
        ' 
        btnHomeProveedor.Location = New Point(585, 319)
        btnHomeProveedor.Margin = New Padding(3, 4, 3, 4)
        btnHomeProveedor.Name = "btnHomeProveedor"
        btnHomeProveedor.Size = New Size(135, 72)
        btnHomeProveedor.TabIndex = 8
        btnHomeProveedor.Text = "Proveedores"
        btnHomeProveedor.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(490, 464)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(198, 72)
        Button4.TabIndex = 9
        Button4.Text = "Mantenimiento"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 577)
        Controls.Add(Button4)
        Controls.Add(btnHomeProveedor)
        Controls.Add(btnCerrarS)
        Controls.Add(btnReportes)
        Controls.Add(btnClientes)
        Controls.Add(btnInventario)
        Controls.Add(btnProductos)
        Controls.Add(btnCompra)
        Controls.Add(btnVentas)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Home"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVentas As Button
    Friend WithEvents btnCompra As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCerrarS As Button
    Friend WithEvents btnHomeProveedor As Button
    Friend WithEvents Button4 As Button
End Class
