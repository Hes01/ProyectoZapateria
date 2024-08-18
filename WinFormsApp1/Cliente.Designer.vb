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
        dgvClientes.Location = New Point(36, 106)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.Size = New Size(814, 221)
        dgvClientes.TabIndex = 24
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
        ClientSize = New Size(882, 479)
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
End Class
