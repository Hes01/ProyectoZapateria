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
        dtpFecha2Reporte = New DateTimePicker()
        GroupBox1 = New GroupBox()
        dgvVendedores = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        dgvProductos = New DataGridView()
        btnObtenerVentas = New Button()
        btnMenu = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvVendedores, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
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
        ' dtpFecha2Reporte
        ' 
        dtpFecha2Reporte.Location = New Point(264, 79)
        dtpFecha2Reporte.Name = "dtpFecha2Reporte"
        dtpFecha2Reporte.Size = New Size(234, 23)
        dtpFecha2Reporte.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtpFecha1Reporte)
        GroupBox1.Controls.Add(dtpFecha2Reporte)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(25, 54)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(547, 130)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Fecha de Reporte"
        ' 
        ' dgvVendedores
        ' 
        dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVendedores.Location = New Point(25, 260)
        dgvVendedores.Name = "dgvVendedores"
        dgvVendedores.Size = New Size(547, 160)
        dgvVendedores.TabIndex = 6
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
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(25, 518)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(547, 160)
        dgvProductos.TabIndex = 8
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
        Controls.Add(dgvProductos)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(dgvVendedores)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reportes"
        Text = "Reportes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvVendedores, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha1Reporte As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecha2Reporte As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvVendedores As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnObtenerVentas As Button
    Friend WithEvents btnMenu As Button
End Class
