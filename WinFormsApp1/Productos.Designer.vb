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
        tablaProductos = New DataGridView()
        txt_codigoProducto = New TextBox()
        btn_buscar = New Button()
        btn_agregar = New Button()
        btn_modificar = New Button()
        btn_eliminar = New Button()
        btn_salir = New Button()
        idProducto = New DataGridViewTextBoxColumn()
        codigo = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        marcaG = New DataGridViewTextBoxColumn()
        categoriaGrid = New DataGridViewTextBoxColumn()
        precio = New DataGridViewTextBoxColumn()
        talla = New DataGridViewTextBoxColumn()
        stock = New DataGridViewTextBoxColumn()
        CType(tablaProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tablaProductos
        ' 
        tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tablaProductos.Columns.AddRange(New DataGridViewColumn() {idProducto, codigo, nombre, marcaG, categoriaGrid, precio, talla, stock})
        tablaProductos.Location = New Point(79, 227)
        tablaProductos.Name = "tablaProductos"
        tablaProductos.RowHeadersWidth = 51
        tablaProductos.RowTemplate.Height = 29
        tablaProductos.Size = New Size(1052, 167)
        tablaProductos.TabIndex = 0
        ' 
        ' txt_codigoProducto
        ' 
        txt_codigoProducto.Location = New Point(117, 104)
        txt_codigoProducto.Name = "txt_codigoProducto"
        txt_codigoProducto.Size = New Size(125, 27)
        txt_codigoProducto.TabIndex = 1
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Location = New Point(337, 104)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(94, 29)
        btn_buscar.TabIndex = 2
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = True
        ' 
        ' btn_agregar
        ' 
        btn_agregar.Location = New Point(105, 613)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(94, 29)
        btn_agregar.TabIndex = 3
        btn_agregar.Text = "Agregar"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Location = New Point(252, 613)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(94, 29)
        btn_modificar.TabIndex = 4
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Location = New Point(405, 613)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(94, 29)
        btn_eliminar.TabIndex = 5
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_salir
        ' 
        btn_salir.Location = New Point(684, 613)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(94, 29)
        btn_salir.TabIndex = 6
        btn_salir.Text = "Salir"
        btn_salir.UseVisualStyleBackColor = True
        ' 
        ' idProducto
        ' 
        idProducto.HeaderText = "ID Producto"
        idProducto.MinimumWidth = 6
        idProducto.Name = "idProducto"
        idProducto.Width = 125
        ' 
        ' codigo
        ' 
        codigo.HeaderText = "Código"
        codigo.MinimumWidth = 6
        codigo.Name = "codigo"
        codigo.Width = 125
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "Nombre"
        nombre.MinimumWidth = 6
        nombre.Name = "nombre"
        nombre.Width = 125
        ' 
        ' marcaG
        ' 
        marcaG.HeaderText = "Marca"
        marcaG.MinimumWidth = 6
        marcaG.Name = "marcaG"
        marcaG.Width = 125
        ' 
        ' categoriaGrid
        ' 
        categoriaGrid.HeaderText = "Categoria"
        categoriaGrid.MinimumWidth = 6
        categoriaGrid.Name = "categoriaGrid"
        categoriaGrid.Width = 125
        ' 
        ' precio
        ' 
        precio.HeaderText = "Precio"
        precio.MinimumWidth = 6
        precio.Name = "precio"
        precio.Width = 125
        ' 
        ' talla
        ' 
        talla.HeaderText = "Talla"
        talla.MinimumWidth = 6
        talla.Name = "talla"
        talla.Width = 125
        ' 
        ' stock
        ' 
        stock.HeaderText = "Stock Actual"
        stock.MinimumWidth = 6
        stock.Name = "stock"
        stock.Width = 125
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1650, 800)
        Controls.Add(btn_salir)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_modificar)
        Controls.Add(btn_agregar)
        Controls.Add(btn_buscar)
        Controls.Add(txt_codigoProducto)
        Controls.Add(tablaProductos)
        Name = "Productos"
        Text = "Productos"
        CType(tablaProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tablaProductos As DataGridView
    Friend WithEvents txt_codigoProducto As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents marcaG As DataGridViewTextBoxColumn
    Friend WithEvents categoriaGrid As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents talla As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
