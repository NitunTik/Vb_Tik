<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab7
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
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "โปรแกรมควบคุม ListBox - ComboBox"
        '
        'cboOutput
        '
        Me.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(254, 47)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(121, 21)
        Me.cboOutput.TabIndex = 4
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.SystemColors.Control
        Me.btnMove.CausesValidation = False
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMove.Location = New System.Drawing.Point(199, 80)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(50, 30)
        Me.btnMove.TabIndex = 5
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnMoveAll
        '
        Me.btnMoveAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnMoveAll.CausesValidation = False
        Me.btnMoveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMoveAll.Location = New System.Drawing.Point(199, 116)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(50, 30)
        Me.btnMoveAll.TabIndex = 5
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.CausesValidation = False
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(199, 152)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 30)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBackAll
        '
        Me.btnBackAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnBackAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBackAll.Location = New System.Drawing.Point(199, 188)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(50, 30)
        Me.btnBackAll.TabIndex = 5
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.CausesValidation = False
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(254, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.CausesValidation = False
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(59, 256)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 29)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.CausesValidation = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Location = New System.Drawing.Point(161, 344)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 29)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "ปิดหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(59, 301)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(121, 20)
        Me.txtAdd.TabIndex = 0
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(254, 301)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(121, 20)
        Me.lblOutput.TabIndex = 7
        '
        'lstAdd
        '
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.Location = New System.Drawing.Point(43, 47)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(150, 186)
        Me.lstAdd.TabIndex = 8
        '
        'frmLab7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(403, 385)
        Me.Controls.Add(Me.lstAdd)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab7"
<<<<<<< HEAD
        Me.Text = " "
=======
        Me.Text = "frmLab7"
>>>>>>> master
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOutput As System.Windows.Forms.ComboBox
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBackAll As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lstAdd As System.Windows.Forms.ListBox
End Class
