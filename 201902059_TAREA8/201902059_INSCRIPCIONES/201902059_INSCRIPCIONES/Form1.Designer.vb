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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbcarnet = New System.Windows.Forms.TextBox()
        Me.rbbasicos = New System.Windows.Forms.RadioButton()
        Me.rbdiversificado = New System.Windows.Forms.RadioButton()
        Me.cbcarrera = New System.Windows.Forms.ComboBox()
        Me.cbpago = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbdiseño = New System.Windows.Forms.TextBox()
        Me.tbelect = New System.Windows.Forms.TextBox()
        Me.tbbach = New System.Windows.Forms.TextBox()
        Me.tbperito = New System.Windows.Forms.TextBox()
        Me.tbdiversificado = New System.Windows.Forms.TextBox()
        Me.tbtbasicos = New System.Windows.Forms.TextBox()
        Me.tbbanco = New System.Windows.Forms.TextBox()
        Me.tbtransferencia = New System.Windows.Forms.TextBox()
        Me.tbefectivo = New System.Windows.Forms.TextBox()
        Me.tbtarjeta = New System.Windows.Forms.TextBox()
        Me.tbgeneral = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnmatriz = New System.Windows.Forms.Button()
        Me.btnentradas = New System.Windows.Forms.Button()
        Me.btnltotales = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.btntotales = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(15, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carnet:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(15, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Carrera:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(15, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nivel de estudios:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(15, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Forma de Pago"
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(182, 23)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(223, 30)
        Me.tbnombre.TabIndex = 5
        '
        'tbcarnet
        '
        Me.tbcarnet.Location = New System.Drawing.Point(182, 61)
        Me.tbcarnet.Name = "tbcarnet"
        Me.tbcarnet.Size = New System.Drawing.Size(223, 30)
        Me.tbcarnet.TabIndex = 6
        '
        'rbbasicos
        '
        Me.rbbasicos.AutoSize = True
        Me.rbbasicos.Location = New System.Drawing.Point(182, 109)
        Me.rbbasicos.Name = "rbbasicos"
        Me.rbbasicos.Size = New System.Drawing.Size(82, 27)
        Me.rbbasicos.TabIndex = 7
        Me.rbbasicos.TabStop = True
        Me.rbbasicos.Text = "Básicos"
        Me.rbbasicos.UseVisualStyleBackColor = True
        '
        'rbdiversificado
        '
        Me.rbdiversificado.AutoSize = True
        Me.rbdiversificado.Location = New System.Drawing.Point(270, 107)
        Me.rbdiversificado.Name = "rbdiversificado"
        Me.rbdiversificado.Size = New System.Drawing.Size(126, 27)
        Me.rbdiversificado.TabIndex = 8
        Me.rbdiversificado.TabStop = True
        Me.rbdiversificado.Text = "Diversificado"
        Me.rbdiversificado.UseVisualStyleBackColor = True
        '
        'cbcarrera
        '
        Me.cbcarrera.FormattingEnabled = True
        Me.cbcarrera.Items.AddRange(New Object() {"Perito Contador", "Bachillerato", "Electronica", "Diseño Grafico"})
        Me.cbcarrera.Location = New System.Drawing.Point(182, 152)
        Me.cbcarrera.Name = "cbcarrera"
        Me.cbcarrera.Size = New System.Drawing.Size(223, 31)
        Me.cbcarrera.TabIndex = 9
        Me.cbcarrera.Visible = False
        '
        'cbpago
        '
        Me.cbpago.FormattingEnabled = True
        Me.cbpago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de Credito", "Transferencia por ACH", "Deposito Bancario"})
        Me.cbpago.Location = New System.Drawing.Point(182, 194)
        Me.cbpago.Name = "cbpago"
        Me.cbpago.Size = New System.Drawing.Size(223, 31)
        Me.cbpago.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Carnet, Me.Nivel, Me.Carrera, Me.Pago, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(828, 230)
        Me.DataGridView1.TabIndex = 11
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Carnet
        '
        Me.Carnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Carnet.HeaderText = "Carnet"
        Me.Carnet.Name = "Carnet"
        '
        'Nivel
        '
        Me.Nivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.Name = "Nivel"
        '
        'Carrera
        '
        Me.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.Name = "Carrera"
        '
        'Pago
        '
        Me.Pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Pago.HeaderText = "Forma de Pago"
        Me.Pago.Name = "Pago"
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.tbdiseño)
        Me.GroupBox1.Controls.Add(Me.tbelect)
        Me.GroupBox1.Controls.Add(Me.tbbach)
        Me.GroupBox1.Controls.Add(Me.tbperito)
        Me.GroupBox1.Controls.Add(Me.tbdiversificado)
        Me.GroupBox1.Controls.Add(Me.tbtbasicos)
        Me.GroupBox1.Controls.Add(Me.tbbanco)
        Me.GroupBox1.Controls.Add(Me.tbtransferencia)
        Me.GroupBox1.Controls.Add(Me.tbefectivo)
        Me.GroupBox1.Controls.Add(Me.tbtarjeta)
        Me.GroupBox1.Controls.Add(Me.tbgeneral)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(846, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 457)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales por carrera:"
        Me.GroupBox1.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(344, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 22)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Q"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(344, 199)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 22)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Q"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(344, 163)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 22)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Q"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(344, 130)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 22)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Q"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(344, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 22)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Q"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(344, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 22)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Q"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(344, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 22)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Q"
        '
        'tbdiseño
        '
        Me.tbdiseño.Enabled = False
        Me.tbdiseño.Location = New System.Drawing.Point(370, 401)
        Me.tbdiseño.Name = "tbdiseño"
        Me.tbdiseño.Size = New System.Drawing.Size(62, 30)
        Me.tbdiseño.TabIndex = 22
        '
        'tbelect
        '
        Me.tbelect.Enabled = False
        Me.tbelect.Location = New System.Drawing.Point(370, 368)
        Me.tbelect.Name = "tbelect"
        Me.tbelect.Size = New System.Drawing.Size(62, 30)
        Me.tbelect.TabIndex = 21
        '
        'tbbach
        '
        Me.tbbach.Enabled = False
        Me.tbbach.Location = New System.Drawing.Point(370, 335)
        Me.tbbach.Name = "tbbach"
        Me.tbbach.Size = New System.Drawing.Size(62, 30)
        Me.tbbach.TabIndex = 20
        '
        'tbperito
        '
        Me.tbperito.Enabled = False
        Me.tbperito.Location = New System.Drawing.Point(370, 303)
        Me.tbperito.Name = "tbperito"
        Me.tbperito.Size = New System.Drawing.Size(62, 30)
        Me.tbperito.TabIndex = 19
        '
        'tbdiversificado
        '
        Me.tbdiversificado.Enabled = False
        Me.tbdiversificado.Location = New System.Drawing.Point(370, 228)
        Me.tbdiversificado.Name = "tbdiversificado"
        Me.tbdiversificado.Size = New System.Drawing.Size(145, 30)
        Me.tbdiversificado.TabIndex = 18
        '
        'tbtbasicos
        '
        Me.tbtbasicos.Enabled = False
        Me.tbtbasicos.Location = New System.Drawing.Point(370, 196)
        Me.tbtbasicos.Name = "tbtbasicos"
        Me.tbtbasicos.Size = New System.Drawing.Size(145, 30)
        Me.tbtbasicos.TabIndex = 17
        '
        'tbbanco
        '
        Me.tbbanco.Enabled = False
        Me.tbbanco.Location = New System.Drawing.Point(370, 160)
        Me.tbbanco.Name = "tbbanco"
        Me.tbbanco.Size = New System.Drawing.Size(145, 30)
        Me.tbbanco.TabIndex = 16
        '
        'tbtransferencia
        '
        Me.tbtransferencia.Enabled = False
        Me.tbtransferencia.Location = New System.Drawing.Point(370, 124)
        Me.tbtransferencia.Name = "tbtransferencia"
        Me.tbtransferencia.Size = New System.Drawing.Size(145, 30)
        Me.tbtransferencia.TabIndex = 15
        '
        'tbefectivo
        '
        Me.tbefectivo.Enabled = False
        Me.tbefectivo.Location = New System.Drawing.Point(370, 91)
        Me.tbefectivo.Name = "tbefectivo"
        Me.tbefectivo.Size = New System.Drawing.Size(145, 30)
        Me.tbefectivo.TabIndex = 14
        '
        'tbtarjeta
        '
        Me.tbtarjeta.Enabled = False
        Me.tbtarjeta.Location = New System.Drawing.Point(370, 58)
        Me.tbtarjeta.Name = "tbtarjeta"
        Me.tbtarjeta.Size = New System.Drawing.Size(145, 30)
        Me.tbtarjeta.TabIndex = 13
        '
        'tbgeneral
        '
        Me.tbgeneral.Enabled = False
        Me.tbgeneral.Location = New System.Drawing.Point(370, 26)
        Me.tbgeneral.Name = "tbgeneral"
        Me.tbgeneral.Size = New System.Drawing.Size(145, 30)
        Me.tbgeneral.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 404)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 22)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Diseño Gráfico"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(225, 371)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 22)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Electrónica"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(215, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 22)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Bachillerato"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(185, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 22)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Perito contador"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(136, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 22)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Total diversificado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(154, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 22)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Totales por carrera:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 22)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total básicos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-4, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(350, 22)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total pagado con deposito bancario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(310, 22)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total pagado por transferencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total pagado en efectivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total pagado con tarjeta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total General"
        '
        'btnmatriz
        '
        Me.btnmatriz.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmatriz.Location = New System.Drawing.Point(572, 75)
        Me.btnmatriz.Name = "btnmatriz"
        Me.btnmatriz.Size = New System.Drawing.Size(99, 64)
        Me.btnmatriz.TabIndex = 13
        Me.btnmatriz.Text = "Limpiar Matriz"
        Me.btnmatriz.UseVisualStyleBackColor = False
        '
        'btnentradas
        '
        Me.btnentradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentradas.Location = New System.Drawing.Point(453, 75)
        Me.btnentradas.Name = "btnentradas"
        Me.btnentradas.Size = New System.Drawing.Size(99, 64)
        Me.btnentradas.TabIndex = 14
        Me.btnentradas.Text = "Limpiar Entradas"
        Me.btnentradas.UseVisualStyleBackColor = False
        '
        'btnltotales
        '
        Me.btnltotales.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnltotales.Location = New System.Drawing.Point(689, 72)
        Me.btnltotales.Name = "btnltotales"
        Me.btnltotales.Size = New System.Drawing.Size(99, 64)
        Me.btnltotales.TabIndex = 15
        Me.btnltotales.Text = "Limpiar Totales"
        Me.btnltotales.UseVisualStyleBackColor = False
        '
        'btnmostrar
        '
        Me.btnmostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmostrar.Location = New System.Drawing.Point(572, 5)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(99, 64)
        Me.btnmostrar.TabIndex = 16
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = False
        '
        'btntotales
        '
        Me.btntotales.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btntotales.Location = New System.Drawing.Point(689, 5)
        Me.btntotales.Name = "btntotales"
        Me.btntotales.Size = New System.Drawing.Size(99, 64)
        Me.btntotales.TabIndex = 17
        Me.btntotales.Text = "Totales"
        Me.btntotales.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(453, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 64)
        Me.btnguardar.TabIndex = 18
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneliminar.Location = New System.Drawing.Point(504, 156)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(99, 64)
        Me.btneliminar.TabIndex = 19
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsalir.Location = New System.Drawing.Point(632, 152)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(99, 64)
        Me.btnsalir.TabIndex = 20
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1370, 492)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btntotales)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.btnltotales)
        Me.Controls.Add(Me.btnentradas)
        Me.Controls.Add(Me.btnmatriz)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbpago)
        Me.Controls.Add(Me.cbcarrera)
        Me.Controls.Add(Me.rbdiversificado)
        Me.Controls.Add(Me.rbbasicos)
        Me.Controls.Add(Me.tbcarnet)
        Me.Controls.Add(Me.tbnombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Colegio Camino del Saber"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents tbcarnet As TextBox
    Friend WithEvents rbbasicos As RadioButton
    Friend WithEvents rbdiversificado As RadioButton
    Friend WithEvents cbcarrera As ComboBox
    Friend WithEvents cbpago As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Carnet As DataGridViewTextBoxColumn
    Friend WithEvents Nivel As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents Pago As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tbdiseño As TextBox
    Friend WithEvents tbelect As TextBox
    Friend WithEvents tbbach As TextBox
    Friend WithEvents tbperito As TextBox
    Friend WithEvents tbdiversificado As TextBox
    Friend WithEvents tbtbasicos As TextBox
    Friend WithEvents tbbanco As TextBox
    Friend WithEvents tbtransferencia As TextBox
    Friend WithEvents tbefectivo As TextBox
    Friend WithEvents tbtarjeta As TextBox
    Friend WithEvents tbgeneral As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnmatriz As Button
    Friend WithEvents btnentradas As Button
    Friend WithEvents btnltotales As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents btntotales As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnsalir As Button
End Class
