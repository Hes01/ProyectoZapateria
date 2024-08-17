<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        btnIngresar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(150, 81)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(200, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(150, 138)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(200, 23)
        txtContraseña.TabIndex = 3
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Location = New Point(197, 199)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(100, 38)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 276)
        Controls.Add(btnIngresar)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As Button

End Class
