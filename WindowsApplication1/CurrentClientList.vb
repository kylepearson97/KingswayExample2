Public Class CurrentClientList
    Private Sub formload(sender As Object, e As EventArgs) Handles Me.Load
        NumberofCustomers.Text = My.Settings.NumberofCustomers
    End Sub
    Private Sub NumberofCustomers_Click(sender As Object, e As EventArgs) Handles NumberofCustomers.Click
        NumberofCustomers.Text = NumberofCustomers.Text + +1
    End Sub
    Private Sub formclose(sender As Object, e As EventArgs) Handles Me.Closing

        My.Settings.NumberofCustomers = Me.NumberofCustomers.Text
        MainMenu.Show()
    End Sub

    Private Sub LogoutBut_Click(sender As Object, e As EventArgs) Handles LogoutBut.Click
        NumberofCustomers.Text = NumberofCustomers.Text - 1
    End Sub
End Class