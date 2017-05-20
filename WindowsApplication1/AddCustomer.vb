Public Class AddCustomer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connstring As String = My.Settings.KingswayFitnessConnectionString1
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = My.Settings.KingswayFitnessConnectionString1
        conn.Open()
        Dim Sql1 As String
        Dim Sql2 As String
        Dim t = Title.SelectedItem
        Dim f = Firstname.Text
        Dim s = Surname.Text
        Dim h = MemHome.Text
        Dim m = MemMobile.Text
        Dim em = MemEmail.Text
        Dim dob = MemDOB.Text
        Sql1 = "INSERT INTO Members (Title, Forename, Surname, [House Phone], [Mobile Number], Email, DOB, Gender, [Membership Status], [Join Date], [Renewal Date], [Payment Method])
        VALUES('" & t & "','" & f & "','" & h & "','" & m & "','" & em & "','" & dob & "',')"
        Sql2 = "INSERT INTO Members Address Table (MemberID, [House Number], Road, Town, County, [Post Code]"
        cmd = New OleDb.OleDbCommand(Sql1, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KingswayFitnessDataSet1.Members)

    End Sub
End Class