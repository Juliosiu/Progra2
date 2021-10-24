Module Module1
    Public matriz(5, 8) As String
    Public fila As Integer = 0
    Public index As Integer = 0

    Sub calculo()
        For fila = 0 To 5
            If (matriz(fila, 0) <> Nothing) Then
                If matriz(fila, 1) = Form1.tbnit.Text Then
                    MsgBox("El nit ya fue ingresado",, "ERROR") : Exit Sub
                End If
            End If
        Next

        If index < 6 Then
            matriz(index, 0) = Form1.tbnombre.Text
            matriz(index, 1) = Form1.tbnit.Text
            matriz(index, 2) = Form1.tbdias.Text
            matriz(index, 3) = Form1.tbhonorarios.Text
            matriz(index, 4) = Form1.cbhabitacion.Text
            matriz(index, 5) = Form1.cbpago.Text
            Select Case Form1.cbhabitacion.Text
                Case "Privada"
                    matriz(index, 6) = Str(Val(Form1.tbdias.Text) * 350)
                Case "Semiprivada"
                    matriz(index, 6) = Str(Val(Form1.tbdias.Text) * 250)
                Case "No privada"
                    matriz(index, 6) = Str(Val(Form1.tbdias.Text) * 150)
            End Select
            Select Case Form1.cbpago.Text
                Case "Efectivo"
                    matriz(index, 7) = Str(Val(matriz(index, 6)) * 0.1)
                Case "Deposito"
                    matriz(index, 7) = Str(Val(matriz(index, 6)) * 0.1)
                Case "Transferencia"
                    matriz(index, 7) = Str(Val(matriz(index, 6)) * 0.08)
                Case "Tarjeta"
                    matriz(index, 7) = Str(Val(matriz(index, 6)) * -1.5 / 100)
                Case Else
                    matriz(index, 7) = 0
            End Select
            matriz(index, 8) = Str(Val(matriz(index, 6)) - Val(matriz(index, 7)))
            index = index + 1
            limpiarentradas()
        Else
            MsgBox("Limpiar matriz",, "ERROR") : Exit Sub
        End If

    End Sub

    Sub limpiarentradas()
        Form1.tbnombre.Text = ""
        Form1.tbnit.Text = ""
        Form1.tbdias.Text = ""
        Form1.tbhonorarios.Text = ""
        Form1.cbhabitacion.SelectedIndex = -1
        Form1.cbpago.SelectedIndex = -1
    End Sub

    Sub limpiarmatriz()
        Dim i As Integer
        Dim j As Integer
        While i <= 5
            While j <= 8
                matriz(i, j) = Nothing
                j = j + 1
            End While
            i = i + 1
        End While
        Form1.DataGridView1.Rows.Clear()

    End Sub

    Sub limpiarestadisticas()
        Form1.tbe1.Text = ""
        Form1.tbe2.Text = ""
        Form1.tbe3.Text = ""
        Form1.GroupBox2.Visible = False
    End Sub

    Sub estadisticas()
        Dim e, e1, e2, e3 As Integer
        While e <= 5
            If matriz(e, 0) <> Nothing Then
                If matriz(e, 4) = "Privada" Then
                    e1 = e1 + 1
                End If
                If matriz(e, 5) = "Transferencia" Then
                    e2 = e2 + Val(matriz(e, 8))
                End If
                If matriz(e, 4) = "No privada" Then
                    e3 = e3 + Val(matriz(e, 2))
                End If
            Else
                Exit While
            End If
            e = e + 1
        End While
        Form1.tbe1.Text = e1
        Form1.tbe2.Text = e2
        Form1.tbe3.Text = e3
        Form1.GroupBox2.Visible = True
    End Sub

    Sub mostrar()
        Dim i As Byte = 0
        Form1.DataGridView1.Rows.Clear()

        While i <= 5
            If matriz(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(matriz(i, 0), matriz(i, 1), matriz(i, 2), matriz(i, 3), matriz(i, 4), matriz(i, 5), matriz(i, 6), matriz(i, 7), matriz(i, 8))
            Else
                Exit While
            End If
            i = i + 1
        End While
    End Sub

    Sub consultar()
        Dim i As Integer = 0
        Dim enc As Boolean = False
        If Form1.tbconsulta.Text <> Nothing Then
            For i = 0 To 5
                If matriz(i, 1) <> Nothing Then
                    If matriz(i, 1) = Form1.tbconsulta.Text Then
                        Form1.tbnombre.Text = matriz(i, 0)
                        Form1.tbnit.Text = matriz(i, 1)
                        Form1.tbdias.Text = matriz(i, 2)
                        Form1.tbhonorarios.Text = matriz(i, 3)
                        Form1.cbhabitacion.Text = matriz(i, 4)
                        Form1.cbpago.Text = matriz(i, 5)
                        enc = True
                    End If
                Else
                    Exit For
                End If
            Next i
        Else
            MsgBox("No se ingresó NIT",, "ERROR") : Exit Sub
        End If
        If enc = True Then
            MsgBox("Datos encontrados",, ":)")
        Else
            MsgBox("No se encontraró el Nit",, ":(")
        End If
        Form1.tbconsulta.Text = ""
    End Sub

End Module
