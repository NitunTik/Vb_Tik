Public Class BISLab2

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        Dim Computer, Printer, Sum, Com1, Com2, ComSum As Integer
        Computer = Val(txtComputer.Text)
        Printer = Val(txtPrinter.Text)
        Sum = Computer + Printer
        Com1 = Computer * 0.05
        Com2 = Printer * 0.1
        ComSum = Com1 + Com2
        lblSales.Text = Sum
        lblCommitment1.Text = Com1
        lblCommitment2.Text = Com2
        lblCommitmentSum.Text = ComSum
    End Sub
End Class