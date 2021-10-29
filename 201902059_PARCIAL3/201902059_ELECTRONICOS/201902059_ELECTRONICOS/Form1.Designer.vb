<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Defectuosas = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Aprobadas = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Ganancias = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Perdidas = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Total = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Sello = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio / unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unidades defectuosas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Unidades aprobadas"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(235, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 25)
        Me.TextBox1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Q"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(235, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 25)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(235, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 25)
        Me.TextBox3.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 26)
        Me.ComboBox1.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(235, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 26)
        Me.ComboBox2.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperarToolStripMenuItem
        '
        Me.OperarToolStripMenuItem.Name = "OperarToolStripMenuItem"
        Me.OperarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.OperarToolStripMenuItem.Text = "Operar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem, Me.MatrizToolStripMenuItem, Me.EstadísticasToolStripMenuItem1})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MatrizToolStripMenuItem.Text = "Matriz"
        '
        'EstadísticasToolStripMenuItem1
        '
        Me.EstadísticasToolStripMenuItem1.Name = "EstadísticasToolStripMenuItem1"
        Me.EstadísticasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EstadísticasToolStripMenuItem1.Text = "Estadísticas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 196)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(9, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 25)
        Me.TextBox4.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 38)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Ingrese código del Producto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(619, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(394, 196)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadísticas"
        Me.GroupBox3.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(235, 35)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(140, 25)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(235, 92)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(140, 25)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(235, 157)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(140, 25)
        Me.TextBox7.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 57)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Lotes que tienen el sello de calidad"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 57)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Lotes que tienen más unidades defectuosas que aprobadas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 57)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Lotes que tienen al menos una unidad defectuosa"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Precio, Me.Defectuosas, Me.Aprobadas, Me.Ganancias, Me.Perdidas, Me.Total, Me.Sello})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 254)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(989, 257)
        Me.DataGridView1.TabIndex = 12
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codigo.HeaderText = "Código del producto"
        Me.Codigo.Name = "Codigo"
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.HeaderText = "Nombre del producto"
        Me.Nombre.Name = "Nombre"
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Precio por Unidad"
        Me.Precio.Name = "Precio"
        '
        'Defectuosas
        '
        Me.Defectuosas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Defectuosas.HeaderText = "Unidades defectuosas"
        Me.Defectuosas.Name = "Defectuosas"
        '
        'Aprobadas
        '
        Me.Aprobadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Aprobadas.HeaderText = "Unidades Aprobadas"
        Me.Aprobadas.Name = "Aprobadas"
        '
        'Ganancias
        '
        Me.Ganancias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Ganancias.HeaderText = "Ganancias"
        Me.Ganancias.Name = "Ganancias"
        '
        'Perdidas
        '
        Me.Perdidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Perdidas.HeaderText = "Pérdidas"
        Me.Perdidas.Name = "Perdidas"
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Sello
        '
        Me.Sello.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Sello.HeaderText = "Sello de calidad"
        Me.Sello.Name = "Sello"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1034, 523)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Monospac821 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "ELECTRONICOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewButtonColumn
    Friend WithEvents Precio As DataGridViewButtonColumn
    Friend WithEvents Defectuosas As DataGridViewButtonColumn
    Friend WithEvents Aprobadas As DataGridViewButtonColumn
    Friend WithEvents Ganancias As DataGridViewButtonColumn
    Friend WithEvents Perdidas As DataGridViewButtonColumn
    Friend WithEvents Total As DataGridViewButtonColumn
    Friend WithEvents Sello As DataGridViewButtonColumn
End Class
