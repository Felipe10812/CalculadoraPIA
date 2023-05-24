Public Class Calculadora
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Operador As Boolean

    Private Sub ButtonUno_Click(sender As Object, e As EventArgs) Handles ButtonUno.Click
        Restricciones()
        TextResultado.Text &= "1"
    End Sub

    Private Sub ButtonDos_Click(sender As Object, e As EventArgs) Handles ButtonDos.Click
        Restricciones()
        TextResultado.Text &= "2"
    End Sub

    Private Sub ButtonTres_Click(sender As Object, e As EventArgs) Handles ButtonTres.Click
        Restricciones()
        TextResultado.Text &= "3"
    End Sub

    Private Sub ButtonCuatro_Click(sender As Object, e As EventArgs) Handles ButtonCuatro.Click
        Restricciones()
        TextResultado.Text &= "4"
    End Sub

    Private Sub ButtonCinco_Click(sender As Object, e As EventArgs) Handles ButtonCinco.Click
        Restricciones()
        TextResultado.Text &= "5"
    End Sub

    Private Sub ButtonSeis_Click(sender As Object, e As EventArgs) Handles ButtonSeis.Click
        Restricciones()
        TextResultado.Text &= "6"
    End Sub

    Private Sub ButtonSiete_Click(sender As Object, e As EventArgs) Handles ButtonSiete.Click
        Restricciones()
        TextResultado.Text &= "7"
    End Sub

    Private Sub ButtonOcho_Click(sender As Object, e As EventArgs) Handles ButtonOcho.Click
        Restricciones()
        TextResultado.Text &= "8"
    End Sub

    Private Sub ButtonNueve_Click(sender As Object, e As EventArgs) Handles ButtonNueve.Click
        Restricciones()
        TextResultado.Text &= "9"
    End Sub

    Private Sub ButtonCero_Click(sender As Object, e As EventArgs) Handles ButtonCero.Click
        Restricciones()
        TextResultado.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        Restricciones()
        If InStr(TextResultado.Text, ".", CompareMethod.Text) = 0 Then
            TextResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        HazOperacion()
        Operacion = ""
    End Sub

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Suma.Click
        HazOperacion()
        Operacion = "+"
    End Sub

    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles Resta.Click
        HazOperacion()
        Operacion = "-"
    End Sub

    Private Sub Multiplicacion_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click
        HazOperacion()
        Operacion = "x"
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        HazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        TextResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        If TextResultado.Text.Length > 0 Then
            TextResultado.Text = TextResultado.Text.Substring(0, TextResultado.Text.Length - 1)
        End If
    End Sub

    Public Sub HazOperacion()
        Operador = True
        Valor2 = Val(TextResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "/"
                    ValorResultado /= Valor2
                Case "x"
                    ValorResultado *= Valor2
            End Select
            TextResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub Restricciones()
        If Operador = True Then
            TextResultado.Text = ""
            Operador = False
        ElseIf TextResultado.Text = "0" Then
            TextResultado.Text = ""
        End If
    End Sub

End Class
