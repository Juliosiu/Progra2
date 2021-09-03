Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnombre.Focus()
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        calcular()
    End Sub

    Private Sub btnentradas_Click(sender As Object, e As EventArgs) Handles btnentradas.Click
        limpiar_entradas()

    End Sub

    Private Sub btnlistas_Click(sender As Object, e As EventArgs) Handles btnlistas.Click
        limpiar_listas()
    End Sub

    Private Sub btnvectores_Click(sender As Object, e As EventArgs) Handles btnvectores.Click
        limpiar_vectores()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If (MsgBox("Desea salir?", vbYesNo + vbQuestion, "SALIR") = vbYes) Then
            End
        End If
    End Sub
End Class
