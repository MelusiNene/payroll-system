Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUserPC.Text = "Worker Payroll System is running on " & Environment.UserName & "-PC"

    End Sub
End Class