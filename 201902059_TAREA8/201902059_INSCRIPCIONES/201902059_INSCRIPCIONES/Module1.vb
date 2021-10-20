Imports System.Math
Module Module1
    Public matriz(6, 5) As String
    Public fila As Byte = 0
    Public inscripcion As Double
    Public primera As Double
    Public total As Double
    Public cargo As Double
    Public total2 As Double
    Public elimina As Byte




    Sub procesos()
        If fila <= 6 Then
            If Form1.tbnombre.Text <> "" Then
                matriz(fila, 0) = Form1.tbnombre.Text
            Else
                MsgBox("Debe de ingresar un nombre",, "ERROR") : Exit Sub
            End If
            If Form1.tbcarnet.Text <> "" And IsNumeric(Form1.tbcarnet.Text) Then
                matriz(fila, 1) = Form1.tbcarnet.Text
            Else
                MsgBox("Debe de ingresar un número de carnet",, "ERROR") : Exit Sub
            End If
            If Form1.rbbasicos.Checked = True Or Form1.rbdiversificado.Checked = True Then
                If Form1.rbbasicos.Checked = True Then
                    matriz(fila, 2) = "Básicos"
                    matriz(fila, 3) = ""
                    inscripcion = 350
                    primera = 250
                Else
                    matriz(fila, 2) = "Diversificado"
                    matriz(fila, 3) = Form1.cbcarrera.Text
                    primera = 350
                    inscripcion = 450
                End If
            Else
                MsgBox("Debe seleccionar un nivel de estudios",, "ERROR") : Exit Sub
            End If
            total = round((primera + inscripcion), 2)
            If Form1.cbpago.SelectedIndex >= 0 Then
                matriz(fila, 4) = Form1.cbpago.Text
                If Form1.cbpago.SelectedIndex = 1 Then
                    cargo = (10 / 100) * total
                Else
                    cargo = 0
                End If
            Else
                MsgBox("Debe seleccionar un método de pago",, "ERROR") : Exit Sub
            End If
            total2 = Round((total + cargo), 2)
            matriz(fila, 5) = total2
        Else
            MsgBox("Debe Limpiar Matriz",, "ERROR") : Exit Sub
        End If
        limpiarentradas()
        fila = fila + 1
    End Sub

    Sub mostrar()
        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 6
            If matriz(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(matriz(i, 0), matriz(i, 1), matriz(i, 2), matriz(i, 3), matriz(i, 4), matriz(i, 5))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub limpiarentradas()
        Form1.tbnombre.Text = ""
        Form1.tbcarnet.Text = ""
        Form1.cbcarrera.SelectedIndex = -1
        Form1.cbpago.SelectedIndex = -1
        Form1.rbbasicos.Checked = False
        Form1.rbdiversificado.Checked = False
    End Sub

    Sub limpiarmatriz()
        Form1.DataGridView1.Rows.Clear()
        Dim F As Byte
        Dim C As Byte

        For F = 0 To 6
            For C = 0 To 5
                matriz(F, C) = Nothing
            Next C
        Next F
        fila = 0
    End Sub

    Sub totales()
        Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11 As Integer
        Dim t As Byte

        For t = 0 To 6
            t1 = t1 + Val(matriz(t, 5))
            If matriz(t, 4) = "Tarjeta de Credito" Then
                t2 = t2 + Val(matriz(t, 5))
            ElseIf matriz(t, 4) = "Efectivo" Then
                t3 = t3 + Val(matriz(t, 5))
            ElseIf matriz(t, 4) = "Transferencia por ACH" Then
                t4 = t4 + Val(matriz(t, 5))
            ElseIf matriz(t, 4) = "Deposito Bancario" Then
                t5 = t5 + Val(matriz(t, 5))
            End If
            If matriz(t, 2) = "Básicos" Then
                t6 = t6 + Val(matriz(t, 5))
            ElseIf matriz(t, 2) = "Diversificado" Then
                t7 = t7 + Val(matriz(t, 5))
            End If
            If matriz(t, 3) = "Perito Contador" Then
                t8 = t8 + 1
            ElseIf matriz(t, 3) = "Bachillerato" Then
                t9 = t9 + 1
            ElseIf matriz(t, 3) = "Electronica" Then
                t10 = t10 + 1
            ElseIf matriz(t, 3) = "Diseño Grafico" Then
                t11 = t11 + 1
            End If
        Next t
        Form1.tbgeneral.Text = t1
        Form1.tbtarjeta.Text = t2
        Form1.tbefectivo.Text = t3
        Form1.tbtransferencia.Text = t4
        Form1.tbbanco.Text = t5
        Form1.tbtbasicos.Text = t6
        Form1.tbdiversificado.Text = t7
        Form1.tbperito.Text = t8
        Form1.tbbach.Text = t9
        Form1.tbelect.Text = t10
        Form1.tbdiseño.Text = t11

        Form1.GroupBox1.Visible = True
    End Sub

    Sub Limpiartotales()
        Form1.tbgeneral.Text = ""
        Form1.tbtarjeta.Text = ""
        Form1.tbefectivo.Text = ""
        Form1.tbtransferencia.Text = ""
        Form1.tbbanco.Text = ""
        Form1.tbtbasicos.Text = ""
        Form1.tbdiversificado.Text = ""
        Form1.tbperito.Text = ""
        Form1.tbbach.Text = ""
        Form1.tbelect.Text = ""
        Form1.tbdiseño.Text = ""
        Form1.GroupBox1.Visible = False
    End Sub

    Sub Eliminar1()

        Form1.DataGridView1.Rows(1).Cells(1).Value = ""

    End Sub

End Module
