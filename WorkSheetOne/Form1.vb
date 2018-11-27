Public Class Form1

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        lblSalay.Text = txtSalary.Text * 12
        lblTax.Text = lblSalay.Text * 0.05
        lblMoney.Text = lblSalay.Text - lblTax.Text
    End Sub
End Class
