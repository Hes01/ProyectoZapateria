<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCliente
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
        btnRegistrar = New Button()
        Label5 = New Label()
        Label4 = New Label()
        cmbTipo = New ComboBox()
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
        txtDni.Location = New Point(321, 268)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(113, 23)
        txtDni.TabIndex = 55
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Location = New Point(290, 269)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(25, 15)
        lblDni.TabIndex = 54
        lblDni.Text = "Dni"
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(321, 215)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New Size(113, 23)
        txtApellidos.TabIndex = 53
        ' 
        ' lblApellidos
        ' 
        lblApellidos.AutoSize = True
        lblApellidos.Location = New Point(259, 215)
        lblApellidos.Name = "lblApellidos"
        lblApellidos.Size = New Size(56, 15)
        lblApellidos.TabIndex = 52
        lblApellidos.Text = "Apellidos"
        ' 
        ' txtNombres
        ' 
        txtNombres.Location = New Point(321, 162)
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New Size(113, 23)
        txtNombres.TabIndex = 51
        ' 
        ' lblNombres
        ' 
        lblNombres.AutoSize = True
        lblNombres.Location = New Point(259, 165)
        lblNombres.Name = "lblNombres"
        lblNombres.Size = New Size(56, 15)
        lblNombres.TabIndex = 50
        lblNombres.Text = "Nombres"
        ' 
        ' lblRazonSocial
        ' 
        lblRazonSocial.AutoSize = True
        lblRazonSocial.Location = New Point(242, 114)
        lblRazonSocial.Name = "lblRazonSocial"
        lblRazonSocial.Size = New Size(73, 15)
        lblRazonSocial.TabIndex = 49
        lblRazonSocial.Text = "Razon Social"
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(321, 109)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.Size = New Size(113, 23)
        txtRazonSocial.TabIndex = 48
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(91, 411)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(75, 23)
        btnRegistrar.TabIndex = 47
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        Label5.Location = New Point(40, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 29)
        Label5.TabIndex = 46
        Label5.Text = "Datos del Cliente"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 374)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 45
        Label4.Text = "Tipo"
        ' 
        ' cmbTipo
        ' 
        cmbTipo.AutoCompleteCustomSource.AddRange(New String() {"Natural", "Juridica"})
        cmbTipo.FormattingEnabled = True
        cmbTipo.Items.AddRange(New Object() {"Natural", "Juridica"})
        cmbTipo.Location = New Point(91, 366)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(113, 23)
        cmbTipo.TabIndex = 44
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(91, 322)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(113, 23)
        txtEmail.TabIndex = 43
        ' 
        ' Correo
        ' 
        Correo.AutoSize = True
        Correo.Location = New Point(33, 325)
        Correo.Name = "Correo"
        Correo.Size = New Size(36, 15)
        Correo.TabIndex = 42
        Correo.Text = "Email"
        ' 
        ' txtDirección
        ' 
        txtDirección.Location = New Point(91, 269)
        txtDirección.Name = "txtDirección"
        txtDirección.Size = New Size(113, 23)
        txtDirección.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 40
        Label3.Text = "Dirección"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(91, 216)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(113, 23)
        txtTelefono.TabIndex = 39
        ' 
        ' Telefono
        ' 
        Telefono.AutoSize = True
        Telefono.Location = New Point(18, 224)
        Telefono.Name = "Telefono"
        Telefono.Size = New Size(52, 15)
        Telefono.TabIndex = 38
        Telefono.Text = "Telefono"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(91, 159)
        txtRuc.Name = "txtRuc"
        txtRuc.Size = New Size(113, 23)
        txtRuc.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 36
        Label2.Text = "ruc"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 35
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(91, 114)
        txtID.Name = "txtID"
        txtID.Size = New Size(37, 23)
        txtID.TabIndex = 34
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(216, 411)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 56
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' AddCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(454, 450)
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
        Name = "AddCliente"
        Text = "AddCliente"
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
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipo As ComboBox
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
