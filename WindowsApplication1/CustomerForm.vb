Public Class CustomerForm
    Private Sub Forename_Click(sender As Object, e As EventArgs) Handles Forename.Click

    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1' tables. You can move, or remove them, as needed.
        Me.Member_Activity_LogTableAdapter.Fill(Me.KingswayFitnessDataSet1.Member_Activity_Log)
        Me.Members_ReasonsTableAdapter.Fill(Me.KingswayFitnessDataSet1.Members_Reasons)
        Me.InductionsTableAdapter.Fill(Me.KingswayFitnessDataSet1.Inductions)
        Me.Medical_TableTableAdapter.Fill(Me.KingswayFitnessDataSet1.Medical_Table)
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

    Private Sub ActivityLogBut_Click(sender As Object, e As EventArgs)
        Dim oForm As New ActivityLogForm
        ActivityLogForm.Show()
    End Sub

    Private Sub LoadBut_Click(sender As Object, e As EventArgs) Handles LoadBut.Click
        Try
            Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MembersID.Text)
            Dim rows2() As DataRow = KingswayFitnessDataSet1.Members_Address_Table.Select("MemberID =" + MembersID.Text)
            Dim rows3() As DataRow = KingswayFitnessDataSet1.Medical_Table.Select("MemberID =" + MembersID.Text)
            Dim rows4() As DataRow = KingswayFitnessDataSet1.Members_Reasons.Select("MemberID =" + MembersID.Text)
            Dim rows5() As DataRow = KingswayFitnessDataSet1.Inductions.Select("MemberID =" + MembersID.Text)
            Dim rows6() As DataRow = KingswayFitnessDataSet1.Activity_Log.Select("MemberID =" + MembersID.Text)

            If rows.Count = 0 Then
                MsgBox("No File Found")
            Else
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
                'Medical Table
                HeartCB.Checked = rows3(0).Item("Heart Condition")
                FaintCB.Checked = rows3(0).Item("Faint/Dizziness")
                ChestCB.Checked = rows3(0).Item("Chest Pain")
                BloodPCB.Checked = rows3(0).Item("High/Low Blood Pressure")
                EpiCB.Checked = rows3(0).Item("Epilepsy")
                JointCB.Checked = rows3(0).Item("Joint Problems")
                BackCB.Checked = rows3(0).Item("Back Problems")
                DiaCB.Checked = rows3(0).Item("Diabetes")
                AstCB.Checked = rows3(0).Item("Astma")
                SmokeCB.Checked = rows3(0).Item("Smoker")
                PregCB.Checked = rows3(0).Item("Pregnant")
                OperCB.Checked = rows3(0).Item("Recent Operation")
                OtherDescGM.Text = rows3(0).Item("Other")
                '^^^^ if nothing in database then the try catches the error but pops up with the msgbox, this needs to be addressed!!!
                DocReqCB.Checked = rows3(0).Item("Doctors Note Required")
                DocPreCB.Checked = rows3(0).Item("Doctors Note Present")
                'Induction
                BodyBCB.Checked = rows4(0).Item("Body Builder")
                WeightRCB.Checked = rows4(0).Item("Weight Reduction")
                FitterCB.Checked = rows4(0).Item("Get Fitter")
                InjuryACB.Checked = rows4(0).Item("Injury Avoidance")
                OtherDescGFA.Text = rows4(0).Item("Other")
                '^^^^ if nothing in database then the try catches the error but pops up with the msgbox, this needs to be addressed!!!
                InductCB.Checked = rows5(0).Item("Inducted")
                InducterName.Text = rows5(0).Item("Inducted By")
                'Activity Log
                If rows.Length = 0 Or rows.Length > 1 Then
                    MsgBox("No Activity Log Found")
                Else
                    ActivityLog.Rows.Add(rows6(0).Item("Time Logged In"), rows6(0).Item("Time Logged Out"))

                End If
                '^^^ Had a stab at this
            End If
        Catch ex As SystemException
            MsgBox("Membership Id Needed")



        End Try


    End Sub
End Class