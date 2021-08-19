<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chkmonetario = New System.Windows.Forms.RadioButton()
        Me.chkmonetariop = New System.Windows.Forms.RadioButton()
        Me.chkahorro = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.efectivo = New System.Windows.Forms.TextBox()
        Me.chequeo = New System.Windows.Forms.TextBox()
        Me.cheque = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.saldoant = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkmonetario
        '
        Me.chkmonetario.AutoSize = True
        Me.chkmonetario.BackColor = System.Drawing.Color.Transparent
        Me.chkmonetario.Location = New System.Drawing.Point(16, 28)
        Me.chkmonetario.Name = "chkmonetario"
        Me.chkmonetario.Size = New System.Drawing.Size(90, 17)
        Me.chkmonetario.TabIndex = 0
        Me.chkmonetario.Text = "MONETARIO"
        Me.chkmonetario.UseVisualStyleBackColor = False
        '
        'chkmonetariop
        '
        Me.chkmonetariop.AutoSize = True
        Me.chkmonetariop.Location = New System.Drawing.Point(16, 51)
        Me.chkmonetariop.Name = "chkmonetariop"
        Me.chkmonetariop.Size = New System.Drawing.Size(142, 17)
        Me.chkmonetariop.TabIndex = 1
        Me.chkmonetariop.Text = "MONETARIO PREMIER"
        Me.chkmonetariop.UseVisualStyleBackColor = True
        '
        'chkahorro
        '
        Me.chkahorro.AutoSize = True
        Me.chkahorro.Location = New System.Drawing.Point(16, 74)
        Me.chkahorro.Name = "chkahorro"
        Me.chkahorro.Size = New System.Drawing.Size(72, 17)
        Me.chkahorro.TabIndex = 2
        Me.chkahorro.Text = "AHORRO"
        Me.chkahorro.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkmonetario)
        Me.GroupBox1.Controls.Add(Me.chkahorro)
        Me.GroupBox1.Controls.Add(Me.chkmonetariop)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(211, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 114)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE DEPOSITO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(404, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 114)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEPOSITO EN:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CHEQUE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 51)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(163, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CHEQUE DE OTRO BANCO"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 74)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "EFECTIVO"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cheque)
        Me.GroupBox3.Controls.Add(Me.chequeo)
        Me.GroupBox3.Controls.Add(Me.efectivo)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(579, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 114)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INGRESE EL MONTO EN Q"
        '
        'efectivo
        '
        Me.efectivo.Location = New System.Drawing.Point(7, 74)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(132, 20)
        Me.efectivo.TabIndex = 0
        Me.efectivo.Visible = False
        '
        'chequeo
        '
        Me.chequeo.Location = New System.Drawing.Point(7, 51)
        Me.chequeo.Name = "chequeo"
        Me.chequeo.Size = New System.Drawing.Size(132, 20)
        Me.chequeo.TabIndex = 1
        Me.chequeo.Visible = False
        '
        'cheque
        '
        Me.cheque.Location = New System.Drawing.Point(7, 28)
        Me.cheque.Name = "cheque"
        Me.cheque.Size = New System.Drawing.Size(132, 20)
        Me.cheque.TabIndex = 2
        Me.cheque.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.saldoant)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 114)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "INGRESE EL SALDO ANTERIOR EN Q"
        '
        'saldoant
        '
        Me.saldoant.Location = New System.Drawing.Point(7, 51)
        Me.saldoant.Name = "saldoant"
        Me.saldoant.Size = New System.Drawing.Size(132, 20)
        Me.saldoant.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(23, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 43)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(309, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(586, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 43)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(767, 212)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "DEPOSITOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkmonetario As RadioButton
    Friend WithEvents chkmonetariop As RadioButton
    Friend WithEvents chkahorro As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cheque As TextBox
    Friend WithEvents chequeo As TextBox
    Friend WithEvents efectivo As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents saldoant As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
