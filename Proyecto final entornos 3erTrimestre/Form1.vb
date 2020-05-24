Public Class Form1
    Dim recargaDePuntos As Integer = 5000

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPuntos.Text = recargaDePuntos
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblPuntos.Text = recargaDePuntos
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtApuesta.Text = ""
    End Sub
End Class
