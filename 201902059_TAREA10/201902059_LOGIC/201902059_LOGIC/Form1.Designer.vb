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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarDescendentementeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbdpi = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbvalor = New System.Windows.Forms.TextBox()
        Me.tbmeses = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DPI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.tbmeses)
        Me.GroupBox1.Controls.Add(Me.tbvalor)
        Me.GroupBox1.Controls.Add(Me.tbnombre)
        Me.GroupBox1.Controls.Add(Me.tbdpi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.OrdenarDescendentementeToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 24)
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
        'OrdenarDescendentementeToolStripMenuItem
        '
        Me.OrdenarDescendentementeToolStripMenuItem.Name = "OrdenarDescendentementeToolStripMenuItem"
        Me.OrdenarDescendentementeToolStripMenuItem.Size = New System.Drawing.Size(166, 20)
        Me.OrdenarDescendentementeToolStripMenuItem.Text = "Ordenar descendentemente"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de DPI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor del articulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meses a pagar"
        '
        'tbdpi
        '
        Me.tbdpi.Location = New System.Drawing.Point(144, 26)
        Me.tbdpi.Name = "tbdpi"
        Me.tbdpi.Size = New System.Drawing.Size(113, 21)
        Me.tbdpi.TabIndex = 4
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(144, 56)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(113, 21)
        Me.tbnombre.TabIndex = 5
        '
        'tbvalor
        '
        Me.tbvalor.Location = New System.Drawing.Point(144, 84)
        Me.tbvalor.Name = "tbvalor"
        Me.tbvalor.Size = New System.Drawing.Size(113, 21)
        Me.tbvalor.TabIndex = 6
        '
        'tbmeses
        '
        Me.tbmeses.Location = New System.Drawing.Point(144, 115)
        Me.tbmeses.Name = "tbmeses"
        Me.tbmeses.Size = New System.Drawing.Size(113, 21)
        Me.tbmeses.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DPI, Me.Nombre, Me.Valor, Me.Meses, Me.Tasa, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(283, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(772, 160)
        Me.DataGridView1.TabIndex = 2
        '
        'DPI
        '
        Me.DPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DPI.HeaderText = "DPI"
        Me.DPI.Name = "DPI"
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Valor
        '
        Me.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'Meses
        '
        Me.Meses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Meses.HeaderText = "Meses"
        Me.Meses.Name = "Meses"
        '
        'Tasa
        '
        Me.Tasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tasa.HeaderText = "Tasa"
        Me.Tasa.Name = "Tasa"
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 189)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("PanRoman", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "LOGIC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbmeses As TextBox
    Friend WithEvents tbvalor As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents tbdpi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarDescendentementeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DPI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Meses As DataGridViewTextBoxColumn
    Friend WithEvents Tasa As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
