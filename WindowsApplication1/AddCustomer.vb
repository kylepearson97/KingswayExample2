Public Class AddCustomer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connstring As String = My.Settings.KingswayFitnessConnectionString1
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = My.Settings.KingswayFitnessConnectionString1
        conn.Open()
        Dim Sql As String
        Sql = ""
        cmd = New OleDb.OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class