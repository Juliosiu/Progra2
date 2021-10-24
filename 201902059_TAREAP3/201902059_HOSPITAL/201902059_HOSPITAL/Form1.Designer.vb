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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbnit = New System.Windows.Forms.TextBox()
        Me.tbdias = New System.Windows.Forms.TextBox()
        Me.tbhonorarios = New System.Windows.Forms.TextBox()
        Me.cbhabitacion = New System.Windows.Forms.ComboBox()
        Me.cbpago = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CálculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbe2 = New System.Windows.Forms.TextBox()
        Me.tbe1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbe3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbconsulta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diashospitalizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Honorarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipohabitación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipopago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbpago)
        Me.GroupBox1.Controls.Add(Me.cbhabitacion)
        Me.GroupBox1.Controls.Add(Me.tbhonorarios)
        Me.GroupBox1.Controls.Add(Me.tbdias)
        Me.GroupBox1.Controls.Add(Me.tbnit)
        Me.GroupBox1.Controls.Add(Me.tbnombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número de Nit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Días hospitalizado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Honorarios del Médico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tipo de habitación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 186)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tipo de pago"
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(220, 25)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(157, 26)
        Me.tbnombre.TabIndex = 7
        '
        'tbnit
        '
        Me.tbnit.Location = New System.Drawing.Point(220, 56)
        Me.tbnit.Name = "tbnit"
        Me.tbnit.Size = New System.Drawing.Size(157, 26)
        Me.tbnit.TabIndex = 8
        '
        'tbdias
        '
        Me.tbdias.Location = New System.Drawing.Point(220, 92)
        Me.tbdias.Name = "tbdias"
        Me.tbdias.Size = New System.Drawing.Size(157, 26)
        Me.tbdias.TabIndex = 9
        '
        'tbhonorarios
        '
        Me.tbhonorarios.Location = New System.Drawing.Point(220, 122)
        Me.tbhonorarios.Name = "tbhonorarios"
        Me.tbhonorarios.Size = New System.Drawing.Size(157, 26)
        Me.tbhonorarios.TabIndex = 10
        '
        'cbhabitacion
        '
        Me.cbhabitacion.FormattingEnabled = True
        Me.cbhabitacion.Items.AddRange(New Object() {"Privada", "Semiprivada", "No privada"})
        Me.cbhabitacion.Location = New System.Drawing.Point(220, 154)
        Me.cbhabitacion.Name = "cbhabitacion"
        Me.cbhabitacion.Size = New System.Drawing.Size(157, 27)
        Me.cbhabitacion.TabIndex = 11
        '
        'cbpago
        '
        Me.cbpago.FormattingEnabled = True
        Me.cbpago.Items.AddRange(New Object() {"Efectivo", "Transferencia", "Deposito", "Tarjeta", "Seguro"})
        Me.cbpago.Location = New System.Drawing.Point(220, 187)
        Me.cbpago.Name = "cbpago"
        Me.cbpago.Size = New System.Drawing.Size(157, 27)
        Me.cbpago.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.CerrarAplicaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CálculoToolStripMenuItem
        '
        Me.CálculoToolStripMenuItem.Name = "CálculoToolStripMenuItem"
        Me.CálculoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.CálculoToolStripMenuItem.Text = "Cálculo"
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
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadisticasToolStripMenuItem, Me.EntradasToolStripMenuItem, Me.MatrizToolStripMenuItem})
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar aplicación"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.tbe3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbe2)
        Me.GroupBox2.Controls.Add(Me.tbe1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(633, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 230)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadísticas"
        Me.GroupBox2.Visible = False
        '
        'tbe2
        '
        Me.tbe2.Enabled = False
        Me.tbe2.Location = New System.Drawing.Point(220, 106)
        Me.tbe2.Name = "tbe2"
        Me.tbe2.Size = New System.Drawing.Size(157, 26)
        Me.tbe2.TabIndex = 9
        '
        'tbe1
        '
        Me.tbe1.Enabled = False
        Me.tbe1.Location = New System.Drawing.Point(220, 45)
        Me.tbe1.Name = "tbe1"
        Me.tbe1.Size = New System.Drawing.Size(157, 26)
        Me.tbe1.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(188, 48)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Pacientes que usaron habitación privada"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 48)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total recaudado por ACH"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(191, 109)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Q"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 157)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 48)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Días que se utilizó la habitación no privada"
        '
        'tbe3
        '
        Me.tbe3.Enabled = False
        Me.tbe3.Location = New System.Drawing.Point(220, 168)
        Me.tbe3.Name = "tbe3"
        Me.tbe3.Size = New System.Drawing.Size(157, 26)
        Me.tbe3.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Nit, Me.Diashospitalizado, Me.Honorarios, Me.Tipohabitación, Me.Tipopago, Me.parcial, Me.Dor, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 296)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 275)
        Me.DataGridView1.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.tbconsulta)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(425, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 230)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consulta"
        '
        'tbconsulta
        '
        Me.tbconsulta.Location = New System.Drawing.Point(20, 122)
        Me.tbconsulta.Name = "tbconsulta"
        Me.tbconsulta.Size = New System.Drawing.Size(157, 26)
        Me.tbconsulta.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 66)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 48)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Escriba el NIT a buscar"
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Nit
        '
        Me.Nit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nit.HeaderText = "NIT"
        Me.Nit.Name = "Nit"
        '
        'Diashospitalizado
        '
        Me.Diashospitalizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Diashospitalizado.HeaderText = "Días Hospitalizado"
        Me.Diashospitalizado.Name = "Diashospitalizado"
        '
        'Honorarios
        '
        Me.Honorarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Honorarios.HeaderText = "Honorarios del Médico"
        Me.Honorarios.Name = "Honorarios"
        '
        'Tipohabitación
        '
        Me.Tipohabitación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tipohabitación.HeaderText = "Tipo de Habitación"
        Me.Tipohabitación.Name = "Tipohabitación"
        '
        'Tipopago
        '
        Me.Tipopago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tipopago.HeaderText = "Tipo de Pago"
        Me.Tipopago.Name = "Tipopago"
        '
        'parcial
        '
        Me.parcial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.parcial.HeaderText = "Parcial"
        Me.parcial.Name = "parcial"
        '
        'Dor
        '
        Me.Dor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Dor.HeaderText = "Descuento o Recargo"
        Me.Dor.Name = "Dor"
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1040, 625)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbpago As ComboBox
    Friend WithEvents cbhabitacion As ComboBox
    Friend WithEvents tbhonorarios As TextBox
    Friend WithEvents tbdias As TextBox
    Friend WithEvents tbnit As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CálculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbe3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbe2 As TextBox
    Friend WithEvents tbe1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbconsulta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Nit As DataGridViewTextBoxColumn
    Friend WithEvents Diashospitalizado As DataGridViewTextBoxColumn
    Friend WithEvents Honorarios As DataGridViewTextBoxColumn
    Friend WithEvents Tipohabitación As DataGridViewTextBoxColumn
    Friend WithEvents Tipopago As DataGridViewTextBoxColumn
    Friend WithEvents parcial As DataGridViewTextBoxColumn
    Friend WithEvents Dor As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
