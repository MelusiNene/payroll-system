Imports MySql.Data.MySqlClient

Public Class frmWorkerRecords

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private WorkerID As String = Nothing


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        showWorkerInfos()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        searchWorkerInfo()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        deleteWorkerInfo()

    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        updateWorkerInfo()

    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

        WorkerID = ListView1.SelectedItems(0).Text

    End Sub

    ' shows the worker information goes here
    Public Sub showWorkerInfos()

        ' shows the worker with designation
        getQuery = "SELECT worker.*, designation.designation_name FROM worker, designation WHERE worker.designation_id = designation.designation_id ORDER BY worker.worker_id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        ListView1.Items.Clear()

        While getReader.Read

            With ListView1.Items.Add(getReader.Item("worker_id").ToString)

                .SubItems.Add(getReader.Item("worker_fullname").ToString)
                .SubItems.Add(getReader.Item("worker_address").ToString)
                .SubItems.Add(Format(getReader.Item("worker_birthdate"), "MMM dd, yyyy"))
                .SubItems.Add(getReader.Item("worker_gender").ToString)
                .SubItems.Add(getReader.Item("contact_no").ToString)
                .SubItems.Add(Format(getReader.Item("date_hired"), "MMM dd, yyyy"))
                .SubItems.Add(getReader.Item("designation_name").ToString)

            End With

        End While

        getReader.Close()

        ' shows the worker without designation
        getQuery = "SELECT worker.* FROM worker WHERE worker.designation_id is null ORDER BY worker.worker_id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader


        While getReader.Read

            With ListView1.Items.Add(getReader.Item("worker_id").ToString)

                .SubItems.Add(getReader.Item("worker_fullname").ToString)
                .SubItems.Add(getReader.Item("worker_address").ToString)
                .SubItems.Add(Format(getReader.Item("worker_birthdate"), "MMM dd, yyyy"))
                .SubItems.Add(getReader.Item("worker_gender").ToString)
                .SubItems.Add(getReader.Item("contact_no").ToString)
                .SubItems.Add(Format(getReader.Item("date_hired"), "MMM dd, yyyy"))

            End With

        End While

        getReader.Close()



    End Sub


    ' searching the worker info goes here
    Public Sub searchWorkerInfo()

        If txtWorkerID.Text = "" Then

            MsgBox("Please enter worker id to be search", MsgBoxStyle.Information)
            txtWorkerID.Focus()

        Else

            ' search worker information with designation
            getQuery = "SELECT worker.*, designation.designation_name FROM worker, designation WHERE worker.designation_id = designation.designation_id AND worker.worker_id ='" & txtWorkerID.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            ListView1.Items.Clear()

            If getReader.Read = True Then

                With ListView1.Items.Add(getReader.Item("worker_id").ToString)

                    .SubItems.Add(getReader.Item("worker_fullname").ToString)
                    .SubItems.Add(getReader.Item("worker_address").ToString)
                    .SubItems.Add(Format(getReader.Item("worker_birthdate"), "MMM dd, yyyy"))
                    .SubItems.Add(getReader.Item("worker_gender").ToString)
                    .SubItems.Add(getReader.Item("contact_no").ToString)
                    .SubItems.Add(Format(getReader.Item("date_hired"), "MMM dd, yyyy"))
                    .SubItems.Add(getReader.Item("designation_name").ToString)

                End With


            ElseIf getReader.Read = False Then

                getReader.Close()

                ' search worker information without designation
                getQuery = "SELECT worker.* FROM worker WHERE worker.designation_id IS NULL AND worker.worker_id ='" & txtWorkerID.Text & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    With ListView1.Items.Add(getReader.Item("worker_id").ToString)

                        .SubItems.Add(getReader.Item("worker_fullname").ToString)
                        .SubItems.Add(getReader.Item("worker_address").ToString)
                        .SubItems.Add(Format(getReader.Item("worker_birthdate"), "MMM dd, yyyy"))
                        .SubItems.Add(getReader.Item("worker_gender").ToString)
                        .SubItems.Add(getReader.Item("contact_no").ToString)
                        .SubItems.Add(Format(getReader.Item("date_hired"), "MMM dd, yyyy"))

                    End With

                Else

                    ' worker id does not exists
                    MsgBox("Worker ID: " & txtWorkerID.Text & vbCrLf & "does not exist", MsgBoxStyle.Information)

                End If

                getReader.Close()

            End If

            getReader.Close()

        End If



    End Sub

    ' updating worker records goes here
    Public Sub updateWorkerInfo()

        If WorkerID = Nothing Then

            MsgBox("Please select a record to update", MsgBoxStyle.Information)

        Else

            If MsgBox(Space(18) & "Worker ID: " & WorkerID & vbCrLf & "Are you sure you want to update?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                frmWorkerModify.showDesignationNames()

                ' updating the worker if designation is not null
                getQuery = "SELECT worker.*, designation.designation_name FROM worker, designation WHERE worker.designation_id = designation.designation_id AND worker.worker_id ='" & WorkerID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    frmWorkerModify.lblWorkerID.Text = (getReader.Item("worker_id").ToString)
                    frmWorkerModify.txtFullname.Text = (getReader.Item("worker_fullname").ToString)
                    frmWorkerModify.txtAddress.Text = (getReader.Item("worker_address").ToString)
                    frmWorkerModify.dtpBirthDate.Text = (Format(getReader.Item("worker_birthdate"), "MMM dd, yyyy"))
                    frmWorkerModify.cbGender.Text = (getReader.Item("worker_gender").ToString)
                    frmWorkerModify.txtContactNo.Text = (getReader.Item("contact_no").ToString)
                    frmWorkerModify.dtpDateOfJoining.Text = (Format(getReader.Item("date_hired"), "MMM dd, yyyy"))
                    frmWorkerModify.cbDesignation.Text = (getReader.Item("designation_name").ToString)

                    frmWorkerModify.Show()

                End If

                getReader.Close()

                ' updating the worker if designation is null goes here
                getQuery = "SELECT worker.* FROM worker WHERE worker.designation_id IS NULL AND worker.worker_id ='" & WorkerID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    frmWorkerModify.lblWorkerID.Text = (getReader.Item("worker_id").ToString)
                    frmWorkerModify.txtFullname.Text = (getReader.Item("worker_fullname").ToString)
                    frmWorkerModify.txtAddress.Text = (getReader.Item("worker_address").ToString)
                    frmWorkerModify.dtpBirthDate.Text = (Format(getReader.Item("worker_birthdate"), "MMM dd, yyyy"))
                    frmWorkerModify.cbGender.Text = (getReader.Item("worker_gender").ToString)
                    frmWorkerModify.dtpDateOfJoining.Text = (Format(getReader.Item("date_hired"), "MMM dd, yyyy"))
                    frmWorkerModify.txtContactNo.Text = (getReader.Item("contact_no").ToString)

                    frmWorkerModify.Show()

                End If

                getReader.Close()

                WorkerID = Nothing

            End If

            WorkerID = Nothing

        End If

    End Sub

    ' deleting worker records goes here
    Public Sub deleteWorkerInfo()

        If WorkerID = Nothing Then

            MsgBox("Please select a record to remove", MsgBoxStyle.Information)

        Else

            If MsgBox(Space(18) & "Worker ID: " & WorkerID & vbCrLf & "Are you sure you want to remove?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                ' remove worker info
                getQuery = "DELETE FROM worker WHERE worker.worker_id ='" & WorkerID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                MsgBox("Succesfully deleted!", MsgBoxStyle.Information)

                getReader.Close()

                ' remove worker dtr info
                getQuery = "DELETE FROM dtr WHERE dtr.worker_id ='" & WorkerID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                WorkerID = Nothing


                ' refresh worker records
                showWorkerInfos()

            End If

            WorkerID = Nothing

        End If

    End Sub

  
  

End Class