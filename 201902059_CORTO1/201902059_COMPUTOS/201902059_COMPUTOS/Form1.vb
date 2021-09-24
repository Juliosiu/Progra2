Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim viaticos As Double
        Dim incentivo As Double
        Const sueldobase As Double = 3800
        Dim incentivo2 As Double
        Dim remuneracion As Double
        Dim sueldofinal As Double

        If rbsur.Checked Or rboriente.Checked Or rboccidente.Checked Or rbnorte.Checked Then
            If rbnorte.Checked = True Then
                viaticos = 150
            ElseIf rbsur.Checked = True Then
                viaticos = 200
            ElseIf rboriente.Checked = True Then
                viaticos = 175
            ElseIf rboccidente.checked = True Then
                viaticos = 225
            End If
        Else
            MsgBox("DEBE SELECCIONAR LA REGION DEL VENDEDOR", 16, "ERROR")
            Exit Sub
        End If

        If rbbono.Checked Or rbcomision.Checked Then
            If rbbono.Checked = True Then
                incentivo = 3 / 100
            ElseIf rbcomision.Checked = True Then
                incentivo = 5 / 100
            End If
        Else
            MsgBox("DEBE SELECCIONAR EL INCENTIVO OTORGADO AL VENDEDOR", 16, "ERROR")
            Exit Sub
        End If

        If IsNumeric(TextBox2.Text) Then
            incentivo2 = Val(TextBox2.Text) * incentivo
            remuneracion = Val(TextBox2.Text) + incentivo2
            sueldofinal = sueldobase + remuneracion + viaticos

            Form2.Label2.Text = "Los resultados del señor " + TextBox1.Text + " son:"
            Form2.TextBox2.Text = Math.Round(incentivo2, 2)
            Form2.TextBox1.Text = Math.Round(remuneracion, 2)
            Form2.TextBox3.Text = Math.Round(viaticos, 2)
            Form2.TextBox4.Text = Math.Round(sueldofinal, 2)

            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Ingrese un dato numerico",, "ERROR")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        limpiar()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (MsgBox("Desea salir?", 36, "SALIDA") = vbYes) Then
            End
        Else
            limpiar()
        End If

    End Sub
End Class
