Imports System.Math
Module Module1
    Public dpi(6) As Integer
    Public nombre(6) As String
    Public valor(6) As Double
    Public meses(6) As Byte
    Public tasa(6) As Double
    Public total(6) As Double
    Public fila As Byte = 0
    Public index As Byte = 0

    Sub operar()
        If index < 7 Then
            If IsNumeric(Form1.tbdpi.Text) And Val(Form1.tbdpi.Text) > 0 And IsNumeric(Form1.tbmeses.Text) And Val(Form1.tbmeses.Text) > 0 And IsNumeric(Form1.tbvalor.Text) And Val(Form1.tbvalor.Text) > 0 And Form1.tbnombre.Text <> "" Then
                dpi(index) = Val(Form1.tbdpi.Text)
                nombre(index) = Form1.tbnombre.Text
                valor(index) = Val(Form1.tbvalor.Text)
                meses(index) = Val(Form1.tbmeses.Text)
                If Val(Form1.tbvalor.Text) > 8000 And Val(Form1.tbmeses.Text) = 12 Then
                    tasa(index) = 2
                Else
                    Select Case Form1.tbmeses.Text
                        Case 0 To 11
                            tasa(index) = 3
                        Case 12 To 23
                            tasa(index) = 4.5
                        Case 24 To 36
                            tasa(index) = 5.5
                        Case > 36
                            tasa(index) = 6.2
                    End Select
                End If
                total(index) = Round(Val(Form1.tbvalor.Text) + ((Val(Form1.tbvalor.Text) * tasa(index)) / 100), 2)
                index = index + 1
                limpiarentradas()
            Else
                MsgBox("Debe de rellenar todos los campos de los Datos",, "ERROR") : Exit Sub
            End If
        Else
            MsgBox("Limpiar matriz",, "ERROR") : Exit Sub
        End If
    End Sub

    Sub mostrar()
        Dim i As Integer = 0

        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 6
            If (dpi(i) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(dpi(i), nombre(i), valor(i), meses(i), tasa(i), total(i))
            Else
                Exit For
            End If
        Next i


    End Sub

    Sub ordenar()
        Dim i As Byte
        Dim j As Byte
        Dim t1 As Integer
        Dim t2 As String
        Dim t3 As Double
        Dim t4 As Byte
        Dim t5 As Double
        Dim t6 As Double
        If index >= 7 Then
            For i = 0 To 5
                For j = i + 1 To 6
                    If (dpi(i) <> Nothing) Then
                        If (dpi(i) < dpi(j)) Then
                            t1 = dpi(i)
                            dpi(i) = dpi(j)
                            dpi(j) = t1

                            t2 = nombre(i)
                            nombre(i) = nombre(j)
                            nombre(j) = t2

                            t3 = valor(i)
                            valor(i) = valor(j)
                            valor(j) = t3

                            t4 = meses(i)
                            meses(i) = meses(j)
                            meses(j) = t4

                            t5 = tasa(i)
                            tasa(i) = tasa(j)
                            tasa(j) = t5

                            t6 = total(i)
                            total(i) = total(j)
                            total(j) = t6
                        End If
                    Else
                        Exit For
                    End If
                Next j
            Next i
        Else
            MsgBox("Debe llenar la matriz",, "ERROR")
        End If
        mostrar()
    End Sub

    Sub limpiarentradas()
        Form1.tbdpi.Text = ""
        Form1.tbmeses.Text = ""
        Form1.tbnombre.Text = ""
        Form1.tbvalor.Text = ""
        Form1.tbdpi.Focus()

    End Sub

    Sub limpiarvectores()
        Dim i As Integer = 0
        For i = 0 To 6
            dpi(i) = Nothing
            nombre(i) = Nothing
            valor(i) = Nothing
            meses(i) = Nothing
            tasa(i) = Nothing
            total(i) = Nothing
        Next i
        Form1.DataGridView1.Rows.Clear()
        index = 0
    End Sub

End Module
