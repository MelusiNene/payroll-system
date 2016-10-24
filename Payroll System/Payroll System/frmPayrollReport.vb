Imports MySql.Data.MySqlClient

Public Class frmPayrollReport

    ' declare variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getGrossPay As Decimal = Nothing
    Private getNetPay As Decimal = Nothing

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Hide()

    End Sub

    ' shows the worker reports
    Public Sub showWorkerReports()

        ' getting the worker details
        getQuery = "SELECT wage.worker_id, worker.worker_fullname, designation.designation_name, designation.designation_amount, " & _
            "wage.days_work, wage.hours_pay, wage.overtime_pay, deduction.sss, deduction.pag_ibig, deduction.late, deduction.others " & _
            "FROM worker, designation, wage, deduction WHERE worker.designation_id = designation.designation_id AND worker.worker_id = " & _
            "wage.worker_id AND wage.deduction_id = deduction.deduction_id ORDER BY wage.worker_id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        ListView1.Items.Clear()

        While getReader.Read

            With ListView1.Items.Add(getReader.Item("worker_id").ToString)

                getGrossPay = Val(getReader.Item("hours_pay").ToString) + Val(getReader.Item("overtime_pay").ToString)
                getNetPay = Val(getGrossPay) - (Val(getReader.Item("pag_ibig").ToString) + Val(getReader.Item("sss").ToString) + Val(getReader.Item("pag_ibig").ToString) + Val(getReader.Item("late").ToString) + Val(getReader.Item("others").ToString))

                .SubItems.Add(getReader.Item("worker_fullname").ToString)
                .SubItems.Add(getReader.Item("designation_name").ToString)
                .SubItems.Add(getReader.Item("days_work").ToString)
                .SubItems.Add(Decimal.Round(getReader.Item("designation_amount"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getReader.Item("hours_pay"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getReader.Item("overtime_pay"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getReader.Item("sss"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getReader.Item("pag_ibig"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getReader.Item("late"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getReader.Item("others"), 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getGrossPay, 2).ToString("f2"))
                .SubItems.Add(Decimal.Round(getNetPay, 2).ToString("f2"))

            End With

        End While

        getReader.Close()

    End Sub


    ' getting the total records of the wage goes here
    Public Sub workerTotalRecords()

        getQuery = "SELECT COUNT(wage.wage_id) as 'total_records' FROM wage"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            lblTotalRecords.Text = (getReader.Item("total_records").ToString)

        End If

        getReader.Close()

    End Sub



    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        ' print the page goes here
        If MsgBox("Are you sure you want to print this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            PrintDialog1.Document = PrintDocument1

            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                PrintDocument1.Print()

            End If

        End If

    End Sub
End Class