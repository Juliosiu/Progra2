Imports System.Math
Module Module1
    Public nombre(5) As String
    Public sueldobruto(5) As Double
    Public descuento(5) As String
    Public descuentoq(5) As Double
    Public sueldoneto(5) As Double
    Public fila As Byte = 0
    Public variable As Double

    Function calcular(sueldob As Double, desc As String) As Double
        Select Case desc
            Case "IGSS"
                variable = sueldob * 15 / 100
            Case Else
                variable = sueldob * 6 / 100
        End Select
        Return variable
    End Function


    Sub calculos()
        If (fila < 6) Then
            If Form1.tbnombre.Text <> "" Then
                nombre(fila) = Form1.tbnombre.Text
            Else
                MsgBox("Ingrese un nombre",, "ERROR") : Exit Sub
                Form1.tbnombre.Focus()
            End If
            If Val(Form1.tbsueldo.Text) > 0 And IsNumeric(Form1.tbsueldo.Text) Then
                sueldobruto(fila) = Val(Form1.tbsueldo.Text)
            Else
                MsgBox("Ingrese un sueldo bruto",, "ERROR") : Exit Sub
                Form1.tbsueldo.Focus()
            End If
            If Form1.cbdescuento.SelectedIndex > -1 Then
                descuento(fila) = Form1.cbdescuento.Text
                descuentoq(fila) = calcular(sueldobruto(fila), descuento(fila))
            Else
                MsgBox("Seleccione un descuento",, "ERROR") : Exit Sub
                Form1.cbdescuento.Focus()
            End If
            sueldoneto(fila) = sueldobruto(fila) - descuentoq(fila)
            mostrarlistas()
            limpiarentradas()
            fila = fila + 1

        Else
            MsgBox("Vectores llenos",, "DEBE LIMPIAR VECTORES") : Exit Sub
        End If
    End Sub

    Sub mostrarlistas()
        Form1.lbnombre.Items.Add(nombre(fila))
        Form1.lbsueldob.Items.Add(Str(sueldobruto(fila)))
        Form1.lbdescuento.Items.Add(descuento(fila))
        Form1.lbdescuentoq.Items.Add(descuentoq(fila))
        Form1.lbsueldon.Items.Add(Round(sueldoneto(fila), 2))
    End Sub

    Sub limpiarentradas()
        Form1.tbnombre.Text = ""
        Form1.tbsueldo.Text = ""
        Form1.cbdescuento.SelectedIndex = -1
        Form1.tbnombre.Focus()
    End Sub

    Sub limpiarvectores()
        fila = 0
        limpiarentradas()
        Form1.lbdescuento.Items.Clear()
        Form1.lbdescuentoq.Items.Clear()
        Form1.lbnombre.Items.Clear()
        Form1.lbsueldob.Items.Clear()
        Form1.lbsueldon.Items.Clear()
    End Sub

End Module
