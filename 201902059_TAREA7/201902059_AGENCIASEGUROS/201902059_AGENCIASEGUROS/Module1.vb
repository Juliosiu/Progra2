Module Module1
    Public edad(6) As Integer
    Public genero(6) As String
    Public codigo(6) As Byte
    Public monto(6) As Double
    Public taller(6) As String
    Public deducible(6) As Double
    Public fila As Byte = 0

    Sub proceso()
        If fila < 7 Then
            If Val(Form1.tbedad.Text) > 0 And IsNumeric(Form1.tbedad.Text) Then
                edad(fila) = Val(Form1.tbedad.Text)
            Else
                MsgBox("Debe ingresar una edad correcta",, "ERROR") : Exit Sub
            End If
            If Form1.cbgenero.SelectedIndex > -1 Then
                genero(fila) = Form1.cbgenero.Text
            Else
                MsgBox("Seleccione un genero",, "ERROR") : Exit Sub
            End If
            If Form1.cbcodigo.SelectedIndex > -1 Then
                codigo(fila) = Form1.cbcodigo.Text
            Else
                MsgBox("Seleccione un código",, "ERROR") : Exit Sub
            End If
            If Val(Form1.tbmonto.Text) > 0 And IsNumeric(Form1.tbmonto.Text) Then
                monto(fila) = Form1.tbmonto.Text
            Else
                MsgBox("Ingrese un Monto",, "ERROR") : Exit Sub
            End If
            If Form1.cbtaller.SelectedIndex > -1 Then
                taller(fila) = Form1.cbtaller.Text
            Else
                MsgBox("Seleccione un taller",, "ERROR") : Exit Sub
            End If
            deducible(fila) = monto(fila) * 6 / 100
            fila = fila + 1
            limpiarentradas()
        Else
            MsgBox("Debe limpiar Vectores",, "Vectores Llenos") : Exit Sub
            limpiarentradas()
        End If

    End Sub


    Sub mostrarcalculos()
        Dim x As Byte
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        For x = 0 To 6
            If edad(x) <> Nothing Then
                Form1.ListBox1.Items.Add(edad(x))
                Form1.ListBox2.Items.Add(genero(x))
                Form1.ListBox3.Items.Add(codigo(x))
                Form1.ListBox4.Items.Add(monto(x))
                Form1.ListBox5.Items.Add(taller(x))
                Form1.ListBox6.Items.Add(deducible(x))
            Else
                Exit For
            End If
        Next x
    End Sub

    Sub limpiarentradas()
        Form1.tbedad.Clear()
        Form1.tbmonto.Clear()
        Form1.cbcodigo.SelectedIndex = -1
        Form1.cbgenero.SelectedIndex = -1
        Form1.cbtaller.SelectedIndex = -1
    End Sub

    Sub limpiarvectores()
        Dim i As Byte
        For i = 0 To 6
            edad(i) = Nothing
            genero(i) = Nothing
            codigo(i) = Nothing
            monto(i) = Nothing
            taller(i) = Nothing
            deducible(i) = Nothing
        Next i
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()

        fila = 0
    End Sub

    Sub limpiarestadisticas()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.TextBox5.Text = ""
        Form1.TextBox6.Text = ""
    End Sub

    Sub totales()
        Dim total As Integer = 0
        Dim z As Integer

        For z = 0 To Form1.ListBox4.Items.Count - 1
            total = total + Val(Form1.ListBox4.Items.Item(z))
        Next z
        Form1.TextBox6.Text = Str(total)

    End Sub

    Sub estadisticas()
        Dim i As Byte
        Dim e1 As Byte = 0
        Dim e2 As Byte = 0
        Dim e3 As Byte = 0
        Dim e4 As Byte = 0

        For i = 0 To Form1.ListBox1.Items.Count - 1
            If (edad(i) < 25) Then
                e1 = e1 + 1
            End If
            If (genero(i) = "Femenino") Then
                e2 = e2 + 1
            End If
            If (genero(i) = "Masculino") And (edad(i) > 18) And (edad(i) < 25) Then
                e3 = e3 + 1
            End If
            If (codigo(i) = "0") Then
                e4 = e4 + 1
            End If
        Next i

        Form1.TextBox1.Text = (e1 / fila) * 100
        Form1.TextBox2.Text = (e2 / fila) * 100
        Form1.TextBox3.Text = (e3 / fila) * 100
        Form1.TextBox4.Text = (e4 / fila) * 100
        Form1.TextBox5.Text = fila
    End Sub

End Module
