Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (MsgBox("Desea regresar?", 36, "RETORNO") = vbYes) Then
            limpiar()
            Me.Hide()
            Form1.Show()
        Else
            Exit Sub
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MsgBox("Desea salir?", 36, "SALIDA") = vbYes) Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class