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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        btnVentas = New Button()
        btnCompra = New Button()
        btnInventario = New Button()
        btnClientes = New Button()
        btnReportes = New Button()
        btnCerrarS = New Button()
        btnHomeProveedor = New Button()
        btnMantenimiento = New Button()
        btnProductos = New Button()
        lblFechaHora = New Label()
        timerActualizacion = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnVentas
        ' 
        btnVentas.BackColor = Color.Transparent
        btnVentas.BackgroundImage = CType(resources.GetObject("btnVentas.BackgroundImage"), Image)
        btnVentas.BackgroundImageLayout = ImageLayout.Center
        btnVentas.FlatAppearance.BorderColor = Color.Silver
        btnVentas.FlatAppearance.BorderSize = 2
        btnVentas.FlatAppearance.CheckedBackColor = Color.Transparent
        btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnVentas.Location = New Point(24, 101)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(118, 113)
        btnVentas.TabIndex = 0
        btnVentas.Text = "Venta"
        btnVentas.TextAlign = ContentAlignment.BottomCenter
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' btnCompra
        ' 
        btnCompra.BackColor = Color.Transparent
        btnCompra.BackgroundImage = CType(resources.GetObject("btnCompra.BackgroundImage"), Image)
        btnCompra.BackgroundImageLayout = ImageLayout.Center
        btnCompra.FlatAppearance.BorderColor = Color.Silver
        btnCompra.FlatAppearance.BorderSize = 2
        btnCompra.FlatAppearance.CheckedBackColor = Color.Transparent
        btnCompra.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnCompra.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnCompra.Location = New Point(167, 101)
        btnCompra.Name = "btnCompra"
        btnCompra.Size = New Size(118, 113)
        btnCompra.TabIndex = 1
        btnCompra.Text = "Compra"
        btnCompra.TextAlign = ContentAlignment.BottomCenter
        btnCompra.UseVisualStyleBackColor = False
        ' 
        ' btnInventario
        ' 
        btnInventario.BackColor = Color.Transparent
        btnInventario.BackgroundImage = CType(resources.GetObject("btnInventario.BackgroundImage"), Image)
        btnInventario.BackgroundImageLayout = ImageLayout.Center
        btnInventario.FlatAppearance.BorderColor = Color.Silver
        btnInventario.FlatAppearance.BorderSize = 2
        btnInventario.FlatAppearance.CheckedBackColor = Color.Transparent
        btnInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnInventario.Location = New Point(24, 239)
        btnInventario.Name = "btnInventario"
        btnInventario.Size = New Size(118, 98)
        btnInventario.TabIndex = 3
        btnInventario.Text = "Inventario"
        btnInventario.TextAlign = ContentAlignment.BottomCenter
        btnInventario.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.Transparent
        btnClientes.BackgroundImage = CType(resources.GetObject("btnClientes.BackgroundImage"), Image)
        btnClientes.BackgroundImageLayout = ImageLayout.Center
        btnClientes.FlatAppearance.BorderColor = Color.Silver
        btnClientes.FlatAppearance.BorderSize = 2
        btnClientes.FlatAppearance.CheckedBackColor = Color.Transparent
        btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnClientes.Location = New Point(315, 101)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(118, 113)
        btnClientes.TabIndex = 4
        btnClientes.Text = "Clientes"
        btnClientes.TextAlign = ContentAlignment.BottomCenter
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnReportes
        ' 
        btnReportes.BackColor = Color.Transparent
        btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), Image)
        btnReportes.BackgroundImageLayout = ImageLayout.Center
        btnReportes.FlatAppearance.BorderColor = Color.Silver
        btnReportes.FlatAppearance.BorderSize = 2
        btnReportes.FlatAppearance.CheckedBackColor = Color.Transparent
        btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnReportes.Location = New Point(315, 239)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(118, 98)
        btnReportes.TabIndex = 5
        btnReportes.Text = "Reportes"
        btnReportes.TextAlign = ContentAlignment.BottomCenter
        btnReportes.UseVisualStyleBackColor = False
        ' 
        ' btnCerrarS
        ' 
        btnCerrarS.BackColor = Color.Snow
        btnCerrarS.BackgroundImage = CType(resources.GetObject("btnCerrarS.BackgroundImage"), Image)
        btnCerrarS.BackgroundImageLayout = ImageLayout.Center
        btnCerrarS.Location = New Point(590, 136)
        btnCerrarS.Name = "btnCerrarS"
        btnCerrarS.Size = New Size(88, 95)
        btnCerrarS.TabIndex = 6
        btnCerrarS.Text = "Salir"
        btnCerrarS.TextAlign = ContentAlignment.BottomCenter
        btnCerrarS.UseVisualStyleBackColor = False
        ' 
        ' btnHomeProveedor
        ' 
        btnHomeProveedor.BackColor = Color.Transparent
        btnHomeProveedor.BackgroundImage = CType(resources.GetObject("btnHomeProveedor.BackgroundImage"), Image)
        btnHomeProveedor.BackgroundImageLayout = ImageLayout.Center
        btnHomeProveedor.FlatAppearance.BorderColor = Color.Silver
        btnHomeProveedor.FlatAppearance.BorderSize = 2
        btnHomeProveedor.FlatAppearance.CheckedBackColor = Color.Transparent
        btnHomeProveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnHomeProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnHomeProveedor.Location = New Point(167, 365)
        btnHomeProveedor.Name = "btnHomeProveedor"
        btnHomeProveedor.Size = New Size(118, 104)
        btnHomeProveedor.TabIndex = 8
        btnHomeProveedor.Text = "Proveedores"
        btnHomeProveedor.TextAlign = ContentAlignment.BottomCenter
        btnHomeProveedor.UseVisualStyleBackColor = False
        ' 
        ' btnMantenimiento
        ' 
        btnMantenimiento.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), Image)
        btnMantenimiento.BackgroundImageLayout = ImageLayout.Center
        btnMantenimiento.ForeColor = Color.Black
        btnMantenimiento.Location = New Point(551, 262)
        btnMantenimiento.Name = "btnMantenimiento"
        btnMantenimiento.Size = New Size(173, 125)
        btnMantenimiento.TabIndex = 9
        btnMantenimiento.Text = "Mantenimiento"
        btnMantenimiento.TextAlign = ContentAlignment.BottomCenter
        btnMantenimiento.UseVisualStyleBackColor = False
        ' 
        ' btnProductos
        ' 
        btnProductos.BackColor = Color.Transparent
        btnProductos.BackgroundImage = CType(resources.GetObject("btnProductos.BackgroundImage"), Image)
        btnProductos.BackgroundImageLayout = ImageLayout.Center
        btnProductos.FlatAppearance.BorderColor = Color.Silver
        btnProductos.FlatAppearance.BorderSize = 2
        btnProductos.FlatAppearance.CheckedBackColor = Color.Transparent
        btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnProductos.Location = New Point(167, 239)
        btnProductos.Name = "btnProductos"
        btnProductos.Size = New Size(118, 98)
        btnProductos.TabIndex = 2
        btnProductos.Text = "Productos"
        btnProductos.TextAlign = ContentAlignment.BottomCenter
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' lblFechaHora
        ' 
        lblFechaHora.AutoSize = True
        lblFechaHora.BackColor = Color.Black
        lblFechaHora.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblFechaHora.ForeColor = Color.Red
        lblFechaHora.Location = New Point(561, 496)
        lblFechaHora.Name = "lblFechaHora"
        lblFechaHora.Size = New Size(108, 18)
        lblFechaHora.TabIndex = 10
        lblFechaHora.Text = "                    "
        ' 
        ' timerActualizacion
        ' 
        timerActualizacion.Enabled = True
        timerActualizacion.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Highlight
        Label1.Font = New Font("Sitka Small", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(1, -3)
        Label1.Name = "Label1"
        Label1.Size = New Size(358, 71)
        Label1.TabIndex = 11
        Label1.Text = "Zapateria JEP"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = My.Resources.Resources.Fondo_amarillo_azul_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(736, 523)
        Controls.Add(Label1)
        Controls.Add(lblFechaHora)
        Controls.Add(btnMantenimiento)
        Controls.Add(btnHomeProveedor)
        Controls.Add(btnCerrarS)
        Controls.Add(btnReportes)
        Controls.Add(btnClientes)
        Controls.Add(btnInventario)
        Controls.Add(btnProductos)
        Controls.Add(btnCompra)
        Controls.Add(btnVentas)
        FormBorderStyle = FormBorderStyle.None
        Name = "Home"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVentas As Button
    Friend WithEvents btnCompra As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCerrarS As Button
    Friend WithEvents btnHomeProveedor As Button
    Friend WithEvents btnMantenimiento As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents lblFechaHora As Label
    Friend WithEvents timerActualizacion As Timer
    Friend WithEvents Label1 As Label
End Class
