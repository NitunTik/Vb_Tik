Public Class frmLab7
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        txtAdd.Focus()
        Dim q As Integer
        q = lstAdd.Items.Count
        lstAdd.SelectedIndex = q - 1
        q = cboOutput.Items.Count
        cboOutput.SelectedIndex = q - 1
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
            Dim q As Integer = lstAdd.SelectedIndex
            cboOutput.Items.Add(lstAdd.SelectedItem)
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            lstAdd.Items.Remove(lstAdd.SelectedItem)
            If lstAdd.Items.Count <> 0 Then
                If lstAdd.Items.Count <= q Then
                    lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                Else
                    lstAdd.SelectedIndex = q
                End If
            End If
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
        Dim q As Integer
        q = cboOutput.Items.Count
        cboOutput.SelectedIndex = q - 1
        q = lstAdd.Items.Count
        lstAdd.SelectedIndex = q - 1
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลิส")
        Else
            Dim q As Integer = cboOutput.SelectedIndex
            lstAdd.Items.Add(cboOutput.SelectedItem)
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            cboOutput.Items.Remove(cboOutput.SelectedItem)
            If cboOutput.Items.Count <> 0 Then
                If cboOutput.Items.Count <= q Then
                    cboOutput.SelectedIndex = cboOutput.Items.Count - 1
                Else
                    cboOutput.SelectedIndex = q
                End If
            End If
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกลิส")
        End If
        For Each item In cboOutput.Items
            lstAdd.Items.Add(item)
        Next
        cboOutput.Items.Clear()
        Dim q As Integer
        q = lstAdd.Items.Count
        lstAdd.SelectedIndex = q - 1
        q = cboOutput.Items.Count
        cboOutput.SelectedIndex = q - 1
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
        txtAdd.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class