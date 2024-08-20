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
        btn_salir = New Button()
        btn_guardar = New Button()
        txt_marca = New TextBox()
        Label9 = New Label()
        TextBox7 = New TextBox()
        txt_categoria = New Label()
        txt_stock = New TextBox()
        Label7 = New Label()
        txt_precio = New TextBox()
        Label6 = New Label()
        txt_talla = New TextBox()
        Label5 = New Label()
        txt_nombre = New TextBox()
        txt_codigo = New TextBox()
        txt_id = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_salir
        ' 
        btn_salir.Location = New Point(398, 543)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(94, 29)
        btn_salir.TabIndex = 36
        btn_salir.Text = "Cancelar"
        btn_salir.UseVisualStyleBackColor = True
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Location = New Point(239, 543)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(94, 29)
        btn_guardar.TabIndex = 35
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' txt_marca
        ' 
        txt_marca.Location = New Point(457, 463)
        txt_marca.Name = "txt_marca"
        txt_marca.Size = New Size(125, 27)
        txt_marca.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(457, 418)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 20)
        Label9.TabIndex = 33
        Label9.Text = "Marca"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(457, 354)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 32
        ' 
        ' txt_categoria
        ' 
        txt_categoria.AutoSize = True
        txt_categoria.Location = New Point(457, 309)
        txt_categoria.Name = "txt_categoria"
        txt_categoria.Size = New Size(74, 20)
        txt_categoria.TabIndex = 31
        txt_categoria.Text = "Categoria"
        ' 
        ' txt_stock
        ' 
        txt_stock.Location = New Point(467, 222)
        txt_stock.Name = "txt_stock"
        txt_stock.Size = New Size(125, 27)
        txt_stock.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(467, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 20)
        Label7.TabIndex = 29
        Label7.Text = "Stock"
        ' 
        ' txt_precio
        ' 
        txt_precio.Location = New Point(467, 103)
        txt_precio.Name = "txt_precio"
        txt_precio.Size = New Size(125, 27)
        txt_precio.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(467, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 27
        Label6.Text = "Precio"
        ' 
        ' txt_talla
        ' 
        txt_talla.Location = New Point(108, 463)
        txt_talla.Name = "txt_talla"
        txt_talla.Size = New Size(125, 27)
        txt_talla.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(108, 418)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 20)
        Label5.TabIndex = 25
        Label5.Text = "talla"
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(114, 354)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(125, 27)
        txt_nombre.TabIndex = 24
        ' 
        ' txt_codigo
        ' 
        txt_codigo.Location = New Point(109, 249)
        txt_codigo.Name = "txt_codigo"
        txt_codigo.Size = New Size(125, 27)
        txt_codigo.TabIndex = 23
        ' 
        ' txt_id
        ' 
        txt_id.Location = New Point(108, 116)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(125, 27)
        txt_id.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(114, 309)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 21
        Label4.Text = "nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 20
        Label3.Text = "codigo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 19
        Label2.Text = "Id Producto"
        ' 
        ' AddProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(801, 612)
        Controls.Add(btn_salir)
        Controls.Add(btn_guardar)
        Controls.Add(txt_marca)
        Controls.Add(Label9)
        Controls.Add(TextBox7)
        Controls.Add(txt_categoria)
        Controls.Add(txt_stock)
        Controls.Add(Label7)
        Controls.Add(txt_precio)
        Controls.Add(Label6)
        Controls.Add(txt_talla)
        Controls.Add(Label5)
        Controls.Add(txt_nombre)
        Controls.Add(txt_codigo)
        Controls.Add(txt_id)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AddProducto"
        Text = "AddProducto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txt_categoria As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_talla As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
