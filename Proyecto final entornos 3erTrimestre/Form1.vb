Public Class Form1
    Dim recargaDePuntos As Integer = 100
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPuntos.Text = recargaDePuntos
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        lblPuntos.Text = recargaDePuntos
        btnJugar.Enabled = True

    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim puntos As Integer = lblPuntos.Text
        puntos = puntos - 1

        If puntos <= 0 Then
            btnJugar.Enabled = False
        End If

        Randomize()
        lbl1.Text = Int(Rnd() * 8)
        lbl2.Text = Int(Rnd() * 8)
        lbl3.Text = Int(Rnd() * 8)

        If lbl1.Text = 7 And lbl2.Text = 7 And lbl3.Text = 7 Then
            Dim ganancia As Integer = 100
            puntos = puntos + ganancia
            Beep()
        End If
        If lbl1.Text = lbl2.Text And lbl1.Text = lbl3.Text Then
            Dim ganancia As Integer = 10
            puntos = puntos + ganancia
            Beep()
        End If

        lblPuntos.Text = puntos

    End Sub

End Class
