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
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.TextBox()
        Me.lblTalla = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.TextBox()
        Me.lblStockActual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBoleta = New System.Windows.Forms.Panel()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBusBoleta = New System.Windows.Forms.Button()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNomCliente = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblRuc = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBoleta.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(72, 231)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(114, 27)
        Me.txtCodigoProducto.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 48)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 24)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "BOLETA"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(24, 81)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(92, 24)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FACTURA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(229, 133)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO COMPROBANTE"
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(314, 231)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(114, 27)
        Me.lblNombre.TabIndex = 4
        '
        'lblMarca
        '
        Me.lblMarca.Location = New System.Drawing.Point(491, 231)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(114, 27)
        Me.lblMarca.TabIndex = 5
        '
        'lblTalla
        '
        Me.lblTalla.Location = New System.Drawing.Point(690, 231)
        Me.lblTalla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTalla.Name = "lblTalla"
        Me.lblTalla.Size = New System.Drawing.Size(114, 27)
        Me.lblTalla.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(624, 375)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(114, 27)
        Me.TextBox5.TabIndex = 10
        '
        'lblPrecio
        '
        Me.lblPrecio.Location = New System.Drawing.Point(425, 375)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(114, 27)
        Me.lblPrecio.TabIndex = 9
        '
        'lblStockActual
        '
        Me.lblStockActual.Location = New System.Drawing.Point(72, 375)
        Me.lblStockActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblStockActual.Name = "lblStockActual"
        Me.lblStockActual.Size = New System.Drawing.Size(114, 27)
        Me.lblStockActual.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(515, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(691, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Talla"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Cantidad venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(440, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Precio Unitario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(665, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Subtotal"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Marca, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(72, 536)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(851, 311)
        Me.DataGridView1.TabIndex = 19
        '
        'Código
        '
        Me.Código.HeaderText = "Codigo"
        Me.Código.MinimumWidth = 6
        Me.Código.Name = "Código"
        Me.Código.Width = 125
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.MinimumWidth = 6
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Modelo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Talla"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio Unitario"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'PanelBoleta
        '
        Me.PanelBoleta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBoleta.Controls.Add(Me.lblRuc)
        Me.PanelBoleta.Controls.Add(Me.lblApellido)
        Me.PanelBoleta.Controls.Add(Me.lblCorreo)
        Me.PanelBoleta.Controls.Add(Me.lblRazonSocial)
        Me.PanelBoleta.Controls.Add(Me.Button1)
        Me.PanelBoleta.Controls.Add(Me.btnBusBoleta)
        Me.PanelBoleta.Controls.Add(Me.lblDireccion)
        Me.PanelBoleta.Controls.Add(Me.lblTelefono)
        Me.PanelBoleta.Controls.Add(Me.lblNomCliente)
        Me.PanelBoleta.Controls.Add(Me.txtDocumento)
        Me.PanelBoleta.Controls.Add(Me.Label9)
        Me.PanelBoleta.Location = New System.Drawing.Point(838, 136)
        Me.PanelBoleta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelBoleta.Name = "PanelBoleta"
        Me.PanelBoleta.Size = New System.Drawing.Size(260, 287)
        Me.PanelBoleta.TabIndex = 20
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(18, 141)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(69, 20)
        Me.lblApellido.TabIndex = 12
        Me.lblApellido.Text = "Apellido:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(14, 237)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(57, 20)
        Me.lblCorreo.TabIndex = 11
        Me.lblCorreo.Text = "Correo:"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(16, 164)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(97, 20)
        Me.lblRazonSocial.TabIndex = 10
        Me.lblRazonSocial.Text = "Razón Social:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 25)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBusBoleta
        '
        Me.btnBusBoleta.Location = New System.Drawing.Point(127, 25)
        Me.btnBusBoleta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBusBoleta.Name = "btnBusBoleta"
        Me.btnBusBoleta.Size = New System.Drawing.Size(86, 31)
        Me.btnBusBoleta.TabIndex = 8
        Me.btnBusBoleta.Text = "Buscar"
        Me.btnBusBoleta.UseVisualStyleBackColor = True
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(14, 213)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(17, 189)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(70, 20)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblNomCliente
        '
        Me.lblNomCliente.AutoSize = True
        Me.lblNomCliente.Location = New System.Drawing.Point(18, 114)
        Me.lblNomCliente.Name = "lblNomCliente"
        Me.lblNomCliente.Size = New System.Drawing.Size(67, 20)
        Me.lblNomCliente.TabIndex = 2
        Me.lblNomCliente.Text = "Nombre:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(127, 81)
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(114, 27)
        Me.txtDocumento.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "DOCUMENTO:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(838, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Datos de Cliente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(399, 481)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(237, 375)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(137, 27)
        Me.NumericUpDown1.TabIndex = 23
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(167, 951)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(114, 27)
        Me.TextBox7.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(208, 927)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 20)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Total"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(422, 951)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(114, 27)
        Me.TextBox13.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(456, 927)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Pagó"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(752, 927)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Vuelto"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(718, 951)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(114, 27)
        Me.TextBox14.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(552, 481)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 31)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(951, 589)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 169)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Generar Venta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(197, 234)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 27)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblRuc
        '
        Me.lblRuc.AutoSize = True
        Me.lblRuc.Location = New System.Drawing.Point(23, 260)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(40, 20)
        Me.lblRuc.TabIndex = 13
        Me.lblRuc.Text = "RUC:"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 1025)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PanelBoleta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblStockActual)
        Me.Controls.Add(Me.lblTalla)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBoleta.ResumeLayout(False)
        Me.PanelBoleta.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombre As TextBox
    Friend WithEvents lblMarca As TextBox
    Friend WithEvents lblTalla As TextBox
    Friend WithEvents TextBox5 As TextBox
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PanelBoleta As Panel
    Friend WithEvents lblNomCliente As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBusBoleta As Button
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblRuc As Label
End Class
