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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbnorte = New System.Windows.Forms.RadioButton()
        Me.rbsur = New System.Windows.Forms.RadioButton()
        Me.rboriente = New System.Windows.Forms.RadioButton()
        Me.rboccidente = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbcomision = New System.Windows.Forms.RadioButton()
        Me.rbbono = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESE DATOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "VENTAS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 21)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 21)
        Me.TextBox2.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.rboccidente)
        Me.GroupBox2.Controls.Add(Me.rboriente)
        Me.GroupBox2.Controls.Add(Me.rbsur)
        Me.GroupBox2.Controls.Add(Me.rbnorte)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(307, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "REGION DEL PAIS"
        '
        'rbnorte
        '
        Me.rbnorte.AutoSize = True
        Me.rbnorte.Location = New System.Drawing.Point(18, 29)
        Me.rbnorte.Name = "rbnorte"
        Me.rbnorte.Size = New System.Drawing.Size(72, 19)
        Me.rbnorte.TabIndex = 0
        Me.rbnorte.TabStop = True
        Me.rbnorte.Text = "NORTE"
        Me.rbnorte.UseVisualStyleBackColor = True
        '
        'rbsur
        '
        Me.rbsur.AutoSize = True
        Me.rbsur.Location = New System.Drawing.Point(18, 62)
        Me.rbsur.Name = "rbsur"
        Me.rbsur.Size = New System.Drawing.Size(54, 19)
        Me.rbsur.TabIndex = 1
        Me.rbsur.TabStop = True
        Me.rbsur.Text = "SUR"
        Me.rbsur.UseVisualStyleBackColor = True
        '
        'rboriente
        '
        Me.rboriente.AutoSize = True
        Me.rboriente.Location = New System.Drawing.Point(129, 29)
        Me.rboriente.Name = "rboriente"
        Me.rboriente.Size = New System.Drawing.Size(85, 19)
        Me.rboriente.TabIndex = 2
        Me.rboriente.TabStop = True
        Me.rboriente.Text = "ORIENTE"
        Me.rboriente.UseVisualStyleBackColor = True
        '
        'rboccidente
        '
        Me.rboccidente.AutoSize = True
        Me.rboccidente.Location = New System.Drawing.Point(129, 63)
        Me.rboccidente.Name = "rboccidente"
        Me.rboccidente.Size = New System.Drawing.Size(103, 19)
        Me.rboccidente.TabIndex = 3
        Me.rboccidente.TabStop = True
        Me.rboccidente.Text = "OCCIDENTE"
        Me.rboccidente.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.rbcomision)
        Me.GroupBox3.Controls.Add(Me.rbbono)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(278, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INCENTIVO"
        '
        'rbcomision
        '
        Me.rbcomision.AutoSize = True
        Me.rbcomision.Location = New System.Drawing.Point(18, 62)
        Me.rbcomision.Name = "rbcomision"
        Me.rbcomision.Size = New System.Drawing.Size(93, 19)
        Me.rbcomision.TabIndex = 1
        Me.rbcomision.TabStop = True
        Me.rbcomision.Text = "COMISION"
        Me.rbcomision.UseVisualStyleBackColor = True
        '
        'rbbono
        '
        Me.rbbono.AutoSize = True
        Me.rbbono.Location = New System.Drawing.Point(18, 29)
        Me.rbbono.Name = "rbbono"
        Me.rbbono.Size = New System.Drawing.Size(64, 19)
        Me.rbbono.TabIndex = 0
        Me.rbbono.TabStop = True
        Me.rbbono.Text = "BONO"
        Me.rbbono.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(386, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(386, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(386, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 34)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 251)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "COMPUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rboccidente As RadioButton
    Friend WithEvents rboriente As RadioButton
    Friend WithEvents rbsur As RadioButton
    Friend WithEvents rbnorte As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbcomision As RadioButton
    Friend WithEvents rbbono As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
