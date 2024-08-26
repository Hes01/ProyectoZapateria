<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Label1 = New Label()
        txt_codigo = New TextBox()
        btn_buscarCodigo = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_nombre = New TextBox()
        txt_marca = New TextBox()
        txt_talla = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txt_stock = New TextBox()
        txt_precioProducto = New TextBox()
        btn_agregar = New Button()
        btn_eliminar = New Button()
        tablaCompra = New DataGridView()
        Código = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        Modelo = New DataGridViewTextBoxColumn()
        Talla = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        SubTotal = New DataGridViewTextBoxColumn()
        btn_generaCompra = New Button()
        Label9 = New Label()
        txt_total = New TextBox()
        group_comprobante = New GroupBox()
        rbtn_factura = New RadioButton()
        rbtn_boleta = New RadioButton()
        Label8 = New Label()
        txt_idProveedor = New TextBox()
        Label10 = New Label()
        txt_subTotal = New TextBox()
        txt_cantida = New NumericUpDown()
        btnCancelar = New Button()
        CType(tablaCompra, ComponentModel.ISupportInitialize).BeginInit()
        group_comprobante.SuspendLayout()
        CType(txt_cantida, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 0
        Label1.Text = "Código"
        ' 
        ' txt_codigo
        ' 
        txt_codigo.Location = New Point(69, 177)
        txt_codigo.Margin = New Padding(3, 2, 3, 2)
        txt_codigo.Name = "txt_codigo"
        txt_codigo.Size = New Size(110, 23)
        txt_codigo.TabIndex = 1
        ' 
        ' btn_buscarCodigo
        ' 
        btn_buscarCodigo.Location = New Point(184, 177)
        btn_buscarCodigo.Margin = New Padding(3, 2, 3, 2)
        btn_buscarCodigo.Name = "btn_buscarCodigo"
        btn_buscarCodigo.Size = New Size(82, 22)
        btn_buscarCodigo.TabIndex = 2
        btn_buscarCodigo.Text = "Buscar"
        btn_buscarCodigo.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(316, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(487, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 4
        Label3.Text = "Marca"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(667, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 5
        Label4.Text = "Talla"
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(316, 177)
        txt_nombre.Margin = New Padding(3, 2, 3, 2)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(110, 23)
        txt_nombre.TabIndex = 6
        ' 
        ' txt_marca
        ' 
        txt_marca.Location = New Point(487, 177)
        txt_marca.Margin = New Padding(3, 2, 3, 2)
        txt_marca.Name = "txt_marca"
        txt_marca.Size = New Size(110, 23)
        txt_marca.TabIndex = 7
        ' 
        ' txt_talla
        ' 
        txt_talla.Location = New Point(667, 177)
        txt_talla.Margin = New Padding(3, 2, 3, 2)
        txt_talla.Name = "txt_talla"
        txt_talla.Size = New Size(110, 23)
        txt_talla.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(69, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 9
        Label5.Text = "Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(316, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 10
        Label6.Text = "Cantidad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(487, 231)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 15)
        Label7.TabIndex = 11
        Label7.Text = "Precio producto"
        ' 
        ' txt_stock
        ' 
        txt_stock.Location = New Point(69, 256)
        txt_stock.Margin = New Padding(3, 2, 3, 2)
        txt_stock.Name = "txt_stock"
        txt_stock.Size = New Size(110, 23)
        txt_stock.TabIndex = 13
        ' 
        ' txt_precioProducto
        ' 
        txt_precioProducto.Location = New Point(487, 256)
        txt_precioProducto.Margin = New Padding(3, 2, 3, 2)
        txt_precioProducto.Name = "txt_precioProducto"
        txt_precioProducto.Size = New Size(110, 23)
        txt_precioProducto.TabIndex = 15
        ' 
        ' btn_agregar
        ' 
        btn_agregar.Location = New Point(260, 324)
        btn_agregar.Margin = New Padding(3, 2, 3, 2)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(82, 22)
        btn_agregar.TabIndex = 17
        btn_agregar.Text = "Agregar"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Location = New Point(426, 324)
        btn_eliminar.Margin = New Padding(3, 2, 3, 2)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(82, 22)
        btn_eliminar.TabIndex = 18
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' tablaCompra
        ' 
        tablaCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tablaCompra.Columns.AddRange(New DataGridViewColumn() {Código, Marca, Modelo, Talla, Cantidad, SubTotal})
        tablaCompra.Location = New Point(12, 365)
        tablaCompra.Margin = New Padding(3, 2, 3, 2)
        tablaCompra.Name = "tablaCompra"
        tablaCompra.RowHeadersWidth = 51
        tablaCompra.RowTemplate.Height = 29
        tablaCompra.Size = New Size(769, 186)
        tablaCompra.TabIndex = 19
        ' 
        ' Código
        ' 
        Código.HeaderText = "Código"
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
        ' Modelo
        ' 
        Modelo.HeaderText = "Modelo"
        Modelo.MinimumWidth = 6
        Modelo.Name = "Modelo"
        Modelo.Width = 125
        ' 
        ' Talla
        ' 
        Talla.HeaderText = "Talla"
        Talla.MinimumWidth = 6
        Talla.Name = "Talla"
        Talla.Width = 125
        ' 
        ' Cantidad
        ' 
        Cantidad.HeaderText = "Cantidad"
        Cantidad.MinimumWidth = 6
        Cantidad.Name = "Cantidad"
        Cantidad.Width = 125
        ' 
        ' SubTotal
        ' 
        SubTotal.HeaderText = "SubTotal"
        SubTotal.MinimumWidth = 6
        SubTotal.Name = "SubTotal"
        SubTotal.Width = 125
        ' 
        ' btn_generaCompra
        ' 
        btn_generaCompra.Location = New Point(806, 393)
        btn_generaCompra.Margin = New Padding(3, 2, 3, 2)
        btn_generaCompra.Name = "btn_generaCompra"
        btn_generaCompra.Size = New Size(82, 81)
        btn_generaCompra.TabIndex = 20
        btn_generaCompra.Text = "Generar Compra"
        btn_generaCompra.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(66, 569)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 21
        Label9.Text = "Total"
        ' 
        ' txt_total
        ' 
        txt_total.Location = New Point(66, 595)
        txt_total.Margin = New Padding(3, 2, 3, 2)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(110, 23)
        txt_total.TabIndex = 22
        ' 
        ' group_comprobante
        ' 
        group_comprobante.Controls.Add(rbtn_factura)
        group_comprobante.Controls.Add(rbtn_boleta)
        group_comprobante.Location = New Point(66, 28)
        group_comprobante.Margin = New Padding(3, 2, 3, 2)
        group_comprobante.Name = "group_comprobante"
        group_comprobante.Padding = New Padding(3, 2, 3, 2)
        group_comprobante.Size = New Size(219, 94)
        group_comprobante.TabIndex = 23
        group_comprobante.TabStop = False
        group_comprobante.Text = "Tipo Comprobante"
        ' 
        ' rbtn_factura
        ' 
        rbtn_factura.AutoSize = True
        rbtn_factura.Location = New Point(128, 46)
        rbtn_factura.Margin = New Padding(3, 2, 3, 2)
        rbtn_factura.Name = "rbtn_factura"
        rbtn_factura.Size = New Size(64, 19)
        rbtn_factura.TabIndex = 1
        rbtn_factura.TabStop = True
        rbtn_factura.Text = "Factura"
        rbtn_factura.UseVisualStyleBackColor = True
        ' 
        ' rbtn_boleta
        ' 
        rbtn_boleta.AutoSize = True
        rbtn_boleta.Location = New Point(18, 46)
        rbtn_boleta.Margin = New Padding(3, 2, 3, 2)
        rbtn_boleta.Name = "rbtn_boleta"
        rbtn_boleta.Size = New Size(58, 19)
        rbtn_boleta.TabIndex = 0
        rbtn_boleta.TabStop = True
        rbtn_boleta.Text = "Boleta"
        rbtn_boleta.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(350, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 24
        Label8.Text = "ID Proveedor:"
        ' 
        ' txt_idProveedor
        ' 
        txt_idProveedor.Location = New Point(350, 61)
        txt_idProveedor.Margin = New Padding(3, 2, 3, 2)
        txt_idProveedor.Name = "txt_idProveedor"
        txt_idProveedor.Size = New Size(110, 23)
        txt_idProveedor.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(658, 230)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 15)
        Label10.TabIndex = 26
        Label10.Text = "SubTotal"
        ' 
        ' txt_subTotal
        ' 
        txt_subTotal.Location = New Point(662, 259)
        txt_subTotal.Margin = New Padding(3, 2, 3, 2)
        txt_subTotal.Name = "txt_subTotal"
        txt_subTotal.Size = New Size(110, 23)
        txt_subTotal.TabIndex = 27
        ' 
        ' txt_cantida
        ' 
        txt_cantida.Location = New Point(312, 258)
        txt_cantida.Margin = New Padding(3, 2, 3, 2)
        txt_cantida.Name = "txt_cantida"
        txt_cantida.Size = New Size(131, 23)
        txt_cantida.TabIndex = 28
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(806, 28)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(82, 22)
        btnCancelar.TabIndex = 29
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Compra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(900, 562)
        Controls.Add(btnCancelar)
        Controls.Add(txt_cantida)
        Controls.Add(txt_subTotal)
        Controls.Add(Label10)
        Controls.Add(txt_idProveedor)
        Controls.Add(Label8)
        Controls.Add(group_comprobante)
        Controls.Add(txt_total)
        Controls.Add(Label9)
        Controls.Add(btn_generaCompra)
        Controls.Add(tablaCompra)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_agregar)
        Controls.Add(txt_precioProducto)
        Controls.Add(txt_stock)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txt_talla)
        Controls.Add(txt_marca)
        Controls.Add(txt_nombre)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_buscarCodigo)
        Controls.Add(txt_codigo)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Compra"
        Text = "Compra"
        CType(tablaCompra, ComponentModel.ISupportInitialize).EndInit()
        group_comprobante.ResumeLayout(False)
        group_comprobante.PerformLayout()
        CType(txt_cantida, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents btn_buscarCodigo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_talla As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_precioProducto As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents tablaCompra As DataGridView
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Talla As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents btn_generaCompra As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents group_comprobante As GroupBox
    Friend WithEvents rbtn_boleta As RadioButton
    Friend WithEvents rbtn_factura As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_idProveedor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents txt_cantida As NumericUpDown
    Friend WithEvents btnCancelar As Button
End Class
