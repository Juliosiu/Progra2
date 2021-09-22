Imports System.Math
Module Module1

    Public placa(5) As String
    Public marca(5) As String
    Public dias(5) As Integer
    Public pagoparcial(5) As Double
    Public descuento(5) As Double
    Public recargo(5) As Double
    Public pagofinal(5) As Double
    Public fila As Byte = 0
    Public variablepp As Double
    Public nit As String

    Function pagop(marcas As String, dia As Integer) As Double
        Select Case marcas
            Case "Honda"
                variablepp = 250 * dia
            Case "Mercedez Benz"
                variablepp = 450 * dia
            Case "Toyota"
                variablepp = 325 * dia
            Case Else
                variablepp = 300 * dia
        End Select
        Return variablepp
    End Function

    Sub calcular()
        If fila < 6 Then
            If Form1.TextBox1.Text <> "" Then
                nit = Form1.TextBox1.Text
            Else
                MsgBox("Ingrese un numero de NIT",, "ERROR") : Exit Sub

            End If
            If Form1.TextBox2.Text <> "" Then
                placa(fila) = Form1.TextBox2.Text
            Else
                MsgBox("Ingrese un numero de placa",, "ERROR") : Exit Sub

            End If
            If Form1.ComboBox1.SelectedIndex > -1 Then
                marca(fila) = Form1.ComboBox1.Text
            Else
                MsgBox("Seleccione una marca",, "ERROR") : Exit Sub

            End If
            If Val(Form1.TextBox3.Text) <> 0 And IsNumeric(Form1.TextBox3.Text) Then
                dias(fila) = Val(Form1.TextBox3.Text)
            Else
                MsgBox("Ingrese una cantidad de Dias",, "ERROR") : Exit Sub
            End If
            pagoparcial(fila) = pagop(marca(fila), dias(fila))
            If Form1.CheckBox1.Checked = True Or Form1.CheckBox2.Checked = True Then
                If Form1.CheckBox1.Checked = True And Val(Form1.TextBox4.Text) = 100 Then
                    descuento(fila) = (5 / 100) * pagoparcial(fila)
                ElseIf Form1.CheckBox2.Checked = True And Val(Form1.TextBox5.text) = 100 Then
                    recargo(fila) = (2.5 / 100) * pagoparcial(fila)
                ElseIf (Form1.CheckBox2.Checked = True And Form1.CheckBox2.Checked = True) And (Val(Form1.TextBox4.Text) + Val(Form1.TextBox5.text) = 100) Then
                    descuento(fila) = 0
                    recargo(fila) = 0
                Else
                    MsgBox("Indique el porcentaje correcto del pago",, "ERROR") : Exit Sub
                End If
            Else
                MsgBox("Seleccione el método de pago",, "ERROR") : Exit Sub
            End If
            pagofinal(fila) = pagoparcial(fila) - descuento(fila) + recargo(fila)
        Else
            MsgBox("Vectores llenos",, "DEBE LIMPIAR VECTORES") : Exit Sub
        End If
        mostrarlistas()
        limpiarentradas()
        fila = fila + 1
    End Sub

    Sub mostrarlistas()
        Form1.ListBox1.Items.Add(placa(fila))
        Form1.ListBox2.Items.Add(marca(fila))
        Form1.ListBox3.Items.Add(dias(fila))
        Form1.ListBox4.Items.Add(pagoparcial(fila))
    End Sub

    Sub limpiarentradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.Label6.Visible = False
        Form1.Label7.Visible = False
        Form1.TextBox4.Visible = False
        Form1.TextBox5.Visible = False
    End Sub

    Sub limpiarvectores()
        fila = 0
        limpiarentradas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
    End Sub



End Module
