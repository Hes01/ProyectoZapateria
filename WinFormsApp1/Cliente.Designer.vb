<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        dgvClientes = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        telefono = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        direccion = New DataGridViewTextBoxColumn()
        nombre_rzSocial = New DataGridViewTextBoxColumn()
        dni_ruc = New DataGridViewTextBoxColumn()
        estado = New DataGridViewTextBoxColumn()
        btnBuscar = New Button()
        txtBuscar = New TextBox()
        btnEliminarCliente = New Button()
        btnModificarCliente = New Button()
        btnAgregarCliente = New Button()
        btnSalirCliente = New Button()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Columns.AddRange(New DataGridViewColumn() {id, telefono, email, direccion, nombre_rzSocial, dni_ruc, estado})
        dgvClientes.Location = New Point(36, 106)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.Size = New Size(752, 221)
        dgvClientes.TabIndex = 24
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' telefono
        ' 
        telefono.HeaderText = "TELEFONO"
        telefono.Name = "telefono"
        ' 
        ' email
        ' 
        email.HeaderText = "EMAIL"
        email.Name = "email"
        ' 
        ' direccion
        ' 
        direccion.HeaderText = "DIRECCION"
        direccion.Name = "direccion"
        ' 
        ' nombre_rzSocial
        ' 
        nombre_rzSocial.HeaderText = "NOMBRE/RAZON SOCIAL"
        nombre_rzSocial.Name = "nombre_rzSocial"
        ' 
        ' dni_ruc
        ' 
        dni_ruc.HeaderText = "DNI/RUC"
        dni_ruc.Name = "dni_ruc"
        ' 
        ' estado
        ' 
        estado.HeaderText = "ESTADO"
        estado.Name = "estado"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(355, 3)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(53, 32)
        btnBuscar.TabIndex = 23
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(36, 9)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(302, 23)
        txtBuscar.TabIndex = 22
        ' 
        ' btnEliminarCliente
        ' 
        btnEliminarCliente.Location = New Point(230, 411)
        btnEliminarCliente.Name = "btnEliminarCliente"
        btnEliminarCliente.Size = New Size(75, 44)
        btnEliminarCliente.TabIndex = 21
        btnEliminarCliente.Text = "Eliminar"
        btnEliminarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnModificarCliente
        ' 
        btnModificarCliente.Location = New Point(124, 411)
        btnModificarCliente.Name = "btnModificarCliente"
        btnModificarCliente.Size = New Size(75, 44)
        btnModificarCliente.TabIndex = 20
        btnModificarCliente.Text = "Modificar"
        btnModificarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Location = New Point(14, 411)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(75, 44)
        btnAgregarCliente.TabIndex = 19
        btnAgregarCliente.Text = "Agregar"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnSalirCliente
        ' 
        btnSalirCliente.Location = New Point(713, 411)
        btnSalirCliente.Name = "btnSalirCliente"
        btnSalirCliente.Size = New Size(75, 44)
        btnSalirCliente.TabIndex = 25
        btnSalirCliente.Text = "Salir"
        btnSalirCliente.UseVisualStyleBackColor = True
        ' 
        ' Cliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 479)
        Controls.Add(btnSalirCliente)
        Controls.Add(dgvClientes)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(btnEliminarCliente)
        Controls.Add(btnModificarCliente)
        Controls.Add(btnAgregarCliente)
        Name = "Cliente"
        Text = "Cliente"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnSalirCliente As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents nombre_rzSocial As DataGridViewTextBoxColumn
    Friend WithEvents dni_ruc As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
