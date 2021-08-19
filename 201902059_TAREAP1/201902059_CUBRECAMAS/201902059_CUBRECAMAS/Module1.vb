Module Module1
    'Precios de mano de obra
    Public moimperial As Double = 65.5
    Public momatrimonial As Double = 85.99
    Public moqueen As Double = 99.99
    Public moking As Double = 105.99
    'Precios de material
    Public lino As Double = 15
    Public algodon As Double = 23.99
    Public seda As Double = 30.99
    Public hilo As Double = 39.99
    'Variables para operaciones
    Public manodeobra As Double
    Public material As Double
    Public yardas As Double
    'Costo por material
    Public costo As Double
    'Costo final
    Public Costofinal As Double
    Public venta As Double

    Public text1 As Double
    Public text2 As Double
    Public text3 As Double
    Public text4 As Double

    Sub limpiar()
        Form1.rbimperial.Checked = False
        Form1.rbking.Checked = False
        Form1.rbmatrimonial.Checked = False
        Form1.rbqueen.Checked = False
        Form1.chkalgodon.Checked = False
        Form1.chkhilo.Checked = False
        Form1.chklino.Checked = False
        Form1.chkseda.Checked = False
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form2.TextBox1.Clear()
        Form2.TextBox2.Clear()
        Form2.TextBox3.Clear()
        Form2.TextBox4.Clear()
        Form2.TextBox6.Clear()
        Form2.TextBox7.Clear()
    End Sub

    Sub salir()
        If (MsgBox("¿DESEA SALIR?", 36, "SALIR") = vbYes) Then
            End
        Else
            limpiar()
        End If
    End Sub
End Module
