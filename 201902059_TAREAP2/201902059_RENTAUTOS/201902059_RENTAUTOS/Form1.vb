Public Class Form1

    Private Sub PROCESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESARToolStripMenuItem.Click
        calcular()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiarvectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("Desea salir?", vbYesNo + vbQuestion, "SALIR") = vbYes) Then
            End
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label6.Visible = True
            TextBox4.Visible = True
            TextBox4.Focus()
        Else
            Label6.Visible = True
            TextBox4.Visible = True
            TextBox4.Clear()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label7.Visible = True
            TextBox5.Visible = True
            TextBox5.Focus()
        Else
            Label7.Visible = True
            TextBox5.Visible = True
            TextBox5.Clear()
        End If
    End Sub
End Class
