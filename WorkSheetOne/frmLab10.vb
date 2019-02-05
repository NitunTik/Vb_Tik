Public Class frmLab10
    Dim decSale(4, 2) As Decimal
    Dim saleName(4) As String
    Dim intIndex, decSumSale As Double
    Private Sub frmLab10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 4
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not IsNumeric(txtSaleA.Text = "") Or Not IsNumeric(txtSaleB.Text = "") Or Not IsNumeric(txtSaleC.Text = "") Then
            MessageBox.Show("ป้อนค่าตัวเลขเท่านั้น")
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleA.Focus()
        Else
            Dim a As Decimal = cboIndex.SelectedIndex
            lstData.SelectedIndex = a
            lstData.Items.Remove(a)
            decSale(a, 0) = Val(txtSaleA.Text)
            decSale(a, 1) = Val(txtSaleB.Text)
            decSale(a, 2) = Val(txtSaleC.Text)
            For i = 0 To 2
                saleName(a) = txtSaleName.Text
                decSale(a, i) = decSale(a, i)
            Next
            txtSaleName.Clear()
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleName.Focus()
            showData()
        End If
    End Sub
    Private Sub showData()
        Dim salea, saleb, salec As Integer
        lstData.Items.Clear()
        For i = 0 To cboIndex.Items.Count - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
        Next
        For i = 0 To 4
            salea = salea + decSale(i, 0)
            saleb = saleb + decSale(i, 1)
            salec = salec + decSale(i, 2)
        Next
        lblSumA.Text = salea
        lblSumB.Text = saleb
        lblSumC.Text = salec
    End Sub
End Class