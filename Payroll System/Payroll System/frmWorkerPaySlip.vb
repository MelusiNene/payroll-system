Imports MySql.Data.MySqlClient

Public Class frmWorkerPaySlip

    ' declare variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getGrossPay As Decimal = Nothing
    Private getNetPay As Decimal = Nothing


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        searchWorkerPaySlip()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            frmMainMenu.Show()
            frmPaySlip.Hide()
            Me.Hide()

        End If

    End Sub


    Private Sub cbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSearch.SelectedIndexChanged

        txtSearch.Text = ""

    End Sub


    ' shows the worker payslip goes here
    Private Sub searchWorkerPaySlip()

        If cbSearch.SelectedIndex = -1 Then

            MsgBox("Please select to be search", MsgBoxStyle.Information)
            cbSearch.Focus()

        ElseIf txtSearch.Text = "" Then

            If cbSearch.SelectedIndex = 0 Then

                MsgBox("Please enter worker id to be search", MsgBoxStyle.Information)
                txtSearch.Focus()

            ElseIf cbSearch.SelectedIndex = 1 Then

                MsgBox("Please enter worker fullname to be search", MsgBoxStyle.Information)
                txtSearch.Focus()


            End If

        ElseIf cbSearch.SelectedIndex = 0 Then

            ' searching for the worker id
            getQuery = "SELECT staff.username, worker.worker_id, worker.worker_fullname, worker.date_hired, designation.designation_name, designation.designation_amount, " & _
                "wage.wage_date, wage.days_work, wage.hours_pay, wage.overtime_pay, deduction.sss, deduction.pag_ibig, deduction.late, deduction.others FROM worker, designation, wage, deduction, staff " & _
                "WHERE staff.id = wage.id AND designation.designation_id = worker.designation_id AND wage.deduction_id = deduction.deduction_id AND worker.worker_id ='" & txtSearch.Text & "' AND wage.worker_id ='" & txtSearch.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            If getReader.Read = True Then

                frmPaySlip.lblWorkerID.Text = (getReader.Item("worker_id").ToString)
                frmPaySlip.lblWorkerFullname.Text = (getReader.Item("worker_fullname").ToString)
                frmPaySlip.lblDateOfJoining.Text = (Format(getReader.Item("date_hired"), "MMM dd, yyyy"))
                frmPaySlip.lblDesignation.Text = (getReader.Item("designation_name").ToString)
                frmPaySlip.lblDaysWork.Text = (getReader.Item("days_work").ToString)
                frmPaySlip.lblDesignationRate.Text = Decimal.Round(getReader.Item("designation_amount"), 2).ToString("f2")
                frmPaySlip.lblHoursPay.Text = Decimal.Round(getReader.Item("hours_pay"), 2).ToString("f2")
                frmPaySlip.lblOverTimePay.Text = Decimal.Round(getReader.Item("overtime_pay"), 2).ToString("f2")
                frmPaySlip.lblSSS.Text = Decimal.Round(getReader.Item("sss"), 2).ToString("f2")
                frmPaySlip.lblPagIbig.Text = Decimal.Round(getReader.Item("pag_ibig"), 2).ToString("f2")
                frmPaySlip.lblLate.Text = Decimal.Round(getReader.Item("late"), 2).ToString("f2")
                frmPaySlip.lblOthers.Text = Decimal.Round(getReader.Item("others"), 2).ToString("f2")

                getGrossPay = Val(frmPaySlip.lblHoursPay.Text) + Val(frmPaySlip.lblOverTimePay.Text)
                getNetPay = Val(getGrossPay) - (Val(frmPaySlip.lblSSS.Text) + Val(frmPaySlip.lblPagIbig.Text) + Val(frmPaySlip.lblLate.Text) + Val(frmPaySlip.lblOthers.Text))

                frmPaySlip.lblGrossPay.Text = Decimal.Round(getGrossPay, 2).ToString("f2")
                frmPaySlip.lblNetPay.Text = Decimal.Round(getNetPay, 2).ToString("f2")

                frmPaySlip.lblDate.Text = Format(getReader.Item("wage_date"), "MMM dd, yyyy")
                frmPaySlip.lblIssuedBy.Text = (getReader.Item("username").ToString)

                frmPaySlip.Show()

            Else

                MsgBox("Sorry no data found!", MsgBoxStyle.Information)
                txtSearch.Focus()

            End If

            getReader.Close()

        ElseIf cbSearch.SelectedIndex = 1 Then

            ' searching for the worker fullname
            getQuery = "SELECT staff.username, worker.worker_id, worker.worker_fullname, worker.date_hired, designation.designation_name, designation.designation_amount, " & _
                "wage.wage_date, wage.days_work, wage.hours_pay, wage.overtime_pay, deduction.sss, deduction.pag_ibig, deduction.late, deduction.others FROM worker, designation, wage, deduction, staff " & _
                "WHERE staff.id = wage.id AND designation.designation_id = worker.designation_id AND wage.deduction_id = deduction.deduction_id AND worker.worker_id = wage.worker_id AND worker.worker_fullname ='" & txtSearch.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            If getReader.Read = True Then

                frmPaySlip.lblWorkerID.Text = (getReader.Item("worker_id").ToString)
                frmPaySlip.lblWorkerFullname.Text = (getReader.Item("worker_fullname").ToString)
                frmPaySlip.lblDateOfJoining.Text = (Format(getReader.Item("date_hired"), "MMM dd, yyyy"))
                frmPaySlip.lblDesignation.Text = (getReader.Item("designation_name").ToString)
                frmPaySlip.lblDaysWork.Text = (getReader.Item("days_work").ToString)
                frmPaySlip.lblDesignationRate.Text = Decimal.Round(getReader.Item("designation_amount"), 2).ToString("f2")
                frmPaySlip.lblHoursPay.Text = Decimal.Round(getReader.Item("hours_pay"), 2).ToString("f2")
                frmPaySlip.lblOverTimePay.Text = Decimal.Round(getReader.Item("overtime_pay"), 2).ToString("f2")
                frmPaySlip.lblSSS.Text = Decimal.Round(getReader.Item("sss"), 2).ToString("f2")
                frmPaySlip.lblPagIbig.Text = Decimal.Round(getReader.Item("pag_ibig"), 2).ToString("f2")
                frmPaySlip.lblLate.Text = Decimal.Round(getReader.Item("late"), 2).ToString("f2")
                frmPaySlip.lblOthers.Text = Decimal.Round(getReader.Item("others"), 2).ToString("f2")

                getGrossPay = Val(frmPaySlip.lblHoursPay.Text) + Val(frmPaySlip.lblOverTimePay.Text)
                getNetPay = Val(getGrossPay) - (Val(frmPaySlip.lblSSS.Text) + Val(frmPaySlip.lblPagIbig.Text) + Val(frmPaySlip.lblLate.Text) + Val(frmPaySlip.lblOthers.Text))

                frmPaySlip.lblGrossPay.Text = Decimal.Round(getGrossPay, 2).ToString("f2")
                frmPaySlip.lblNetPay.Text = Decimal.Round(getNetPay, 2).ToString("f2")

                frmPaySlip.lblDate.Text = Format(getReader.Item("wage_date"), "MMM dd, yyyy")
                frmPaySlip.lblIssuedBy.Text = (getReader.Item("username").ToString)

                frmPaySlip.Show()

            Else

                MsgBox("Sorry no data found!", MsgBoxStyle.Information)
                txtSearch.Focus()

            End If

            getReader.Close()

        End If



    End Sub


End Class