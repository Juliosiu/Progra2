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
        Me.cbetapa = New System.Windows.Forms.ComboBox()
        Me.cbequipo = New System.Windows.Forms.ComboBox()
        Me.rbgua = New System.Windows.Forms.RadioButton()
        Me.rbext = New System.Windows.Forms.RadioButton()
        Me.tbrecorrido = New System.Windows.Forms.TextBox()
        Me.tbtiempo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnlestadisticas = New System.Windows.Forms.Button()
        Me.btnestadisticas = New System.Windows.Forms.Button()
        Me.tbrec2 = New System.Windows.Forms.TextBox()
        Me.tbrec1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnlentradas = New System.Windows.Forms.Button()
        Me.btnllista = New System.Windows.Forms.Button()
        Me.btnordenar = New System.Windows.Forms.Button()
        Me.tbe1 = New System.Windows.Forms.TextBox()
        Me.tbrec3 = New System.Windows.Forms.TextBox()
        Me.tbrec4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbt4 = New System.Windows.Forms.TextBox()
        Me.tbt3 = New System.Windows.Forms.TextBox()
        Me.tbt2 = New System.Windows.Forms.TextBox()
        Me.tbt1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbconsulta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Etapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nacionalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penalización = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnordenar)
        Me.GroupBox1.Controls.Add(Me.btnllista)
        Me.GroupBox1.Controls.Add(Me.btnlentradas)
        Me.GroupBox1.Controls.Add(Me.btnmostrar)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.tbtiempo)
        Me.GroupBox1.Controls.Add(Me.tbrecorrido)
        Me.GroupBox1.Controls.Add(Me.rbext)
        Me.GroupBox1.Controls.Add(Me.rbgua)
        Me.GroupBox1.Controls.Add(Me.cbequipo)
        Me.GroupBox1.Controls.Add(Me.cbetapa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(329, 332)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del ciclista"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Etapa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recorrido (km)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tiempo (min)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nacionalidad"
        '
        'cbetapa
        '
        Me.cbetapa.FormattingEnabled = True
        Me.cbetapa.Location = New System.Drawing.Point(157, 35)
        Me.cbetapa.Name = "cbetapa"
        Me.cbetapa.Size = New System.Drawing.Size(153, 25)
        Me.cbetapa.TabIndex = 5
        '
        'cbequipo
        '
        Me.cbequipo.FormattingEnabled = True
        Me.cbequipo.Location = New System.Drawing.Point(157, 73)
        Me.cbequipo.Name = "cbequipo"
        Me.cbequipo.Size = New System.Drawing.Size(153, 25)
        Me.cbequipo.TabIndex = 6
        '
        'rbgua
        '
        Me.rbgua.AutoSize = True
        Me.rbgua.Location = New System.Drawing.Point(172, 185)
        Me.rbgua.Name = "rbgua"
        Me.rbgua.Size = New System.Drawing.Size(119, 21)
        Me.rbgua.TabIndex = 7
        Me.rbgua.TabStop = True
        Me.rbgua.Text = "Guatemalteco"
        Me.rbgua.UseVisualStyleBackColor = True
        '
        'rbext
        '
        Me.rbext.AutoSize = True
        Me.rbext.Location = New System.Drawing.Point(172, 212)
        Me.rbext.Name = "rbext"
        Me.rbext.Size = New System.Drawing.Size(98, 21)
        Me.rbext.TabIndex = 8
        Me.rbext.TabStop = True
        Me.rbext.Text = "Extranjero"
        Me.rbext.UseVisualStyleBackColor = True
        '
        'tbrecorrido
        '
        Me.tbrecorrido.Location = New System.Drawing.Point(157, 109)
        Me.tbrecorrido.Name = "tbrecorrido"
        Me.tbrecorrido.Size = New System.Drawing.Size(153, 28)
        Me.tbrecorrido.TabIndex = 9
        '
        'tbtiempo
        '
        Me.tbtiempo.Location = New System.Drawing.Point(157, 143)
        Me.tbtiempo.Name = "tbtiempo"
        Me.tbtiempo.Size = New System.Drawing.Size(153, 28)
        Me.tbtiempo.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.tbconsulta)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.btnactualizar)
        Me.GroupBox2.Controls.Add(Me.btnconsultar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 46)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(250, 261)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Etapa"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(7, 239)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(100, 37)
        Me.btnguardar.TabIndex = 11
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnmostrar
        '
        Me.btnmostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmostrar.Location = New System.Drawing.Point(113, 239)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(100, 37)
        Me.btnmostrar.TabIndex = 12
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = False
        '
        'btnconsultar
        '
        Me.btnconsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnconsultar.Location = New System.Drawing.Point(71, 84)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(100, 37)
        Me.btnconsultar.TabIndex = 13
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnactualizar.Location = New System.Drawing.Point(71, 138)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(100, 37)
        Me.btnactualizar.TabIndex = 14
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneliminar.Location = New System.Drawing.Point(71, 191)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(100, 37)
        Me.btneliminar.TabIndex = 15
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.tbt4)
        Me.GroupBox3.Controls.Add(Me.tbt3)
        Me.GroupBox3.Controls.Add(Me.tbt2)
        Me.GroupBox3.Controls.Add(Me.tbt1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tbrec4)
        Me.GroupBox3.Controls.Add(Me.tbrec3)
        Me.GroupBox3.Controls.Add(Me.tbe1)
        Me.GroupBox3.Controls.Add(Me.btnlestadisticas)
        Me.GroupBox3.Controls.Add(Me.btnestadisticas)
        Me.GroupBox3.Controls.Add(Me.tbrec2)
        Me.GroupBox3.Controls.Add(Me.tbrec1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(613, 15)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(384, 332)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadisticas"
        '
        'btnlestadisticas
        '
        Me.btnlestadisticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlestadisticas.Location = New System.Drawing.Point(192, 266)
        Me.btnlestadisticas.Name = "btnlestadisticas"
        Me.btnlestadisticas.Size = New System.Drawing.Size(100, 53)
        Me.btnlestadisticas.TabIndex = 12
        Me.btnlestadisticas.Text = "Limpiar Estadísticas"
        Me.btnlestadisticas.UseVisualStyleBackColor = False
        '
        'btnestadisticas
        '
        Me.btnestadisticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnestadisticas.Location = New System.Drawing.Point(34, 282)
        Me.btnestadisticas.Name = "btnestadisticas"
        Me.btnestadisticas.Size = New System.Drawing.Size(100, 37)
        Me.btnestadisticas.TabIndex = 11
        Me.btnestadisticas.Text = "Estadísticas"
        Me.btnestadisticas.UseVisualStyleBackColor = False
        '
        'tbrec2
        '
        Me.tbrec2.Enabled = False
        Me.tbrec2.Location = New System.Drawing.Point(124, 156)
        Me.tbrec2.Name = "tbrec2"
        Me.tbrec2.Size = New System.Drawing.Size(98, 28)
        Me.tbrec2.TabIndex = 10
        '
        'tbrec1
        '
        Me.tbrec1.Enabled = False
        Me.tbrec1.Location = New System.Drawing.Point(124, 120)
        Me.tbrec1.Name = "tbrec1"
        Me.tbrec1.Size = New System.Drawing.Size(98, 28)
        Me.tbrec1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Movistar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Sky"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(121, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 47)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Recorridos (km) por equipo: "
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(251, 35)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "corredores nacionales que hicieron más de 45 km"
        '
        'btnlentradas
        '
        Me.btnlentradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlentradas.Location = New System.Drawing.Point(222, 239)
        Me.btnlentradas.Name = "btnlentradas"
        Me.btnlentradas.Size = New System.Drawing.Size(100, 53)
        Me.btnlentradas.TabIndex = 13
        Me.btnlentradas.Text = "Limpiar entradas"
        Me.btnlentradas.UseVisualStyleBackColor = False
        '
        'btnllista
        '
        Me.btnllista.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnllista.Location = New System.Drawing.Point(104, 282)
        Me.btnllista.Name = "btnllista"
        Me.btnllista.Size = New System.Drawing.Size(109, 37)
        Me.btnllista.TabIndex = 14
        Me.btnllista.Text = "Limpiar Lista"
        Me.btnllista.UseVisualStyleBackColor = False
        '
        'btnordenar
        '
        Me.btnordenar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnordenar.Location = New System.Drawing.Point(8, 282)
        Me.btnordenar.Name = "btnordenar"
        Me.btnordenar.Size = New System.Drawing.Size(90, 37)
        Me.btnordenar.TabIndex = 15
        Me.btnordenar.Text = "Ordenar"
        Me.btnordenar.UseVisualStyleBackColor = False
        '
        'tbe1
        '
        Me.tbe1.Enabled = False
        Me.tbe1.Location = New System.Drawing.Point(264, 38)
        Me.tbe1.Name = "tbe1"
        Me.tbe1.Size = New System.Drawing.Size(46, 28)
        Me.tbe1.TabIndex = 13
        '
        'tbrec3
        '
        Me.tbrec3.Enabled = False
        Me.tbrec3.Location = New System.Drawing.Point(124, 190)
        Me.tbrec3.Name = "tbrec3"
        Me.tbrec3.Size = New System.Drawing.Size(98, 28)
        Me.tbrec3.TabIndex = 14
        '
        'tbrec4
        '
        Me.tbrec4.Enabled = False
        Me.tbrec4.Location = New System.Drawing.Point(124, 226)
        Me.tbrec4.Name = "tbrec4"
        Me.tbrec4.Size = New System.Drawing.Size(98, 28)
        Me.tbrec4.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Pro Cycling"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Pro Team"
        '
        'tbt4
        '
        Me.tbt4.Enabled = False
        Me.tbt4.Location = New System.Drawing.Point(228, 226)
        Me.tbt4.Name = "tbt4"
        Me.tbt4.Size = New System.Drawing.Size(140, 28)
        Me.tbt4.TabIndex = 22
        '
        'tbt3
        '
        Me.tbt3.Enabled = False
        Me.tbt3.Location = New System.Drawing.Point(228, 190)
        Me.tbt3.Name = "tbt3"
        Me.tbt3.Size = New System.Drawing.Size(140, 28)
        Me.tbt3.TabIndex = 21
        '
        'tbt2
        '
        Me.tbt2.Enabled = False
        Me.tbt2.Location = New System.Drawing.Point(228, 156)
        Me.tbt2.Name = "tbt2"
        Me.tbt2.Size = New System.Drawing.Size(140, 28)
        Me.tbt2.TabIndex = 20
        '
        'tbt1
        '
        Me.tbt1.Enabled = False
        Me.tbt1.Location = New System.Drawing.Point(228, 120)
        Me.tbt1.Name = "tbt1"
        Me.tbt1.Size = New System.Drawing.Size(140, 28)
        Me.tbt1.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(246, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 47)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Tiempo"
        '
        'tbconsulta
        '
        Me.tbconsulta.Location = New System.Drawing.Point(71, 39)
        Me.tbconsulta.Name = "tbconsulta"
        Me.tbconsulta.Size = New System.Drawing.Size(153, 28)
        Me.tbconsulta.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Etapa, Me.Equipo, Me.Km, Me.Tiempo, Me.Nacionalidad, Me.Penalización, Me.Tiempot})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(976, 277)
        Me.DataGridView1.TabIndex = 14
        '
        'Etapa
        '
        Me.Etapa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Etapa.HeaderText = "Etapa"
        Me.Etapa.Name = "Etapa"
        '
        'Equipo
        '
        Me.Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        '
        'Km
        '
        Me.Km.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Km.HeaderText = "Kilometros Recorridos"
        Me.Km.Name = "Km"
        '
        'Tiempo
        '
        Me.Tiempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tiempo.HeaderText = "Tiempo"
        Me.Tiempo.Name = "Tiempo"
        '
        'Nacionalidad
        '
        Me.Nacionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nacionalidad.HeaderText = "Nacionalidad"
        Me.Nacionalidad.Name = "Nacionalidad"
        '
        'Penalización
        '
        Me.Penalización.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Penalización.HeaderText = "Penalización"
        Me.Penalización.Name = "Penalización"
        '
        'Tiempot
        '
        Me.Tiempot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tiempot.HeaderText = "Tiempo Total"
        Me.Tiempot.Name = "Tiempot"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsalir.Location = New System.Drawing.Point(897, 649)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(100, 37)
        Me.btnsalir.TabIndex = 23
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 690)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Ciclistas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnordenar As Button
    Friend WithEvents btnllista As Button
    Friend WithEvents btnlentradas As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents tbtiempo As TextBox
    Friend WithEvents tbrecorrido As TextBox
    Friend WithEvents rbext As RadioButton
    Friend WithEvents rbgua As RadioButton
    Friend WithEvents cbequipo As ComboBox
    Friend WithEvents cbetapa As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbconsulta As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btnconsultar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbt4 As TextBox
    Friend WithEvents tbt3 As TextBox
    Friend WithEvents tbt2 As TextBox
    Friend WithEvents tbt1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbrec4 As TextBox
    Friend WithEvents tbrec3 As TextBox
    Friend WithEvents tbe1 As TextBox
    Friend WithEvents btnlestadisticas As Button
    Friend WithEvents btnestadisticas As Button
    Friend WithEvents tbrec2 As TextBox
    Friend WithEvents tbrec1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Etapa As DataGridViewTextBoxColumn
    Friend WithEvents Equipo As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo As DataGridViewTextBoxColumn
    Friend WithEvents Nacionalidad As DataGridViewTextBoxColumn
    Friend WithEvents Penalización As DataGridViewTextBoxColumn
    Friend WithEvents Tiempot As DataGridViewTextBoxColumn
    Friend WithEvents btnsalir As Button
End Class
