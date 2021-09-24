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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbsueldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbdescuento = New System.Windows.Forms.ComboBox()
        Me.lbnombre = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbsueldob = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbdescuento = New System.Windows.Forms.ListBox()
        Me.lbsueldon = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbdescuentoq = New System.Windows.Forms.ListBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL EMPLEADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SUELDO BRUTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESCUENTOS"
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(243, 22)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(236, 26)
        Me.tbnombre.TabIndex = 3
        '
        'tbsueldo
        '
        Me.tbsueldo.Location = New System.Drawing.Point(299, 59)
        Me.tbsueldo.Name = "tbsueldo"
        Me.tbsueldo.Size = New System.Drawing.Size(127, 26)
        Me.tbsueldo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Q. "
        '
        'cbdescuento
        '
        Me.cbdescuento.FormattingEnabled = True
        Me.cbdescuento.Items.AddRange(New Object() {"IGSS", "ISR"})
        Me.cbdescuento.Location = New System.Drawing.Point(299, 109)
        Me.cbdescuento.Name = "cbdescuento"
        Me.cbdescuento.Size = New System.Drawing.Size(121, 27)
        Me.cbdescuento.TabIndex = 6
        '
        'lbnombre
        '
        Me.lbnombre.FormattingEnabled = True
        Me.lbnombre.ItemHeight = 19
        Me.lbnombre.Location = New System.Drawing.Point(4, 196)
        Me.lbnombre.Name = "lbnombre"
        Me.lbnombre.Size = New System.Drawing.Size(207, 194)
        Me.lbnombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NOMBRE DEL EMPLEADO"
        '
        'lbsueldob
        '
        Me.lbsueldob.FormattingEnabled = True
        Me.lbsueldob.ItemHeight = 19
        Me.lbsueldob.Location = New System.Drawing.Point(224, 196)
        Me.lbsueldob.Name = "lbsueldob"
        Me.lbsueldob.Size = New System.Drawing.Size(155, 194)
        Me.lbsueldob.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SUELDO BRUTO"
        '
        'lbdescuento
        '
        Me.lbdescuento.FormattingEnabled = True
        Me.lbdescuento.ItemHeight = 19
        Me.lbdescuento.Location = New System.Drawing.Point(406, 196)
        Me.lbdescuento.Name = "lbdescuento"
        Me.lbdescuento.Size = New System.Drawing.Size(155, 194)
        Me.lbdescuento.TabIndex = 11
        '
        'lbsueldon
        '
        Me.lbsueldon.FormattingEnabled = True
        Me.lbsueldon.ItemHeight = 19
        Me.lbsueldon.Location = New System.Drawing.Point(757, 196)
        Me.lbsueldon.Name = "lbsueldon"
        Me.lbsueldon.Size = New System.Drawing.Size(155, 194)
        Me.lbsueldon.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "DESCUENTOS %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(753, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "SUELDO NETO Q"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(597, 174)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "DESCUENTOS Q"
        '
        'lbdescuentoq
        '
        Me.lbdescuentoq.FormattingEnabled = True
        Me.lbdescuentoq.ItemHeight = 19
        Me.lbdescuentoq.Location = New System.Drawing.Point(586, 196)
        Me.lbdescuentoq.Name = "lbdescuentoq"
        Me.lbdescuentoq.Size = New System.Drawing.Size(155, 194)
        Me.lbdescuentoq.TabIndex = 15
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.Red
        Me.btncalcular.Location = New System.Drawing.Point(638, 12)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(143, 52)
        Me.btncalcular.TabIndex = 17
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(638, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 52)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "LIMPIAR VECTORES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(921, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbdescuentoq)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbsueldon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbdescuento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbsueldob)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbnombre)
        Me.Controls.Add(Me.cbdescuento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbsueldo)
        Me.Controls.Add(Me.tbnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "PLANILLA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents tbsueldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbdescuento As ComboBox
    Friend WithEvents lbnombre As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbsueldob As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbdescuento As ListBox
    Friend WithEvents lbsueldon As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbdescuentoq As ListBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents Button1 As Button
End Class
