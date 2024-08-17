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
        btnModificarProveedor = New Button()
        btnEliminarProveedor = New Button()
        TextBox1 = New TextBox()
        btnBuscarProveedor = New Button()
        DataGridView1 = New DataGridView()
        btnSalirProveedor = New Button()
        id = New DataGridViewTextBoxColumn()
        telefono = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        direccion = New DataGridViewTextBoxColumn()
        nombre_rzSocial = New DataGridViewTextBoxColumn()
        dni_ruc = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' btnModificarProveedor
        ' 
        btnModificarProveedor.Location = New Point(140, 486)
        btnModificarProveedor.Name = "btnModificarProveedor"
        btnModificarProveedor.Size = New Size(75, 44)
        btnModificarProveedor.TabIndex = 13
        btnModificarProveedor.Text = "Modificar"
        btnModificarProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarProveedor
        ' 
        btnEliminarProveedor.Location = New Point(246, 486)
        btnEliminarProveedor.Name = "btnEliminarProveedor"
        btnEliminarProveedor.Size = New Size(75, 44)
        btnEliminarProveedor.TabIndex = 14
        btnEliminarProveedor.Text = "Eliminar"
        btnEliminarProveedor.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 87)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(302, 23)
        TextBox1.TabIndex = 15
        ' 
        ' btnBuscarProveedor
        ' 
        btnBuscarProveedor.Location = New Point(358, 78)
        btnBuscarProveedor.Name = "btnBuscarProveedor"
        btnBuscarProveedor.Size = New Size(53, 32)
        btnBuscarProveedor.TabIndex = 17
        btnBuscarProveedor.Text = "Buscar"
        btnBuscarProveedor.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, telefono, email, direccion, nombre_rzSocial, dni_ruc})
        DataGridView1.Location = New Point(52, 165)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(665, 221)
        DataGridView1.TabIndex = 18
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
        ' Proveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 542)
        Controls.Add(btnSalirProveedor)
        Controls.Add(DataGridView1)
        Controls.Add(btnBuscarProveedor)
        Controls.Add(TextBox1)
        Controls.Add(btnEliminarProveedor)
        Controls.Add(btnModificarProveedor)
        Controls.Add(btnAgregarProveedor)
        Name = "Proveedor"
        Text = "Proveedor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSalirProveedor As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents nombre_rzSocial As DataGridViewTextBoxColumn
    Friend WithEvents dni_ruc As DataGridViewTextBoxColumn
End Class
