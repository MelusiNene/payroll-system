Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private retrieveUsername As String = Nothing
    Private retrievePassword As String = Nothing
    Private staff_type As String = Nothing
    Public staff_name As String = Nothing
    Public getStaffID As Integer = Nothing


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        getLogInStaff()

    End Sub

    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click

        verifyAccount()

    End Sub

    Private Sub btnRetrievePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrievePassword.Click

        retriveAccount()

    End Sub

    Private Sub lblForgotPassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked

        ' starting width = 428
        Me.Width = 846
        Me.CenterToScreen()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MsgBox("Are you sure you want to exit? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Hide()

        End If

    End Sub


    ' verifying an account goes here
    Private Sub verifyAccount()

        getQuery = "SELECT staff.secret_question, staff.secret_answer FROM staff WHERE staff.username ='" & txtName.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            txtSecretQuestion.Text = (getReader.Item("secret_question").ToString)

            ' starting height = 90
            ' show modify button
            GroupBox8.Height = 236
            btnVerify.Visible = False
            btnRetrievePassword.Visible = True

        Else

            MsgBox("Username: " & txtName.Text & vbCrLf & Space(5) & "does not exist!", MsgBoxStyle.Information)

        End If

        getReader.Close()

    End Sub


    ' retrieving an account goes here
    Private Sub retriveAccount()

        getQuery = "SELECT staff.username, staff.password FROM staff WHERE staff.username ='" & txtName.Text & _
            "' AND staff.secret_answer ='" & txtSecretAnswer.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            retrieveUsername = (getReader.Item("username").ToString)
            retrievePassword = (getReader.Item("password").ToString)
            MsgBox("Username: " & retrieveUsername & vbCrLf & "Password: " & retrievePassword)

            ' show verify button
            ' starting height = 236
            btnRetrievePassword.Visible = False
            btnVerify.Visible = True
            GroupBox8.Height = 90

            ' clear fields
            clearInputFields()

        Else

            MsgBox("Wrong information!", MsgBoxStyle.Information)

        End If

        getReader.Close()

    End Sub

   

    ' clear text fields goes here
    Public Sub clearInputFields()

        Me.Width = 428
        Me.CenterToScreen()
        txtUsername.Clear()
        txtPassword.Clear()
        txtName.Clear()
        txtSecretAnswer.Clear()
        txtSecretQuestion.Clear()
        GroupBox8.Height = 91
        btnVerify.Visible = True
        btnRetrievePassword.Visible = False

    End Sub


    ' loggin the staff goes here
    Public Sub getLogInStaff()

        If txtUsername.Text = "" Then

            MsgBox("Please enter your username", MsgBoxStyle.Information)
            txtUsername.Focus()

        ElseIf txtPassword.Text = "" Then

            MsgBox("Please enter your password", MsgBoxStyle.Information)
            txtPassword.Focus()

        Else

            ' loggin the staff goes here
            getQuery = "SELECT staff.id, staff.username, staff.login_type FROM staff WHERE staff.username ='" & _
                txtUsername.Text & "' AND staff.password ='" & txtPassword.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            If getReader.Read = True Then

                getStaffID = (getReader.Item("id").ToString)
                staff_type = (getReader.Item("login_type").ToString)
                staff_name = (getReader.Item("username").ToString)

                getReader.Close()


                ' full accessable
                If staff_type = "Admin" Then

                    ' greet the user
                    frmHome.lblWelcome.Text = "Welcome, " & staff_type & ": " & staff_name + "!"

                    ' set the color buttons
                    frmHome.btnEditMySettings.BackColor = Color.DarkSlateGray
                    frmHome.btnApplicationManager.BackColor = Color.DarkSlateGray
                    frmMainMenu.btnPayrollSystem.BackColor = Color.DarkSlateGray
                    frmMainMenu.btnPayrollReports.BackColor = Color.DarkSlateGray
                    frmMainMenu.btnPayrollSlip.BackColor = Color.DarkSlateGray

                    ' enabling the buttons for the admin
                    frmHome.btnEditMySettings.Enabled = True
                    frmHome.btnApplicationManager.Enabled = True
                    frmMainMenu.btnPayrollSystem.Enabled = True
                    frmMainMenu.btnPayrollReports.Enabled = True
                    frmMainMenu.btnPayrollSlip.Enabled = True

                    ' inserting the log history
                    getLogHistory()

                    frmHome.txtAnnotate.Text = My.Settings.Annotations

                    frmHome.Show()
                    frmAttendance.Hide()
                    Me.Hide()

                    ' refresh fields
                    clearInputFields()

                    ' limiting the user accessable
                ElseIf staff_type = "User" Then

                    ' greet the user
                    frmHome.lblWelcome.Text = "Welcome, " & staff_type & ": " & staff_name + "!"

                    ' set the color buttons
                    frmHome.btnEditMySettings.BackColor = Color.MediumBlue
                    frmHome.btnApplicationManager.BackColor = Color.MediumBlue
                    frmMainMenu.btnPayrollSystem.BackColor = Color.MediumBlue
                    frmMainMenu.btnPayrollReports.BackColor = Color.MediumBlue
                    frmMainMenu.btnPayrollSlip.BackColor = Color.MediumBlue


                    ' disabling the buttons for the user
                    frmHome.btnEditMySettings.Enabled = False
                    frmHome.btnApplicationManager.Enabled = False
                    frmMainMenu.btnPayrollSystem.Enabled = False
                    frmMainMenu.btnPayrollReports.Enabled = False
                    frmMainMenu.btnPayrollSlip.Enabled = False

                
                    ' inserting the log history
                    getLogHistory()

                    frmHome.txtAnnotate.Text = My.Settings.Annotations

                    frmHome.Show()
                    frmAttendance.Hide()
                    Me.Hide()

                    ' refresh fields
                    clearInputFields()

                End If

                

            Else

                MsgBox("Incorrect username and/or password!", MsgBoxStyle.Information)

            End If

            getReader.Close()

        End If

      

    End Sub


    ' getting the log of the staff goes here
    Public Sub getLogHistory()

        getQuery = "INSERT INTO log_history VALUES('" & getStaffID & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        getReader.Close()

    End Sub


End Class
