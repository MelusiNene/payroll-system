Imports MySql.Data.MySqlClient

Public Class frmEditDesignation

    ' declaring variables
    Private getQuery As String = Nothing
    Private getCommand As MySqlCommand
    Private getReader As MySqlDataReader

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            frmDesignationRecords.Show()
            Me.Hide()

        End If

    End Sub


    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        modifyDesignationInfo()

    End Sub



    ' modifying the designation goes here
    Public Sub modifyDesignationInfo()

        If MsgBox(Space(10) & "Designation ID: " & lblDesignationID.Text & vbCrLf & "Are you sure you want to modify?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            ' update the designation
            getQuery = "UPDATE designation SET designation.designation_name ='" & txtDesignationName.Text & _
              "', designation.designation_amount ='" & txtAmount.Text & "' WHERE designation.designation_id ='" & lblDesignationID.Text & "'"
            getCommand = New MySqlCommand(getQuery, MySQLConnection)
            getReader = getCommand.ExecuteReader

            MsgBox("Successfully updated!", MsgBoxStyle.Information)

            getReader.Close()

            frmDesignationRecords.showDesignationInfos()

        End If

    End Sub



End Class