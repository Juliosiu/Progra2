Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir?", vbYesNo, "SALR") = vbYes Then
            End
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiarvectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub OrdenarDescendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendentementeToolStripMenuItem.Click
        ordenar()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar()
    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        operar()
    End Sub
End Class
