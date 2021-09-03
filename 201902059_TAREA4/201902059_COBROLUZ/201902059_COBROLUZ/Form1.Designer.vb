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
        Me.cbservicio = New System.Windows.Forms.ComboBox()
        Me.cbtarifa = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtanterior = New System.Windows.Forms.TextBox()
        Me.txtconsumo = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnentradas = New System.Windows.Forms.Button()
        Me.btnlistas = New System.Windows.Forms.Button()
        Me.btnvectores = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(319, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(362, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(218, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SALDO ANTERIOR Q."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(167, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONSUMO DEL MES EN kW"
        '
        'cbservicio
        '
        Me.cbservicio.FormattingEnabled = True
        Me.cbservicio.Items.AddRange(New Object() {"RESIDENCIAL", "INDUSTRIAL"})
        Me.cbservicio.Location = New System.Drawing.Point(415, 168)
        Me.cbservicio.Name = "cbservicio"
        Me.cbservicio.Size = New System.Drawing.Size(193, 26)
        Me.cbservicio.TabIndex = 4
        Me.cbservicio.Text = "SELECCIONE UNO"
        '
        'cbtarifa
        '
        Me.cbtarifa.FormattingEnabled = True
        Me.cbtarifa.Items.AddRange(New Object() {"SOCIAL", "NO SOCIAL"})
        Me.cbtarifa.Location = New System.Drawing.Point(417, 215)
        Me.cbtarifa.Name = "cbtarifa"
        Me.cbtarifa.Size = New System.Drawing.Size(192, 26)
        Me.cbtarifa.TabIndex = 5
        Me.cbtarifa.Text = "SELECCIONE UNO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(233, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TIPO DE SERVICIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(251, 215)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "TIPO DE TARIFA"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(415, 17)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(193, 25)
        Me.txtnombre.TabIndex = 8
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(416, 55)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(193, 25)
        Me.txtnit.TabIndex = 9
        '
        'txtanterior
        '
        Me.txtanterior.Location = New System.Drawing.Point(416, 93)
        Me.txtanterior.Name = "txtanterior"
        Me.txtanterior.Size = New System.Drawing.Size(193, 25)
        Me.txtanterior.TabIndex = 10
        '
        'txtconsumo
        '
        Me.txtconsumo.Location = New System.Drawing.Point(416, 127)
        Me.txtconsumo.Name = "txtconsumo"
        Me.txtconsumo.Size = New System.Drawing.Size(193, 25)
        Me.txtconsumo.TabIndex = 11
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(849, 36)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(127, 65)
        Me.btncalcular.TabIndex = 12
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnentradas
        '
        Me.btnentradas.Location = New System.Drawing.Point(716, 107)
        Me.btnentradas.Name = "btnentradas"
        Me.btnentradas.Size = New System.Drawing.Size(127, 61)
        Me.btnentradas.TabIndex = 13
        Me.btnentradas.Text = "LIMPIAR ENTRADAS"
        Me.btnentradas.UseVisualStyleBackColor = True
        '
        'btnlistas
        '
        Me.btnlistas.Location = New System.Drawing.Point(849, 107)
        Me.btnlistas.Name = "btnlistas"
        Me.btnlistas.Size = New System.Drawing.Size(127, 61)
        Me.btnlistas.TabIndex = 14
        Me.btnlistas.Text = "LIMPIAR LISTAS"
        Me.btnlistas.UseVisualStyleBackColor = True
        '
        'btnvectores
        '
        Me.btnvectores.Location = New System.Drawing.Point(982, 107)
        Me.btnvectores.Name = "btnvectores"
        Me.btnvectores.Size = New System.Drawing.Size(127, 61)
        Me.btnvectores.TabIndex = 15
        Me.btnvectores.Text = "LIMPIAR VECTORES"
        Me.btnvectores.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(849, 174)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(127, 67)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(16, 311)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 225)
        Me.ListBox1.TabIndex = 17
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(142, 311)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(114, 225)
        Me.ListBox2.TabIndex = 18
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 17
        Me.ListBox3.Location = New System.Drawing.Point(262, 311)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(124, 225)
        Me.ListBox3.TabIndex = 19
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 17
        Me.ListBox4.Location = New System.Drawing.Point(392, 311)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(137, 225)
        Me.ListBox4.TabIndex = 20
        '
        'ListBox5
        '
        Me.ListBox5.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 17
        Me.ListBox5.Location = New System.Drawing.Point(535, 311)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(136, 225)
        Me.ListBox5.TabIndex = 21
        '
        'ListBox6
        '
        Me.ListBox6.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 17
        Me.ListBox6.Location = New System.Drawing.Point(677, 311)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(135, 225)
        Me.ListBox6.TabIndex = 22
        '
        'ListBox7
        '
        Me.ListBox7.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 17
        Me.ListBox7.Location = New System.Drawing.Point(818, 311)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(136, 225)
        Me.ListBox7.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(259, 265)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "SERVICIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(389, 265)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "TARIFA"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(543, 265)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 40)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "SALDO ANTERIOR"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(673, 265)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 40)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "PAGO INICIAL"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(816, 265)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "MORA"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(958, 265)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "DESCUENTO"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(1099, 265)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "PAGO TOTAL"
        '
        'ListBox8
        '
        Me.ListBox8.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 17
        Me.ListBox8.Location = New System.Drawing.Point(960, 311)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(136, 225)
        Me.ListBox8.TabIndex = 31
        '
        'ListBox9
        '
        Me.ListBox9.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 17
        Me.ListBox9.Location = New System.Drawing.Point(1102, 311)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(136, 225)
        Me.ListBox9.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(158, 265)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 18)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "NIT"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(14, 265)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "NOMBRE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1231, 536)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnvectores)
        Me.Controls.Add(Me.btnlistas)
        Me.Controls.Add(Me.btnentradas)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtconsumo)
        Me.Controls.Add(Me.txtanterior)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbtarifa)
        Me.Controls.Add(Me.cbservicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "COBRO LUZ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbservicio As ComboBox
    Friend WithEvents cbtarifa As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents txtanterior As TextBox
    Friend WithEvents txtconsumo As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnentradas As Button
    Friend WithEvents btnlistas As Button
    Friend WithEvents btnvectores As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
