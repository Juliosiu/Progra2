Public Class CINE
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        calcular()
    End Sub

    Private Sub btnlimpiarlistas_Click(sender As Object, e As EventArgs) Handles btnlimpiarlistas.Click
        limpiarlistas()
    End Sub

    Private Sub btnlimpiarvectores_Click(sender As Object, e As EventArgs) Handles btnlimpiarvectores.Click
        limpiarvectores()
    End Sub

    Private Sub btnlimpiarentradas_Click(sender As Object, e As EventArgs) Handles btnlimpiarentradas.Click
        limpiarentradas()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If (MsgBox("Desea salir?", vbYesNo + vbQuestion, "SALIR") = vbYes) Then
            End
        End If
    End Sub
End Class
