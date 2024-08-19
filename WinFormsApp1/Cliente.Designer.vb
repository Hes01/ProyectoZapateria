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
        btnEliminar = New Button()
        btnModificar = New Button()
        btnAgregar = New Button()
        btnSalir = New Button()
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
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(230, 411)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 44)
        btnEliminar.TabIndex = 21
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(124, 411)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 44)
        btnModificar.TabIndex = 20
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(14, 411)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 44)
        btnAgregar.TabIndex = 19
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(713, 411)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 44)
        btnSalir.TabIndex = 25
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Cliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 479)
        Controls.Add(btnSalir)
        Controls.Add(dgvClientes)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Name = "Cliente"
        Text = "Cliente"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
End Class
