<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCliente
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
        txtDni = New TextBox()
        lblDni = New Label()
        txtApellidos = New TextBox()
        lblApellidos = New Label()
        txtNombres = New TextBox()
        lblNombres = New Label()
        lblRazonSocial = New Label()
        txtRazonSocial = New TextBox()
        btnGuardar = New Button()
        Label5 = New Label()
        txtEmail = New TextBox()
        Correo = New Label()
        txtDirección = New TextBox()
        Label3 = New Label()
        txtTelefono = New TextBox()
        Telefono = New Label()
        txtRuc = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtID = New TextBox()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(313, 265)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "Dni"
        txtDni.Size = New Size(113, 23)
        txtDni.TabIndex = 77
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Location = New Point(282, 266)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(25, 15)
        lblDni.TabIndex = 76
        lblDni.Text = "Dni"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(313, 212)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.PlaceholderText = "Apellidos"
        txtApellidos.Size = New Size(113, 23)
        txtApellidos.TabIndex = 75
        ' 
        ' lblApellidos
        ' 
        lblApellidos.AutoSize = True
        lblApellidos.Location = New Point(251, 212)
        lblApellidos.Name = "lblApellidos"
        lblApellidos.Size = New Size(56, 15)
        lblApellidos.TabIndex = 74
        lblApellidos.Text = "Apellidos"
        ' 
        ' txtNombres
        ' 
        txtNombres.Location = New Point(313, 159)
        txtNombres.Name = "txtNombres"
        txtNombres.PlaceholderText = "Nombres"
        txtNombres.Size = New Size(113, 23)
        txtNombres.TabIndex = 73
        ' 
        ' lblNombres
        ' 
        lblNombres.AutoSize = True
        lblNombres.Location = New Point(251, 162)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New Size(56, 15)
        lblNombres.TabIndex = 72
        lblNombres.Text = "Nombres"
        ' 
        ' lblRazonSocial
        ' 
        lblRazonSocial.AutoSize = True
        lblRazonSocial.Location = New Point(234, 111)
        lblRazonSocial.Name = "lblRazonSocial"
        lblRazonSocial.Size = New Size(73, 15)
        lblRazonSocial.TabIndex = 71
        lblRazonSocial.Text = "Razon Social"
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(313, 106)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.PlaceholderText = "Razón Social"
        txtRazonSocial.Size = New Size(113, 23)
        txtRazonSocial.TabIndex = 70
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(105, 391)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 69
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        Label5.Location = New Point(32, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(207, 29)
        Label5.TabIndex = 68
        Label5.Text = "Editar Datos del Cliente"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(83, 319)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(113, 23)
        txtEmail.TabIndex = 65
        ' 
        ' Correo
        ' 
        Correo.AutoSize = True
        Correo.Location = New Point(25, 322)
        Correo.Name = "Correo"
        Correo.Size = New Size(36, 15)
        Correo.TabIndex = 64
        Correo.Text = "Email"
        ' 
        ' txtDirección
        ' 
        txtDirección.Location = New Point(83, 266)
        txtDirección.Name = "txtDirección"
        txtDirección.PlaceholderText = "Dirección"
        txtDirección.Size = New Size(113, 23)
        txtDirección.TabIndex = 63
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(4, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 62
        Label3.Text = "Dirección"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(83, 213)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Telefono"
        txtTelefono.Size = New Size(113, 23)
        txtTelefono.TabIndex = 61
        ' 
        ' Telefono
        ' 
        Telefono.AutoSize = True
        Telefono.Location = New Point(10, 221)
        Telefono.Name = "Telefono"
        Telefono.Size = New Size(52, 15)
        Telefono.TabIndex = 60
        Telefono.Text = "Telefono"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(83, 156)
        txtRuc.Name = "txtRuc"
        txtRuc.PlaceholderText = "ruc"
        txtRuc.Size = New Size(113, 23)
        txtRuc.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 58
        Label2.Text = "ruc"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 57
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(83, 111)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "id"
        txtID.Size = New Size(37, 23)
        txtID.TabIndex = 56
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(232, 391)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 78
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' EditCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(459, 450)
        Controls.Add(btnCancelar)
        Controls.Add(txtDni)
        Controls.Add(lblDni)
        Controls.Add(txtApellidos)
        Controls.Add(lblApellidos)
        Controls.Add(txtNombres)
        Controls.Add(lblNombres)
        Controls.Add(lblRazonSocial)
        Controls.Add(txtRazonSocial)
        Controls.Add(btnGuardar)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(Correo)
        Controls.Add(txtDirección)
        Controls.Add(Label3)
        Controls.Add(txtTelefono)
        Controls.Add(Telefono)
        Controls.Add(txtRuc)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtID)
        FormBorderStyle = FormBorderStyle.None
        Name = "EditCliente"
        Text = "EditCliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Correo As Label
    Friend WithEvents txtDirección As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Telefono As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCancelar As Button
End Class
