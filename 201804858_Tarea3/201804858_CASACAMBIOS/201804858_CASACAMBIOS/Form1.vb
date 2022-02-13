Public Class Form1
    Private Sub aplicar_Click(sender As Object, e As EventArgs) Handles aplicar.Click
        If btnVenta.Checked = True Then
            Form2.ShowDialog()
        End If

        If btnCompra.Checked = True Then
            Form3.ShowDialog()
        End If
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
