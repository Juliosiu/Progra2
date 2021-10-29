Imports System.Math
Module Module1
    Public matriz(5, 8) As String
    Public fila As Integer = 0
    Public index As Integer = 0

    Sub operar()
        For fila = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If matriz(fila, 0) = Form1.ComboBox1.Text Then
                    MsgBox("El código ya fue ingresado",, "ERROR") : Exit Sub
                End If
            End If
        Next

        If index < 6 Then
            matriz(index, 0) = Form1.ComboBox1.Text
            matriz(index, 1) = Form1.ComboBox2.Text
            matriz(index, 2) = Form1.TextBox1.Text
            matriz(index, 3) = Form1.TextBox2.Text
            matriz(index, 4) = Form1.TextBox3.Text
            matriz(index, 5) = Round(Val(Form1.TextBox3.Text) * Val(Form1.TextBox1.Text), 2)
            matriz(index, 6) = Round(Val(Form1.TextBox2.Text) * Val(Form1.TextBox1.Text) * 0.75, 2)
            matriz(index, 7) = Round(Val(matriz(index, 5)) - Val(matriz(index, 6)), 2)
            If Val(Form1.TextBox2.Text) = 0 Then
                matriz(index, 8) = "SI"
            Else
                matriz(index, 8) = "NO"
            End If
            index = index + 1
            limpiarentradas()
        Else
            MsgBox("Limpiar matriz",, "ERROR") : Exit Sub
        End If
    End Sub

    Sub limpiarentradas()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
    End Sub

    Sub mostrar()
        Dim i As Integer = 0
        If index >= 6 Then
            Form1.DataGridView1.Rows.Clear()
            For i = 0 To 5
                If (matriz(i, 0) <> Nothing) Then
                    Form1.DataGridView1.Rows.Add(matriz(i, 0), matriz(i, 1), matriz(i, 2), matriz(i, 3), matriz(i, 4), matriz(i, 5), matriz(i, 6), matriz(i, 7), matriz(i, 8))
                Else
                    Exit For
                End If
            Next i
        Else
            MsgBox("Aún no ha terminado de ingresar datos",, "ERROR")
        End If
    End Sub

    Sub consultar()
        Dim i As Integer = 0
        Dim enc As Boolean = False
        If Form1.TextBox4.Text <> Nothing Then
            For i = 0 To 5
                If matriz(i, 0) <> Nothing Then
                    If matriz(i, 0) = Form1.TextBox4.Text Then
                        Form1.ComboBox1.Text = matriz(i, 0)
                        Form1.ComboBox2.Text = matriz(i, 1)
                        Form1.TextBox1.Text = matriz(i, 2)
                        Form1.TextBox2.Text = matriz(i, 3)
                        Form1.TextBox3.Text = matriz(i, 4)
                        Form1.DataGridView1.Rows.Clear()
                        Form1.DataGridView1.Rows.Add(matriz(i, 0), matriz(i, 1), matriz(i, 2), matriz(i, 3), matriz(i, 4), matriz(i, 5), matriz(i, 6), matriz(i, 7), matriz(i, 8))
                        enc = True
                    End If
                Else
                    Exit For
                End If
            Next i
        Else
            MsgBox("No se ingresó código",, "ERROR") : Exit Sub
        End If
        If enc = True Then
            MsgBox("Datos encontrados",, ":)")
        Else
            MsgBox("No se encontraró el Código",, ":(")
        End If

        Form1.TextBox4.Text = ""
    End Sub

    Sub estadisticas()
        Dim e, e1, e2, e3 As Integer
        For e = 0 To 5
            If matriz(e, 0) <> Nothing Then
                If Val(matriz(e, 3)) = 0 Then
                    e1 = e1 + 1
                End If
                If Val(matriz(e, 3)) > Val(matriz(e, 4)) Then
                    e2 = e2 + 1
                End If
                If Val(matriz(e, 3)) > 0 Then
                    e3 = e3 + 1
                End If
            Else
                Exit For
            End If
        Next e
        Form1.GroupBox3.Visible = True
        Form1.TextBox5.Text = e1
        Form1.TextBox6.Text = e2
        Form1.TextBox7.Text = e3

    End Sub

    Sub limpiarmatriz()
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To 5
            For j = 0 To 8
                matriz(i, j) = Nothing
            Next j
        Next i
        Form1.DataGridView1.Rows.Clear()
        index = 0
    End Sub

    Sub limpiarestadisticas()
        Form1.GroupBox3.Visible = False
        Form1.TextBox5.Text = 0
        Form1.TextBox6.Text = 0
        Form1.TextBox7.Text = 0
    End Sub

End Module
