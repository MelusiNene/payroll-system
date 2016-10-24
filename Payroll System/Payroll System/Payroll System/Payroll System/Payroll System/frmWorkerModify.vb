Imports MySql.Data.MySqlClient

Public Class frmWorkerModify

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getDesignationID As String = Nothing


    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        modifyWorkerInfo()

    End Sub



    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Hide()

        End If

    End Sub

    ' shows designation names goes here
    Public Sub showDesignationNames()

        getQuery = "SELECT designation.designation_name FROM designation"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        cbDesignation.Items.Clear()

        While getReader.Read

            cbDesignation.Items.Add(getReader.Item("designation_name").ToString)

        End While

        getReader.Close()

    End Sub

    ' updating the worker record goes here
    Public Sub modifyWorkerInfo()

        If txtFullname.Text = "" Then

            MsgBox("Please enter your fullname", MsgBoxStyle.Information)
            txtFullname.Focus()

        ElseIf txtAddress.Text = "" Then

            MsgBox("Please enter your address", MsgBoxStyle.Information)
            txtAddress.Focus()

        ElseIf cbDesignation.SelectedIndex = -1 Then

            MsgBox("Please select designation", MsgBoxStyle.Information)
            cbDesignation.Focus()

        Else

            ' get the designation id goes here
            getQuery = "SELECT designation.designation_id FROM designation WHERE designation.designation_name ='" & cbDesignation.SelectedItem & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            If getReader.Read = True Then

                getDesignationID = (getReader.Item("designation_id").ToString)

                getReader.Close()

                If MsgBox("Are you sure you want to modify", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    ' modify worker record goes here
                    getQuery = "UPDATE worker SET worker.worker_fullname ='" & txtFullname.Text & "', worker.worker_address ='" & txtAddress.Text & _
                  "', worker.worker_birthdate ='" & dtpBirthDate.Value.ToString("yyyy-MM-dd") & "', worker.worker_gender ='" & cbGender.SelectedItem & "', worker.date_hired ='" & dtpDateOfJoining.Value.ToString("yyyy-MM-dd") & "', worker.contact_no ='" & txtContactNo.Text & _
                  "', worker.designation_id ='" & getDesignationID & "' WHERE worker.worker_id ='" & lblWorkerID.Text & "'"
                    getCommand = New MySqlCommand(getQuery, MySQLConnection)
                    getReader = getCommand.ExecuteReader

                    MsgBox("Updated successfully!", MsgBoxStyle.Information)

                    getReader.Close()

                    ' refresh records
                    frmWorkerRecords.showWorkerInfos()

                End If

            End If

            getReader.Close()


        End If

    End Sub



End Class