Imports MySql.Data.MySqlClient

Public Class frmViewWorkerRecords

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getDay As Date = Nothing
    Private getWorkingHours As Integer = Nothing
    Private getStartingTimeIN As Integer = Nothing
    Private getEndingTimeOUT As Integer = Nothing
    Private getTimeInFormat As DateTime = Nothing
    Private getTimeOutFormat As DateTime = Nothing
    Private getOverTimeHours As Integer = Nothing
    Private getLateTimeHOurs As Integer = Nothing
    Private getStartingOvertime As Integer = 17
    Private getEndingOvertime As Integer = Nothing
    Private getStartingLateTime As Integer = 8
    Private getEndingLateTime As Integer = Nothing

    ' get the worker's details
    Private Sub ViewWorkerRecords()

        getQuery = "SELECT HOUR(dtr.time_in) AS 'in_hours', HOUR(dtr.time_out) AS 'out_hours', dtr.* FROM dtr, worker WHERE dtr.date IS NOT NULL AND dtr.time_in IS NOT NULL AND dtr.time_out IS NOT NULL AND worker.worker_id ='" & _
            frmWorkerPayroll.txtSearchWorkerID.Text & "' AND dtr.worker_id ='" & frmWorkerPayroll.txtSearchWorkerID.Text & "' ORDER BY dtr.date"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the day 
            getDay = (getReader.Item("date"))

            ' getting the time in and time out 12 hour format
            getTimeInFormat = (getReader.Item("time_in").ToString)
            getTimeOutFormat = (getReader.Item("time_out").ToString)

            ' getting the time in
            getStartingTimeIN = (getReader.Item("in_hours").ToString)

            ' getting the time out
            getEndingTimeOUT = (getReader.Item("out_hours").ToString)

            ' getting the over time
            getEndingOvertime = (getReader.Item("out_hours").ToString)

            ' getting the late time
            getEndingLateTime = (getReader.Item("in_hours".ToString))


            ' calculate the working late
            While getStartingLateTime < getEndingLateTime

                getLateTimeHOurs = getLateTimeHOurs + 1

                getStartingLateTime = getStartingLateTime + 1

            End While

            ' calculate the working overtime
            While getStartingOvertime < getEndingOvertime

                getOverTimeHours = getOverTimeHours + 1

                getStartingOvertime = getStartingOvertime + 1

            End While

            'calculate the working hours
            While getStartingTimeIN < getEndingTimeOUT

                getWorkingHours = getWorkingHours + 1

                getStartingTimeIN = getStartingTimeIN + 1

            End While

            With ListView1.Items.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

                .SubItems.Add(Format(getDay, "ddd"))
                .SubItems.Add(Format(getTimeInFormat, "h:mm:ss tt"))
                .SubItems.Add(Format(getTimeOutFormat, "h:mm:ss tt"))
                .SubItems.Add(getWorkingHours)
                .SubItems.Add(getOverTimeHours)
                .SubItems.Add(getLateTimeHOurs)

            End With

            ' set to nothing
            getStartingTimeIN = Nothing
            getEndingTimeOUT = Nothing
            getWorkingHours = Nothing
            getOverTimeHours = Nothing
            getLateTimeHOurs = Nothing
            getStartingLateTime = 8
            getStartingOvertime = 17

        End While

        getReader.Close()

    End Sub

    Private Sub frmViewWorkerRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ViewWorkerRecords()

    End Sub
End Class