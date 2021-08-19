Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cheque.Visible = True
            cheque.Focus()
        Else
            cheque.Visible = False
            cheque.Clear()
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            chequeo.Visible = True
            chequeo.Focus()
        Else
            chequeo.Visible = False
            chequeo.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            efectivo.Visible = True
            efectivo.Focus()
        Else
            efectivo.Visible = False
            efectivo.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        saldonuevo = Val(saldoant.Text) + Val(cheque.Text) + Val(chequeo.Text) + Val(efectivo.Text)


        If chkahorro.Checked Or chkmonetario.Checked Or chkmonetariop.Checked Then
            If chkahorro.Checked Then
                Select Case saldonuevo
                    Case Is < 1001
                        interes = 1.5 / 100
                    Case Is < 5001
                        interes = 2.5 / 100
                    Case Is < 15001
                        interes = 7.5 / 100
                    Case Is >= 15001
                        interes = 10 / 100
                End Select
            ElseIf chkmonetariop.Checked Then
                Select Case Val(saldoant.Text)
                    Case Is < 10001
                        interes = 2.5 / 100
                    Case Is < 15001
                        interes = 3 / 100
                    Case Is >= 15001
                        interes = 4.5 / 100
                End Select
            Else interes = 0
            End If
        Else MsgBox("Seleccione una de las 3 opciones", 48, "SELECCIONAR")
            Exit Sub
        End If



        If chkahorro.Checked Then
            intereses = saldonuevo * (interes)
        ElseIf chkmonetariop.Checked Then
            intereses = Val(saldoant.Text) * interes
        Else
            intereses = 0
        End If

        saldonuevo2 = saldonuevo + intereses
        Form2.TextBox1.Text = Math.Round(saldonuevo, 2)
        Form2.TextBox2.Text = Math.Round(intereses, 2)
        Form2.TextBox3.Text = Math.Round(saldonuevo2, 2)
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        salir()
    End Sub
End Class
