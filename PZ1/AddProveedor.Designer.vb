<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProveedor
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
        cmbTipo = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        btnRegistrar = New Button()
        txtDni = New TextBox()
        lblDni = New Label()
        txtApellidos = New TextBox()
        lblApellidos = New Label()
        txtNombres = New TextBox()
        lblNombres = New Label()
        lblRazonSocial = New Label()
        txtRazonSocial = New TextBox()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(92, 333)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(113, 23)
        txtEmail.TabIndex = 19
        ' 
        ' Correo
        ' 
        Correo.AutoSize = True
        Correo.Location = New Point(34, 336)
        Correo.Name = "Correo"
        Correo.Size = New Size(36, 15)
        Correo.TabIndex = 18
        Correo.Text = "Email"
        ' 
        ' txtDirección
        ' 
        txtDirección.Location = New Point(92, 280)
        txtDirección.Name = "txtDirección"
        txtDirección.PlaceholderText = "Dirección"
        txtDirección.Size = New Size(113, 23)
        txtDirección.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 16
        Label3.Text = "Dirección"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(92, 227)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Telefono"
        txtTelefono.Size = New Size(113, 23)
        txtTelefono.TabIndex = 15
        ' 
        ' Telefono
        ' 
        Telefono.AutoSize = True
        Telefono.Location = New Point(19, 235)
        Telefono.Name = "Telefono"
        Telefono.Size = New Size(52, 15)
        Telefono.TabIndex = 14
        Telefono.Text = "Telefono"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(92, 170)
        txtRuc.Name = "txtRuc"
        txtRuc.PlaceholderText = "Ruc"
        txtRuc.Size = New Size(113, 23)
        txtRuc.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 12
        Label2.Text = "ruc"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 11
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.HideSelection = False
        txtID.Location = New Point(92, 125)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "id"
        txtID.Size = New Size(37, 23)
        txtID.TabIndex = 10
        ' 
        ' cmbTipo
        ' 
        cmbTipo.AutoCompleteCustomSource.AddRange(New String() {"Natural", "Juridica"})
        cmbTipo.FormattingEnabled = True
        cmbTipo.Items.AddRange(New Object() {"Natural", "Juridica"})
        cmbTipo.Location = New Point(92, 377)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(113, 23)
        cmbTipo.TabIndex = 20
        cmbTipo.Text = "Tipo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 21
        Label4.Text = "Tipo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        Label5.Location = New Point(41, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 29)
        Label5.TabIndex = 22
        Label5.Text = "Datos del Proveedor"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(92, 422)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(75, 23)
        btnRegistrar.TabIndex = 23
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(322, 279)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "Dni"
        txtDni.Size = New Size(113, 23)
        txtDni.TabIndex = 33
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Location = New Point(291, 280)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(25, 15)
        lblDni.TabIndex = 32
        lblDni.Text = "Dni"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(322, 226)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.PlaceholderText = "Apellidos"
        txtApellidos.Size = New Size(113, 23)
        txtApellidos.TabIndex = 31
        ' 
        ' lblApellidos
        ' 
        lblApellidos.AutoSize = True
        lblApellidos.Location = New Point(260, 226)
        lblApellidos.Name = "lblApellidos"
        lblApellidos.Size = New Size(56, 15)
        lblApellidos.TabIndex = 30
        lblApellidos.Text = "Apellidos"
        ' 
        ' txtNombres
        ' 
        txtNombres.Location = New Point(322, 173)
        txtNombres.Name = "txtNombres"
        txtNombres.PlaceholderText = "Nombres"
        txtNombres.Size = New Size(113, 23)
        txtNombres.TabIndex = 29
        ' 
        ' lblNombres
        ' 
        lblNombres.AutoSize = True
        lblNombres.Location = New Point(260, 176)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New Size(56, 15)
        lblNombres.TabIndex = 28
        lblNombres.Text = "Nombres"
        ' 
        ' lblRazonSocial
        ' 
        lblRazonSocial.AutoSize = True
        lblRazonSocial.Location = New Point(243, 125)
        lblRazonSocial.Name = "lblRazonSocial"
        lblRazonSocial.Size = New Size(73, 15)
        lblRazonSocial.TabIndex = 25
        lblRazonSocial.Text = "Razon Social"
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(322, 120)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.PlaceholderText = "Razon Social"
        txtRazonSocial.Size = New Size(113, 23)
        txtRazonSocial.TabIndex = 24
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(217, 422)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 34
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' AddProveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(470, 468)
        Controls.Add(btnCancelar)
        Controls.Add(txtDni)
        Controls.Add(lblDni)
        Controls.Add(txtApellidos)
        Controls.Add(lblApellidos)
        Controls.Add(txtNombres)
        Controls.Add(lblNombres)
        Controls.Add(lblRazonSocial)
        Controls.Add(txtRazonSocial)
        Controls.Add(btnRegistrar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmbTipo)
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
        Name = "AddProveedor"
        Text = "AddProveedor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents btnCancelar As Button
End Class
