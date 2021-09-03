Imports System.Math
Module Module1
    Public nombre(10) As String
    Public nit(10) As String
    Public servicio(10) As String
    Public tarifa(10) As String
    Public saldoant(10) As Double
    Public pagoinicial(10) As Double
    Public mora(10) As Double
    Public descuento(10) As Double
    Public pagototal(10) As Double
    Public FILA As Byte = 0
    Public costo As Double
    Public mor As Double
    Public total As Double
    Public desc As Double



    Sub calcular()

        If (FILA < 10) Then
            If (Form1.txtnombre.Text <> "") Then
                nombre(FILA) = Form1.txtnombre.Text
            Else
                MsgBox("Ingrese un nombre",, "ERROR")
                Form1.txtnombre.Focus() : Exit Sub
            End If
            If (Val(Form1.txtnit.Text) > 0 And Val(Form1.txtnit.Text) < 99999999) Then
                nit(FILA) = Form1.txtnit.Text
            Else
                MsgBox("Ingrese un NIT",, "ERROR")
                Form1.txtnit.Focus() : Exit Sub
            End If
            If (Val(Form1.txtanterior.Text) > 0) Then
                saldoant(FILA) = Val(Form1.txtanterior.Text)
                mor = Round(Val(Form1.txtanterior.Text) * 0.02, 2)
                mora(FILA) = mor
            Else
                saldoant(FILA) = 0
            End If
            If IsNumeric(Form1.txtconsumo.Text) And Val(Form1.txtconsumo.Text) > 0 Then
                If Form1.cbservicio.SelectedIndex = 0 Then
                    Select Case (Val(Form1.txtconsumo.Text))
                        Case 0 To 100 : costo = 0.99
                        Case 101 To 300 : costo = 1.2
                        Case Is > 300 : costo = 3
                    End Select

                ElseIf Form1.cbservicio.SelectedIndex = 1 Then
                    Select Case (Val(Form1.txtconsumo.Text))
                        Case 0 To 100 : costo = 1.99
                        Case 101 To 300 : costo = 2.2
                        Case Is > 300 : costo = 4
                    End Select

                Else
                    MsgBox("Seleccione un tipo de servicio",, "ERROR")
                    Form1.cbservicio.Focus() : Exit Sub
                End If
                pagoinicial(FILA) = Round(Val(Form1.txtconsumo.Text) * costo, 2)
            End If
            servicio(FILA) = Form1.cbservicio.Text
            If Form1.cbtarifa.SelectedIndex = 0 Then
                desc = Round(((Val(Form1.txtconsumo.Text) * costo) + Val(Form1.txtanterior.Text) + mor) * (0.2), 2)
            ElseIf Form1.cbtarifa.SelectedIndex = 1 Then
                desc = Round(Val(Form1.txtconsumo.Text) * costo * 0.1, 2)
            Else
                MsgBox("Seleccione un tipo de servicio",, "ERROR")
                Form1.cbtarifa.Focus() : Exit Sub
            End If
            tarifa(FILA) = Form1.cbtarifa.Text
            descuento(FILA) = desc
            total = Round(Val(Form1.txtconsumo.Text) * costo + Val(Form1.txtanterior.Text) + mor - desc, 2)
            pagototal(FILA) = total
            mostrar_listas()
            FILA = FILA + 1
            limpiar_entradas()
        Else
            MsgBox("Vectores llenos",, "DEBE LIMPIAR VECTORES") : Exit Sub
        End If
    End Sub

    Sub mostrar_listas()
        Form1.ListBox1.Items.Add(nombre(FILA))
        Form1.ListBox2.Items.Add(nit(FILA))
        Form1.ListBox3.Items.Add(servicio(FILA))
        Form1.ListBox4.Items.Add(tarifa(FILA))
        Form1.ListBox5.Items.Add(Str(saldoant(FILA)))
        Form1.ListBox6.Items.Add(Str(pagoinicial(FILA)))
        Form1.ListBox7.Items.Add(Str(mora(FILA)))
        Form1.ListBox8.Items.Add(Str(descuento(FILA)))
        Form1.ListBox9.Items.Add(Str(pagototal(FILA)))
    End Sub

    Sub limpiar_entradas()
        Form1.txtnombre.Text = ""
        Form1.txtnit.Text = ""
        Form1.txtconsumo.Text = ""
        Form1.txtanterior.Text = ""
        Form1.cbservicio.SelectedIndex = -1
        Form1.cbtarifa.SelectedIndex = -1
        Form1.cbservicio.Text = "SELECCIONE UNO"
        Form1.cbtarifa.Text = "SELECCIONE UNO"
    End Sub

    Sub limpiar_listas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
    End Sub

    Sub limpiar_vectores()
        FILA = 0
        limpiar_listas()
    End Sub

End Module
