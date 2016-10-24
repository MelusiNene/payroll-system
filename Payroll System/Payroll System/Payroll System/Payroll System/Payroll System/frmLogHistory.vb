Imports MySql.Data.MySqlClient

Public Class frmLogHistory

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getTotalLogRecords As Integer = Nothing


    ' getting the log history goes here
    Public Sub showLogHistory()

        getQuery = "SELECT staff.login_type, staff.username, log_history.date_time FROM staff, log_history WHERE staff.id = log_history.id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            With ListView1.Items.Add(getReader.Item("login_type").ToString)

                .SubItems.Add(getReader.Item("username").ToString)
                .SubItems.Add(getReader.Item("date_time").ToString)

            End With

        End While

        getReader.Close()

    End Sub

    ' removing the log history after 50 records goes here
    Public Sub removeLogHistory()

        ' getting the total records of the history
        getQuery = "SELECT COUNT(*) AS 'log_records' FROM log_history"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            getTotalLogRecords = (getReader.Item("log_records").ToString)

        End If

        getReader.Close()


        'removing the log history
        If getTotalLogRecords = 150 Then

            getQuery = "DELETE FROM log_history"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            getReader.Close()

        End If



    End Sub

End Class