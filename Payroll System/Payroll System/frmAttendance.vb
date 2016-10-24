Imports MySql.Data.MySqlClient

Public Class frmAttendance

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private TimeIN As String = Nothing
    Private TimeOUT As String = Nothing
    Private getDate As String = Nothing
    Public getFrmMainMenu As String = Nothing
    Private unableToOpen As String = "You cannot open"
    Private getWorkerID As Integer = Nothing

    Private Sub frmAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        disableTimeButtonsColor()
        lblDate.Text = Format(Date.Today, "MMM dd, yyyy")
        lblTime.Text = TimeOfDay
        showWorkerFullnames()
        showAttendance()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblTime.Text = TimeOfDay

    End Sub


    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        logInWorker()

    End Sub


    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click

        workerLogOut()
        enablesLogIn()

    End Sub



    Private Sub btnViewRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRecords.Click

        frmAttendanceRecords.Show()

    End Sub


    Private Sub btnTimeIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIN.Click

        'workerTimeIN = dtpTimeIN.Value.ToString("HH:mm:ss")

        getTimeIN()

    End Sub

    Private Sub btnTimeOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOUT.Click

        ' workerTimeOut = dtpTimeOUT.Value.ToString("HH:mm:ss")

        getTimeOUT()

    End Sub



    ' shows the worker names goes here
    Public Sub showWorkerFullnames()

        getQuery = "SELECT worker.worker_fullname FROM worker"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        cbWorkerFullnames.Items.Clear()

        While getReader.Read

            cbWorkerFullnames.Items.Add(getReader.Item("worker_fullname").ToString)

        End While

        getReader.Close()

    End Sub


    Private Sub cbWorkerFullnames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbWorkerFullnames.SelectedIndexChanged

        refreshFields()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

        If getFrmMainMenu = unableToOpen Then

            MsgBox("You are already login!", MsgBoxStyle.Information)

        Else

            ' shows login form using hotkey ctrl + f1
            frmMainMenu.Hide()
            frmLogin.Show()

        End If


    End Sub



    ' shows the worker dtr goes here
    Public Sub showAttendance()

        ' declare variable to get 12 hour format
        Dim time_in As DateTime = Nothing
        Dim time_out As DateTime = Nothing

        ' clear previous items on the listview
        Listview1.Items.Clear()


        ' shows the dtr of the worker time in and time out
        getQuery = "SELECT worker.worker_fullname, dtr.time_in, dtr.time_out, dtr.date FROM worker, dtr WHERE dtr.time_in IS NOT NULL and dtr.time_out IS NOT NULL AND worker.worker_id = dtr.worker_id AND dtr.date ='" & Format(Date.Today, "yyyy-MM-dd") & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the time in and time out 12 hour format
            time_in = (getReader.Item("time_in").ToString)
            time_out = (getReader.Item("time_out").ToString)

            With Listview1.Items.Add(getReader.Item("worker_fullname").ToString)

                .SubItems.Add(Format(time_in, "h:mm:ss tt"))
                .SubItems.Add(Format(time_out, "h:mm:ss tt"))
                .SubItems.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()


        ' shows the dtr of the worker time in
        getQuery = "SELECT worker.worker_fullname, dtr.time_in, dtr.date FROM worker, dtr WHERE worker.worker_id = dtr.worker_id AND dtr.time_in IS NOT NULL AND dtr.time_out IS NULL AND dtr.date ='" & Format(Date.Today, "yyyy-MM-dd") & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            ' getting the time in 12 hour format
            time_in = (getReader.Item("time_in").ToString)

            With Listview1.Items.Add(getReader.Item("worker_fullname").ToString)

                .SubItems.Add(Format(time_in, "h:mm:ss tt"))
                ' set time out to null
                .SubItems.Add("")
                .SubItems.Add(Format(getReader.Item("date"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()


    End Sub

    ' getting the time in and time out buttons goes here
    Public Sub getTimeButtons()

        ' get time in
        getQuery = "SELECT dtr.time_in, dtr.date FROM dtr, worker WHERE worker.worker_id ='" & getWorkerID & _
             "'AND dtr.worker_id ='" & getWorkerID & "' AND dtr.date ='" & Date.Now.ToString("yyyy-MM-dd") & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            TimeIN = (getReader.Item("time_in").ToString)
            getDate = (getReader.Item("date"))

        End If

        getReader.Close()

        ' get time out
        getQuery = "SELECT dtr.time_out, dtr.date FROM dtr, worker WHERE worker.worker_id ='" & getWorkerID & "' AND dtr.worker_id ='" & _
            getWorkerID & "' AND dtr.date ='" & Date.Now.ToString("yyyy-MM-dd") & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            TimeOUT = (getReader.Item("time_out").ToString)
            getDate = (getReader.Item("date"))

        End If

        getReader.Close()


        ' getting the enabling/disabling buttons
        ' enable time in button
        ' disable time out button
        If TimeIN = "" Then

            'btnTimeIN.Enabled = True
            'btnTimeOUT.Enabled = False
            disableTimeOutColor()
            TimeIN = Nothing
            TimeOUT = Nothing
            getDate = Nothing

            ' disable time in and time out buttons
        ElseIf TimeIN <> "" And TimeOUT <> "" And getDate = Date.Today Then

            'btnTimeIN.Enabled = False
            'btnTimeOUT.Enabled = False
            disableTimeButtonsColor()
            TimeOUT = Nothing
            TimeIN = Nothing
            getDate = Nothing

            ' enable time out button
            ' disable time in button
        ElseIf TimeIN <> "" Then

            'btnTimeIN.Enabled = False
            'btnTimeOUT.Enabled = True
            disableTimeINColor()
            TimeIN = Nothing
            TimeOUT = Nothing
            getDate = Nothing

            ' enable time out button
            ' disable time in button
        ElseIf TimeOUT = "" Then

            'btnTimeOUT.Enabled = True
            'btnTimeIN.Enabled = False
            disableTimeINColor()
            TimeOUT = Nothing
            TimeIN = Nothing
            getDate = Nothing

            ' enable time in button
            ' disable time out button
        ElseIf TimeOUT <> "" Then

            'btnTimeIN.Enabled = True
            'btnTimeOUT.Enabled = False
            disableTimeOutColor()
            TimeOUT = Nothing
            TimeIN = Nothing
            getDate = Nothing

            ' enable time in and time out buttons
        ElseIf TimeIN = "" And TimeOUT = "" And getDate = "" Then

            'btnTimeIN.Enabled = True
            'btnTimeOUT.Enabled = False
            disableTimeOutColor()
            TimeOUT = Nothing
            TimeIN = Nothing
            getDate = Nothing

        End If


    End Sub



    ' worker time in goes here
    Public Sub getTimeIN()

        
                ' worker time in
        getQuery = "INSERT INTO dtr (worker_id, time_in, date) VALUES('" & getWorkerID & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & Date.Today.ToString("yyyy-MM-dd") & "')"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                ' refresh dtr
                showAttendance()

                ' refresh buttons
                getTimeButtons()

            
    End Sub

    ' worker time out goes here
    Public Sub getTimeOUT()



        ' worker time out
        getQuery = "UPDATE dtr SET dtr.time_out ='" & Format(TimeOfDay, "HH:mm:ss") & "' WHERE dtr.worker_id ='" & getWorkerID & "' AND dtr.date ='" & Format(Date.Today, "yyyy-MM-dd") & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        getReader.Close()

        ' refresh dtr
        showAttendance()

        ' refresh buttons
        getTimeButtons()


    End Sub


    ' worker login
    Public Sub logInWorker()

        If cbWorkerFullnames.SelectedIndex = -1 Then

            MsgBox("Please select worker fullname", MsgBoxStyle.Information)
            cbWorkerFullnames.Focus()

        ElseIf txtPassword.Text = "" Then

            MsgBox("Please enter your password", MsgBoxStyle.Information)
            txtPassword.Focus()


        Else

            ' get the id of the worker name
            getQuery = "SELECT worker.worker_id FROM worker WHERE worker.worker_password ='" & txtPassword.Text & "' AND worker.worker_fullname ='" & cbWorkerFullnames.SelectedItem & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            If getReader.Read = True Then

                getWorkerID = (getReader.Item("worker_id").ToString)

                MsgBox("Welcome: " & cbWorkerFullnames.SelectedItem, MsgBoxStyle.Information)

                getReader.Close()

                getTimeButtons()

                disableLogIn()
               
            Else

                MsgBox("Incorrect fullname and/or password!", MsgBoxStyle.Information)
                txtPassword.Focus()

            End If

            getReader.Close()



        End If

    End Sub

    ' disabling the time in goes here
    Public Sub disableTimeINColor()

        btnTimeOUT.Enabled = True
        btnTimeIN.Enabled = False

        btnTimeOUT.BackColor = Color.DarkSlateGray
        btnTimeOUT.ForeColor = Color.White

        btnTimeIN.BackColor = Color.MediumBlue
        btnTimeIN.ForeColor = Color.Red

    End Sub


    ' disabling the time out goes here
    Public Sub disableTimeOutColor()

        btnTimeIN.Enabled = True
        btnTimeOUT.Enabled = False

        btnTimeIN.BackColor = Color.DarkSlateGray
        btnTimeIN.ForeColor = Color.White

        btnTimeOUT.BackColor = Color.MediumBlue
        btnTimeOUT.ForeColor = Color.Red
       
    End Sub


    ' disable the time in/out goes here
    Public Sub disableTimeButtonsColor()

        btnTimeIN.Enabled = False
        btnTimeOUT.Enabled = False

        btnTimeOUT.BackColor = Color.MediumBlue
        btnTimeOUT.ForeColor = Color.Red

        btnTimeIN.BackColor = Color.MediumBlue
        btnTimeIN.ForeColor = Color.Red

    End Sub


    ' clear all fields
    Public Sub refreshFields()

        disableTimeButtonsColor()
        txtPassword.Clear()
        btnTimeIN.Enabled = False
        btnTimeOUT.Enabled = False
        txtPassword.BackColor = Color.White
        txtPassword.Enabled = True
        cbWorkerFullnames.Enabled = True
        btnLogIn.Visible = True
        btnLogOut.Visible = False

    End Sub

    ' set fields after worker logout
    Private Sub workerLogOut()

        txtPassword.Clear()
        cbWorkerFullnames.SelectedIndex = -1
        btnLogOut.Visible = False
        btnLogIn.Visible = True

    End Sub

    ' set enables button
    Private Sub enablesLogIn()

        txtPassword.Enabled = True
        cbWorkerFullnames.Enabled = True

        ' hide logout
        btnLogOut.Visible = False

        ' unhide login
        btnLogIn.Visible = True

        txtPassword.BackColor = Color.White
        ' cbWorkerFullnames.BackColor = Color.White


    End Sub

    ' disable after login
    Private Sub disableLogIn()

        txtPassword.Enabled = False
        cbWorkerFullnames.Enabled = False

        ' hide login
        btnLogIn.Visible = False

        ' unhide logout
        btnLogOut.Visible = True

        txtPassword.BackColor = Color.Gold
        'cbWorkerFullnames.BackColor = Color.Gold

    End Sub



    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class