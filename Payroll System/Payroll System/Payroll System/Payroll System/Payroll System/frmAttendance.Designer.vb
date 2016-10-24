<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblWorkerPassword = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cbWorkerFullnames = New System.Windows.Forms.ComboBox()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnTimeOUT = New System.Windows.Forms.Button()
        Me.btnTimeIN = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Listview1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpActions)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(897, 511)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.btnViewRecords)
        Me.grpActions.Controls.Add(Me.MenuStrip1)
        Me.grpActions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpActions.ForeColor = System.Drawing.Color.Crimson
        Me.grpActions.Location = New System.Drawing.Point(6, 434)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(338, 71)
        Me.grpActions.TabIndex = 15
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Actions"
        '
        'btnViewRecords
        '
        Me.btnViewRecords.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnViewRecords.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewRecords.Location = New System.Drawing.Point(16, 26)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(306, 32)
        Me.btnViewRecords.TabIndex = 5
        Me.btnViewRecords.Text = "View Records"
        Me.btnViewRecords.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 47)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(155, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LoginToolStripMenuItem.Text = "Admin"
        Me.LoginToolStripMenuItem.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(338, 409)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblWorkerPassword)
        Me.GroupBox7.Controls.Add(Me.btnLogIn)
        Me.GroupBox7.Controls.Add(Me.txtPassword)
        Me.GroupBox7.Controls.Add(Me.cbWorkerFullnames)
        Me.GroupBox7.Controls.Add(Me.lblFullname)
        Me.GroupBox7.Controls.Add(Me.btnLogOut)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(325, 225)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        '
        'lblWorkerPassword
        '
        Me.lblWorkerPassword.AutoSize = True
        Me.lblWorkerPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkerPassword.ForeColor = System.Drawing.Color.Crimson
        Me.lblWorkerPassword.Location = New System.Drawing.Point(103, 103)
        Me.lblWorkerPassword.Name = "lblWorkerPassword"
        Me.lblWorkerPassword.Size = New System.Drawing.Size(120, 18)
        Me.lblWorkerPassword.TabIndex = 19
        Me.lblWorkerPassword.Text = "Worker Password:"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogIn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogIn.Location = New System.Drawing.Point(9, 172)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(306, 32)
        Me.btnLogIn.TabIndex = 18
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(9, 122)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(306, 27)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbWorkerFullnames
        '
        Me.cbWorkerFullnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkerFullnames.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbWorkerFullnames.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbWorkerFullnames.FormattingEnabled = True
        Me.cbWorkerFullnames.Location = New System.Drawing.Point(9, 48)
        Me.cbWorkerFullnames.Name = "cbWorkerFullnames"
        Me.cbWorkerFullnames.Size = New System.Drawing.Size(306, 27)
        Me.cbWorkerFullnames.TabIndex = 7
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Crimson
        Me.lblFullname.Location = New System.Drawing.Point(101, 27)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(119, 18)
        Me.lblFullname.TabIndex = 4
        Me.lblFullname.Text = "Worker Fullname:"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogOut.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogOut.Location = New System.Drawing.Point(9, 172)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(306, 32)
        Me.btnLogOut.TabIndex = 20
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnTimeOUT)
        Me.GroupBox8.Controls.Add(Me.btnTimeIN)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 250)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(325, 127)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        '
        'btnTimeOUT
        '
        Me.btnTimeOUT.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTimeOUT.Enabled = False
        Me.btnTimeOUT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTimeOUT.Location = New System.Drawing.Point(184, 30)
        Me.btnTimeOUT.Name = "btnTimeOUT"
        Me.btnTimeOUT.Size = New System.Drawing.Size(119, 81)
        Me.btnTimeOUT.TabIndex = 18
        Me.btnTimeOUT.Text = "Time OUT"
        Me.btnTimeOUT.UseVisualStyleBackColor = False
        '
        'btnTimeIN
        '
        Me.btnTimeIN.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTimeIN.Enabled = False
        Me.btnTimeIN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTimeIN.Location = New System.Drawing.Point(23, 30)
        Me.btnTimeIN.Name = "btnTimeIN"
        Me.btnTimeIN.Size = New System.Drawing.Size(119, 81)
        Me.btnTimeIN.TabIndex = 17
        Me.btnTimeIN.Text = "Time IN"
        Me.btnTimeIN.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Listview1)
        Me.GroupBox4.Location = New System.Drawing.Point(350, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(541, 486)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Listview1
        '
        Me.Listview1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Listview1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listview1.FullRowSelect = True
        Me.Listview1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Listview1.Location = New System.Drawing.Point(6, 17)
        Me.Listview1.Name = "Listview1"
        Me.Listview1.Size = New System.Drawing.Size(529, 462)
        Me.Listview1.TabIndex = 2
        Me.Listview1.TabStop = False
        Me.Listview1.UseCompatibleStateImageBehavior = False
        Me.Listview1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Worker Fullname"
        Me.ColumnHeader1.Width = 203
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Time In"
        Me.ColumnHeader2.Width = 98
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time Out"
        Me.ColumnHeader3.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 118
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTime)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 71)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Crimson
        Me.lblTime.Location = New System.Drawing.Point(22, 19)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(71, 33)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDate)
        Me.GroupBox3.Location = New System.Drawing.Point(505, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 71)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Crimson
        Me.lblDate.Location = New System.Drawing.Point(23, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(68, 33)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(897, 100)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(921, 629)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll System - Daily Time Record | Version 1.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpActions.ResumeLayout(False)
        Me.grpActions.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Listview1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents cbWorkerFullnames As System.Windows.Forms.ComboBox
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewRecords As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTimeOUT As System.Windows.Forms.Button
    Friend WithEvents btnTimeIN As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkerPassword As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
