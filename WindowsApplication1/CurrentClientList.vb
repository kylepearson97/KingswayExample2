Public Class CurrentClientList
    Private Sub formload(sender As Object, e As EventArgs) Handles Me.Load
        NumberofCustomers.Text = (CurrentClient.RowCount.ToString - 1)
        Me.MembersTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members)
    End Sub
    Private Sub formclose(sender As Object, e As EventArgs) Handles Me.Closing

        NumberofCustomers.Text = (CurrentClient.RowCount.ToString - 1)
        MainMenu.Show()
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If CurrentClient.RowCount.ToString - 1 < 45 Then

                Dim MemID = TextBox1.Text
                Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MemID)
                If rows.Length = 0 Or rows.Length > 1 Then
                    MsgBox("No File Found")
                Else
                    CurrentClient.Rows.Add(rows(0).Item("MemberID"), rows(0).Item("Forename"), rows(0).Item("Surname"), DateTime.Now.ToString("yyyy/MM/dd HH:mm"))
                End If
                NumberofCustomers.Text = (CurrentClient.RowCount.ToString - 1)
            Else
                MsgBox("Gym Full")
            End If

        End If


    End Sub

    Private Sub CurrentClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CurrentClient.CellContentClick

        Dim connstring As String = My.Settings.KingswayFitnessConnectionString1
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = My.Settings.KingswayFitnessConnectionString1
        conn.Open()
        Dim Sql As String
        Sql = "INSERT INTO [Member Activity Log](MemberID , [Time Logged out] , [Time Logged in])  VALUES('" & CurrentClient.CurrentRow.Cells.Item(0).Value & "','" & CurrentClient.CurrentRow.Cells.Item(3).Value & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm") & "')"
        cmd = New OleDb.OleDbCommand(Sql, conn)
        MsgBox(cmd.ExecuteNonQuery())
        conn.Close()
        MsgBox("User Logged Out")
        CurrentClient.Rows.Remove(CurrentClient.CurrentRow)
        NumberofCustomers.Text = (CurrentClient.RowCount.ToString - 1)
    End Sub
End Class