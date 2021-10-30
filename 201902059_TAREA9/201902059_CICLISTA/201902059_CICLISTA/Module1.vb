Imports System.Math
Module Module1
    Public etapa(11) As Integer
    Public equipo(11) As String
    Public recorrido(11) As Double
    Public tiempo(11) As Double
    Public nacionalidad(11) As String
    Public penalizacion(11) As Integer
    Public total(11) As Integer
    Public fila As Byte = 0
    Public index As Byte = 0

    Sub guardar()
        If index < 12 Then
            If (Form1.cbequipo.SelectedIndex > -1) And (Form1.cbetapa.SelectedIndex > -1) And IsNumeric(Form1.tbrecorrido.Text) And (Val(Form1.tbrecorrido.Text) > 0) And IsNumeric(Form1.tbtiempo.Text) And (Val(Form1.tbtiempo.Text) > 0) And (Form1.rbext.Checked = True Or Form1.rbgua.Checked = True) Then
                For fila = 0 To 11
                    If (etapa(fila) <> Nothing) Then
                        If etapa(fila) = Form1.cbetapa.Text Then
                            MsgBox("La etapa ya fue ingresada",, "ERROR") : Exit Sub
                        End If
                    End If
                Next
                etapa(index) = Form1.cbetapa.Text
                equipo(index) = Form1.cbequipo.Text
                recorrido(index) = Form1.tbrecorrido.Text
                tiempo(index) = Form1.tbtiempo.Text
                If Form1.rbgua.Checked = True Then
                    nacionalidad(index) = Form1.rbgua.Text
                Else
                    nacionalidad(index) = Form1.rbext.Text
                End If
                If Val(Form1.tbtiempo.Text) > 160 Then
                    penalizacion(index) = +50
                ElseIf Val(Form1.tbtiempo.Text) > 140 Then
                    penalizacion(index) = +40
                ElseIf Val(Form1.tbtiempo.Text) > 120 Then
                    penalizacion(index) = +30
                ElseIf Val(Form1.tbtiempo.Text) < 85 And Form1.cbequipo.Text = "Movistar" Then
                    penalizacion(index) = -15
                ElseIf Val(Form1.tbtiempo.Text) < 85 And Form1.cbequipo.Text = "Pro Team" Then
                    penalizacion(index) = -10
                Else
                    penalizacion(index) = 0
                End If
                total(index) = Val(tiempo(index)) + Val(penalizacion(index))
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
        'If index >= 12 Then
        Form1.DataGridView1.Rows.Clear()
            For i = 0 To 11
                If (etapa(i) <> Nothing) Then
                    Form1.DataGridView1.Rows.Add(etapa(i), equipo(i), recorrido(i), tiempo(i), nacionalidad(i), penalizacion(i), total(i))
                Else
                    Exit For
                End If
            Next i
        ' Else
        'MsgBox("Aún no ha terminado de ingresar datos",, "ERROR")
        'End If
    End Sub

    Sub limpiarentradas()
        Form1.cbequipo.SelectedIndex = -1
        Form1.cbetapa.SelectedIndex = -1
        Form1.tbrecorrido.Text = ""
        Form1.tbtiempo.Text = ""
        Form1.rbext.Checked = False
        Form1.rbgua.Checked = False
    End Sub

    Sub limpiarvectores()
        Dim i As Integer = 0
        For i = 0 To 11
            etapa(i) = Nothing
            equipo(i) = Nothing
            recorrido(i) = Nothing
            tiempo(i) = Nothing
            nacionalidad(i) = Nothing
            penalizacion(i) = Nothing
            total(i) = Nothing
        Next i
        Form1.DataGridView1.Rows.Clear()
        index = 0
    End Sub



    Sub estadisticas()
        Dim i As Integer = 0
        Dim e1 As Integer
        Dim rec1, rec2, rec3, rec4 As Integer
        Dim t1, t2, t3, t4 As Integer
        Dim a, aa, b, bb, c, cc, d, dd As Double


        For i = 0 To 11
            If etapa(i) <> Nothing Then
                If nacionalidad(i) = "Guatemalteco" And Val(recorrido(i)) > 45 Then
                    e1 = e1 + 1
                End If
                Select Case equipo(i)
                    Case "Sky"
                        rec1 = rec1 + Val(recorrido(i))
                        t1 = t1 + Val(tiempo(i))
                    Case "Movistar"
                        rec2 = rec2 + Val(recorrido(i))
                        t2 = t2 + Val(tiempo(i))
                    Case "Pro Cycling"
                        rec3 = rec3 + Val(recorrido(i))
                        t3 = t3 + Val(tiempo(i))
                    Case Else
                        rec4 = rec4 + Val(recorrido(i))
                        t4 = t4 + Val(tiempo(i))
                End Select

                Form1.tbe1.Text = e1
                Form1.tbrec1.Text = rec1
                Form1.tbrec2.Text = rec2
                Form1.tbrec3.Text = rec3
                Form1.tbrec4.Text = rec4
                a = Int(t1 / 60)
                aa = Round((t1 / 60 - a) * 60, 2)
                b = Int(t2 / 60)
                bb = Round((t2 / 60 - b) * 60, 2)
                c = Int(t3 / 60)
                cc = Round((t3 / 60 - c) * 60, 2)
                d = Int(t4 / 60)
                dd = Round((t4 / 60 - d) * 60, 2)
                Form1.tbt1.Text = Str(a) + "horas con " + Str(aa) + "minutos"
                Form1.tbt2.Text = Str(b) + "horas con " + Str(bb) + "minutos"
                Form1.tbt3.Text = Str(c) + "horas con " + Str(cc) + "minutos"
                Form1.tbt4.Text = Str(d) + "horas con " + Str(dd) + "minutos"
            Else
                Exit For
            End If
        Next i

    End Sub

    Sub limpiarestadisticas()
        Form1.tbe1.Text = ""
        Form1.tbrec1.Text = ""
        Form1.tbrec2.Text = ""
        Form1.tbrec3.Text = ""
        Form1.tbrec4.Text = ""
        Form1.tbt1.Text = ""
        Form1.tbt2.Text = ""
        Form1.tbt3.Text = ""
        Form1.tbt4.Text = ""
    End Sub

    Sub consultar()
        Dim i As Integer = 0
        Dim enc As Boolean = False
        If Form1.tbconsulta.Text <> Nothing Then
            For i = 0 To 11
                If etapa(i) <> Nothing Then
                    If etapa(i) = Form1.tbconsulta.Text Then
                        Form1.cbetapa.Text = etapa(i)
                        Form1.cbequipo.Text = equipo(i)
                        Form1.tbrecorrido.Text = recorrido(i)
                        Form1.tbtiempo.Text = tiempo(i)
                        If nacionalidad(i) = "Guatemalteco" Then
                            Form1.rbgua.Checked = True
                        Else
                            Form1.rbext.Checked = True
                        End If
                        Form1.DataGridView1.Rows.Clear()
                        Form1.DataGridView1.Rows.Add(etapa(i), equipo(i), recorrido(i), tiempo(i), nacionalidad(i), penalizacion(i), total(i))
                        enc = True
                        index = i
                    End If
                Else
                    Exit For
                End If
            Next i
        Else
            MsgBox("No se ingresó etapa",, "ERROR") : Exit Sub
        End If
        If enc = True Then
            MsgBox("Datos encontrados",, ":)")
        Else
            MsgBox("No se encontró la etapa",, ":(")
        End If
        Form1.tbconsulta.Text = ""
    End Sub

    Sub eliminar()
        Dim I As Integer
        etapa(index) = Nothing
        equipo(index) = Nothing
        recorrido(index) = Nothing
        tiempo(index) = Nothing
        nacionalidad(index) = Nothing
        penalizacion(index) = Nothing
        total(index) = Nothing

        For I = index To 10
            etapa(I) = etapa(I + 1)
            equipo(I) = equipo(I + 1)
            recorrido(I) = recorrido(I + 1)
            tiempo(I) = tiempo(I + 1)
            nacionalidad(I) = nacionalidad(I + 1)
            penalizacion(I) = penalizacion(I + 1)
            total(I) = total(I + 1)
        Next I
        MsgBox("Registro Eliminado correctamente")
        etapa(I) = Nothing
        equipo(I) = Nothing
        recorrido(I) = Nothing
        tiempo(I) = Nothing
        nacionalidad(I) = Nothing
        penalizacion(I) = Nothing
        total(I) = Nothing
        index = I
        limpiarentradas()
        Form1.DataGridView1.Rows.Clear()

    End Sub

    Sub actualizar()
        etapa(index) = Form1.cbetapa.Text
        equipo(index) = Form1.cbequipo.Text
        recorrido(index) = Form1.tbrecorrido.Text
        tiempo(index) = Form1.tbtiempo.Text
        If Form1.rbgua.Checked = True Then
            nacionalidad(index) = Form1.rbgua.Text
        Else
            nacionalidad(index) = Form1.rbext.Text
        End If
        If Val(Form1.tbtiempo.Text) > 160 Then
            penalizacion(index) = +50
        ElseIf Val(Form1.tbtiempo.Text) > 140 Then
            penalizacion(index) = +40
        ElseIf Val(Form1.tbtiempo.Text) > 120 Then
            penalizacion(index) = +30
        ElseIf Val(Form1.tbtiempo.Text) < 85 And Form1.cbequipo.Text = "Movistar" Then
            penalizacion(index) = -15
        ElseIf Val(Form1.tbtiempo.Text) < 85 And Form1.cbequipo.Text = "Pro Team" Then
            penalizacion(index) = -10
        Else
            penalizacion(index) = 0
        End If
        total(index) = Val(tiempo(index)) + Val(penalizacion(index))

        MsgBox("Registro Actualizado correctamente")

        index = 11
        limpiarentradas()
    End Sub

    Sub ordenar()
        Dim aux1 As Integer
        For i = 0 To 11
            For j = 0 To 10
                If (etapa(j) > etapa(i)) Then
                    aux1 = etapa(j)
                    etapa(j) = etapa(i)
                    etapa(i) = aux1
                Else
                    Exit For
                End If
            Next
        Next


    End Sub
End Module
