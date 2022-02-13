Public Class Form2
    Private Sub pagoF_Click(sender As Object, e As EventArgs) Handles pagoF.Click
        Dim num, result, comision As Double
        num = valor.Text
        If dolar.Checked = True Then
            result = num * 7.69
            comision = result * 0.03
            resultadoV.Text = "Q " + (result + comision).ToString("0.00")
        ElseIf peso.Checked = True Then
            result = num * 0.38
            comision = result * 0.03
            resultadoV.Text = "Q " + (result + comision).ToString("0.00")
        ElseIf euro.Checked = True Then
            result = num * 8.79
            comision = result * 0.03
            resultadoV.Text = "Q " + (result + comision).ToString("0.00")
        ElseIf colones.Checked = True Then
            result = num * 0.012
            comision = result * 0.03
            resultadoV.Text = "Q " + (result + comision).ToString("0.000")
        End If
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        resultadoV.Text = ""
        valor.Text = ""
    End Sub

    Private Sub salir2_Click(sender As Object, e As EventArgs) Handles salir2.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class