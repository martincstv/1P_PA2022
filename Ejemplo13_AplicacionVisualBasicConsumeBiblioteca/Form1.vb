Imports Ejemplo13_BibliotecaClases

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = Convert.ToDouble(TextBox_Numero1.Text)
        numero2 = Convert.ToDouble(TextBox_Numero2.Text)

        Dim operaciones As New Operaciones
        resultado = operaciones.Potencia(numero1, numero2)
        Label_Resultado.Text = resultado.ToString

    End Sub
End Class

