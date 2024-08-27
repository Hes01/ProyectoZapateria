<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProducto
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
        txtCodigo = New TextBox()
        txtNombre = New TextBox()
        txtTalla = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        cmbCategoria = New ComboBox()
        cmbMarca = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnCancelar = New Button()
        btnRegistrar = New Button()
        SuspendLayout()
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(155, 111)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(133, 23)
        txtCodigo.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(155, 156)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(310, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtTalla
        ' 
        txtTalla.Location = New Point(155, 200)
        txtTalla.Name = "txtTalla"
        txtTalla.Size = New Size(85, 23)
        txtTalla.TabIndex = 2
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(155, 244)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(85, 23)
        txtPrecio.TabIndex = 3
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(155, 283)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(85, 23)
        txtStock.TabIndex = 4
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(155, 332)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(104, 23)
        cmbCategoria.TabIndex = 5
        ' 
        ' cmbMarca
        ' 
        cmbMarca.FormattingEnabled = True
        cmbMarca.Location = New Point(155, 377)
        cmbMarca.Name = "cmbMarca"
        cmbMarca.Size = New Size(104, 23)
        cmbMarca.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 7
        Label1.Text = "Codigo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 9
        Label3.Text = "Talla"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(80, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 10
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(80, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 11
        Label5.Text = "Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(80, 340)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 12
        Label6.Text = "Categoria"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(80, 385)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 15)
        Label7.TabIndex = 13
        Label7.Text = "Marca"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.Location = New Point(173, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(169, 23)
        Label8.TabIndex = 14
        Label8.Text = "Agregar Producto"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(267, 415)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 36
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(142, 415)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(75, 23)
        btnRegistrar.TabIndex = 35
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' AddProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(493, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnRegistrar)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbMarca)
        Controls.Add(cmbCategoria)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtTalla)
        Controls.Add(txtNombre)
        Controls.Add(txtCodigo)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddProducto"
        Text = "AddProducto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTalla As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
End Class
