Public Class Form1
    Dim recargaDePuntos As Integer = 100
    ''' <summary>
    ''' Método que carga el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setPuntos(recargaDePuntos) ''Refactorización Extraer método- Creo un método en lugar de repetir 3 veces la misma parte del código
    End Sub
    ''' <summary>
    ''' Método que te recarga los puntos al hacerle click al botón recargar
    ''' </summary>
    ''' <param name="sender">El objeto donde se ha producido el evento</param>
    ''' <param name="e">El evento que se ha producido</param>
    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        setPuntos(recargaDePuntos) ''Refactorización Extraer método- Creo un método en lugar de repetir 3 veces la misma parte del código
        btnJugar.Enabled = True

    End Sub
    ''' <summary>
    ''' Método que te resta 1 punto en cada jugada y la tragaperras saca 3 numeros aleatorios, si son los tres iguales te da un premio y si son los tres un 7 un premio mayor
    ''' </summary>
    ''' <param name="sender">El objeto donde se ha producido el evento</param>
    ''' <param name="e">El evento que se ha producido</param>
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim puntos As Integer = getPuntos() ''Refactorización Extraer método- Creo un método en lugar de repetir 3 veces la misma parte del código
        puntos = puntos - 1

        If puntos <= 0 Then
            btnJugar.Enabled = False
        End If

        lbl1.Text = generarRandom() ''Refactorización Extraer método- Creo un método en lugar de repetir 3 veces la misma parte del código
        lbl2.Text = generarRandom()
        lbl3.Text = generarRandom()

        If lbl1.Text = 7 And lbl2.Text = 7 And lbl3.Text = 7 Then
            Dim ganancia As Integer = 100
            puntos = puntos + ganancia
            Beep()
        ElseIf lbl1.Text = lbl2.Text And lbl1.Text = lbl3.Text Then
            Dim ganancia As Integer = 10
            puntos = puntos + ganancia
            Beep()
        End If

        setPuntos(puntos) ''Refactorización Extraer método- Uso un método creado para no repetir código

    End Sub
    ''' <summary>
    ''' Método que recoge los puntos del label puntos
    ''' </summary>
    ''' <returns>Retorna los puntos</returns>
    Private Function getPuntos()
        Return lblPuntos.Text
    End Function
    ''' <summary>
    ''' Método que introduce los puntos en el label puntos
    ''' </summary>
    ''' <param name="puntos">Se le pasa por valor una variable de tipo Integer</param>
    Private Sub setPuntos(ByVal puntos As Integer)
        lblPuntos.Text = puntos
    End Sub
    ''' <summary>
    ''' Método que genera un número aleatorio
    ''' </summary>
    ''' <returns>Retorna el número aleatorio</returns>
    Private Function generarRandom()
        Randomize()
        Return Int(Rnd() * 8)
    End Function
End Class
