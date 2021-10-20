Public Class Form1
    Dim a As Byte

    Private Sub rbdiversificado_CheckedChanged(sender As Object, e As EventArgs) Handles rbdiversificado.CheckedChanged
        If rbdiversificado.Checked = True Then
            cbcarrera.Visible = True
        Else
            cbcarrera.Visible = False
            cbcarrera.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnentradas_Click(sender As Object, e As EventArgs) Handles btnentradas.Click
        limpiarentradas()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        procesos()
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        mostrar()
    End Sub

    Private Sub btnmatriz_Click(sender As Object, e As EventArgs) Handles btnmatriz.Click
        limpiarmatriz()
    End Sub

    Private Sub btntotales_Click(sender As Object, e As EventArgs) Handles btntotales.Click
        totales()
    End Sub

    Private Sub btnltotales_Click(sender As Object, e As EventArgs) Handles btnltotales.Click
        Limpiartotales()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Desea salir?", vbYesNo, "SALIDA") = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim i As Byte
        For i = 0 To 5
            If matriz(DataGridView1.CurrentRow.Index, 0) <> Nothing Then
                matriz(DataGridView1.CurrentRow.Index, i) = Nothing
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            Else
                Exit For
            End If
        Next i
    End Sub
End Class
