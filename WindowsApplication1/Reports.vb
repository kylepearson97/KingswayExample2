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
End Class
