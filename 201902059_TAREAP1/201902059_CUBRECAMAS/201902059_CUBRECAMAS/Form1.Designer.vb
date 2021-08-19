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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbking = New System.Windows.Forms.RadioButton()
        Me.rbqueen = New System.Windows.Forms.RadioButton()
        Me.rbmatrimonial = New System.Windows.Forms.RadioButton()
        Me.rbimperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkhilo = New System.Windows.Forms.CheckBox()
        Me.chkseda = New System.Windows.Forms.CheckBox()
        Me.chkalgodon = New System.Windows.Forms.CheckBox()
        Me.chklino = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbking)
        Me.GroupBox1.Controls.Add(Me.rbqueen)
        Me.GroupBox1.Controls.Add(Me.rbmatrimonial)
        Me.GroupBox1.Controls.Add(Me.rbimperial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO DE CUBRECAMA"
        '
        'rbking
        '
        Me.rbking.AutoSize = True
        Me.rbking.Location = New System.Drawing.Point(21, 135)
        Me.rbking.Name = "rbking"
        Me.rbking.Size = New System.Drawing.Size(58, 19)
        Me.rbking.TabIndex = 3
        Me.rbking.Text = "KING"
        Me.rbking.UseVisualStyleBackColor = True
        '
        'rbqueen
        '
        Me.rbqueen.AutoSize = True
        Me.rbqueen.Location = New System.Drawing.Point(21, 97)
        Me.rbqueen.Name = "rbqueen"
        Me.rbqueen.Size = New System.Drawing.Size(73, 19)
        Me.rbqueen.TabIndex = 2
        Me.rbqueen.Text = "QUEEN"
        Me.rbqueen.UseVisualStyleBackColor = True
        '
        'rbmatrimonial
        '
        Me.rbmatrimonial.AutoSize = True
        Me.rbmatrimonial.Location = New System.Drawing.Point(21, 60)
        Me.rbmatrimonial.Name = "rbmatrimonial"
        Me.rbmatrimonial.Size = New System.Drawing.Size(119, 19)
        Me.rbmatrimonial.TabIndex = 1
        Me.rbmatrimonial.Text = "MATRIMONIAL"
        Me.rbmatrimonial.UseVisualStyleBackColor = True
        '
        'rbimperial
        '
        Me.rbimperial.AutoSize = True
        Me.rbimperial.Location = New System.Drawing.Point(21, 35)
        Me.rbimperial.Name = "rbimperial"
        Me.rbimperial.Size = New System.Drawing.Size(89, 19)
        Me.rbimperial.TabIndex = 0
        Me.rbimperial.Text = "IMPERIAL"
        Me.rbimperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chkhilo)
        Me.GroupBox2.Controls.Add(Me.chkseda)
        Me.GroupBox2.Controls.Add(Me.chkalgodon)
        Me.GroupBox2.Controls.Add(Me.chklino)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(235, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 173)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE MATERIAL"
        '
        'chkhilo
        '
        Me.chkhilo.AutoSize = True
        Me.chkhilo.Location = New System.Drawing.Point(24, 136)
        Me.chkhilo.Name = "chkhilo"
        Me.chkhilo.Size = New System.Drawing.Size(111, 19)
        Me.chkhilo.TabIndex = 3
        Me.chkhilo.Text = "HILO CRUDO"
        Me.chkhilo.UseVisualStyleBackColor = True
        '
        'chkseda
        '
        Me.chkseda.AutoSize = True
        Me.chkseda.Location = New System.Drawing.Point(24, 97)
        Me.chkseda.Name = "chkseda"
        Me.chkseda.Size = New System.Drawing.Size(62, 19)
        Me.chkseda.TabIndex = 2
        Me.chkseda.Text = "SEDA"
        Me.chkseda.UseVisualStyleBackColor = True
        '
        'chkalgodon
        '
        Me.chkalgodon.AutoSize = True
        Me.chkalgodon.Location = New System.Drawing.Point(24, 61)
        Me.chkalgodon.Name = "chkalgodon"
        Me.chkalgodon.Size = New System.Drawing.Size(92, 19)
        Me.chkalgodon.TabIndex = 1
        Me.chkalgodon.Text = "ALGODÓN"
        Me.chkalgodon.UseVisualStyleBackColor = True
        '
        'chklino
        '
        Me.chklino.AutoSize = True
        Me.chklino.Location = New System.Drawing.Point(24, 35)
        Me.chklino.Name = "chklino"
        Me.chklino.Size = New System.Drawing.Size(58, 19)
        Me.chklino.TabIndex = 0
        Me.chklino.Text = "LINO"
        Me.chklino.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(458, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 173)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CANTIDAD DE YARDAS"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(70, 133)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(79, 21)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(70, 95)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(79, 21)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(70, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 21)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 21)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Visible = False
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.Aqua
        Me.btncalcular.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(33, 212)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(144, 63)
        Me.btncalcular.TabIndex = 6
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.Aqua
        Me.btnlimpiar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(268, 212)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(144, 63)
        Me.btnlimpiar.TabIndex = 7
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Aqua
        Me.btnsalir.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(492, 212)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(144, 63)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(687, 300)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CUBRECAMAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbking As RadioButton
    Friend WithEvents rbqueen As RadioButton
    Friend WithEvents rbmatrimonial As RadioButton
    Friend WithEvents rbimperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkhilo As CheckBox
    Friend WithEvents chkseda As CheckBox
    Friend WithEvents chkalgodon As CheckBox
    Friend WithEvents chklino As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
End Class
