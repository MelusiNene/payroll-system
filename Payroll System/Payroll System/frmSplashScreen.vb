Public Class frmSplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        ' splash screen using progressbar to load a form goes here
        If ProgressBar1.Value <> ProgressBar1.Maximum Then

            ProgressBar1.Value = ProgressBar1.Value + 100

        Else

            Timer1.Stop()
            frmAttendance.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' getting the connection goes here
        getMySQLConnection()

        ' deleting the log history if the records exceed to 50
        frmLogHistory.removeLogHistory()

    End Sub



End Class
