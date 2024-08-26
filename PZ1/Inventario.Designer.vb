<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Label1 = New Label()
        txtCodigoProducto = New TextBox()
        btnBuscar = New Button()
        dgvProductoKardex = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        OPERACION = New DataGridViewTextBoxColumn()
        TIPO = New DataGridViewTextBoxColumn()
        CANTIDAD = New DataGridViewTextBoxColumn()
        btnMenu = New Button()
        CType(dgvProductoKardex, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightGreen
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold)
        Label1.Location = New Point(379, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 37)
        Label1.TabIndex = 0
        Label1.Text = "INVENTARIO"
        ' 
        ' txtCodigoProducto
        ' 
        txtCodigoProducto.Location = New Point(39, 107)
        txtCodigoProducto.Margin = New Padding(3, 2, 3, 2)
        txtCodigoProducto.Name = "txtCodigoProducto"
        txtCodigoProducto.PlaceholderText = "Codigo de Producto"
        txtCodigoProducto.Size = New Size(141, 23)
        txtCodigoProducto.TabIndex = 1
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(200, 107)
        btnBuscar.Margin = New Padding(3, 2, 3, 2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(66, 23)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProductoKardex
        ' 
        dgvProductoKardex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductoKardex.Columns.AddRange(New DataGridViewColumn() {Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        dgvProductoKardex.Location = New Point(39, 223)
        dgvProductoKardex.Margin = New Padding(3, 2, 3, 2)
        dgvProductoKardex.Name = "dgvProductoKardex"
        dgvProductoKardex.RowHeadersWidth = 51
        dgvProductoKardex.RowTemplate.Height = 29
        dgvProductoKardex.Size = New Size(907, 141)
        dgvProductoKardex.TabIndex = 4
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "ID"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "FECHA"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "OPERACION"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "TIPO"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "CANTIDAD"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "PRODUCTO"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "SALDO"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "FECHA"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' OPERACION
        ' 
        OPERACION.HeaderText = "OPERACION"
        OPERACION.MinimumWidth = 6
        OPERACION.Name = "OPERACION"
        OPERACION.Width = 125
        ' 
        ' TIPO
        ' 
        TIPO.HeaderText = "TIPO"
        TIPO.MinimumWidth = 6
        TIPO.Name = "TIPO"
        TIPO.Width = 125
        ' 
        ' CANTIDAD
        ' 
        CANTIDAD.HeaderText = "CANTIDAD"
        CANTIDAD.MinimumWidth = 6
        CANTIDAD.Name = "CANTIDAD"
        CANTIDAD.Width = 125
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(12, 11)
        btnMenu.Margin = New Padding(3, 2, 3, 2)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(66, 23)
        btnMenu.TabIndex = 5
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' Inventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(957, 510)
        Controls.Add(btnMenu)
        Controls.Add(dgvProductoKardex)
        Controls.Add(btnBuscar)
        Controls.Add(txtCodigoProducto)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Inventario"
        Text = "Inventario"
        CType(dgvProductoKardex, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvProductoKardex As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents OPERACION As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents btnMenu As Button
End Class
