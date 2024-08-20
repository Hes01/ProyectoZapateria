<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProducto
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_id = New TextBox()
        txt_codigo = New TextBox()
        txt_nombre = New TextBox()
        txt_talla = New TextBox()
        Label5 = New Label()
        txt_precio = New TextBox()
        Label6 = New Label()
        txt_stock = New TextBox()
        Label7 = New Label()
        TextBox7 = New TextBox()
        txt_categoria = New Label()
        txt_marca = New TextBox()
        Label9 = New Label()
        btn_guardar = New Button()
        btn_salir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 20)
        Label1.TabIndex = 0
        Label1.Text = "Modificar Datos de Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "Id Producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 2
        Label3.Text = "codigo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 375)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 3
        Label4.Text = "nombre"
        ' 
        ' txt_id
        ' 
        txt_id.Location = New Point(68, 182)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(125, 27)
        txt_id.TabIndex = 4
        ' 
        ' txt_codigo
        ' 
        txt_codigo.Location = New Point(69, 315)
        txt_codigo.Name = "txt_codigo"
        txt_codigo.Size = New Size(125, 27)
        txt_codigo.TabIndex = 5
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(74, 420)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(125, 27)
        txt_nombre.TabIndex = 6
        ' 
        ' txt_talla
        ' 
        txt_talla.Location = New Point(68, 529)
        txt_talla.Name = "txt_talla"
        txt_talla.Size = New Size(125, 27)
        txt_talla.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 484)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 20)
        Label5.TabIndex = 7
        Label5.Text = "talla"
        ' 
        ' txt_precio
        ' 
        txt_precio.Location = New Point(427, 169)
        txt_precio.Name = "txt_precio"
        txt_precio.Size = New Size(125, 27)
        txt_precio.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(427, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 9
        Label6.Text = "Precio"
        ' 
        ' txt_stock
        ' 
        txt_stock.Location = New Point(427, 288)
        txt_stock.Name = "txt_stock"
        txt_stock.Size = New Size(125, 27)
        txt_stock.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(427, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 20)
        Label7.TabIndex = 11
        Label7.Text = "Stock"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(417, 420)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 14
        ' 
        ' txt_categoria
        ' 
        txt_categoria.AutoSize = True
        txt_categoria.Location = New Point(417, 375)
        txt_categoria.Name = "txt_categoria"
        txt_categoria.Size = New Size(74, 20)
        txt_categoria.TabIndex = 13
        txt_categoria.Text = "Categoria"
        ' 
        ' txt_marca
        ' 
        txt_marca.Location = New Point(417, 529)
        txt_marca.Name = "txt_marca"
        txt_marca.Size = New Size(125, 27)
        txt_marca.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(417, 484)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 20)
        Label9.TabIndex = 15
        Label9.Text = "Marca"
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Location = New Point(199, 609)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(94, 29)
        btn_guardar.TabIndex = 17
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' btn_salir
        ' 
        btn_salir.Location = New Point(358, 609)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(94, 29)
        btn_salir.TabIndex = 18
        btn_salir.Text = "Cancelar"
        btn_salir.UseVisualStyleBackColor = True
        ' 
        ' EditProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(709, 690)
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
        Controls.Add(Label1)
        Name = "EditProducto"
        Text = "EditProducto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_talla As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txt_categoria As Label
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_salir As Button
End Class
