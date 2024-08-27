<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        txtBuscar = New TextBox()
        dgvProductos = New DataGridView()
        btnSalir = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnAgregar = New Button()
        btnBuscar = New Button()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(22, 61)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(234, 23)
        txtBuscar.TabIndex = 0
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(22, 153)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowTemplate.Height = 25
        dgvProductos.Size = New Size(766, 317)
        dgvProductos.TabIndex = 1
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(714, 516)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 44)
        btnSalir.TabIndex = 29
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(231, 516)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 44)
        btnEliminar.TabIndex = 28
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(125, 516)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 44)
        btnModificar.TabIndex = 27
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(15, 516)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 44)
        btnAgregar.TabIndex = 26
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(262, 55)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(53, 32)
        btnBuscar.TabIndex = 30
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 586)
        Controls.Add(btnBuscar)
        Controls.Add(btnSalir)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Controls.Add(dgvProductos)
        Controls.Add(txtBuscar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBuscar As Button
End Class
