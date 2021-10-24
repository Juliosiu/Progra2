Public Class Form1
    Private Sub CálculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoToolStripMenuItem.Click
        calculo()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        consultar()
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        estadisticas()
    End Sub

    Private Sub EstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem.Click
        limpiarestadisticas()
    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        limpiarmatriz()
    End Sub

    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        If MsgBox("Desea salir?", vbYesNo, "SALR") = vbYes Then
            End
        End If
    End Sub
End Class
