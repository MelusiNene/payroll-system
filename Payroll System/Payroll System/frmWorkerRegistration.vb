Imports MySql.Data.MySqlClient

Public Class frmWorkerRegistration

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getDesignationID As String = Nothing

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If MsgBox("Are you sure you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            frmMainMenu.Show()
            Me.Hide()

        End If

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        newWorkerAccount()

    End Sub

    ' incrementing the worker id goes here
    Public Sub incrementWorkerID()

        getQuery = "SELECT worker.worker_id FROM worker ORDER BY worker.worker_id DESC LIMIT 1"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            lblWorkerID.Text = (getReader.Item("worker_id").ToString) + 1

        End While

        getReader.Close()

    End Sub

    ' shows the designation name goes here
    Public Sub getDesignationNames()

        getQuery = "SELECT designation.designation_name FROM designation"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        cbDesignation.Items.Clear()

        While getReader.Read

            cbDesignation.Items.Add(getReader.Item("designation_name").ToString)

        End While

        getReader.Close()

    End Sub

    ' creating accoung for worker goes here
    Public Sub newWorkerAccount()

        If txtFirstname.Text = "" Then

            MsgBox("Please enter your firstname", MsgBoxStyle.Information)
            txtFirstname.Focus()

        ElseIf txtMiddlename.Text = "" Then

            MsgBox("Please enter your middlename", MsgBoxStyle.Information)
            txtMiddlename.Focus()

        ElseIf txtLastname.Text = "" Then

            MsgBox("Please enter your lastname", MsgBoxStyle.Information)
            txtLastname.Focus()

        ElseIf txtAddress.Text = "" Then

            MsgBox("Please enter your address", MsgBoxStyle.Information)
            txtAddress.Focus()

        ElseIf txtPassword.Text = "" Then

            MsgBox("Please enter your password", MsgBoxStyle.Information)
            txtPassword.Focus()

        ElseIf cbGender.SelectedIndex = -1 Then

            MsgBox("Please select your gender", MsgBoxStyle.Information)
            cbGender.Focus()

        ElseIf cbDesignation.SelectedIndex = -1 Then

            MsgBox("Please select designation", MsgBoxStyle.Information)
            cbDesignation.Focus()

        Else

            If MsgBox("Are you sure you want to add a new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                ' getting the id for designation name goes here
                getQuery = "SELECT designation.designation_id FROM designation WHERE designation.designation_name ='" & cbDesignation.SelectedItem & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    getDesignationID = (getReader.Item("designation_id").ToString)

                    getReader.Close()


                    ' worker account goes here
                    getQuery = "INSERT INTO worker VALUES('" & lblWorkerID.Text & "','" & txtFirstname.Text + " " + txtMiddlename.Text + "." + " " + txtLastname.Text & "','" & _
                      txtPassword.Text & "','" & txtAddress.Text & "','" & dtpBirthDate.Text & "','" & cbGender.SelectedItem & _
                        "','" & Date.Today.ToString("yyyy-MM-dd") & "','" & txtContactNo.Text & "','" & getDesignationID & "')"
                    getCommand = New MySqlCommand(getQuery, MySQLConnection)
                    getReader = getCommand.ExecuteReader

                    MsgBox("New worker added!", MsgBoxStyle.Information)

                    getReader.Close()

                    ' refresh id
                    incrementWorkerID()

                    ' clear textfields
                    clearAllTextFields()

                End If

                getReader.Close()

            End If

           


        End If



    End Sub

    ' clear inputted textfields
    Public Sub clearAllTextFields()

        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtLastname.Clear()
        txtPassword.Clear()
        txtAddress.Clear()
        cbGender.SelectedIndex = -1
        txtContactNo.Clear()
        cbDesignation.SelectedIndex = -1
        dtpBirthDate.Value = Date.Today.ToString("yyyy-MM-dd")

    End Sub


 
End Class