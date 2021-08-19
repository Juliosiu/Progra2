Public Class Form1
    Private Sub chklino_CheckedChanged(sender As Object, e As EventArgs) Handles chklino.CheckedChanged
        If chklino.Checked Then
            TextBox1.Visible = True
            TextBox1.Focus()
        Else
            TextBox1.Visible = False
            TextBox1.Clear()
        End If
    End Sub

    Private Sub chkalgodon_CheckedChanged(sender As Object, e As EventArgs) Handles chkalgodon.CheckedChanged
        If chkalgodon.Checked Then
            TextBox2.Visible = True
            TextBox2.Focus()
        Else
            TextBox2.Visible = False
            TextBox2.Clear()
        End If
    End Sub

    Private Sub chkseda_CheckedChanged(sender As Object, e As EventArgs) Handles chkseda.CheckedChanged
        If chkseda.Checked Then
            TextBox3.Visible = True
            TextBox3.Focus()
        Else
            TextBox3.Visible = False
            TextBox3.Clear()
        End If
    End Sub

    Private Sub chkhilo_CheckedChanged(sender As Object, e As EventArgs) Handles chkhilo.CheckedChanged
        If chkhilo.Checked Then
            TextBox4.Visible = True
            TextBox4.Focus()
        Else
            TextBox4.Visible = False
            TextBox4.Clear()
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        If chklino.Checked Or chkalgodon.Checked Or chkseda.Checked Or chkhilo.Checked Then
            If chklino.Checked Then
                If (IsNumeric(TextBox1.Text) And Val(TextBox1.Text) > 0) Then
                    text1 = Val(TextBox1.Text)
                Else
                    MsgBox("CANTIDAD DE YARDAS NO VALIDO",, "ERROR")
                    TextBox1.Focus()
                    Exit Sub
                End If
            End If
            If chkalgodon.Checked Then
                If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text) > 0) Then
                    text2 = Val(TextBox2.Text)
                Else
                    MsgBox("CANTIDAD DE YARDAS NO VALIDO",, "ERROR")
                    TextBox2.Focus()
                    Exit Sub
                End If
            End If
            If chkseda.Checked Then
                If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text) > 0) Then
                    text3 = Val(TextBox3.Text)
                Else
                    MsgBox("CANTIDAD DE YARDAS NO VALIDO",, "ERROR")
                    TextBox3.Focus()
                    Exit Sub
                End If
            End If
            If chkhilo.Checked Then
                If (IsNumeric(TextBox4.Text) And Val(TextBox4.Text) > 0) Then
                    text4 = Val(TextBox4.Text)
                Else
                    MsgBox("CANTIDAD DE YARDAS NO VALIDO",, "ERROR")
                    TextBox4.Focus()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("NO SE HA SELECCIONADO EL MATERIAL",, "ERROR")
        End If

        yardas = text1 + text2 + text3 + text4

        If rbimperial.Checked Or rbking.Checked Or rbmatrimonial.Checked Or rbqueen.Checked Then

            If rbimperial.Checked Then
                manodeobra = moimperial

                If yardas = 3 Then
                    costo = (text1 * lino) + (text2 * algodon) + (text3 * seda) + (text4 * hilo)
                Else
                    MsgBox("No ha introducido la cantidad exacta de material (3)", 48, "CANTIDAD DE MATERIAL")
                    Exit Sub
                End If

            ElseIf rbmatrimonial.Checked Then
                manodeobra = momatrimonial
                If yardas = 5 Then
                    costo = (text1 * lino) + (text2 * algodon) + (text3 * seda) + (text4 * hilo)
                Else
                    MsgBox("No ha introducido la cantidad exacta de material (5)", 48, "CANTIDAD DE MATERIAL")
                    Exit Sub
                End If
            ElseIf rbqueen.Checked Then
                manodeobra = moqueen
                If yardas = 6 Then
                    costo = (text1 * lino) + (text2 * algodon) + (text3 * seda) + (text4 * hilo)
                Else
                    MsgBox("No ha introducido la cantidad exacta de material (6)", 48, "CANTIDAD DE MATERIAL")
                    Exit Sub
                End If
            ElseIf rbking.Checked Then
                manodeobra = moking
                If yardas = 7 Then
                    costo = (text1 * lino) + (text2 * algodon) + (text3 * seda) + (text4 * hilo)
                Else
                    MsgBox("No ha introducido la cantidad exacta de material (7)", 48, "CANTIDAD DE MATERIAL")
                    Exit Sub
                End If
            End If
        Else
            MsgBox("NO HA SELECCIONADO NINGUN TAMAÑO DE CUBRECAMA", 48, "SELECCIONAR")
            Exit Sub
        End If

        Costofinal = costo + manodeobra
        venta = Costofinal * (1.65)
        Form2.TextBox1.Text = Math.Round(Val(TextBox1.Text) * lino, 2)
        Form2.TextBox2.Text = Math.Round(Val(TextBox2.Text) * algodon, 2)
        Form2.TextBox3.Text = Math.Round(Val(TextBox3.Text) * seda, 2)
        Form2.TextBox4.Text = Math.Round(Val(TextBox4.Text) * hilo, 2)
        Form2.TextBox7.Text = Math.Round(Costofinal, 2)
        Form2.TextBox6.Text = Math.Round(venta, 2)
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        salir()
    End Sub
End Class
