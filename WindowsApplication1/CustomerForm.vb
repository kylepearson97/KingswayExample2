Public Class CustomerForm
    Private Sub Forename_Click(sender As Object, e As EventArgs) Handles Forename.Click

    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members)
        Me.Members_Address_TableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members_Address_Table)

    End Sub
    Private Sub formclose(sender As Object, e As EventArgs) Handles Me.FormClosed

        MainMenu.Show()

    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()


    End Sub

    Private Sub MembersID_TextChanged(sender As Object, e As EventArgs) Handles MembersID.TextChanged
        Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MembersID.Text)
        Dim rows2() As DataRow = KingswayFitnessDataSet1.Members_Address_Table.Select("MemberID =" + MembersID.Text)

        Firstname.Text = rows(0).Item("Forename")
        Lastname.Text = rows(0).Item("Surname")
        Address1.Text = rows2(0).Item("House Number/Name")
        Address2.Text = rows2(0).Item("Road")
        Address3.Text = rows2(0).Item("Town")
        Address4.Text = rows2(0).Item("County")
        Address5.Text = rows2(0).Item("Post Code")
        MemGender.Text = rows(0).Item("Gender")
        MemDOB.Text = rows(0).Item("DOB")
        MemMobile.Text = rows(0).Item("Mobile Number")
        MemHome.Text = rows(0).Item("House Phone Number")
        'jiggery to make it show true/false for status, maybe an if statement to change to Active/ Non active?
        Dim MemStatus1 As Boolean = rows(0).Item("Membership Status")
        MemStatus.Text = Convert.ToString(MemStatus1)
        MemEmail.Text = rows(0).Item("Email")
        MemRenewal.Text = rows(0).Item("Renewal Date")
        MemDateJoin.Text = rows(0).Item("Join Date")
        MemType.Text = rows(0).Item("Payment Method")


    End Sub

    Private Sub ActivityLogBut_Click(sender As Object, e As EventArgs)
        Dim oForm As New ActivityLogForm
        ActivityLogForm.Show()
    End Sub
End Class