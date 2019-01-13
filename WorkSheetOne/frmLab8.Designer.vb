<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
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
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOldTotalScore = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOldTotalCredit = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblOldGPA = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "โปรแกรมคำนวณเกรดเฉลี่ยสะสม"
        '
        'lstSubject
        '
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.Location = New System.Drawing.Point(22, 73)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(96, 134)
        Me.lstSubject.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "วิชา"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "คะแนนสอบ"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(226, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "หน่วนกิต"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(328, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "เกรด"
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.Location = New System.Drawing.Point(124, 73)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(96, 134)
        Me.lstScore.TabIndex = 5
        '
        'lstCredit
        '
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.Location = New System.Drawing.Point(226, 73)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(96, 134)
        Me.lstCredit.TabIndex = 5
        '
        'lstGrade
        '
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.Location = New System.Drawing.Point(328, 73)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(96, 134)
        Me.lstGrade.TabIndex = 5
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(22, 213)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(96, 20)
        Me.txtSubject.TabIndex = 0
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(124, 213)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(96, 20)
        Me.txtScore.TabIndex = 1
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(226, 213)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(96, 20)
        Me.txtCredit.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(328, 213)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(47, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(377, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(47, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "คะแนนสะสมก่อนหน้า"
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOldTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldTotalScore.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldTotalScore.Location = New System.Drawing.Point(120, 240)
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(60, 23)
        Me.lblOldTotalScore.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(186, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "หน่วยกิตสะสม"
        '
        'lblOldTotalCredit
        '
        Me.lblOldTotalCredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOldTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldTotalCredit.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldTotalCredit.Location = New System.Drawing.Point(262, 240)
        Me.lblOldTotalCredit.Name = "lblOldTotalCredit"
        Me.lblOldTotalCredit.Size = New System.Drawing.Size(60, 23)
        Me.lblOldTotalCredit.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(328, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "เกรดเฉลี่ยสะสม"
        '
        'lblOldGPA
        '
        Me.lblOldGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOldGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldGPA.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldGPA.Location = New System.Drawing.Point(377, 240)
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(60, 23)
        Me.lblOldGPA.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 28)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNewGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewGPA.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNewGPA.Location = New System.Drawing.Point(211, 294)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(77, 23)
        Me.lblNewGPA.TabIndex = 9
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 350)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.lblOldTotalCredit)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab8"
        Me.Text = "frmLab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstSubject As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstScore As System.Windows.Forms.ListBox
    Friend WithEvents lstCredit As System.Windows.Forms.ListBox
    Friend WithEvents lstGrade As System.Windows.Forms.ListBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblOldTotalScore As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblOldTotalCredit As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblOldGPA As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNewGPA As System.Windows.Forms.Label
End Class
