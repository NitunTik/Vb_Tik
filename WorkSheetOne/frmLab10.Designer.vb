<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(86, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายจากอาร์เรย์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "รายการข้อมูล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "พนักงานขายคนที่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ชื่อพนง.ขาย"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Items.AddRange(New Object() {",0,0,0", ",0,0,0", ",0,0,0", ",0,0,0", ",0,0,0"})
        Me.lstData.Location = New System.Drawing.Point(27, 72)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(120, 108)
        Me.lstData.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "รวมยอดขายสินค้า A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "รวมยอดขายสินค้า B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "รวมยอดขายสินค้า C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(163, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 26)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ผู้ที่ทำยอดขายสูงสุด"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(163, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 26)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "เป็นเงิน"
        '
        'lblSumA
        '
        Me.lblSumA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumA.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumA.Location = New System.Drawing.Point(282, 72)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.Size = New System.Drawing.Size(90, 26)
        Me.lblSumA.TabIndex = 6
        Me.lblSumA.Text = "0"
        Me.lblSumA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSumB
        '
        Me.lblSumB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumB.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumB.Location = New System.Drawing.Point(282, 107)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.Size = New System.Drawing.Size(90, 26)
        Me.lblSumB.TabIndex = 6
        Me.lblSumB.Text = "0"
        Me.lblSumB.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSumC
        '
        Me.lblSumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumC.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumC.Location = New System.Drawing.Point(282, 143)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.Size = New System.Drawing.Size(90, 26)
        Me.lblSumC.TabIndex = 6
        Me.lblSumC.Text = "0"
        Me.lblSumC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleName.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMaxSaleName.Location = New System.Drawing.Point(282, 186)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(90, 26)
        Me.lblMaxSaleName.TabIndex = 6
        Me.lblMaxSaleName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleAmount.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(282, 215)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(90, 26)
        Me.lblMaxSaleAmount.TabIndex = 6
        Me.lblMaxSaleAmount.Text = "0"
        Me.lblMaxSaleAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(27, 215)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(121, 21)
        Me.cboIndex.TabIndex = 8
        '
        'txtSaleName
        '
        Me.txtSaleName.Location = New System.Drawing.Point(27, 280)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(120, 20)
        Me.txtSaleName.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(312, 305)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 30)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSaleA
        '
        Me.txtSaleA.Location = New System.Drawing.Point(177, 279)
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(59, 20)
        Me.txtSaleA.TabIndex = 9
        '
        'txtSaleB
        '
        Me.txtSaleB.Location = New System.Drawing.Point(241, 279)
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(59, 20)
        Me.txtSaleB.TabIndex = 9
        '
        'txtSaleC
        '
        Me.txtSaleC.Location = New System.Drawing.Point(306, 279)
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(59, 20)
        Me.txtSaleC.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label15.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(172, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 26)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "ยอดขาย A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label16.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(238, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 26)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "ยอดขาย B"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(303, 250)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 26)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "ยอดขาย C"
        '
        'frmLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 345)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab10"
        Me.Text = "frmLab10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSumA As System.Windows.Forms.Label
    Friend WithEvents lblSumB As System.Windows.Forms.Label
    Friend WithEvents lblSumC As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleName As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleAmount As System.Windows.Forms.Label
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents txtSaleName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSaleA As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleB As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleC As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
