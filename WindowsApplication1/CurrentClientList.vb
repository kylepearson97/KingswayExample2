Public Class CurrentClientList
    Private Sub formload(sender As Object, e As EventArgs) Handles Me.Load
        NumberofCustomers.Text = (CurrentClient.RowCount.ToString - 1)
        Me.MembersTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members)
    End Sub
    Private Sub NumberofCustomers_Click(sender As Object, e As EventArgs) Handles NumberofCustomers.Click
        NumberofCustomers.Text = NumberofCustomers.Text + +1
    End Sub
    Private Sub formclose(sender As Object, e As EventArgs) Handles Me.Closing

        My.Settings.NumberofCustomers = Me.NumberofCustomers.Text
        MainMenu.Show()
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Dim MemID = TextBox1.Text
            Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MemID)
            If rows.Length = 0 Or rows.Length > 1 Then
                MsgBox("No File Found")
            Else
                CurrentClient.Rows.Add(rows(0).Item("MemberID"), rows(0).Item("Forename"), rows(0).Item("Surname"), DateTime.Now.ToString("yyyy/MM/dd HH:mm"))
            End If
            NumberofCustomers.Text = (CurrentClient.RowCount.ToString - 1)
        End If

    End Sub

End Class