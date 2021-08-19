Public Class Form1

    Const parroz As Double = 2
    Const pfrijol As Double = 1.75
    Const pazucar As Double = 2.5
    Const desc1 As Double = 0.025
    Const desc2 As Double = 0.03

    Dim total1, totaliva, pparcial, descuento1, descuento2, pfinal, descuentot As Double

    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click

        total1 = Val(txtarroz.Text) * parroz + Val(txtfrijol.Text) * pfrijol + Val(txtazucar.Text) * pazucar
        TextBox1.Text = "Q. " & Math.Round(total1, 2)

        totaliva = total1 * 0.12
        TextBox2.Text = "Q. " & Math.Round(totaliva, 2)

        pparcial = total1 + totaliva
        TextBox3.Text = "Q. " & Math.Round(pparcial, 2)

        If pparcial > 15 Then descuento1 = pparcial * desc1 Else descuento1 = 0
        TextBox4.Text = "Q. " & Math.Round(descuento1, 2)

        If Val(txtfrijol.Text) > 5 Then descuento2 = pparcial * desc2 Else descuento2 = 0
        TextBox5.Text = "Q. " & Math.Round(descuento2, 2)

        pfinal = pparcial - descuento1 - descuento2
        TextBox6.Text = "Q. " & Math.Round(pfinal, 2)

        descuentot = descuento1 + descuento2
        Label7.Text = "Gracias por su compra, usted ha ahorrado un total de: Q. " & Math.Round(descuentot, 2)
        Label8.Text = "El total a cancelar es de Q. " & Math.Round(pfinal, 2)
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()

        txtarroz.Text = "0"
        txtazucar.Text = "0"
        txtfrijol.Text = "0"
        txtarroz.Focus()
        TextBox1.Text = "Q. 0"
        TextBox2.Text = "Q. 0"
        TextBox3.Text = "Q. 0"
        TextBox4.Text = "Q. 0"
        TextBox5.Text = "Q. 0"
        TextBox6.Text = "Q. 0"
        Label7.Text = ""
        Label8.Text = ""
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        If (MsgBox("DESEA SALIR?", 36, "SALIR DEL PROGRAMA") = vbYes) Then
            Me.Close()
        Else
            Limpiar()
        End If
    End Sub

End Class
