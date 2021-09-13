Imports System.Math
Module Module1
    Public ccine(8) As String
    Public ffuncion(8) As String
    Public subtotal(8) As Double
    Public descuento1(8) As Double
    Public total(8) As Double
    Public descuento2(8) As Double
    Public fila As Byte = 0
    Public desc1 As Double
    Public desc2 As Double
    Public cantidad(8) As Integer
    Public variablesub As Double
    Public variabledesc1 As Double
    Public variabledesc2 As Double


    Sub calcular()
        If (fila < 9) Then
            If (CINE.cbcine.Text = "A" Or CINE.cbcine.Text = "B" Or CINE.cbcine.Text = "C") And IsNumeric(CINE.tbcantidad.Text) And Val(CINE.tbcantidad.Text) > 0 And (CINE.cbfuncion.Text = "1" Or CINE.cbfuncion.Text = "2" Or CINE.cbfuncion.Text = "3" Or CINE.cbfuncion.Text = "4") Then
                cantidad(fila) = Val(CINE.tbcantidad.Text)
                ccine(fila) = CINE.cbcine.Text
                ffuncion(fila) = CINE.cbfuncion.Text
                subtotal(fila) = Round(calcularsubtotal(ffuncion(fila), ccine(fila), cantidad(fila)), 2)
                descuento1(fila) = Round(subtotal(fila) * descuentoo1(ffuncion(fila), ccine(fila)), 2)
                descuento2(fila) = Round(subtotal(fila) * descuentoo2(subtotal(fila)), 2)
                total(fila) = Round(subtotal(fila) - descuento1(fila) - descuento2(fila), 2)
            Else
                MsgBox("Ingrese un cine, una función y la cantidad de boletos",, "ERROR")
                Exit Sub
            End If
        Else
            MsgBox("Vectores llenos",, "DEBE LIMPIAR VECTORES") : Exit Sub
        End If
        mostrarlistas()
        fila = fila + 1
        limpiarentradas()
    End Sub

    Sub limpiarentradas()
        CINE.cbcine.SelectedIndex = -1
        CINE.cbfuncion.SelectedIndex = -1
        CINE.tbcantidad.Text = ""
    End Sub

    Sub mostrarlistas()
        CINE.ListBox1.Items.Add(ccine(fila))
        CINE.ListBox2.Items.Add(ffuncion(fila))
        CINE.lbsub.Items.Add(Str(subtotal(fila)))
        CINE.lbdesc1.Items.Add(Str(descuento1(fila)))
        CINE.lbdesc2.Items.Add(Str(descuento2(fila)))
        CINE.lbtotal.Items.Add(Str(total(fila)))
        CINE.ListBox3.Items.Add(Str(cantidad(fila)))
    End Sub

    Function calcularsubtotal(funcion As String, cine As String, cant As Integer) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        variablesub = 30 * cant
                    Case "2"
                        variablesub = 35 * cant
                    Case Else
                        variablesub = 40 * cant
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        variablesub = 24 * cant
                    Case "2"
                        variablesub = 34 * cant
                    Case Else
                        variablesub = 44 * cant
                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        variablesub = 35 * cant
                    Case "2"
                        variablesub = 40 * cant
                    Case Else
                        variablesub = 50 * cant
                End Select

        End Select

        Return variablesub

    End Function

    Function descuentoo1(funcion As String, cine As String) As Double

        If (funcion = "3" Or funcion = "4") And (cine = "B" Or cine = "C") Then
            variabledesc1 = 5.5 / 100
        ElseIf (funcion = "1") And (cine = "B" Or cine = "C") Then
            variabledesc1 = 3 / 100
        ElseIf (funcion = "2") And (cine = "A") Then
            variabledesc1 = 1.5 / 100
        Else
            variabledesc1 = 0
        End If

        Return variabledesc1
    End Function

    Function descuentoo2(subt As Double) As Double
        If subt > 100 And subt < 300 Then
            variabledesc2 = 2 / 100
        ElseIf subt >= 300 And subt < 500 Then
            variabledesc2 = 4 / 100
        ElseIf subt >= 500 And subt < 1000 Then
            variabledesc2 = 6 / 100
        Else
            variabledesc2 = 0
        End If
        Return variabledesc2
    End Function

    Sub limpiarvectores()
        fila = 0
        limpiarentradas()
    End Sub

    Sub limpiarlistas()
        CINE.ListBox1.Items.Clear()
        CINE.ListBox2.Items.Clear()
        CINE.ListBox3.Items.Clear()
        CINE.lbdesc1.Items.Clear()
        CINE.lbdesc2.Items.Clear()
        CINE.lbsub.Items.Clear()
        CINE.lbtotal.Items.Clear()
    End Sub
End Module
