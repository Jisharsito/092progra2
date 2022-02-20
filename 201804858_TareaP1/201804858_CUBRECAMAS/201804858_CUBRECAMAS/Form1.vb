Public Class Form1
    Private Sub result_Click(sender As Object, e As EventArgs) Handles result.Click
        Dim ta, mat, vent, total, mano, gan As Double

        If (peque.Checked = True) Then
            If (algo.Checked = True) Then
                ta = 65.5
                mat = 2 * 15.0
            ElseIf (seda.Checked = True) Then
                ta = 65.5
                mat = 2 * 23.99
            ElseIf (lona.Checked = True) Then
                ta = 65.5
                mat = 2 * 30.99
            Else
                MsgBox("No se ha seleccionado un material")
            End If
        ElseIf (medio.Checked = True) Then
            If (algo.Checked = True) Then
                ta = 85.99
                mat = 2.5 * 15.0
            ElseIf (seda.Checked = True) Then
                ta = 85.99
                mat = 2.5 * 23.99
            ElseIf (lona.Checked = True) Then
                ta = 85.99
                mat = 2.5 * 30.99
            Else
                MsgBox("No se ha seleccionado un material")
            End If
        ElseIf (grande.Checked = True) Then
            If (algo.Checked = True) Then
                ta = 99.99
                mat = 15.0
            ElseIf (seda.Checked = True) Then
                ta = 99.99
                mat = 23.99
            ElseIf (lona.Checked = True) Then
                ta = 99.99
                mat = 30.99
            Else
                MsgBox("No se ha seleccionado un material")
            End If
        Else
            MsgBox("No se ha seleccionado una talla o un material")
        End If

        mano = (ta + mat)
        gan = 0.65 * mano
        vent = mano + gan
        total = Convert.ToDouble(cant.Text) * vent

        costo.Text = mano.ToString("N2")
        venta.Text = vent.ToString("N2")
        resultado.Text = total.ToString("N2")

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        peque.Checked = False
        medio.Checked = False
        grande.Checked = False
        algo.Checked = False
        seda.Checked = False
        lona.Checked = False

        costo.Text = ""
        venta.Text = ""
        resultado.Text = ""

        cant.Text = ""

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
