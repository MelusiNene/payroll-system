Imports MySql.Data.MySqlClient

Public Class frmPaySlip

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Hide()

    End Sub

 
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        ' print the page goes here
        If MsgBox("Are you sure you want to print this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            PrintDialog1.Document = PrintDocument1

            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                PrintDocument1.Print()

            End If

        End If

    End Sub

    Private Sub frmPaySlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblYearPeriod.Text = Format(Date.Today, "yyyy")

    End Sub
End Class