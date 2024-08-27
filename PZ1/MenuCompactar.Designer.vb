<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCompactar
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
        btnCopia = New Button()
        btnSitu = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        ToolTip1 = New ToolTip(components)
        btnMenu = New Button()
        ToolTip2 = New ToolTip(components)
        GroupBox2 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox3 = New GroupBox()
        btn_compra_InSitu = New Button()
        btn_compra_copia = New Button()
        ToolTip3 = New ToolTip(components)
        GroupBox4 = New GroupBox()
        btn_producto_inSitu = New Button()
        btn_producto_copia = New Button()
        ToolTip4 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCopia
        ' 
        btnCopia.Location = New Point(70, 61)
        btnCopia.Margin = New Padding(3, 4, 3, 4)
        btnCopia.Name = "btnCopia"
        btnCopia.Size = New Size(160, 83)
        btnCopia.TabIndex = 0
        btnCopia.Text = "Por Copia"
        btnCopia.UseVisualStyleBackColor = True
        ' 
        ' btnSitu
        ' 
        btnSitu.Location = New Point(70, 173)
        btnSitu.Margin = New Padding(3, 4, 3, 4)
        btnSitu.Name = "btnSitu"
        btnSitu.Size = New Size(160, 83)
        btnSitu.TabIndex = 1
        btnSitu.Text = "In Situ"
        btnSitu.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(125, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 20)
        Label1.TabIndex = 2
        Label1.Text = "Tipo de Compactación"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        GroupBox1.Controls.Add(btnCopia)
        GroupBox1.Controls.Add(btnSitu)
        GroupBox1.Location = New Point(35, 81)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(330, 309)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Persona"
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(609, 437)
        btnMenu.Margin = New Padding(3, 4, 3, 4)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(141, 52)
        btnMenu.TabIndex = 2
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Location = New Point(373, 85)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(298, 305)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Venta"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(56, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(194, 88)
        Button2.TabIndex = 1
        Button2.Text = "In Situ"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(56, 64)
        Button1.Name = "Button1"
        Button1.Size = New Size(194, 88)
        Button1.TabIndex = 0
        Button1.Text = "Por copia"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        GroupBox3.Controls.Add(btn_compra_InSitu)
        GroupBox3.Controls.Add(btn_compra_copia)
        GroupBox3.Location = New Point(677, 85)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(298, 305)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Compra"
        ' 
        ' btn_compra_InSitu
        ' 
        btn_compra_InSitu.Location = New Point(56, 169)
        btn_compra_InSitu.Name = "btn_compra_InSitu"
        btn_compra_InSitu.Size = New Size(194, 88)
        btn_compra_InSitu.TabIndex = 1
        btn_compra_InSitu.Text = "In Situ"
        btn_compra_InSitu.UseVisualStyleBackColor = True
        ' 
        ' btn_compra_copia
        ' 
        btn_compra_copia.Location = New Point(56, 64)
        btn_compra_copia.Name = "btn_compra_copia"
        btn_compra_copia.Size = New Size(194, 88)
        btn_compra_copia.TabIndex = 0
        btn_compra_copia.Text = "Por copia"
        btn_compra_copia.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        GroupBox4.Controls.Add(btn_producto_inSitu)
        GroupBox4.Controls.Add(btn_producto_copia)
        GroupBox4.Location = New Point(981, 85)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(298, 305)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Producto"
        ' 
        ' btn_producto_inSitu
        ' 
        btn_producto_inSitu.Location = New Point(56, 169)
        btn_producto_inSitu.Name = "btn_producto_inSitu"
        btn_producto_inSitu.Size = New Size(194, 88)
        btn_producto_inSitu.TabIndex = 1
        btn_producto_inSitu.Text = "In Situ"
        btn_producto_inSitu.UseVisualStyleBackColor = True
        ' 
        ' btn_producto_copia
        ' 
        btn_producto_copia.Location = New Point(56, 64)
        btn_producto_copia.Name = "btn_producto_copia"
        btn_producto_copia.Size = New Size(194, 88)
        btn_producto_copia.TabIndex = 0
        btn_producto_copia.Text = "Por copia"
        btn_producto_copia.UseVisualStyleBackColor = True
        ' 
        ' MenuCompactar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1314, 564)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(btnMenu)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "MenuCompactar"
        Text = "MenuCompactar"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCopia As Button
    Friend WithEvents btnSitu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnMenu As Button
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_compra_InSitu As Button
    Friend WithEvents btn_compra_copia As Button
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_producto_inSitu As Button
    Friend WithEvents btn_producto_copia As Button
    Friend WithEvents ToolTip4 As ToolTip
End Class
