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
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCopia
        ' 
        btnCopia.Location = New Point(61, 46)
        btnCopia.Name = "btnCopia"
        btnCopia.Size = New Size(140, 62)
        btnCopia.TabIndex = 0
        btnCopia.Text = "Por Copia"
        btnCopia.UseVisualStyleBackColor = True
        ' 
        ' btnSitu
        ' 
        btnSitu.Location = New Point(61, 130)
        btnSitu.Name = "btnSitu"
        btnSitu.Size = New Size(140, 62)
        btnSitu.TabIndex = 1
        btnSitu.Text = "In Situ"
        btnSitu.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(109, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 15)
        Label1.TabIndex = 2
        Label1.Text = "Tipo de Compactación"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        GroupBox1.Controls.Add(btnCopia)
        GroupBox1.Controls.Add(btnSitu)
        GroupBox1.Location = New Point(12, 61)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(289, 232)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Compactación"
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(109, 316)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(59, 39)
        btnMenu.TabIndex = 2
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' MenuCompactar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(313, 376)
        Controls.Add(btnMenu)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MenuCompactar"
        Text = "MenuCompactar"
        GroupBox1.ResumeLayout(False)
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
End Class
