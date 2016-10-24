Public Class frmHome

    Private Sub btnWPMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWPMS.Click

        frmMainMenu.Show()
        frmAbout.Hide()
        frmAppManager.Hide()
        frmAccountSettings.Hide()
        frmLogHistory.Hide()
        Me.Hide()

    End Sub


    Private Sub btnEditMySettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditMySettings.Click

        frmAccountSettings.grpStaffInfo.Visible = False
        frmAccountSettings.Show()
        frmAbout.Hide()
        frmAppManager.Hide()
        frmLogHistory.Hide()

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            frmLogin.Show()
            Me.Hide()
            frmAbout.Hide()
            frmAccountSettings.Hide()
            frmAppManager.Hide()
            frmLogHistory.Hide()

        End If

    End Sub

 
    Private Sub btnLogHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogHistory.Click

        frmLogHistory.showLogHistory()
        frmLogHistory.Show()
        frmAbout.Hide()
        frmAccountSettings.Hide()
        frmAppManager.Hide()

    End Sub

    Private Sub btnApplicationManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplicationManager.Click

        frmAppManager.clearTextFields()
        frmAppManager.Width = 424
        frmAppManager.Show()
        frmAbout.Hide()
        frmAccountSettings.Hide()
        frmLogHistory.Hide()

    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click

        frmAbout.Show()
        frmAccountSettings.Hide()
        frmLogHistory.Hide()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtAnnotate.Clear()

    End Sub

   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        MsgBox("Message saved!", MsgBoxStyle.Information)
        ' save annotatation
        My.Settings.Annotations = txtAnnotate.Text
        My.Settings.Save()

    End Sub
End Class