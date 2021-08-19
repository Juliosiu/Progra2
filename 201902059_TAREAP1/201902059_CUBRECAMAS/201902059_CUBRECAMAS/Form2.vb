Public Class Form2
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click

        Me.Hide()
        Form1.Show()
        limpiar()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If (MsgBox("¿DESEA SALIR?", 36, "SALIR") = vbYes) Then
            End
        End If
    End Sub
End Class