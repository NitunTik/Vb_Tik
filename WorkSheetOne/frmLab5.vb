Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Double

    Private Sub radMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.Click
        radCredit.Enabled = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.Click
        radCredit.Enabled = False
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaid.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        decDiscount = 0
        Dim num1, num2 As Double
        num1 = Val(txtPrice.Text)
        num2 = Val(txtUnit.Text)
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        If txtProduct.Text = "" Or num1 = 0 Or num2 = 0 Or decTotal < 0 Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "ERROR")
        Else
            If radMember.Checked = True And radPaid.Checked = True Then
                If decTotal < 1000 Then
                    decDiscount = 0
                ElseIf decTotal < 5000 Then
                    decDiscount = 0.05 * decTotal
                ElseIf decTotal < 10000 Then
                    decDiscount = 0.1 * decTotal
                Else
                    decDiscount = 0.15 * decTotal
                End If
                decNet = decTotal - decDiscount
                decCredit = 0
            ElseIf radMember.Checked = True And radCredit.Checked = True Then
                decCredit = decTotal
                decNet = decTotal
                decDiscount = 0
            Else
                decNet = decTotal
                decDiscount = 0
                decCredit = 0
            End If
            lblCredit.Text = decCredit
            lblDiscount.Text = decDiscount
            lblPaid.Text = decNet
        End If
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = Val(txtUnit.Text) * Val(txtPrice.Text)
    End Sub

    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radMember.Select()
        radPaid.Select()
    End Sub
End Class