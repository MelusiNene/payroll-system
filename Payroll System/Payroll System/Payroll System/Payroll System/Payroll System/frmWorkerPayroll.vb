Imports MySql.Data.MySqlClient

Public Class frmWorkerPayroll

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getMinDate As DateTime
    Private getMaxDate As DateTime
    Private getPresentDays As Integer = Nothing
    Private getWorkerID As String = Nothing
    Private getWorkerFullname As String = Nothing
    Private getWorkerDesignation As String = Nothing
    Private getWorkingHours As Integer = Nothing
    Private getTimeInHours As Integer = Nothing
    Private getTimeOutHours As Integer = Nothing
    Private getDesignationAmount As Decimal = Nothing
    Private getDesignationID As Integer = Nothing
    Private getOverTimeHours As Integer = Nothing
    Private getWorkerOverTime As Integer = Nothing
    Private getLateHours As Integer = Nothing
    Private getWorkerLateTime As Integer = Nothing
    Private loopOverTime As Integer = 17
    Private loopLateTime As Integer = 8
    Private getIncrementPayNumbers As Integer = 1
    Private passLateTime = Nothing
    Private lateSummary As Integer = 5

    ' declare variable to get decimal point
    Private getGrossPay As Decimal = Nothing
    Private getLateSummary As Decimal = Nothing
    Private getTotalDeduction As Decimal = Nothing
    Private getNetPay As Decimal = Nothing
    Private calculateTotalDeduction As Decimal = Nothing
    Private calculateNetPay As Decimal = Nothing


    Private Sub btnSearchWorkerID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchWorkerID.Click

        workerAbsent()
        payWorkerID()

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        submitWorkerWage()

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            frmMainMenu.Show()
            Me.Hide()
            frmViewWorkerRecords.Hide()

        End If

    End Sub


    ' getting the FromDate and ToDate goes here
    Public Sub payWorkerID()

        ' getting the worker id, worker fullname and worker designation
        getQuery = "SELECT worker.worker_id, worker.worker_fullname, designation.designation_name, designation.designation_amount FROM worker, designation WHERE worker.designation_id = designation.designation_id AND worker.worker_id ='" & txtSearchWorkerID.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If txtSearchWorkerID.Text = "" Then

            MsgBox("Please enter worker id to search", MsgBoxStyle.Information)
            txtSearchWorkerID.Focus()

        ElseIf getReader.Read = True Then

            ' getting the worker informations
            getWorkerID = (getReader.Item("worker_id").ToString)
            getWorkerFullname = (getReader.Item("worker_fullname").ToString)
            getWorkerDesignation = (getReader.Item("designation_name").ToString)
            getDesignationAmount = (getReader.Item("designation_amount").ToString)

            getReader.Close()

            ' getting the dtr record if the worker works
            getQuery = "SELECT dtr.worker_id FROM dtr, worker WHERE dtr.worker_id ='" & txtSearchWorkerID.Text & "' AND worker.worker_id ='" & txtSearchWorkerID.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            ' worker absent
            If getReader.Read = False Then

                MsgBox(Space(15) & "Worker ID: " & txtSearchWorkerID.Text & vbCrLf & "Don't have an attendance records", MsgBoxStyle.Information)

                ' refresh fields
                clearTextFields()

            Else


                getReader.Close()

                ' shows the FromDate and ToDate
                getQuery = "SELECT MIN(dtr.date) as 'FromDate', MAX(dtr.date) as 'ToDate' FROM dtr, worker WHERE dtr.worker_id ='" & txtSearchWorkerID.Text & "' AND worker.worker_id ='" & txtSearchWorkerID.Text & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    getMinDate = (getReader.Item("FromDate").ToString)
                    getMaxDate = (getReader.Item("ToDate").ToString)

                End If

                getReader.Close()


                ' calculate the present days
                showPresentDays()

                ' calculate the working hours
                showWorkingHours()

                ' calculate the over time hours
                showOverTimeHours()

                ' calculate the late hours
                showLateHours()

                ' display informations
                WorkeyPay()

                ' perform calculations
                calculateWage()

                ' refresh variables
                refreshVariables()

            End If

            getReader.Close()

        Else

            MsgBox(Space(5) & "Worker ID: " & txtSearchWorkerID.Text & vbCrLf & "Sorry no data found", MsgBoxStyle.Information)

            ' refresh fields
            clearTextFields()

        End If


        getReader.Close()



    End Sub

    ' shows the time in hours and time out hours of the worker goes here
    Public Sub showWorkingHours()

        getQuery = "SELECT HOUR(dtr.time_in) AS 'timein_hours', HOUR(dtr.time_out) AS 'timeout_hours' FROM dtr, worker WHERE dtr.worker_id ='" & txtSearchWorkerID.Text & "' AND worker.worker_id ='" & txtSearchWorkerID.Text & "' AND dtr.time_out IS NOT NULL"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader


        While getReader.Read

            ' getting the time in and time out of the worker
            getTimeInHours = (getReader.Item("timein_hours"))
            getTimeOutHours = (getReader.Item("timeout_hours"))

            While getTimeInHours < getTimeOutHours

                ' getting the working hours of the worker
                getWorkingHours = getWorkingHours + 1

                ' loop to get the hours work
                getTimeInHours = getTimeInHours + 1

            End While

            ' refresh time in and time out
            getTimeInHours = Nothing
            getTimeOutHours = Nothing

        End While

        getReader.Close()

        txtWorkingHours.Text = getWorkingHours

        ' refresh working hours
        getWorkingHours = Nothing

    End Sub

    Public Sub showPresentDays()

        ' getting the present days goes here
        getQuery = "SELECT dtr.date FROM dtr, worker WHERE dtr.date BETWEEN '" & Format(getMinDate.ToString("yyyy-MM-dd")) & "' AND '" & Format(getMaxDate.ToString("yyyy-MM-dd")) & "' AND dtr.worker_id ='" & txtSearchWorkerID.Text & "' AND worker.worker_id ='" & txtSearchWorkerID.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' calculate the present days
            getPresentDays = getPresentDays + 1

        End While

        getReader.Close()

    End Sub

    ' shows the overtime hour of the worker
    Public Sub showOverTimeHours()

        ' getting the overtime hour of the worker
        getQuery = "SELECT HOUR(dtr.time_out) as 'over_time' FROM dtr, worker WHERE dtr.time_out IS NOT NULL AND worker.worker_id ='" & txtSearchWorkerID.Text & "' AND dtr.worker_id ='" & txtSearchWorkerID.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' get the over time hour
            getOverTimeHours = (getReader.Item("over_time"))

            While loopOverTime < getOverTimeHours

                ' get the hours
                getWorkerOverTime = getWorkerOverTime + 1

                loopOverTime = loopOverTime + 1

            End While
            ' refresh loop
            loopOverTime = 17

        End While

        getReader.Close()

       

    End Sub

    ' shows the late hour of the worker
    Public Sub showLateHours()

        ' getting the late hour of the worker
        getQuery = "SELECT HOUR(dtr.time_in) AS 'late_hour' FROM dtr, worker WHERE dtr.time_out IS NOT NULL AND worker.worker_id ='" & txtSearchWorkerID.Text & "' AND dtr.worker_id ='" & txtSearchWorkerID.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            getLateHours = (getReader.Item("late_hour"))

            ' get the late hour
            While loopLateTime < getLateHours

                ' get the hours
                getWorkerLateTime = getWorkerLateTime + 1

                loopLateTime = loopLateTime + 1

            End While

            ' passing the late value
            passLateTime = getWorkerLateTime

            ' refresh loop
            loopLateTime = 8

        End While

        getReader.Close()

    End Sub



    ' inputted deductions

    Private Sub txtSSS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSS.TextChanged

        calculateTotalDeduction = Val(txtSSS.Text) + Val(txtPagIbig.Text) + Val(txtLateSummary.Text) + Val(txtOthers.Text)

        calculateNetPay = Val(txtGrossPay.Text) - Val(calculateTotalDeduction)

        txtTotalDeduction.Text = Decimal.Round(calculateTotalDeduction, 2).ToString("f2")

        txtNetPay.Text = Decimal.Round(calculateNetPay, 2).ToString("f2")

    End Sub

    Private Sub txtPagIbig_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPagIbig.TextChanged

        calculateTotalDeduction = Val(txtSSS.Text) + Val(txtPagIbig.Text) + Val(txtLateSummary.Text) + Val(txtOthers.Text)

        calculateNetPay = Val(txtGrossPay.Text) - Val(calculateTotalDeduction)

        txtTotalDeduction.Text = Decimal.Round(calculateTotalDeduction, 2).ToString("f2")

        txtNetPay.Text = Decimal.Round(calculateNetPay, 2).ToString("f2")

    End Sub

    Private Sub txtLateSummary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        calculateTotalDeduction = Val(txtSSS.Text) + Val(txtPagIbig.Text) + Val(txtLateSummary.Text) + Val(txtOthers.Text)

        calculateNetPay = Val(txtGrossPay.Text) - Val(calculateTotalDeduction)

        txtTotalDeduction.Text = Decimal.Round(calculateTotalDeduction, 2).ToString("f2")

        txtNetPay.Text = Decimal.Round(calculateNetPay, 2).ToString("f2")

    End Sub


    Private Sub txtOthers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOthers.TextChanged


        calculateTotalDeduction = Val(txtSSS.Text) + Val(txtPagIbig.Text) + Val(txtLateSummary.Text) + Val(txtOthers.Text)

        calculateNetPay = Val(txtGrossPay.Text) - Val(calculateTotalDeduction)

        txtTotalDeduction.Text = Decimal.Round(calculateTotalDeduction, 2).ToString("f2")

        txtNetPay.Text = Decimal.Round(calculateNetPay, 2).ToString("f2")

    End Sub

    ' calculate the worker wage goes here
    Public Sub calculateWage()

        ' calculate the net pay
        txtOverTime.Text = Decimal.Round(20, 2).ToString("f2")

        getGrossPay = (Val(txtRatePerHour.Text) * Val(txtWorkingHours.Text)) + (Val(txtOverTime.Text) * Val(txtOverTimeHours.Text))
        getLateSummary = getWorkerLateTime * lateSummary
        ' getTotalDeduction = Val(txtSSS.Text) + Val(txtPagIbig.Text) + Val(txtLateSummary.Text)

        txtLateSummary.Text = Decimal.Round(getLateSummary, 2).ToString("f2")
        txtGrossPay.Text = Decimal.Round(getGrossPay, 2).ToString("f2")
        txtTotalDeduction.Text = Decimal.Round(getLateSummary, 2).ToString("f2")
        getNetPay = Val(txtGrossPay.Text) - getLateSummary

        txtNetPay.Text = Decimal.Round(getNetPay, 2).ToString("f2")


    End Sub


    ' set the variable to nothing
    Public Sub refreshVariables()

        getPresentDays = Nothing
        getMinDate = Nothing
        getMaxDate = Nothing
        getWorkerID = Nothing
        getWorkerFullname = Nothing
        getWorkerDesignation = Nothing
        getWorkerOverTime = Nothing
        getWorkerLateTime = Nothing

    End Sub


    ' clear all inputted text fields
    Public Sub clearTextFields()

        txtSearchWorkerID.Clear()
        txtWorkerID.Clear()
        txtWorkerFullname.Clear()
        txtDesignation.Clear()
        txtPresentDays.Clear()
        txtWorkingHours.Clear()
        txtGrossPay.Clear()
        txtRatePerHour.Clear()
        txtPagIbig.Clear()
        txtOthers.Clear()
        txtOverTime.Clear()
        txtOverTimeHours.Clear()
        txtLateSummary.Clear()
        txtPagIbig.Clear()
        txtSSS.Clear()
        txtTotalDeduction.Clear()
        txtNetPay.Clear()
        dtpFrom.Text = Date.Now
        dtpTo.Text = Date.Now


    End Sub


    ' assign information into textfields
    Public Sub WorkeyPay()

        txtOverTimeHours.Text = getWorkerOverTime
        txtPresentDays.Text = getPresentDays
        dtpTo.Text = getMaxDate
        dtpFrom.Text = getMinDate
        txtWorkerID.Text = getWorkerID
        txtWorkerFullname.Text = getWorkerFullname
        txtDesignation.Text = getWorkerDesignation
        txtRatePerHour.Text = Decimal.Round(getDesignationAmount, 2).toString("f2")

    End Sub

    ' increment the pay id goes here
    Public Sub incrementPayID()

        getQuery = "SELECT wage.wage_id AS 'increment_number' FROM wage ORDER BY wage.wage_id DESC LIMIT 1"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            getIncrementPayNumbers = (getReader.Item("increment_number").ToString) + 1

        End While

        getReader.Close()

    End Sub


    ' get the worker wage goes here
    Public Sub submitWorkerWage()

        If txtWorkerID.Text = "" Then

            MsgBox("Please select worker ID", MsgBoxStyle.Information)
            txtSearchWorkerID.Focus()

        Else

            If MsgBox(Space(15) & "Worker ID: " & txtWorkerID.Text & vbCrLf & "Are you sure you want to pay?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                ' declare variable to hold the key 
                Dim getDeductionID As Integer = Nothing

                ' get the deduction id
                getQuery = "SELECT wage.deduction_id FROM wage WHERE wage.worker_id ='" & txtSearchWorkerID.Text & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    getDeductionID = (getReader.Item("deduction_id").ToString)

                End If

                getReader.Close()

                ' remove the previous deduction
                getQuery = "DELETE FROM deduction WHERE deduction.deduction_id ='" & getDeductionID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                ' remove the previous wage
                getQuery = "DELETE FROM wage WHERE wage.worker_id ='" & txtSearchWorkerID.Text & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                ' refresh increment id
                incrementPayID()

                ' get the wage/deduction of the worker
                getQuery = "INSERT INTO wage VALUES('" & getIncrementPayNumbers & "','" & txtPresentDays.Text & "','" & Val(txtRatePerHour.Text) * Val(txtWorkingHours.Text) & _
                    "','" & Val(txtOverTime.Text) * Val(txtOverTimeHours.Text) & "','" & Date.Today.ToString("yyyy-MM-dd") & "','" & txtWorkerID.Text & "','" & getIncrementPayNumbers & "','" & frmLogin.getStaffID & "')"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                getQuery = "INSERT INTO deduction VALUES('" & getIncrementPayNumbers & "','" & txtSSS.Text & "','" & txtPagIbig.Text & "','" & txtLateSummary.Text & "','" & txtOthers.Text & "','" & Date.Today.ToString("yyyy-MM-dd") & "')"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                MsgBox("Successfully saved!", MsgBoxStyle.Information)

                ' remove the dtr of the worker
                deleteWorkerDTR()

                ' refresh textfields
                clearTextFields()

                ' refresh increment id
                incrementPayID()


            End If

            End If

    End Sub

    ' remove the dtr of the worker after pay
    Private Sub deleteWorkerDTR()

        ' remove the dtr
        getQuery = "DELETE FROM dtr WHERE dtr.worker_id ='" & txtWorkerID.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        getReader.Close()

    End Sub



    Private Sub btnViewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRecord.Click

        If txtSearchWorkerID.Text = "" Then

            MsgBox("Please select worker ID", MsgBoxStyle.Information)
            txtSearchWorkerID.Focus()

        Else

            frmViewWorkerRecords.txtTotalLateHours.Text = passLateTime
            frmViewWorkerRecords.txtTotalWorkHours.Text = txtWorkingHours.Text
            frmViewWorkerRecords.txtTotalOverTimeHours.Text = txtOverTimeHours.Text
            frmViewWorkerRecords.Show()

        End If


    End Sub

    ' remove dtr of the worker absent
    Private Sub workerAbsent()

        getQuery = "DELETE FROM dtr WHERE dtr.time_OUT IS NULL AND dtr.worker_id ='" & txtSearchWorkerID.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        getReader.Close()

    End Sub

End Class