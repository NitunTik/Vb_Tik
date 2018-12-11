Public Class frmLab3

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtInput.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtInput.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtInput.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtInput.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        txtInput.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtInput.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtInput.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtInput.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        txtInput.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        txtInput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBRed.Click
        txtInput.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlue.Click
        txtInput.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGreen.Click
        txtInput.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBViolet.Click
        txtInput.BackColor = Color.Violet
    End Sub

    Private Sub lblBBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlack.Click
        txtInput.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBOrange.Click
        txtInput.BackColor = Color.Orange
    End Sub

    Private Sub lblBYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBYellow.Click
        txtInput.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBrown.Click
        txtInput.BackColor = Color.Brown
    End Sub

    Private Sub lblBWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBWhite.Click
        txtInput.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBSky.Click
        txtInput.BackColor = Color.SkyBlue
    End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        txtInput.Font = New Font(txtInput.Font.Name, cboSize.SelectedItem, FontStyle.Regular)
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        txtInput.Text = Val(txtInput.Text) + 2
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        txtInput.Text = Val(txtInput.Text) - 2
    End Sub
End Class