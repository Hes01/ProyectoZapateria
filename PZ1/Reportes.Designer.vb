<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Label1 = New Label()
        dtpFecha1Reporte = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        vendedor = New DataGridViewTextBoxColumn()
        total = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        btnObtenerVentas = New Button()
        btnMenu = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 15)
        Label1.TabIndex = 0
        Label1.Text = "Selecciona la fecha para realizar el reporte"
        ' 
        ' dtpFecha1Reporte
        ' 
        dtpFecha1Reporte.CustomFormat = "yy/mm/dd"
        dtpFecha1Reporte.Location = New Point(22, 79)
        dtpFecha1Reporte.Name = "dtpFecha1Reporte"
        dtpFecha1Reporte.Size = New Size(236, 23)
        dtpFecha1Reporte.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fecha Inicial"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(264, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 4
        Label3.Text = "Fecha Final"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(264, 79)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(234, 23)
        DateTimePicker2.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtpFecha1Reporte)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(25, 54)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(547, 130)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Fecha de Reporte"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, vendedor, total})
        DataGridView1.Location = New Point(25, 260)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(547, 160)
        DataGridView1.TabIndex = 6
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' vendedor
        ' 
        vendedor.HeaderText = "VENDEDOR"
        vendedor.Name = "vendedor"
        vendedor.Width = 300
        ' 
        ' total
        ' 
        total.HeaderText = "TOTAL VENDIDO"
        total.Name = "total"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 15)
        Label4.TabIndex = 5
        Label4.Text = "Ventas de Vendedores"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 473)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 15)
        Label5.TabIndex = 7
        Label5.Text = "Ventas de productos"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        DataGridView2.Location = New Point(25, 518)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(547, 160)
        DataGridView2.TabIndex = 8
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "PRODUCTO"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 300
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "TOTAL VENDIDO"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' btnObtenerVentas
        ' 
        btnObtenerVentas.Location = New Point(440, 12)
        btnObtenerVentas.Name = "btnObtenerVentas"
        btnObtenerVentas.Size = New Size(100, 23)
        btnObtenerVentas.TabIndex = 10
        btnObtenerVentas.Text = "Obtener Ventas"
        btnObtenerVentas.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(324, 12)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(100, 23)
        btnMenu.TabIndex = 11
        btnMenu.Text = "Menú"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' Reportes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ClientSize = New Size(592, 749)
        Controls.Add(btnMenu)
        Controls.Add(btnObtenerVentas)
        Controls.Add(DataGridView2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "Reportes"
        Text = "Reportes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha1Reporte As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents vendedor As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnObtenerVentas As Button
    Friend WithEvents btnMenu As Button
End Class
