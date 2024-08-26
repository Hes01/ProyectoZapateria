<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        btnAgregarProveedor = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        txtBuscar = New TextBox()
        btnBuscar = New Button()
        dgvProveedor = New DataGridView()
        btnSalirProveedor = New Button()
        CType(dgvProveedor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAgregarProveedor
        ' 
        btnAgregarProveedor.Location = New Point(30, 486)
        btnAgregarProveedor.Name = "btnAgregarProveedor"
        btnAgregarProveedor.Size = New Size(75, 44)
        btnAgregarProveedor.TabIndex = 12
        btnAgregarProveedor.Text = "Agregar"
        btnAgregarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(140, 486)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 44)
        btnModificar.TabIndex = 13
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(246, 486)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 44)
        btnEliminar.TabIndex = 14
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(41, 84)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Nombres, dni, razon social..."
        txtBuscar.Size = New Size(302, 23)
        txtBuscar.TabIndex = 15
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(358, 78)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(53, 32)
        btnBuscar.TabIndex = 17
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProveedor
        ' 
        dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProveedor.Location = New Point(52, 165)
        dgvProveedor.Name = "dgvProveedor"
        dgvProveedor.Size = New Size(665, 221)
        dgvProveedor.TabIndex = 18
        ' 
        ' btnSalirProveedor
        ' 
        btnSalirProveedor.Location = New Point(759, 486)
        btnSalirProveedor.Name = "btnSalirProveedor"
        btnSalirProveedor.Size = New Size(75, 44)
        btnSalirProveedor.TabIndex = 19
        btnSalirProveedor.Text = "Salir"
        btnSalirProveedor.UseVisualStyleBackColor = True
        ' 
        ' Proveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(855, 542)
        Controls.Add(btnSalirProveedor)
        Controls.Add(dgvProveedor)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregarProveedor)
        FormBorderStyle = FormBorderStyle.None
        Name = "Proveedor"
        Text = "Proveedor"
        CType(dgvProveedor, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvProveedor As DataGridView
    Friend WithEvents btnSalirProveedor As Button
End Class
