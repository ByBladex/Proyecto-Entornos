Public Class Form1
    Dim recargaDePuntos As Integer = 100
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPuntos.Text = recargaDePuntos
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        lblPuntos.Text = recargaDePuntos
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim puntos As Integer = lblPuntos.Text
        puntos = puntos - 1
        lblPuntos.Text = puntos

        Dim ganancia As Integer = 100

        Randomize()
        lbl1.Text = Int(Rnd() * 10)
        lbl2.Text = Int(Rnd() * 10)
        lbl3.Text = Int(Rnd() * 10)

        'Si algún número es un 7 mostrar la imagen y emitir un sonido
        If lbl1.Text = 7 And lbl2.Text = 7 And lbl3.Text = 7 Then
            puntos = puntos + ganancia
            Beep()
        End If
    End Sub

End Class
