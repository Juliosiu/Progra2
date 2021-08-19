
Module Module1
    Public saldonuevo As Double
    Public interes As Decimal
    Public saldonuevo2 As Decimal
    Public intereses As Decimal

    Sub limpiar()
        Form1.chkmonetario.Checked = False
        Form1.chkahorro.Checked = False
        Form1.chkmonetariop.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.CheckBox1.Checked = False
        Form1.saldoant.Clear()
        Form2.TextBox1.Text = ""
        Form2.TextBox2.Text = ""
        Form2.TextBox3.Text = ""
    End Sub

    Sub salir()
        If (MsgBox("¿DESEA SALIR?", 36, "SALIR") = vbYes) Then
            End
        Else
            limpiar()
        End If
    End Sub
End Module
