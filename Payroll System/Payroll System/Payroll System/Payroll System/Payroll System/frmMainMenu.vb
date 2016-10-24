Public Class frmMainMenu

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmHome.Show()
        Me.Hide()

    End Sub


    Private Sub btnAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendance.Click

        ' refresh dtr
        frmAttendance.showAttendance()

        frmAttendance.getFrmMainMenu = "You cannot open"

        ' refresh id
        frmAttendance.showWorkerFullnames()

        'refresh fields
        frmAttendance.refreshFields()

        frmAttendance.Show()

        frmWorkerRecords.Hide()

        frmPayrollReport.Hide()

    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorker.Click

        ' clear fields
        frmWorkerRegistration.clearAllTextFields()

        ' refresh increment id
        frmWorkerRegistration.incrementWorkerID()

        ' refresh designation name
        frmWorkerRegistration.getDesignationNames()
        frmWorkerRegistration.Show()
        Me.Hide()
        frmPayrollReport.Hide()
        frmWorkerRecords.Hide()

    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        frmHome.Show()
        frmPayrollReport.Hide()
        Me.Close()
        frmWorkerRecords.Hide()

    End Sub


    Private Sub btnRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecords.Click

        frmWorkerRecords.Show()
        frmPayrollReport.Hide()

    End Sub

    Private Sub btnDesignation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesignation.Click

        frmDesignationRecords.clearTextFields()
        frmDesignationRecords.Show()
        frmDesignationRecords.ListView1.Items.Clear()
        Me.Hide()
        frmPayrollReport.Hide()
        frmWorkerRecords.Hide()

    End Sub

    Private Sub btnPayrollSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayrollSystem.Click

        frmWorkerPayroll.lblDate.Text = Format(Date.Today, "MMM dd, yyyy")
        frmWorkerPayroll.clearTextFields()
        frmWorkerPayroll.Show()
        Me.Hide()

        frmPayrollReport.Hide()

        frmWorkerRecords.Hide()

    End Sub

    Private Sub btnPayrollSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayrollSlip.Click

        frmWorkerPaySlip.cbSearch.SelectedIndex = -1
        frmWorkerPaySlip.txtSearch.Text = ""
        frmWorkerPaySlip.Show()
        Me.Hide()
        frmPayrollReport.Hide()
        frmWorkerRecords.Hide()

    End Sub

    Private Sub btnPayrollReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayrollReports.Click

        frmPayrollReport.workerTotalRecords()
        frmPayrollReport.showWorkerReports()
        frmPayrollReport.Show()
        frmWorkerRecords.Hide()

    End Sub
End Class