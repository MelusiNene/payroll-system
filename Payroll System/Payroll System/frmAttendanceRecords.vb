Imports MySql.Data.MySqlClient

Public Class frmAttendanceRecords

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private time_in As DateTime = Nothing
    Private time_out As DateTime = Nothing

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        showAttendanceRecords()

    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If dtpTo.Value < dtpFrom.Value Then

            MsgBox("Please correct the date " & vbCrLf & Space(12) & "From : To", MsgBoxStyle.Information)

            ListView1.Items.Clear()

        Else

            searchByDate()

        End If


    End Sub


    ' shows the attendance records goes here
    Public Sub showAttendanceRecords()

        ListView1.Items.Clear()

        ' shows the worker time in
        getQuery = "SELECT worker.worker_fullname, dtr.time_in, dtr.time_out, dtr.date FROM worker, dtr WHERE worker.worker_id = dtr.worker_id AND dtr.time_in IS NOT NULL AND dtr.time_out IS NULL AND dtr.date IS NOT NULL"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the time in 12 hour format
            time_in = (getReader.Item("time_in").ToString)

            With ListView1.Items.Add(getReader.Item("worker_fullname").ToString)

                .SubItems.Add(Format(time_in, "h:mm:ss tt"))
                .SubItems.Add("")
                .SubItems.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()

        ' shows the worker time in and time out
        getQuery = "SELECT worker_fullname, dtr.time_in, dtr.time_out, dtr.date FROM worker, dtr WHERE worker.worker_id = dtr.worker_id AND dtr.time_in IS NOT NULL AND dtr.time_out IS NOT NULL AND dtr.time_out IS NOT NULL"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the time in and time out 12 hour format
            time_in = (getReader.Item("time_in").ToString)
            time_out = (getReader.Item("time_out").ToString)

            With ListView1.Items.Add(getReader.Item("worker_fullname").ToString)

                .SubItems.Add(Format(time_in, "h:mm:ss tt"))
                .SubItems.Add(Format(time_out, "h:mm:ss tt"))
                .SubItems.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()


    End Sub

    ' searching by date of the dtr of the worker 
    Public Sub searchByDate()

        'getQuery = "SELECT worker.worker_fullname, dtr.time_in, dtr.time_out, dtr.date FROM worker, dtr WHERE worker.worker_id = dtr.worker_id AND dtr.date <='" + Format(dtpFrom.Value, "yyyy-MM-dd") + "' AND dtr.date >='" + Format(dtpTo.Value, "yyyy-MM-dd") + "'"

        ListView1.Items.Clear()

        ' shows the worker time in
        getQuery = "SELECT worker.worker_fullname, dtr.time_in, dtr.time_out, dtr.date FROM worker, dtr WHERE worker.worker_id = dtr.worker_id AND dtr.time_in IS NOT NULL AND dtr.time_out IS NULL AND dtr.date IS NOT NULL AND dtr.date BETWEEN '" + Format(dtpFrom.Value, "yyyy-MM-dd") + "' AND '" + Format(dtpTo.Value, "yyyy-MM-dd") + "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the time in 12 hour format
            time_in = (getReader.Item("time_in").ToString)

            With ListView1.Items.Add(getReader.Item("worker_fullname").ToString)

                .SubItems.Add(Format(time_in, "h:mm:ss tt"))
                .SubItems.Add("")
                .SubItems.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()

        ' shows the worker time in and time out
        getQuery = "SELECT worker.worker_fullname, dtr.time_in, dtr.time_out, dtr.date FROM worker, dtr WHERE worker.worker_id = dtr.worker_id AND dtr.time_in IS NOT NULL AND dtr.time_out IS NOT NULL AND dtr.date IS NOT NULL AND dtr.date BETWEEN '" + Format(dtpFrom.Value, "yyyy-MM-dd") + "' AND '" + Format(dtpTo.Value, "yyyy-MM-dd") + "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the time in and time out 12 hour format
            time_in = (getReader.Item("time_in").ToString)
            time_out = (getReader.Item("time_out").ToString)

            With ListView1.Items.Add(getReader.Item("worker_fullname").ToString)

                .SubItems.Add(Format(time_in, "h:mm:ss tt"))
                .SubItems.Add(Format(time_out, "h:mm:ss tt"))
                .SubItems.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()


    End Sub

End Class