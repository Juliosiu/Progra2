<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CINE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CINE))
        Me.cbcine = New System.Windows.Forms.ComboBox()
        Me.cbfuncion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbsub = New System.Windows.Forms.ListBox()
        Me.lbdesc1 = New System.Windows.Forms.ListBox()
        Me.lbdesc2 = New System.Windows.Forms.ListBox()
        Me.lbtotal = New System.Windows.Forms.ListBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnlimpiarlistas = New System.Windows.Forms.Button()
        Me.btnlimpiarentradas = New System.Windows.Forms.Button()
        Me.btnlimpiarvectores = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbcine
        '
        Me.cbcine.FormattingEnabled = True
        Me.cbcine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbcine.Location = New System.Drawing.Point(282, 42)
        Me.cbcine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbcine.Name = "cbcine"
        Me.cbcine.Size = New System.Drawing.Size(180, 27)
        Me.cbcine.TabIndex = 0
        '
        'cbfuncion
        '
        Me.cbfuncion.FormattingEnabled = True
        Me.cbfuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbfuncion.Location = New System.Drawing.Point(282, 99)
        Me.cbfuncion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbfuncion.Name = "cbfuncion"
        Me.cbfuncion.Size = New System.Drawing.Size(180, 27)
        Me.cbfuncion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INGRESE CINE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INGRESE FUNCION"
        '
        'tbcantidad
        '
        Me.tbcantidad.Location = New System.Drawing.Point(328, 165)
        Me.tbcantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbcantidad.Name = "tbcantidad"
        Me.tbcantidad.Size = New System.Drawing.Size(57, 26)
        Me.tbcantidad.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INGRESE CANTIDAD DE BOLETOS"
        '
        'lbsub
        '
        Me.lbsub.FormattingEnabled = True
        Me.lbsub.ItemHeight = 19
        Me.lbsub.Location = New System.Drawing.Point(340, 250)
        Me.lbsub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbsub.Name = "lbsub"
        Me.lbsub.Size = New System.Drawing.Size(105, 213)
        Me.lbsub.TabIndex = 6
        '
        'lbdesc1
        '
        Me.lbdesc1.FormattingEnabled = True
        Me.lbdesc1.ItemHeight = 19
        Me.lbdesc1.Location = New System.Drawing.Point(465, 250)
        Me.lbdesc1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbdesc1.Name = "lbdesc1"
        Me.lbdesc1.Size = New System.Drawing.Size(120, 213)
        Me.lbdesc1.TabIndex = 7
        '
        'lbdesc2
        '
        Me.lbdesc2.FormattingEnabled = True
        Me.lbdesc2.ItemHeight = 19
        Me.lbdesc2.Location = New System.Drawing.Point(593, 250)
        Me.lbdesc2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbdesc2.Name = "lbdesc2"
        Me.lbdesc2.Size = New System.Drawing.Size(115, 213)
        Me.lbdesc2.TabIndex = 8
        '
        'lbtotal
        '
        Me.lbtotal.FormattingEnabled = True
        Me.lbtotal.ItemHeight = 19
        Me.lbtotal.Location = New System.Drawing.Point(716, 250)
        Me.lbtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(104, 213)
        Me.lbtotal.TabIndex = 9
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Red
        Me.btnaceptar.Location = New System.Drawing.Point(579, 28)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(105, 49)
        Me.btnaceptar.TabIndex = 10
        Me.btnaceptar.Text = "ACEPTAR"
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnlimpiarlistas
        '
        Me.btnlimpiarlistas.BackColor = System.Drawing.Color.Red
        Me.btnlimpiarlistas.Location = New System.Drawing.Point(516, 83)
        Me.btnlimpiarlistas.Name = "btnlimpiarlistas"
        Me.btnlimpiarlistas.Size = New System.Drawing.Size(105, 51)
        Me.btnlimpiarlistas.TabIndex = 11
        Me.btnlimpiarlistas.Text = "LIMPIAR LISTAS"
        Me.btnlimpiarlistas.UseVisualStyleBackColor = False
        '
        'btnlimpiarentradas
        '
        Me.btnlimpiarentradas.BackColor = System.Drawing.Color.Red
        Me.btnlimpiarentradas.Location = New System.Drawing.Point(516, 140)
        Me.btnlimpiarentradas.Name = "btnlimpiarentradas"
        Me.btnlimpiarentradas.Size = New System.Drawing.Size(105, 51)
        Me.btnlimpiarentradas.TabIndex = 12
        Me.btnlimpiarentradas.Text = "LIMPIAR ENTRADAS"
        Me.btnlimpiarentradas.UseVisualStyleBackColor = False
        '
        'btnlimpiarvectores
        '
        Me.btnlimpiarvectores.BackColor = System.Drawing.Color.Red
        Me.btnlimpiarvectores.Location = New System.Drawing.Point(638, 83)
        Me.btnlimpiarvectores.Name = "btnlimpiarvectores"
        Me.btnlimpiarvectores.Size = New System.Drawing.Size(105, 51)
        Me.btnlimpiarvectores.TabIndex = 13
        Me.btnlimpiarvectores.Text = "LIMPIAR VECTORES"
        Me.btnlimpiarvectores.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Red
        Me.btnsalir.Location = New System.Drawing.Point(638, 140)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(105, 51)
        Me.btnsalir.TabIndex = 14
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 227)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "SUBTOTAL Q."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(451, 227)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DESCUENTO 1 Q."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(593, 227)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "DESCUENTO 2 Q."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(735, 227)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "TOTAL Q."
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(9, 250)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(107, 213)
        Me.ListBox1.TabIndex = 19
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 19
        Me.ListBox2.Location = New System.Drawing.Point(124, 250)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(103, 213)
        Me.ListBox2.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "CINE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 227)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "FUNCION"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 19
        Me.ListBox3.Location = New System.Drawing.Point(245, 250)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(83, 213)
        Me.ListBox3.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "BOLETOS"
        '
        'CINE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(825, 466)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiarvectores)
        Me.Controls.Add(Me.btnlimpiarentradas)
        Me.Controls.Add(Me.btnlimpiarlistas)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.lbdesc2)
        Me.Controls.Add(Me.lbdesc1)
        Me.Controls.Add(Me.lbsub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbcantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbfuncion)
        Me.Controls.Add(Me.cbcine)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CINE"
        Me.Text = "CINE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbcine As ComboBox
    Friend WithEvents cbfuncion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbcantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbsub As ListBox
    Friend WithEvents lbdesc1 As ListBox
    Friend WithEvents lbdesc2 As ListBox
    Friend WithEvents lbtotal As ListBox
    Friend WithEvents btnaceptar As Button
    Friend WithEvents btnlimpiarlistas As Button
    Friend WithEvents btnlimpiarentradas As Button
    Friend WithEvents btnlimpiarvectores As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label10 As Label
End Class
