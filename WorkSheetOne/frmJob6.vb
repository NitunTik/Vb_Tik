Public Class frmJob6
    Dim Total As Double
    Private Sub chkForMe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkForMe.Click
        If chkForMe.Checked = True Then
            chkItemsAdd1.Enabled = True
            chkItemsAdd2.Enabled = True
            chkItemsAdd3.Enabled = True
            chkItemsAdd4.Enabled = True
            chkFree1.Enabled = True
            chkFree2.Enabled = True
            chkFree3.Enabled = True

            Total = Val(lblStartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
            lblPaidPrice.Text = Total
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("ต้องการยกเลิกการซื้อรถใช้หรืไม่", "", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then
                chkItemsAdd1.Enabled = False
                chkItemsAdd2.Enabled = False
                chkItemsAdd3.Enabled = False
                chkItemsAdd4.Enabled = False
                chkFree1.Enabled = False
                chkFree2.Enabled = False
                chkFree3.Enabled = False

                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""
            Else
                chkForMe.Checked = True

            End If
        End If
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            Total = Total + Val(lblItemsPrice1.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemsPrice1.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            Total = Total + Val(lblItemsPrice2.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemsPrice2.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            Total = Total + Val(lblItemsPrice3.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemsPrice3.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            Total = Total + Val(lblItemsPrice4.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemsPrice4.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            Total = Total - Val(lblFree1.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total + Val(lblFree1.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            Total = Total - Val(lblFree2.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total + Val(lblFree2.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            Total = Total - Val(lblFree3.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total + Val(lblFree3.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub
End Class