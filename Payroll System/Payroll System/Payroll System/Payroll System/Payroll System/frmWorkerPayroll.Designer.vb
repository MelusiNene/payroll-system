<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkerPayroll
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
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSearchWorkerID = New System.Windows.Forms.Label()
        Me.txtSearchWorkerID = New System.Windows.Forms.TextBox()
        Me.btnSearchWorkerID = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblNetWage = New System.Windows.Forms.Label()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblLateSummary = New System.Windows.Forms.Label()
        Me.txtLateSummary = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.lblTotalDeductions = New System.Windows.Forms.Label()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.txtPagIbig = New System.Windows.Forms.TextBox()
        Me.lblPagIbig = New System.Windows.Forms.Label()
        Me.lblOthers = New System.Windows.Forms.Label()
        Me.lblSSS = New System.Windows.Forms.Label()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnViewRecord = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblOverTimeHours = New System.Windows.Forms.Label()
        Me.txtOverTimeHours = New System.Windows.Forms.TextBox()
        Me.lblWorkingHours = New System.Windows.Forms.Label()
        Me.txtWorkingHours = New System.Windows.Forms.TextBox()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblPresentDays = New System.Windows.Forms.Label()
        Me.txtPresentDays = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRatePerOT = New System.Windows.Forms.Label()
        Me.txtOverTime = New System.Windows.Forms.TextBox()
        Me.lblRatePerHour = New System.Windows.Forms.Label()
        Me.txtRatePerHour = New System.Windows.Forms.TextBox()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.lblWorkerFullname = New System.Windows.Forms.Label()
        Me.txtWorkerFullname = New System.Windows.Forms.TextBox()
        Me.lblWorkerID = New System.Windows.Forms.Label()
        Me.txtWorkerID = New System.Windows.Forms.TextBox()
        Me.grpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.lblTo)
        Me.grpActions.Controls.Add(Me.lblFrom)
        Me.grpActions.Controls.Add(Me.dtpFrom)
        Me.grpActions.Controls.Add(Me.dtpTo)
        Me.grpActions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpActions.ForeColor = System.Drawing.Color.Crimson
        Me.grpActions.Location = New System.Drawing.Point(327, 19)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(305, 130)
        Me.grpActions.TabIndex = 22
        Me.grpActions.TabStop = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.Crimson
        Me.lblTo.Location = New System.Drawing.Point(201, 26)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(26, 18)
        Me.lblTo.TabIndex = 21
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.Crimson
        Me.lblFrom.Location = New System.Drawing.Point(60, 26)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(44, 18)
        Me.lblFrom.TabIndex = 20
        Me.lblFrom.Text = "From:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(18, 47)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowUpDown = True
        Me.dtpFrom.Size = New System.Drawing.Size(131, 33)
        Me.dtpFrom.TabIndex = 19
        Me.dtpFrom.TabStop = False
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = ""
        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(160, 47)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowUpDown = True
        Me.dtpTo.Size = New System.Drawing.Size(131, 33)
        Me.dtpTo.TabIndex = 18
        Me.dtpTo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSearchWorkerID)
        Me.GroupBox1.Controls.Add(Me.txtSearchWorkerID)
        Me.GroupBox1.Controls.Add(Me.btnSearchWorkerID)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 130)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'lblSearchWorkerID
        '
        Me.lblSearchWorkerID.AutoSize = True
        Me.lblSearchWorkerID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchWorkerID.ForeColor = System.Drawing.Color.Crimson
        Me.lblSearchWorkerID.Location = New System.Drawing.Point(102, 26)
        Me.lblSearchWorkerID.Name = "lblSearchWorkerID"
        Me.lblSearchWorkerID.Size = New System.Drawing.Size(74, 18)
        Me.lblSearchWorkerID.TabIndex = 21
        Me.lblSearchWorkerID.Text = "Worker ID:"
        '
        'txtSearchWorkerID
        '
        Me.txtSearchWorkerID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchWorkerID.Location = New System.Drawing.Point(38, 47)
        Me.txtSearchWorkerID.Name = "txtSearchWorkerID"
        Me.txtSearchWorkerID.Size = New System.Drawing.Size(211, 27)
        Me.txtSearchWorkerID.TabIndex = 20
        Me.txtSearchWorkerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchWorkerID
        '
        Me.btnSearchWorkerID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSearchWorkerID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchWorkerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchWorkerID.Location = New System.Drawing.Point(84, 80)
        Me.btnSearchWorkerID.Name = "btnSearchWorkerID"
        Me.btnSearchWorkerID.Size = New System.Drawing.Size(117, 32)
        Me.btnSearchWorkerID.TabIndex = 19
        Me.btnSearchWorkerID.Text = "Search"
        Me.btnSearchWorkerID.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox9)
        Me.GroupBox2.Controls.Add(Me.GroupBox10)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.grpActions)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(973, 615)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Worker Payment"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblNetWage)
        Me.GroupBox8.Controls.Add(Me.txtNetPay)
        Me.GroupBox8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(327, 420)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(305, 80)
        Me.GroupBox8.TabIndex = 29
        Me.GroupBox8.TabStop = False
        '
        'lblNetWage
        '
        Me.lblNetWage.AutoSize = True
        Me.lblNetWage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetWage.ForeColor = System.Drawing.Color.Crimson
        Me.lblNetWage.Location = New System.Drawing.Point(113, 13)
        Me.lblNetWage.Name = "lblNetWage"
        Me.lblNetWage.Size = New System.Drawing.Size(86, 26)
        Me.lblNetWage.TabIndex = 21
        Me.lblNetWage.Text = "Net Pay:"
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtNetPay.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(50, 40)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(211, 27)
        Me.txtNetPay.TabIndex = 20
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblLateSummary)
        Me.GroupBox9.Controls.Add(Me.txtLateSummary)
        Me.GroupBox9.Controls.Add(Me.txtSSS)
        Me.GroupBox9.Controls.Add(Me.lblTotalDeductions)
        Me.GroupBox9.Controls.Add(Me.txtTotalDeduction)
        Me.GroupBox9.Controls.Add(Me.txtPagIbig)
        Me.GroupBox9.Controls.Add(Me.lblPagIbig)
        Me.GroupBox9.Controls.Add(Me.lblOthers)
        Me.GroupBox9.Controls.Add(Me.lblSSS)
        Me.GroupBox9.Controls.Add(Me.txtOthers)
        Me.GroupBox9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox9.Location = New System.Drawing.Point(656, 155)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(305, 302)
        Me.GroupBox9.TabIndex = 30
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Deductions"
        '
        'lblLateSummary
        '
        Me.lblLateSummary.AutoSize = True
        Me.lblLateSummary.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLateSummary.ForeColor = System.Drawing.Color.Crimson
        Me.lblLateSummary.Location = New System.Drawing.Point(105, 27)
        Me.lblLateSummary.Name = "lblLateSummary"
        Me.lblLateSummary.Size = New System.Drawing.Size(99, 18)
        Me.lblLateSummary.TabIndex = 35
        Me.lblLateSummary.Text = "Late Summary:"
        '
        'txtLateSummary
        '
        Me.txtLateSummary.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtLateSummary.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLateSummary.Location = New System.Drawing.Point(49, 48)
        Me.txtLateSummary.Name = "txtLateSummary"
        Me.txtLateSummary.ReadOnly = True
        Me.txtLateSummary.Size = New System.Drawing.Size(211, 27)
        Me.txtLateSummary.TabIndex = 34
        Me.txtLateSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSS
        '
        Me.txtSSS.BackColor = System.Drawing.SystemColors.Window
        Me.txtSSS.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSS.Location = New System.Drawing.Point(49, 105)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(211, 27)
        Me.txtSSS.TabIndex = 31
        Me.txtSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalDeductions
        '
        Me.lblTotalDeductions.AutoSize = True
        Me.lblTotalDeductions.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeductions.ForeColor = System.Drawing.Color.Crimson
        Me.lblTotalDeductions.Location = New System.Drawing.Point(105, 244)
        Me.lblTotalDeductions.Name = "lblTotalDeductions"
        Me.lblTotalDeductions.Size = New System.Drawing.Size(115, 18)
        Me.lblTotalDeductions.TabIndex = 30
        Me.lblTotalDeductions.Text = "Total Deductions:"
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.BackColor = System.Drawing.Color.DarkTurquoise
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeduction.Location = New System.Drawing.Point(49, 265)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.ReadOnly = True
        Me.txtTotalDeduction.Size = New System.Drawing.Size(211, 27)
        Me.txtTotalDeduction.TabIndex = 29
        Me.txtTotalDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPagIbig
        '
        Me.txtPagIbig.BackColor = System.Drawing.SystemColors.Window
        Me.txtPagIbig.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagIbig.Location = New System.Drawing.Point(49, 156)
        Me.txtPagIbig.Name = "txtPagIbig"
        Me.txtPagIbig.Size = New System.Drawing.Size(211, 27)
        Me.txtPagIbig.TabIndex = 28
        Me.txtPagIbig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPagIbig
        '
        Me.lblPagIbig.AutoSize = True
        Me.lblPagIbig.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagIbig.ForeColor = System.Drawing.Color.Crimson
        Me.lblPagIbig.Location = New System.Drawing.Point(121, 135)
        Me.lblPagIbig.Name = "lblPagIbig"
        Me.lblPagIbig.Size = New System.Drawing.Size(68, 18)
        Me.lblPagIbig.TabIndex = 26
        Me.lblPagIbig.Text = "Pag - Ibig:"
        '
        'lblOthers
        '
        Me.lblOthers.AutoSize = True
        Me.lblOthers.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOthers.ForeColor = System.Drawing.Color.Crimson
        Me.lblOthers.Location = New System.Drawing.Point(105, 189)
        Me.lblOthers.Name = "lblOthers"
        Me.lblOthers.Size = New System.Drawing.Size(121, 18)
        Me.lblOthers.TabIndex = 24
        Me.lblOthers.Text = "Others (Optional):"
        '
        'lblSSS
        '
        Me.lblSSS.AutoSize = True
        Me.lblSSS.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSS.ForeColor = System.Drawing.Color.Crimson
        Me.lblSSS.Location = New System.Drawing.Point(137, 84)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(33, 18)
        Me.lblSSS.TabIndex = 22
        Me.lblSSS.Text = "SSS:"
        '
        'txtOthers
        '
        Me.txtOthers.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.Location = New System.Drawing.Point(49, 210)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(211, 27)
        Me.txtOthers.TabIndex = 23
        Me.txtOthers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lblDate)
        Me.GroupBox10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox10.Location = New System.Drawing.Point(656, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(305, 130)
        Me.GroupBox10.TabIndex = 29
        Me.GroupBox10.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Crimson
        Me.lblDate.Location = New System.Drawing.Point(69, 47)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(68, 33)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox6.Location = New System.Drawing.Point(6, 506)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(953, 103)
        Me.GroupBox6.TabIndex = 28
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnViewRecord)
        Me.GroupBox7.Controls.Add(Me.btnClose)
        Me.GroupBox7.Controls.Add(Me.btnSave)
        Me.GroupBox7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox7.Location = New System.Drawing.Point(278, 17)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(394, 69)
        Me.GroupBox7.TabIndex = 27
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Actions"
        '
        'btnViewRecord
        '
        Me.btnViewRecord.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnViewRecord.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewRecord.Location = New System.Drawing.Point(141, 26)
        Me.btnViewRecord.Name = "btnViewRecord"
        Me.btnViewRecord.Size = New System.Drawing.Size(117, 32)
        Me.btnViewRecord.TabIndex = 25
        Me.btnViewRecord.Text = "View"
        Me.btnViewRecord.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(264, 26)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 32)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(18, 26)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 32)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblOverTimeHours)
        Me.GroupBox4.Controls.Add(Me.txtOverTimeHours)
        Me.GroupBox4.Controls.Add(Me.lblWorkingHours)
        Me.GroupBox4.Controls.Add(Me.txtWorkingHours)
        Me.GroupBox4.Controls.Add(Me.lblGrossPay)
        Me.GroupBox4.Controls.Add(Me.lblPresentDays)
        Me.GroupBox4.Controls.Add(Me.txtPresentDays)
        Me.GroupBox4.Controls.Add(Me.txtGrossPay)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(327, 155)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(305, 259)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payroll Computation"
        '
        'lblOverTimeHours
        '
        Me.lblOverTimeHours.AutoSize = True
        Me.lblOverTimeHours.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverTimeHours.ForeColor = System.Drawing.Color.Crimson
        Me.lblOverTimeHours.Location = New System.Drawing.Point(97, 135)
        Me.lblOverTimeHours.Name = "lblOverTimeHours"
        Me.lblOverTimeHours.Size = New System.Drawing.Size(115, 18)
        Me.lblOverTimeHours.TabIndex = 28
        Me.lblOverTimeHours.Text = "Over Time Hours:"
        '
        'txtOverTimeHours
        '
        Me.txtOverTimeHours.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtOverTimeHours.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverTimeHours.Location = New System.Drawing.Point(50, 156)
        Me.txtOverTimeHours.Name = "txtOverTimeHours"
        Me.txtOverTimeHours.ReadOnly = True
        Me.txtOverTimeHours.Size = New System.Drawing.Size(211, 27)
        Me.txtOverTimeHours.TabIndex = 27
        Me.txtOverTimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkingHours
        '
        Me.lblWorkingHours.AutoSize = True
        Me.lblWorkingHours.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkingHours.ForeColor = System.Drawing.Color.Crimson
        Me.lblWorkingHours.Location = New System.Drawing.Point(104, 81)
        Me.lblWorkingHours.Name = "lblWorkingHours"
        Me.lblWorkingHours.Size = New System.Drawing.Size(103, 18)
        Me.lblWorkingHours.TabIndex = 26
        Me.lblWorkingHours.Text = "Working Hours:"
        '
        'txtWorkingHours
        '
        Me.txtWorkingHours.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtWorkingHours.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkingHours.Location = New System.Drawing.Point(50, 102)
        Me.txtWorkingHours.Name = "txtWorkingHours"
        Me.txtWorkingHours.ReadOnly = True
        Me.txtWorkingHours.Size = New System.Drawing.Size(211, 27)
        Me.txtWorkingHours.TabIndex = 25
        Me.txtWorkingHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.ForeColor = System.Drawing.Color.Crimson
        Me.lblGrossPay.Location = New System.Drawing.Point(119, 198)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(72, 18)
        Me.lblGrossPay.TabIndex = 24
        Me.lblGrossPay.Text = "Gross Pay:"
        '
        'lblPresentDays
        '
        Me.lblPresentDays.AutoSize = True
        Me.lblPresentDays.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentDays.ForeColor = System.Drawing.Color.Crimson
        Me.lblPresentDays.Location = New System.Drawing.Point(107, 27)
        Me.lblPresentDays.Name = "lblPresentDays"
        Me.lblPresentDays.Size = New System.Drawing.Size(92, 18)
        Me.lblPresentDays.TabIndex = 22
        Me.lblPresentDays.Text = "Present Days:"
        '
        'txtPresentDays
        '
        Me.txtPresentDays.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtPresentDays.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresentDays.Location = New System.Drawing.Point(50, 48)
        Me.txtPresentDays.Name = "txtPresentDays"
        Me.txtPresentDays.ReadOnly = True
        Me.txtPresentDays.Size = New System.Drawing.Size(211, 27)
        Me.txtPresentDays.TabIndex = 22
        Me.txtPresentDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.Color.DarkTurquoise
        Me.txtGrossPay.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(50, 219)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(211, 27)
        Me.txtGrossPay.TabIndex = 23
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRatePerOT)
        Me.GroupBox3.Controls.Add(Me.txtOverTime)
        Me.GroupBox3.Controls.Add(Me.lblRatePerHour)
        Me.GroupBox3.Controls.Add(Me.txtRatePerHour)
        Me.GroupBox3.Controls.Add(Me.lblDesignation)
        Me.GroupBox3.Controls.Add(Me.txtDesignation)
        Me.GroupBox3.Controls.Add(Me.lblWorkerFullname)
        Me.GroupBox3.Controls.Add(Me.txtWorkerFullname)
        Me.GroupBox3.Controls.Add(Me.lblWorkerID)
        Me.GroupBox3.Controls.Add(Me.txtWorkerID)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 302)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Worker Information"
        '
        'lblRatePerOT
        '
        Me.lblRatePerOT.AutoSize = True
        Me.lblRatePerOT.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatePerOT.ForeColor = System.Drawing.Color.Crimson
        Me.lblRatePerOT.Location = New System.Drawing.Point(90, 244)
        Me.lblRatePerOT.Name = "lblRatePerOT"
        Me.lblRatePerOT.Size = New System.Drawing.Size(103, 18)
        Me.lblRatePerOT.TabIndex = 30
        Me.lblRatePerOT.Text = "Over Time Rate"
        '
        'txtOverTime
        '
        Me.txtOverTime.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtOverTime.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverTime.Location = New System.Drawing.Point(38, 265)
        Me.txtOverTime.Name = "txtOverTime"
        Me.txtOverTime.ReadOnly = True
        Me.txtOverTime.Size = New System.Drawing.Size(211, 27)
        Me.txtOverTime.TabIndex = 29
        Me.txtOverTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRatePerHour
        '
        Me.lblRatePerHour.AutoSize = True
        Me.lblRatePerHour.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatePerHour.ForeColor = System.Drawing.Color.Crimson
        Me.lblRatePerHour.Location = New System.Drawing.Point(95, 190)
        Me.lblRatePerHour.Name = "lblRatePerHour"
        Me.lblRatePerHour.Size = New System.Drawing.Size(93, 18)
        Me.lblRatePerHour.TabIndex = 28
        Me.lblRatePerHour.Text = "Rate per Hour"
        '
        'txtRatePerHour
        '
        Me.txtRatePerHour.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtRatePerHour.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRatePerHour.Location = New System.Drawing.Point(38, 211)
        Me.txtRatePerHour.Name = "txtRatePerHour"
        Me.txtRatePerHour.ReadOnly = True
        Me.txtRatePerHour.Size = New System.Drawing.Size(211, 27)
        Me.txtRatePerHour.TabIndex = 27
        Me.txtRatePerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignation.ForeColor = System.Drawing.Color.Crimson
        Me.lblDesignation.Location = New System.Drawing.Point(95, 135)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(86, 18)
        Me.lblDesignation.TabIndex = 26
        Me.lblDesignation.Text = "Designation:"
        '
        'txtDesignation
        '
        Me.txtDesignation.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtDesignation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(38, 156)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(211, 27)
        Me.txtDesignation.TabIndex = 25
        Me.txtDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkerFullname
        '
        Me.lblWorkerFullname.AutoSize = True
        Me.lblWorkerFullname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkerFullname.ForeColor = System.Drawing.Color.Crimson
        Me.lblWorkerFullname.Location = New System.Drawing.Point(83, 81)
        Me.lblWorkerFullname.Name = "lblWorkerFullname"
        Me.lblWorkerFullname.Size = New System.Drawing.Size(119, 18)
        Me.lblWorkerFullname.TabIndex = 24
        Me.lblWorkerFullname.Text = "Worker Fullname:"
        '
        'txtWorkerFullname
        '
        Me.txtWorkerFullname.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtWorkerFullname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkerFullname.Location = New System.Drawing.Point(38, 102)
        Me.txtWorkerFullname.Name = "txtWorkerFullname"
        Me.txtWorkerFullname.ReadOnly = True
        Me.txtWorkerFullname.Size = New System.Drawing.Size(211, 27)
        Me.txtWorkerFullname.TabIndex = 23
        Me.txtWorkerFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkerID
        '
        Me.lblWorkerID.AutoSize = True
        Me.lblWorkerID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkerID.ForeColor = System.Drawing.Color.Crimson
        Me.lblWorkerID.Location = New System.Drawing.Point(102, 27)
        Me.lblWorkerID.Name = "lblWorkerID"
        Me.lblWorkerID.Size = New System.Drawing.Size(74, 18)
        Me.lblWorkerID.TabIndex = 22
        Me.lblWorkerID.Text = "Worker ID:"
        '
        'txtWorkerID
        '
        Me.txtWorkerID.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtWorkerID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkerID.Location = New System.Drawing.Point(38, 48)
        Me.txtWorkerID.Name = "txtWorkerID"
        Me.txtWorkerID.ReadOnly = True
        Me.txtWorkerID.Size = New System.Drawing.Size(211, 27)
        Me.txtWorkerID.TabIndex = 22
        Me.txtWorkerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmWorkerPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(997, 642)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkerPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll System - Worker Payment | Version 1.1"
        Me.grpActions.ResumeLayout(False)
        Me.grpActions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchWorkerID As System.Windows.Forms.Button
    Friend WithEvents txtSearchWorkerID As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchWorkerID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkerFullname As System.Windows.Forms.Label
    Friend WithEvents txtWorkerFullname As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkerID As System.Windows.Forms.Label
    Friend WithEvents txtWorkerID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblWorkingHours As System.Windows.Forms.Label
    Friend WithEvents txtWorkingHours As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents lblPresentDays As System.Windows.Forms.Label
    Friend WithEvents txtPresentDays As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPagIbig As System.Windows.Forms.Label
    Friend WithEvents lblOthers As System.Windows.Forms.Label
    Friend WithEvents lblSSS As System.Windows.Forms.Label
    Friend WithEvents txtOthers As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtPagIbig As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNetWage As System.Windows.Forms.Label
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents lblRatePerHour As System.Windows.Forms.Label
    Friend WithEvents txtRatePerHour As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalDeductions As System.Windows.Forms.Label
    Friend WithEvents txtTotalDeduction As System.Windows.Forms.TextBox
    Friend WithEvents lblOverTimeHours As System.Windows.Forms.Label
    Friend WithEvents txtOverTimeHours As System.Windows.Forms.TextBox
    Friend WithEvents lblRatePerOT As System.Windows.Forms.Label
    Friend WithEvents txtOverTime As System.Windows.Forms.TextBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents btnViewRecord As System.Windows.Forms.Button
    Friend WithEvents lblLateSummary As System.Windows.Forms.Label
    Friend WithEvents txtLateSummary As System.Windows.Forms.TextBox
End Class
