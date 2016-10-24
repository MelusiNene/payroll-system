Imports MySql.Data.MySqlClient

Public Class frmAppManager

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private staffID As Integer = 1
    Private staffLoginType As String = Nothing
    Private staffUsername As String = Nothing
    Private selectStaffID As String = Nothing


    Private Sub frmAppManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IncrementStaffID()

    End Sub



    Private Sub btnViewRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' starting width = 382
        Me.Width = 882
        Me.CenterToScreen()

    End Sub

    Private Sub btnNewAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        clearTextFields()

    End Sub


    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        staffAccount()

    End Sub


    Private Sub btnDeleteAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RemoveStaffAccount()

    End Sub


    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        selectStaffID = ListView1.SelectedItems(0).Text

    End Sub


    ' incrementing id for staff goes here
    Public Sub IncrementStaffID()

        getQuery = "SELECT id FROM staff ORDER BY id DESC LIMIT 1"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            staffID = (getReader.Item("id").ToString) + 1

        End While

        getReader.Close()

    End Sub


    ' creating an account for staff goes here
    Public Sub staffAccount()

        ' getting the login type goes here
        If rdbtnAdmin.Checked = True Then

            staffLoginType = rdbtnAdmin.Text

        ElseIf rdbtnUser.Checked = True Then

            staffLoginType = rdbtnUser.Text

        End If


        ' getting the username if exists goes here
        getQuery = "SELECT username FROM staff WHERE username ='" & txtusername.Text & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            staffUsername = (getReader.Item("username").ToString)

        End If

        getReader.Close()


        ' inputting all information goes here
        If txtusername.Text = "" Then

            MsgBox("Please enter your username", MsgBoxStyle.Information)
            txtusername.Focus()

        ElseIf txtPassword.Text = "" Then

            MsgBox("Please enter your password", MsgBoxStyle.Information)
            txtPassword.Focus()

        ElseIf txtRePassword.Text = "" Then

            MsgBox("Please enter your password", MsgBoxStyle.Information)
            txtRePassword.Focus()

        ElseIf txtSecretQuestion.Text = "" Then

            MsgBox("Please enter your secret question", MsgBoxStyle.Information)
            txtSecretQuestion.Focus()

        ElseIf txtSecretAnswer.Text = "" Then

            MsgBox("Please enter your secret answer", MsgBoxStyle.Information)
            txtSecretAnswer.Focus()

        ElseIf staffLoginType = "" Then

            MsgBox("Please select login type", MsgBoxStyle.Information)

        ElseIf txtPassword.Text <> txtRePassword.Text Then

            MsgBox("Password does not match", MsgBoxStyle.Information)
            txtPassword.Clear()
            txtRePassword.Clear()
            txtPassword.Focus()

        ElseIf staffUsername = txtusername.Text Then

            MsgBox("Username: " & txtusername.Text & vbCrLf & Space(5) & "Already Exist!", MsgBoxStyle.Information)
            txtusername.Focus()

        Else

            ' creating account for staff goes here
            getQuery = "INSERT INTO staff VALUES('" & staffID & "','" & txtusername.Text & "','" & txtPassword.Text & _
                "','" & txtSecretQuestion.Text & "','" & txtSecretAnswer.Text & "','" & staffLoginType & "')"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            MsgBox("Account registered successfully!", MsgBoxStyle.Information)

            getReader.Close()

            IncrementStaffID()

        End If

    End Sub


    ' retrieving account info goes here
    Public Sub showStaffAccouts()

        getQuery = "SELECT staff.id, staff.login_type, staff.username FROM staff ORDER BY staff.id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        ListView1.Items.Clear()

        While getReader.Read

            With ListView1.Items.Add(getReader.Item("id").ToString)

                .SubItems.Add(getReader.Item("login_type").ToString)
                .SubItems.Add(getReader.Item("username").ToString)

            End With

        End While

        getReader.Close()

    End Sub

    ' deleting an staff account goes here
    Public Sub RemoveStaffAccount()

        If selectStaffID = Nothing Then

            MsgBox("Please select a record to remove", MsgBoxStyle.Information)

        Else

            ' remove staff account goes here
            If MsgBox(Space(18) & "Staff ID: " & selectStaffID & vbCrLf & "Are you sure you want to remove?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                getQuery = "DELETE FROM staff WHERE staff.id ='" & selectStaffID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                MsgBox("Account deleted sucessfully!", MsgBoxStyle.Information)

                getReader.Close()

                ' refresh incrementing id 
                IncrementStaffID()

                selectStaffID = Nothing


            End If

            selectStaffID = Nothing

        End If
    End Sub

    ' clear all textboxes goes here
    Public Sub clearTextFields()

        txtusername.Clear()
        txtPassword.Clear()
        txtRePassword.Clear()
        txtSecretAnswer.Clear()
        txtSecretQuestion.Clear()
        rdbtnAdmin.Checked = False
        rdbtnUser.Checked = False

    End Sub


    Private Sub btnViewRecords_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRecords.Click

        ' starting width = 424
        Me.Width = 900
        Me.CenterToScreen()

    End Sub

    Private Sub btnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        showStaffAccouts()

    End Sub

    Private Sub btnDeleteAccount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAccount.Click

        RemoveStaffAccount()

    End Sub

    Private Sub btnSubmit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        staffAccount()

    End Sub

    Private Sub btnNewAccount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewAccount.Click

        clearTextFields()

    End Sub

    Private Sub ListView1_MouseClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

        selectStaffID = ListView1.SelectedItems(0).Text

    End Sub
End Class