Public Class Reports
    Private Sub OldCustomer_MouseHover(sender As Object, e As EventArgs) Handles OldCustomer.MouseHover
        OldCustomer.Image = My.Resources.OldCustClick
    End Sub

    Private Sub OldCustomer_MouseLeave(sender As Object, e As EventArgs) Handles OldCustomer.MouseLeave
        OldCustomer.Image = My.Resources.OldCustNoClick
    End Sub

    Private Sub OldCustomer_Click(sender As Object, e As EventArgs) Handles OldCustomer.Click
        Dim oForm As New OldCustomer
        oForm.Show()
    End Sub

    Private Sub TodayAct_Click(sender As Object, e As EventArgs) Handles TodayAct.Click
        Dim oForm As New TodayActivity
        oForm.Show()
    End Sub

    Private Sub TodayAct_MouseHover(sender As Object, e As EventArgs) Handles TodayAct.MouseHover
        TodayAct.Image = My.Resources.TodayClick
    End Sub

    Private Sub TodayAct_MouseLeave(sender As Object, e As EventArgs) Handles TodayAct.MouseLeave
        TodayAct.Image = My.Resources.TodayNoClick
    End Sub
End Class
