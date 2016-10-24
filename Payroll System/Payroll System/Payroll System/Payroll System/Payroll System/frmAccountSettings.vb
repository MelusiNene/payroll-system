Imports MySql.Data.MySqlClient

Public Class frmAccountSettings

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getLoginType As String = Nothing


    Private Sub frmAccountSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        showStaffAccountID()
        showWorkerID()
        showWorkerInfo()

    End Sub

    Private Sub cbSelectID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSelectStaffID.SelectedIndexChanged

        getAccountInfo()

    End Sub

    Private Sub lblLinkShow_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLinkShow.LinkClicked

        showInfo()

    End Sub

    Private Sub lblLinkHide_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLinkHide.LinkClicked

        hideInfo()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        enableButtonEdit()

    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        enableButtonConfirm()
        modifyAccount()

    End Sub


    Private Sub cbSelectWorkerID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSelectWorkerID.SelectedIndexChanged

        getWorkerInfo()

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        changeWorkerPassword()

    End Sub

    ' getting the staff id goes here
    Private Sub showStaffAccountID()

        getQuery = "SELECT staff.id FROM staff ORDER BY staff.id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        cbSelectStaffID.Items.Clear()

        While getReader.Read

            cbSelectStaffID.Items.Add(getReader.Item("id").ToString)

        End While

        getReader.Close()

    End Sub

    ' getting the account info goes here
    Private Sub getAccountInfo()

        getQuery = "SELECT staff.username, staff.password, staff.secret_question, staff.secret_answer, login_type FROM staff WHERE staff.id ='" & _
            cbSelectStaffID.SelectedItem & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            getLoginType = (getReader.Item("login_type").ToString)

            If getLoginType = "Admin" Then

                rdbtnAdmin.Checked = True

            ElseIf getLoginType = "User" Then

                rdbtnUser.Checked = True

            End If

            txtUsername.Text = (getReader.Item("username").ToString)
            txtPassword.Text = (getReader.Item("password").ToString)
            txtSecretQuestion.Text = (getReader.Item("secret_question").ToString)
            txtSecretAnswer.Text = (getReader.Item("secret_answer").ToString)

            grpStaffInfo.Visible = True

        End If

        getReader.Close()

    End Sub

    ' modify the staff account goes here
    Private Sub modifyAccount()

        If cbSelectStaffID.SelectedItem = Nothing Then

            MsgBox("Please select id", MsgBoxStyle.Information)

        Else

            If MsgBox("Are you sure you want to modify?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                If rdbtnAdmin.Checked = True Then

                    getLoginType = rdbtnAdmin.Text

                ElseIf rdbtnUser.Checked = True Then

                    getLoginType = rdbtnUser.Text

                End If

                getQuery = "UPDATE staff SET staff.username ='" & txtUsername.Text & "', staff.password ='" & _
                        txtPassword.Text & "', staff.secret_question ='" & txtSecretQuestion.Text & "', staff.secret_answer ='" & _
                        txtSecretAnswer.Text & "', staff.login_type ='" & getLoginType & "' WHERE staff.id ='" & cbSelectStaffID.SelectedItem & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                MsgBox("Account updated successfully!", MsgBoxStyle.Information)

                getReader.Close()

                ' set back color to uninputted fields
                setColor()


            End If

        End If




    End Sub

    ' show account information goes here
    Private Sub showInfo()

        txtUsername.PasswordChar = ""
        txtPassword.PasswordChar = ""
        txtSecretQuestion.PasswordChar = ""
        txtSecretAnswer.PasswordChar = ""

        lblLinkShow.Visible = False
        lblLinkHide.Visible = True

    End Sub

    ' hide account information goes here
    Private Sub hideInfo()

        txtUsername.PasswordChar = "●"
        txtPassword.PasswordChar = "●"
        txtSecretQuestion.PasswordChar = "●"
        txtSecretAnswer.PasswordChar = "●"

        lblLinkHide.Visible = False
        lblLinkShow.Visible = True

    End Sub

    ' show edit button goes here
    Private Sub enableButtonEdit()

        ' set back color to white
        editColor()

        txtUsername.ReadOnly = False
        txtPassword.ReadOnly = False
        txtSecretQuestion.ReadOnly = False
        txtSecretAnswer.ReadOnly = False

        btnEdit.Visible = False
        btnConfirm.Visible = True

    End Sub

    ' show confirm button goes here
    Private Sub enableButtonConfirm()

        ' set back color to sky blue
        setColor()

        txtUsername.ReadOnly = True
        txtPassword.ReadOnly = True
        txtSecretQuestion.ReadOnly = True
        txtSecretAnswer.ReadOnly = True

        btnConfirm.Visible = False
        btnEdit.Visible = True

    End Sub


    ' set to white inputting textfields
    Private Sub editColor()

        txtUsername.BackColor = Color.White
        txtPassword.BackColor = Color.White
        txtSecretAnswer.BackColor = Color.White
        txtSecretQuestion.BackColor = Color.White

    End Sub

    ' set to skyblue uninputted textfields
    Private Sub setColor()

        txtUsername.BackColor = Color.SkyBlue
        txtPassword.BackColor = Color.SkyBlue
        txtSecretAnswer.BackColor = Color.SkyBlue
        txtSecretQuestion.BackColor = Color.SkyBlue

    End Sub

    ' clear the fields after changing the password 
    Private Sub clearFields()

        cbSelectWorkerID.SelectedIndex = -1
        txtWorkerFullname.Clear()
        txtOldPassword.Clear()
        txtNewPassword.Clear()

    End Sub


    ' show the worker id goes here
    Private Sub showWorkerID()

        getQuery = "SELECT worker.worker_id FROM worker"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        cbSelectWorkerID.Items.Clear()

        While getReader.Read

            cbSelectWorkerID.Items.Add(getReader.Item("worker_id").ToString)

        End While


        getReader.Close()

    End Sub


    ' shows the worker info in listview goes here
    Private Sub showWorkerInfo()

        getQuery = "SELECT worker.worker_id, worker.worker_fullname, worker.worker_password FROM worker ORDER BY worker.worker_id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            With ListView1.Items.Add(getReader.Item("worker_id").ToString)

                .SubItems.Add(getReader.Item("worker_fullname").ToString)

            End With

        End While


        getReader.Close()

    End Sub

    ' get the worker info
    Private Sub getWorkerInfo()

        getQuery = "SELECT worker.worker_fullname, worker.worker_password FROM worker WHERE worker.worker_id ='" & cbSelectWorkerID.SelectedItem & "'"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        If getReader.Read = True Then

            txtWorkerFullname.Text = (getReader.Item("worker_fullname").ToString)
            txtOldPassword.Text = (getReader.Item("worker_password").ToString)

            GroupBox7.Visible = True

        End If

        getReader.Close()

    End Sub

    ' change the password of the worker goes here
    Private Sub changeWorkerPassword()

        If cbSelectWorkerID.SelectedIndex = -1 Then

            MsgBox("Please select worker id", MsgBoxStyle.Information)
            cbSelectWorkerID.Focus()

        ElseIf txtNewPassword.Text = "" Then

            MsgBox("Please enter new password", MsgBoxStyle.Information)
            txtNewPassword.Focus()

        Else

            If MsgBox(Space(30) & "Worker ID: " & cbSelectWorkerID.SelectedItem & vbCrLf & "Are you sure you want to change your password?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                getQuery = "UPDATE worker SET worker.worker_password ='" & txtNewPassword.Text & "' WHERE worker.worker_id ='" & cbSelectWorkerID.SelectedItem & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                MsgBox("Password changed successfully!")

                getReader.Close()

                ' refresh fields
                clearFields()

            End If


        End If

    End Sub


  
End Class