Public Class Form3
    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click
        Dim num, result, comision As Double
        num = valor.Text
        If dolar.Checked = True Then
            result = num / 7.69
            comision = result * 0.025
            final.Text = "$ " + (result + comision).ToString("0.00")
        ElseIf peso.Checked = True Then
            result = num / 0.38
            comision = result * 0.025
            final.Text = "$ " + (result + comision).ToString("0.00")
        ElseIf euro.Checked = True Then
            result = num / 8.79
            comision = result * 0.025
            final.Text = "€ " + (result + comision).ToString("0.00")
        ElseIf colones.Checked = True Then
            result = num / 0.012
            comision = result * 0.025
            final.Text = "₡ " + (result + comision).ToString("0.000")
        End If
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        final.Text = ""
        valor.Text = ""
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class