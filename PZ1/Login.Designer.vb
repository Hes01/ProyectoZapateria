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
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        btnIngresar = New Button()
        btnSalir = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(49, 263)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.PlaceholderText = "Usuario"
        txtUsuario.Size = New Size(200, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(49, 306)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.PlaceholderText = "contraseña"
        txtContraseña.Size = New Size(200, 23)
        txtContraseña.TabIndex = 3
        ' 
        ' btnIngresar
        ' 
        btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnIngresar.FlatStyle = FlatStyle.Popup
        btnIngresar.Location = New Point(164, 365)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(100, 38)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Location = New Point(43, 365)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(100, 38)
        btnSalir.TabIndex = 5
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._Login2
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(49, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 176)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        BackgroundImage = My.Resources.Resources.fondo_login_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(314, 464)
        Controls.Add(PictureBox1)
        Controls.Add(btnSalir)
        Controls.Add(btnIngresar)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
