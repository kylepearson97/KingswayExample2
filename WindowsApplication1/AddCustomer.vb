Public Class AddCustomer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connstring As String = My.Settings.KingswayFitnessConnectionString1
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = My.Settings.KingswayFitnessConnectionString1
        conn.Open()
        Dim Sql1 As String
        Dim Sql2 As String
        'Member
        Dim t = Title.SelectedItem
        Dim f = Firstname.Text
        Dim s = Lastname.Text
        Dim h = MemHome.Text
        Dim m = MemMobile.Text
        Dim em = MemEmail.Text
        Dim dob = MemDOB.Value.ToShortDateString
        Dim g = MemGender.SelectedItem
        Dim stat = MemStatus.SelectedItem
        If stat = "Active" Then
            stat = True
        Else
            stat = False
        End If
        Dim join = MemDateJoin.Value.Date
        Dim ren = MemRenewal.Value.Date
        Dim pay = MemType.Text
        'Address
        Dim hn = Address1.Text
        Dim r = Address2.Text
        Dim town = Address3.Text
        Dim c = Address4.Text
        Dim pc = Address5.Text
        Sql1 = "INSERT INTO Members (Title, Forename, Surname, [House Phone Number], [Mobile Number], Email, DOB, Gender, [Membership Status], [Join Date], [Renewal Date], [Payment Method])
        VALUES('" & t & "','" & f & "','" & s & "','" & h & "','" & m & "','" & em & "',#" & dob & "#,'" & g & "'," & stat & ",#" & join & "#,#" & ren & "#,'" & pay & "')"
        cmd = New OleDb.OleDbCommand(Sql1, conn)
        cmd.ExecuteNonQuery()
        Me.MembersTableAdapter.Fill(Me.KingswayFitnessDataSet1.Members)
        Dim memid = Me.KingswayFitnessDataSet1.Members.Last.MemberID + 1


        Sql2 = "INSERT INTO [Members Address Table] (MemberID, [House Number/Name], Road, Town, County, [Post Code]) 
        VALUES(" & memid & ",'" & hn & "','" & r & "','" & town & "','" & c & "','" & pc & "')"
        cmd = New OleDb.OleDbCommand(Sql2, conn)
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("User Added")
        End If
        conn.Close()
    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KingswayFitnessDataSet1.Members)

    End Sub


End Class