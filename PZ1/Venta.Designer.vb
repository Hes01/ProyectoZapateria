<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtCodigoProducto = New TextBox()
        rbtnBoleta = New RadioButton()
        rbtnFactura = New RadioButton()
        GroupBox1 = New GroupBox()
        lblNombre = New TextBox()
        lblMarca = New TextBox()
        lblTalla = New TextBox()
        txtSubtotal = New TextBox()
        lblPrecio = New TextBox()
        lblStockActual = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        dgvVenta = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Código = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        PanelBoleta = New Panel()
        lblIdPersona = New Label()
        lblRuc = New Label()
        lblApellido = New Label()
        lblCorreo = New Label()
        lblRazonSocial = New Label()
        Button1 = New Button()
        btnBusBoleta = New Button()
        lblDireccion = New Label()
        lblTelefono = New Label()
        lblNomCliente = New Label()
        txtDocumento = New TextBox()
        Label9 = New Label()
        Label13 = New Label()
        btnAgregar = New Button()
        txtCantidad = New NumericUpDown()
        txtTotal = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        btnEliminar = New Button()
        Button4 = New Button()
        btnBuscar = New Button()
        cmbTipoPago = New ComboBox()
        lblIdVendedor = New Label()
        lblIdProducto = New Label()
        nueva = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvVenta, ComponentModel.ISupportInitialize).BeginInit()
        PanelBoleta.SuspendLayout()
        CType(txtCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCodigoProducto
        ' 
        txtCodigoProducto.Location = New Point(63, 173)
        txtCodigoProducto.Name = "txtCodigoProducto"
        txtCodigoProducto.Size = New Size(100, 23)
        txtCodigoProducto.TabIndex = 0
        ' 
        ' rbtnBoleta
        ' 
        rbtnBoleta.AutoSize = True
        rbtnBoleta.Location = New Point(21, 36)
        rbtnBoleta.Name = "rbtnBoleta"
        rbtnBoleta.Size = New Size(66, 19)
        rbtnBoleta.TabIndex = 1
        rbtnBoleta.TabStop = True
        rbtnBoleta.Text = "BOLETA"
        rbtnBoleta.UseVisualStyleBackColor = True
        ' 
        ' rbtnFactura
        ' 
        rbtnFactura.AutoSize = True
        rbtnFactura.Location = New Point(21, 61)
        rbtnFactura.Name = "rbtnFactura"
        rbtnFactura.Size = New Size(75, 19)
        rbtnFactura.TabIndex = 2
        rbtnFactura.TabStop = True
        rbtnFactura.Text = "FACTURA"
        rbtnFactura.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnBoleta)
        GroupBox1.Controls.Add(rbtnFactura)
        GroupBox1.Location = New Point(76, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "TIPO COMPROBANTE"
        ' 
        ' lblNombre
        ' 
        lblNombre.Location = New Point(275, 173)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(100, 23)
        lblNombre.TabIndex = 4
        ' 
        ' lblMarca
        ' 
        lblMarca.Location = New Point(430, 173)
        lblMarca.Name = "lblMarca"
        lblMarca.Size = New Size(100, 23)
        lblMarca.TabIndex = 5
        ' 
        ' lblTalla
        ' 
        lblTalla.Location = New Point(604, 173)
        lblTalla.Name = "lblTalla"
        lblTalla.Size = New Size(100, 23)
        lblTalla.TabIndex = 6
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(546, 281)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(100, 23)
        txtSubtotal.TabIndex = 10
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Location = New Point(372, 281)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(100, 23)
        lblPrecio.TabIndex = 9
        ' 
        ' lblStockActual
        ' 
        lblStockActual.Location = New Point(63, 281)
        lblStockActual.Name = "lblStockActual"
        lblStockActual.Size = New Size(100, 23)
        lblStockActual.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 11
        Label1.Text = "Codigo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(451, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 12
        Label2.Text = "Marca"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(275, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 13
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(605, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 14
        Label4.Text = "Talla"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(92, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 15
        Label5.Text = "Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(217, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 15)
        Label6.TabIndex = 16
        Label6.Text = "Cantidad venta"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(385, 263)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 15)
        Label7.TabIndex = 17
        Label7.Text = "Precio Unitario"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(582, 263)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 15)
        Label8.TabIndex = 18
        Label8.Text = "Subtotal"
        ' 
        ' dgvVenta
        ' 
        dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVenta.Columns.AddRange(New DataGridViewColumn() {Column1, Column6, Código, Marca, Column2, Column3, Column4, Column5})
        dgvVenta.Location = New Point(37, 402)
        dgvVenta.Name = "dgvVenta"
        dgvVenta.RowHeadersWidth = 51
        dgvVenta.Size = New Size(909, 233)
        dgvVenta.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Codigo"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Código
        ' 
        Código.HeaderText = "Nombre"
        Código.MinimumWidth = 6
        Código.Name = "Código"
        Código.Width = 125
        ' 
        ' Marca
        ' 
        Marca.HeaderText = "Marca"
        Marca.MinimumWidth = 6
        Marca.Name = "Marca"
        Marca.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Talla"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cantidad"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Precio Unitario"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Subtotal"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' PanelBoleta
        ' 
        PanelBoleta.BorderStyle = BorderStyle.Fixed3D
        PanelBoleta.Controls.Add(lblIdPersona)
        PanelBoleta.Controls.Add(lblRuc)
        PanelBoleta.Controls.Add(lblApellido)
        PanelBoleta.Controls.Add(lblCorreo)
        PanelBoleta.Controls.Add(lblRazonSocial)
        PanelBoleta.Controls.Add(Button1)
        PanelBoleta.Controls.Add(btnBusBoleta)
        PanelBoleta.Controls.Add(lblDireccion)
        PanelBoleta.Controls.Add(lblTelefono)
        PanelBoleta.Controls.Add(lblNomCliente)
        PanelBoleta.Controls.Add(txtDocumento)
        PanelBoleta.Controls.Add(Label9)
        PanelBoleta.Location = New Point(733, 102)
        PanelBoleta.Name = "PanelBoleta"
        PanelBoleta.Size = New Size(228, 239)
        PanelBoleta.TabIndex = 20
        ' 
        ' lblIdPersona
        ' 
        lblIdPersona.AutoSize = True
        lblIdPersona.Location = New Point(18, 213)
        lblIdPersona.Name = "lblIdPersona"
        lblIdPersona.Size = New Size(47, 15)
        lblIdPersona.TabIndex = 14
        lblIdPersona.Text = "Label10"
        ' 
        ' lblRuc
        ' 
        lblRuc.AutoSize = True
        lblRuc.Location = New Point(20, 195)
        lblRuc.Name = "lblRuc"
        lblRuc.Size = New Size(33, 15)
        lblRuc.TabIndex = 13
        lblRuc.Text = "RUC:"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(16, 106)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(54, 15)
        lblApellido.TabIndex = 12
        lblApellido.Text = "Apellido:"
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(12, 178)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(46, 15)
        lblCorreo.TabIndex = 11
        lblCorreo.Text = "Correo:"
        ' 
        ' lblRazonSocial
        ' 
        lblRazonSocial.AutoSize = True
        lblRazonSocial.Location = New Point(14, 123)
        lblRazonSocial.Name = "lblRazonSocial"
        lblRazonSocial.Size = New Size(76, 15)
        lblRazonSocial.TabIndex = 10
        lblRazonSocial.Text = "Razón Social:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnBusBoleta
        ' 
        btnBusBoleta.Location = New Point(111, 19)
        btnBusBoleta.Name = "btnBusBoleta"
        btnBusBoleta.Size = New Size(75, 23)
        btnBusBoleta.TabIndex = 8
        btnBusBoleta.Text = "Buscar"
        btnBusBoleta.UseVisualStyleBackColor = True
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(12, 160)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(60, 15)
        lblDireccion.TabIndex = 6
        lblDireccion.Text = "Dirección:"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(15, 142)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(55, 15)
        lblTelefono.TabIndex = 4
        lblTelefono.Text = "Telefono:"
        ' 
        ' lblNomCliente
        ' 
        lblNomCliente.AutoSize = True
        lblNomCliente.Location = New Point(16, 86)
        lblNomCliente.Name = "lblNomCliente"
        lblNomCliente.Size = New Size(54, 15)
        lblNomCliente.TabIndex = 2
        lblNomCliente.Text = "Nombre:"
        ' 
        ' txtDocumento
        ' 
        txtDocumento.Location = New Point(111, 61)
        txtDocumento.Name = "txtDocumento"
        txtDocumento.Size = New Size(100, 23)
        txtDocumento.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(15, 63)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 15)
        Label9.TabIndex = 0
        Label9.Text = "DOCUMENTO:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(733, 84)
        Label13.Name = "Label13"
        Label13.Size = New Size(93, 15)
        Label13.TabIndex = 21
        Label13.Text = "Datos de Cliente"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(349, 361)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 22
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(207, 281)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(120, 23)
        txtCantidad.TabIndex = 23
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(836, 713)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(872, 695)
        Label14.Name = "Label14"
        Label14.Size = New Size(32, 15)
        Label14.TabIndex = 25
        Label14.Text = "Total"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(399, 695)
        Label15.Name = "Label15"
        Label15.Size = New Size(0, 15)
        Label15.TabIndex = 27
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(483, 361)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 30
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(984, 464)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 127)
        Button4.TabIndex = 31
        Button4.Text = "Generar Venta"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        btnBuscar.Location = New Point(178, 167)
        btnBuscar.Margin = New Padding(3, 2, 3, 2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(43, 32)
        btnBuscar.TabIndex = 32
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' cmbTipoPago
        ' 
        cmbTipoPago.FormattingEnabled = True
        cmbTipoPago.Items.AddRange(New Object() {"EFECTIVO", "TRANSFERENCIA"})
        cmbTipoPago.Location = New Point(63, 693)
        cmbTipoPago.Margin = New Padding(3, 2, 3, 2)
        cmbTipoPago.Name = "cmbTipoPago"
        cmbTipoPago.Size = New Size(224, 23)
        cmbTipoPago.TabIndex = 33
        ' 
        ' lblIdVendedor
        ' 
        lblIdVendedor.AutoSize = True
        lblIdVendedor.Location = New Point(3, 0)
        lblIdVendedor.Name = "lblIdVendedor"
        lblIdVendedor.Size = New Size(13, 15)
        lblIdVendedor.TabIndex = 34
        lblIdVendedor.Text = "1"
        ' 
        ' lblIdProducto
        ' 
        lblIdProducto.AutoSize = True
        lblIdProducto.Location = New Point(317, 87)
        lblIdProducto.Name = "lblIdProducto"
        lblIdProducto.Size = New Size(0, 15)
        lblIdProducto.TabIndex = 35
        ' 
        ' nueva
        ' 
        nueva.AutoSize = True
        nueva.Font = New Font("Microsoft Sans Serif", 25.8F)
        nueva.Location = New Point(317, 16)
        nueva.Name = "nueva"
        nueva.Size = New Size(260, 39)
        nueva.TabIndex = 36
        nueva.Text = "NUEVA VENTA"
        ' 
        ' Venta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1131, 769)
        Controls.Add(nueva)
        Controls.Add(lblIdProducto)
        Controls.Add(lblIdVendedor)
        Controls.Add(cmbTipoPago)
        Controls.Add(btnBuscar)
        Controls.Add(Button4)
        Controls.Add(btnEliminar)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(txtTotal)
        Controls.Add(txtCantidad)
        Controls.Add(btnAgregar)
        Controls.Add(Label13)
        Controls.Add(PanelBoleta)
        Controls.Add(dgvVenta)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSubtotal)
        Controls.Add(lblPrecio)
        Controls.Add(lblStockActual)
        Controls.Add(lblTalla)
        Controls.Add(lblMarca)
        Controls.Add(lblNombre)
        Controls.Add(GroupBox1)
        Controls.Add(txtCodigoProducto)
        FormBorderStyle = FormBorderStyle.None
        Name = "Venta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Venta"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvVenta, ComponentModel.ISupportInitialize).EndInit()
        PanelBoleta.ResumeLayout(False)
        PanelBoleta.PerformLayout()
        CType(txtCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents rbtnBoleta As RadioButton
    Friend WithEvents rbtnFactura As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombre As TextBox
    Friend WithEvents lblMarca As TextBox
    Friend WithEvents lblTalla As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents lblPrecio As TextBox
    Friend WithEvents lblStockActual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvVenta As DataGridView
    Friend WithEvents PanelBoleta As Panel
    Friend WithEvents lblNomCliente As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBusBoleta As Button
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCantidad As NumericUpDown
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblRuc As Label
    Friend WithEvents cmbTipoPago As ComboBox
    Friend WithEvents lblIdPersona As Label
    Friend WithEvents lblIdVendedor As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents nueva As Label
End Class
