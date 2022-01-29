Public Class Form1
    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Dim prod1, prod2, prod3, suma, impu, descu As Double

        prod1 = arroz.Text * 2
        prod2 = frijol.Text * 1.75
        prod3 = azucar.Text * 2.5

        suma = prod1 + prod2 + prod3

        pago1.Text = "Q" + suma.ToString("0.000")

        impu = suma * 0.12

        iva.Text = "Q" + impu.ToString("0.000")

        pago2.Text = "Q" + (suma + impu).ToString("0.000")

        descu = (suma + impu) * 0.025

        desc.Text = "Q" + descu.ToString("0.000")

        pago3.Text = "Q" + (suma + impu - descu).ToString("0.000")

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        arroz.Text = ""
        frijol.Text = ""
        azucar.Text = ""
        pago1.Text = ""
        iva.Text = ""
        pago2.Text = ""
        desc.Text = ""
        pago3.Text = ""

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
