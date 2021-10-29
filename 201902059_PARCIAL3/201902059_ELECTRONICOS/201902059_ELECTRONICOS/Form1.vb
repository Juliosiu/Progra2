Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("L01")
        ComboBox1.Items.Add("L02")
        ComboBox1.Items.Add("L03")
        ComboBox1.Items.Add("L04")
        ComboBox1.Items.Add("L05")
        ComboBox1.Items.Add("L06")
        ComboBox2.Items.Add("Memoria RAM")
        ComboBox2.Items.Add("Disco Duro")
        ComboBox2.Items.Add("Procesador")
        ComboBox2.Items.Add("MotherBoard")
        ComboBox2.Items.Add("Tarjeta Gráfica")
        ComboBox2.Items.Add("SSD")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ComboBox2.SelectedIndex = 0
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ComboBox2.SelectedIndex = 1
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ComboBox2.SelectedIndex = 2
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ComboBox2.SelectedIndex = 3
        ElseIf ComboBox1.SelectedIndex = 4 Then
            ComboBox2.SelectedIndex = 4
        ElseIf ComboBox1.SelectedIndex = 5 Then
            ComboBox2.SelectedIndex = 5
        End If
    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        operar()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir?", vbYesNo, "SALR") = vbYes Then
            End
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        consultar()
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        estadisticas()
    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        limpiarmatriz()
    End Sub

    Private Sub EstadísticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem1.Click
        limpiarestadisticas()
    End Sub
End Class
