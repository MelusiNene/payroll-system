Imports MySql.Data.MySqlClient

Public Class frmDesignationRecords

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader
    Private getDesignationID As Integer = 1
    Private selectDesignationID As String = Nothing

    Private Sub frmDesignationRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IncrementDesignationID()

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        newDesignation()

    End Sub


    Private Sub btnEditDesignation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDesignation.Click

        showEditDesignation()

    End Sub

    Private Sub btnDeleteDesignation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDesignation.Click

        deleteDesignation()

    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        searchDesignationInfo()

    End Sub

    Private Sub btnShowInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInformation.Click

        showDesignationInfos()

    End Sub



    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

        selectDesignationID = ListView1.SelectedItems(0).Text

    End Sub


    ' shows the designation info goes here
    Public Sub showDesignationInfos()

        getQuery = "SELECT designation.* FROM designation ORDER by designation.designation_id"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        ListView1.Items.Clear()

        While getReader.Read

            With ListView1.Items.Add(getReader.Item("designation_id").ToString)

                .SubItems.Add(getReader.Item("designation_name").ToString)
                .SubItems.Add(getReader.Item("designation_amount").ToString)

            End With

        End While

        getReader.Close()

    End Sub

    ' getting the designation infos goes here
    Public Sub searchDesignationInfo()

        If cbSearch.SelectedItem = "Designation ID" Then

            getQuery = "SELECT designation.* FROM designation WHERE designation.designation_id ='" & txtSearch.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            ListView1.Items.Clear()

            While getReader.Read

                With ListView1.Items.Add(getReader.Item("designation_id").ToString)

                    .SubItems.Add(getReader.Item("designation_name").ToString)
                    .SubItems.Add(getReader.Item("designation_amount").ToString)

                End With

            End While

            getReader.Close()

            ' search ang designation name idisplay sa listview
        ElseIf cbSearch.SelectedItem = "Designation Name" Then

            getQuery = "SELECT designation.* FROM designation WHERE designation.designation_name ='" & txtSearch.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            ListView1.Items.Clear()

            While getReader.Read

                With ListView1.Items.Add(getReader.Item("designation_id").ToString)

                    .SubItems.Add(getReader.Item("designation_name").ToString)
                    .SubItems.Add(getReader.Item("designation_amount").ToString)

                End With

            End While

            getReader.Close()

            ' search ang designation amount
        ElseIf cbSearch.SelectedItem = "Designation Amount" Then

            getQuery = "SELECT designation.* FROM designation WHERE designation.designation_amount ='" & txtSearch.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            ListView1.Items.Clear()

            While getReader.Read

                With ListView1.Items.Add(getReader.Item("designation_id").ToString)

                    .SubItems.Add(getReader.Item("designation_name").ToString)
                    .SubItems.Add(getReader.Item("designation_amount").ToString)

                End With

            End While

            getReader.Close()

        End If

    End Sub


    ' increment the designation id goes here
    Public Sub IncrementDesignationID()

        ' increment ang designation id
        getQuery = "SELECT designation.designation_id FROM designation ORDER BY designation_id DESC LIMIT 1"
        getCommand = New MySqlCommand(getQuery, MySQLConnection)
        getReader = getCommand.ExecuteReader

        While getReader.Read

            getDesignationID = (getReader.Item("designation_id").ToString) + 1

        End While


        getReader.Close()

    End Sub

    ' select the designation info to edit
    Public Sub showEditDesignation()

        If selectDesignationID = Nothing Then

            MsgBox("Please select a record to edit!", MsgBoxStyle.Information)

        Else

            If MsgBox(Space(10) & "Designation ID: " & selectDesignationID & vbCrLf & "Are you sure you want to modify?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                ' idisplay ang designation info sa form na m edit
                getQuery = "SELECT designation.* FROM designation WHERE designation.designation_id ='" & selectDesignationID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                If getReader.Read = True Then

                    frmEditDesignation.lblDesignationID.Text = (getReader.Item("designation_id").ToString)
                    frmEditDesignation.txtDesignationName.Text = (getReader.Item("designation_name").ToString)
                    frmEditDesignation.txtAmount.Text = (getReader.Item("designation_amount").ToString)

                    frmEditDesignation.Show()

                    selectDesignationID = Nothing

                End If

                getReader.Close()

                selectDesignationID = Nothing

            End If

        End If

    End Sub


    ' delete the designation
    Public Sub deleteDesignation()

        If selectDesignationID = Nothing Then

            MsgBox("Please select a record to remove", MsgBoxStyle.Information)

        Else

            If MsgBox(Space(10) & "Designation ID: " & selectDesignationID & vbCrLf & "Are you sure you want to remove?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                ' i remove ang designation
                getQuery = "DELETE FROM designation WHERE designation.designation_id ='" & selectDesignationID & "'"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                MsgBox("Successfully deleted!", MsgBoxStyle.Information)

                ' refresh ang info sa listview
                showDesignationInfos()

                selectDesignationID = Nothing

            End If

            End If


    End Sub


    ' adding a designation info
    Public Sub newDesignation()

        If txtDesignationName.Text = "" Then

            MsgBox("Please enter designation name", MsgBoxStyle.Information)
            txtDesignationName.Focus()

        ElseIf txtAmount.Text = "" Then

            MsgBox("Please enter amount", MsgBoxStyle.Information)
            txtAmount.Focus()

        Else

            ' detect if the designation name exist

            getQuery = "SELECT designation.designation_name FROM designation WHERE designation.designation_name ='" & txtDesignationName.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            If getReader.Read = True Then

                MsgBox("Designation name: " & txtDesignationName.Text & vbCrLf & Space(10) & "Already exist!", MsgBoxStyle.Information)
                txtDesignationName.Focus()

            Else

                getReader.Close()

                ' pag pa dugang ug bag o na position
                getQuery = "INSERT INTO designation VALUES('" & getDesignationID & "','" & txtDesignationName.Text & "','" & txtAmount.Text & "')"
                getCommand = New MySqlCommand(getQuery, MySQLConnection)
                getReader = getCommand.ExecuteReader

                getReader.Close()

                MsgBox("New designation added!", MsgBoxStyle.Information)

                ' refresh ang designation id 
                IncrementDesignationID()

                ' refresh ang info sa listview
                showDesignationInfos()

                ' refresh textfields
                clearTextFields()

            End If


            getReader.Close()


                End If



    End Sub


    ' clear textfields
    Public Sub clearTextFields()

        txtDesignationName.Clear()
        txtAmount.Clear()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub
End Class