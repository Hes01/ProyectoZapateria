<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProveedor
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
        btnCancelar = New Button()
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
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(253, 392)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 99
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(334, 266)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(113, 23)
        txtDni.TabIndex = 98
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Location = New Point(303, 267)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(25, 15)
        lblDni.TabIndex = 97
        lblDni.Text = "Dni"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(334, 213)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New Size(113, 23)
        txtApellidos.TabIndex = 96
        ' 
        ' lblApellidos
        ' 
        lblApellidos.AutoSize = True
        lblApellidos.Location = New Point(272, 213)
        lblApellidos.Name = "lblApellidos"
        lblApellidos.Size = New Size(56, 15)
        lblApellidos.TabIndex = 95
        lblApellidos.Text = "Apellidos"
        ' 
        ' txtNombres
        ' 
        txtNombres.Location = New Point(334, 160)
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New Size(113, 23)
        txtNombres.TabIndex = 94
        ' 
        ' lblNombres
        ' 
        lblNombres.AutoSize = True
        lblNombres.Location = New Point(272, 163)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New Size(56, 15)
        lblNombres.TabIndex = 93
        lblNombres.Text = "Nombres"
        ' 
        ' lblRazonSocial
        ' 
        lblRazonSocial.AutoSize = True
        lblRazonSocial.Location = New Point(255, 112)
        lblRazonSocial.Name = "lblRazonSocial"
        lblRazonSocial.Size = New Size(73, 15)
        lblRazonSocial.TabIndex = 92
        lblRazonSocial.Text = "Razon Social"
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(334, 107)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.Size = New Size(113, 23)
        txtRazonSocial.TabIndex = 91
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(126, 392)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 90
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        Label5.Location = New Point(53, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 29)
        Label5.TabIndex = 89
        Label5.Text = "Editar Datos del Proveedor"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(104, 320)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(113, 23)
        txtEmail.TabIndex = 88
        ' 
        ' Correo
        ' 
        Correo.AutoSize = True
        Correo.Location = New Point(46, 323)
        Correo.Name = "Correo"
        Correo.Size = New Size(36, 15)
        Correo.TabIndex = 87
        Correo.Text = "Email"
        ' 
        ' txtDirección
        ' 
        txtDirección.Location = New Point(104, 267)
        txtDirección.Name = "txtDirección"
        txtDirección.Size = New Size(113, 23)
        txtDirección.TabIndex = 86
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 85
        Label3.Text = "Dirección"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(104, 214)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(113, 23)
        txtTelefono.TabIndex = 84
        ' 
        ' Telefono
        ' 
        Telefono.AutoSize = True
        Telefono.Location = New Point(31, 222)
        Telefono.Name = "Telefono"
        Telefono.Size = New Size(52, 15)
        Telefono.TabIndex = 83
        Telefono.Text = "Telefono"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(104, 157)
        txtRuc.Name = "txtRuc"
        txtRuc.Size = New Size(113, 23)
        txtRuc.TabIndex = 82
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 81
        Label2.Text = "ruc"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 80
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(104, 112)
        txtID.Name = "txtID"
        txtID.Size = New Size(37, 23)
        txtID.TabIndex = 79
        ' 
        ' EditProveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(800, 450)
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
        Name = "EditProveedor"
        Text = "EditProveedor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancelar As Button
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
End Class
