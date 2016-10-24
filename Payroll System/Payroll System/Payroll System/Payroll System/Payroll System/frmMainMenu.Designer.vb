<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDesignation = New System.Windows.Forms.Button()
        Me.btnWorker = New System.Windows.Forms.Button()
        Me.btnPayrollSlip = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnPayrollReports = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnPayrollSystem = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtEMPS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 540)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll System"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(883, 438)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnClose)
        Me.GroupBox6.Controls.Add(Me.btnDesignation)
        Me.GroupBox6.Controls.Add(Me.btnWorker)
        Me.GroupBox6.Controls.Add(Me.btnPayrollSlip)
        Me.GroupBox6.Controls.Add(Me.btnRecords)
        Me.GroupBox6.Controls.Add(Me.btnPayrollReports)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox6.Location = New System.Drawing.Point(6, 163)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(226, 259)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Actions"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(6, 214)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(214, 32)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDesignation
        '
        Me.btnDesignation.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnDesignation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesignation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDesignation.Location = New System.Drawing.Point(6, 100)
        Me.btnDesignation.Name = "btnDesignation"
        Me.btnDesignation.Size = New System.Drawing.Size(214, 32)
        Me.btnDesignation.TabIndex = 18
        Me.btnDesignation.Text = "Designation"
        Me.btnDesignation.UseVisualStyleBackColor = False
        '
        'btnWorker
        '
        Me.btnWorker.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnWorker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWorker.Location = New System.Drawing.Point(6, 24)
        Me.btnWorker.Name = "btnWorker"
        Me.btnWorker.Size = New System.Drawing.Size(214, 32)
        Me.btnWorker.TabIndex = 13
        Me.btnWorker.Text = "New Worker"
        Me.btnWorker.UseVisualStyleBackColor = False
        '
        'btnPayrollSlip
        '
        Me.btnPayrollSlip.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPayrollSlip.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayrollSlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayrollSlip.Location = New System.Drawing.Point(6, 138)
        Me.btnPayrollSlip.Name = "btnPayrollSlip"
        Me.btnPayrollSlip.Size = New System.Drawing.Size(214, 32)
        Me.btnPayrollSlip.TabIndex = 17
        Me.btnPayrollSlip.Text = "Payroll Slip"
        Me.btnPayrollSlip.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRecords.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRecords.Location = New System.Drawing.Point(6, 62)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(214, 32)
        Me.btnRecords.TabIndex = 15
        Me.btnRecords.Text = "Worker Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnPayrollReports
        '
        Me.btnPayrollReports.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPayrollReports.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayrollReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayrollReports.Location = New System.Drawing.Point(6, 176)
        Me.btnPayrollReports.Name = "btnPayrollReports"
        Me.btnPayrollReports.Size = New System.Drawing.Size(214, 32)
        Me.btnPayrollReports.TabIndex = 16
        Me.btnPayrollReports.Text = "Payroll Reports"
        Me.btnPayrollReports.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Location = New System.Drawing.Point(256, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(621, 403)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(6, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(609, 382)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAttendance)
        Me.GroupBox3.Controls.Add(Me.btnPayrollSystem)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 138)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Main Menu"
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAttendance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAttendance.Location = New System.Drawing.Point(6, 80)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(214, 48)
        Me.btnAttendance.TabIndex = 10
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnPayrollSystem
        '
        Me.btnPayrollSystem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPayrollSystem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayrollSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayrollSystem.Location = New System.Drawing.Point(6, 26)
        Me.btnPayrollSystem.Name = "btnPayrollSystem"
        Me.btnPayrollSystem.Size = New System.Drawing.Size(214, 48)
        Me.btnPayrollSystem.TabIndex = 5
        Me.btnPayrollSystem.Text = "Payroll System"
        Me.btnPayrollSystem.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtEMPS)
        Me.GroupBox5.Location = New System.Drawing.Point(-4, 556)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(935, 33)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'txtEMPS
        '
        Me.txtEMPS.AutoSize = True
        Me.txtEMPS.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEMPS.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtEMPS.Location = New System.Drawing.Point(287, 10)
        Me.txtEMPS.Name = "txtEMPS"
        Me.txtEMPS.Size = New System.Drawing.Size(419, 19)
        Me.txtEMPS.TabIndex = 1
        Me.txtEMPS.Text = "Worker Payroll Management System | All Rights Reserved 2013"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(131, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(666, 82)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(923, 604)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll System - Main Menu | Version 1.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents btnPayrollSystem As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEMPS As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDesignation As System.Windows.Forms.Button
    Friend WithEvents btnWorker As System.Windows.Forms.Button
    Friend WithEvents btnPayrollSlip As System.Windows.Forms.Button
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnPayrollReports As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
