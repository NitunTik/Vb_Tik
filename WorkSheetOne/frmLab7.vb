Public Class frmLab7
    Dim q As Integer
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        txtAdd.Focus()
        q = lstAdd.Items.Count
        lstAdd.SelectedIndex = q - 1
    End Sub

    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลิส")
        Else
            cboOutput.Items.Add(lstAdd.Text)
            lstAdd.Items.Remove(lstAdd.Text)
        End If
    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลิส")
        End If
        For Each item In lstAdd.Items
            cboOutput.Items.Add(item)
        Next
        lstAdd.Items.Clear()
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลิส")
        Else
            lstAdd.Items.Add(cboOutput.Text)
            cboOutput.Items.Remove(cboOutput.Text)
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลิส")
        End If
        For Each item In cboOutput.Items
            lstAdd.Items.Add(item)
        Next
        cboOutput.Items.Clear()
    End Sub

    Private Sub lstAdd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAdd.SelectedIndexChanged
        lblOutput.Text = lstAdd.SelectedItem
    End Sub
    Private Sub cboOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        txtAdd.Clear()
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class