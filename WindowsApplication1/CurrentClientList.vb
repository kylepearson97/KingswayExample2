Public Class CurrentClientList
    Private Sub formload(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Activity_Log' table. You can move, or remove it, as needed.
        Me.Activity_LogTableAdapter.Fill(Me.KingswayFitnessDataSet1.Activity_Log)
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Member_Activity_Log' table. You can move, or remove it, as needed.
        Me.Member_Activity_LogTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Member_Activity_Log)
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Staff)
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
        If NumberofCustomers.Text = 0 Then
        Else
            NumberofCustomers.Text = NumberofCustomers.Text - 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim table As Hashtable = New Hashtable

        CurrentClient.Rows.Add("1", "Sam")

    End Sub

End Class