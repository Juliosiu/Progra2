Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbetapa.Items.Add("1")
        cbetapa.Items.Add("2")
        cbetapa.Items.Add("3")
        cbetapa.Items.Add("4")
        cbetapa.Items.Add("5")
        cbetapa.Items.Add("6")
        cbetapa.Items.Add("7")
        cbetapa.Items.Add("8")
        cbetapa.Items.Add("9")
        cbetapa.Items.Add("10")
        cbetapa.Items.Add("11")
        cbetapa.Items.Add("12")

        cbequipo.Items.Add("Sky")
        cbequipo.Items.Add("Movistar")
        cbequipo.Items.Add("Pro Cycling")
        cbequipo.Items.Add("Pro Team")
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        guardar()
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        mostrar()
    End Sub

    Private Sub btnlentradas_Click(sender As Object, e As EventArgs) Handles btnlentradas.Click
        limpiarentradas()
    End Sub

    Private Sub btnllista_Click(sender As Object, e As EventArgs) Handles btnllista.Click
        limpiarvectores()
    End Sub

    Private Sub btnestadisticas_Click(sender As Object, e As EventArgs) Handles btnestadisticas.Click
        estadisticas()
    End Sub

    Private Sub btnlestadisticas_Click(sender As Object, e As EventArgs) Handles btnlestadisticas.Click
        limpiarestadisticas()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        consultar()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        actualizar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        eliminar()
    End Sub

    Private Sub btnordenar_Click(sender As Object, e As EventArgs) Handles btnordenar.Click
        ordenar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Desea salir?", vbYesNo, "SALR") = vbYes Then
            End
        End If
    End Sub
End Class
