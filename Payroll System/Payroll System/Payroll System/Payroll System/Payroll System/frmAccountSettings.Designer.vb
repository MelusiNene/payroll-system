<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbSelectWorkerID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblWorkerFullname = New System.Windows.Forms.Label()
        Me.lblOldPassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtWorkerFullname = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbSelectStaffID = New System.Windows.Forms.ComboBox()
        Me.lblSelectStaffID = New System.Windows.Forms.Label()
        Me.grpStaffInfo = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdbtnAdmin = New System.Windows.Forms.RadioButton()
        Me.rdbtnUser = New System.Windows.Forms.RadioButton()
        Me.txtSecretQuestion = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLinkShow = New System.Windows.Forms.LinkLabel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblLinkHide = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpStaffInfo.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1001, 534)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Settings"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Location = New System.Drawing.Point(503, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(484, 477)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbSelectWorkerID)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox5.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(467, 87)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Worker Accounts"
        '
        'cbSelectWorkerID
        '
        Me.cbSelectWorkerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectWorkerID.FormattingEnabled = True
        Me.cbSelectWorkerID.Location = New System.Drawing.Point(180, 43)
        Me.cbSelectWorkerID.Name = "cbSelectWorkerID"
        Me.cbSelectWorkerID.Size = New System.Drawing.Size(200, 27)
        Me.cbSelectWorkerID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(212, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select Worker ID:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ListView1)
        Me.GroupBox7.Controls.Add(Me.txtNewPassword)
        Me.GroupBox7.Controls.Add(Me.lblWorkerFullname)
        Me.GroupBox7.Controls.Add(Me.lblOldPassword)
        Me.GroupBox7.Controls.Add(Me.lblNewPassword)
        Me.GroupBox7.Controls.Add(Me.btnSave)
        Me.GroupBox7.Controls.Add(Me.txtWorkerFullname)
        Me.GroupBox7.Controls.Add(Me.txtOldPassword)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 119)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(467, 352)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(16, 181)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(434, 165)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Worker ID"
        Me.ColumnHeader1.Width = 111
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Worker Fullname"
        Me.ColumnHeader2.Width = 318
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(146, 102)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword.Size = New System.Drawing.Size(304, 27)
        Me.txtNewPassword.TabIndex = 11
        Me.txtNewPassword.TabStop = False
        '
        'lblWorkerFullname
        '
        Me.lblWorkerFullname.AutoSize = True
        Me.lblWorkerFullname.ForeColor = System.Drawing.Color.Black
        Me.lblWorkerFullname.Location = New System.Drawing.Point(12, 26)
        Me.lblWorkerFullname.Name = "lblWorkerFullname"
        Me.lblWorkerFullname.Size = New System.Drawing.Size(130, 19)
        Me.lblWorkerFullname.TabIndex = 0
        Me.lblWorkerFullname.Text = "Worker Fullname:"
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.ForeColor = System.Drawing.Color.Black
        Me.lblOldPassword.Location = New System.Drawing.Point(36, 66)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(106, 19)
        Me.lblOldPassword.TabIndex = 1
        Me.lblOldPassword.Text = "Old Password:"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.ForeColor = System.Drawing.Color.Black
        Me.lblNewPassword.Location = New System.Drawing.Point(29, 107)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(113, 19)
        Me.lblNewPassword.TabIndex = 2
        Me.lblNewPassword.Text = "New Password:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(313, 135)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtWorkerFullname
        '
        Me.txtWorkerFullname.BackColor = System.Drawing.Color.SkyBlue
        Me.txtWorkerFullname.Location = New System.Drawing.Point(146, 23)
        Me.txtWorkerFullname.Name = "txtWorkerFullname"
        Me.txtWorkerFullname.ReadOnly = True
        Me.txtWorkerFullname.Size = New System.Drawing.Size(304, 27)
        Me.txtWorkerFullname.TabIndex = 4
        Me.txtWorkerFullname.TabStop = False
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldPassword.Location = New System.Drawing.Point(146, 63)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtOldPassword.ReadOnly = True
        Me.txtOldPassword.Size = New System.Drawing.Size(304, 27)
        Me.txtOldPassword.TabIndex = 5
        Me.txtOldPassword.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.grpStaffInfo)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 477)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbSelectStaffID)
        Me.GroupBox3.Controls.Add(Me.lblSelectStaffID)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(467, 87)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Staff Accounts"
        '
        'cbSelectStaffID
        '
        Me.cbSelectStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectStaffID.FormattingEnabled = True
        Me.cbSelectStaffID.Location = New System.Drawing.Point(180, 43)
        Me.cbSelectStaffID.Name = "cbSelectStaffID"
        Me.cbSelectStaffID.Size = New System.Drawing.Size(200, 27)
        Me.cbSelectStaffID.TabIndex = 13
        '
        'lblSelectStaffID
        '
        Me.lblSelectStaffID.AutoSize = True
        Me.lblSelectStaffID.ForeColor = System.Drawing.Color.Black
        Me.lblSelectStaffID.Location = New System.Drawing.Point(219, 21)
        Me.lblSelectStaffID.Name = "lblSelectStaffID"
        Me.lblSelectStaffID.Size = New System.Drawing.Size(108, 19)
        Me.lblSelectStaffID.TabIndex = 12
        Me.lblSelectStaffID.Text = "Select Staff ID:"
        '
        'grpStaffInfo
        '
        Me.grpStaffInfo.Controls.Add(Me.GroupBox6)
        Me.grpStaffInfo.Controls.Add(Me.txtSecretQuestion)
        Me.grpStaffInfo.Controls.Add(Me.btnEdit)
        Me.grpStaffInfo.Controls.Add(Me.lblUsername)
        Me.grpStaffInfo.Controls.Add(Me.lblLinkShow)
        Me.grpStaffInfo.Controls.Add(Me.lblPassword)
        Me.grpStaffInfo.Controls.Add(Me.lblQuestion)
        Me.grpStaffInfo.Controls.Add(Me.btnConfirm)
        Me.grpStaffInfo.Controls.Add(Me.lblAnswer)
        Me.grpStaffInfo.Controls.Add(Me.txtSecretAnswer)
        Me.grpStaffInfo.Controls.Add(Me.txtUsername)
        Me.grpStaffInfo.Controls.Add(Me.txtPassword)
        Me.grpStaffInfo.Controls.Add(Me.lblLinkHide)
        Me.grpStaffInfo.Location = New System.Drawing.Point(6, 119)
        Me.grpStaffInfo.Name = "grpStaffInfo"
        Me.grpStaffInfo.Size = New System.Drawing.Size(467, 352)
        Me.grpStaffInfo.TabIndex = 15
        Me.grpStaffInfo.TabStop = False
        Me.grpStaffInfo.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdbtnAdmin)
        Me.GroupBox6.Controls.Add(Me.rdbtnUser)
        Me.GroupBox6.Location = New System.Drawing.Point(180, 26)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        '
        'rdbtnAdmin
        '
        Me.rdbtnAdmin.AutoSize = True
        Me.rdbtnAdmin.ForeColor = System.Drawing.Color.Crimson
        Me.rdbtnAdmin.Location = New System.Drawing.Point(24, 20)
        Me.rdbtnAdmin.Name = "rdbtnAdmin"
        Me.rdbtnAdmin.Size = New System.Drawing.Size(72, 23)
        Me.rdbtnAdmin.TabIndex = 14
        Me.rdbtnAdmin.TabStop = True
        Me.rdbtnAdmin.Text = "Admin"
        Me.rdbtnAdmin.UseVisualStyleBackColor = True
        '
        'rdbtnUser
        '
        Me.rdbtnUser.AutoSize = True
        Me.rdbtnUser.ForeColor = System.Drawing.Color.Crimson
        Me.rdbtnUser.Location = New System.Drawing.Point(119, 20)
        Me.rdbtnUser.Name = "rdbtnUser"
        Me.rdbtnUser.Size = New System.Drawing.Size(57, 23)
        Me.rdbtnUser.TabIndex = 15
        Me.rdbtnUser.TabStop = True
        Me.rdbtnUser.Text = "User"
        Me.rdbtnUser.UseVisualStyleBackColor = True
        '
        'txtSecretQuestion
        '
        Me.txtSecretQuestion.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSecretQuestion.Location = New System.Drawing.Point(140, 178)
        Me.txtSecretQuestion.Name = "txtSecretQuestion"
        Me.txtSecretQuestion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSecretQuestion.ReadOnly = True
        Me.txtSecretQuestion.Size = New System.Drawing.Size(304, 27)
        Me.txtSecretQuestion.TabIndex = 11
        Me.txtSecretQuestion.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(307, 250)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(137, 35)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(53, 102)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 19)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblLinkShow
        '
        Me.lblLinkShow.AutoSize = True
        Me.lblLinkShow.Location = New System.Drawing.Point(136, 250)
        Me.lblLinkShow.Name = "lblLinkShow"
        Me.lblLinkShow.Size = New System.Drawing.Size(47, 19)
        Me.lblLinkShow.TabIndex = 10
        Me.lblLinkShow.TabStop = True
        Me.lblLinkShow.Text = "Show"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(56, 142)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 19)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.ForeColor = System.Drawing.Color.Black
        Me.lblQuestion.Location = New System.Drawing.Point(13, 181)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(121, 19)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Secret Question:"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Location = New System.Drawing.Point(307, 250)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(137, 35)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.TabStop = False
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblAnswer.Location = New System.Drawing.Point(23, 220)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(111, 19)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "Secret Answer:"
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSecretAnswer.Location = New System.Drawing.Point(140, 217)
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSecretAnswer.ReadOnly = True
        Me.txtSecretAnswer.Size = New System.Drawing.Size(304, 27)
        Me.txtSecretAnswer.TabIndex = 7
        Me.txtSecretAnswer.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.SkyBlue
        Me.txtUsername.Location = New System.Drawing.Point(140, 99)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(304, 27)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.SkyBlue
        Me.txtPassword.Location = New System.Drawing.Point(140, 139)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(304, 27)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.TabStop = False
        '
        'lblLinkHide
        '
        Me.lblLinkHide.AutoSize = True
        Me.lblLinkHide.Location = New System.Drawing.Point(136, 250)
        Me.lblLinkHide.Name = "lblLinkHide"
        Me.lblLinkHide.Size = New System.Drawing.Size(40, 19)
        Me.lblLinkHide.TabIndex = 9
        Me.lblLinkHide.TabStop = True
        Me.lblLinkHide.Text = "Hide"
        '
        'frmAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1025, 558)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll System - Account Settings | Version 1.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpStaffInfo.ResumeLayout(False)
        Me.grpStaffInfo.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblLinkShow As System.Windows.Forms.LinkLabel
    Friend WithEvents lblLinkHide As System.Windows.Forms.LinkLabel
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSelectStaffID As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectStaffID As System.Windows.Forms.Label
    Friend WithEvents grpStaffInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtSecretQuestion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnUser As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSelectWorkerID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkerFullname As System.Windows.Forms.Label
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtWorkerFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
