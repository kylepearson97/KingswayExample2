Public Class CustomerForm


    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Name_Query' table. You can move, or remove it, as needed.
        Me.Name_QueryTableAdapter.Fill(Me.KingswayFitnessDataSet1.Name_Query)
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1' tables. You can move, or remove them, as needed.
        Me.Member_Activity_LogTableAdapter.Fill(Me.KingswayFitnessDataSet1.Member_Activity_Log)
        Me.Members_ReasonsTableAdapter.Fill(Me.KingswayFitnessDataSet1.Members_Reasons)
        Me.InductionsTableAdapter.Fill(Me.KingswayFitnessDataSet1.Inductions)
        Me.Medical_TableTableAdapter.Fill(Me.KingswayFitnessDataSet1.Medical_Table)
        Me.MembersTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members)
        Me.Members_Address_TableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members_Address_Table)
        Me.StaffTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Staff)

    End Sub
    Private Sub formclose(sender As Object, e As EventArgs) Handles Me.FormClosed

        MainMenu.Show()

    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()


    End Sub

    Private Sub LoadBut_Click(sender As Object, e As EventArgs) Handles LoadBut.Click
        Try
            Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MembersID.Text)
            Dim rows2() As DataRow = KingswayFitnessDataSet1.Members_Address_Table.Select("MemberID =" + MembersID.Text)
            Dim rows3() As DataRow = KingswayFitnessDataSet1.Medical_Table.Select("MemberID =" + MembersID.Text)
            Dim rows4() As DataRow = KingswayFitnessDataSet1.Members_Reasons.Select("MemberID =" + MembersID.Text)
            Dim rows5() As DataRow = KingswayFitnessDataSet1.Inductions.Select("MemberID =" + MembersID.Text)
            Dim rows6() As DataRow = KingswayFitnessDataSet1.Member_Activity_Log.Select("MemberID =" + MembersID.Text)
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
                If MemStatus1 = True Then
                    MemStatus.Text = "Active"
                Else
                    MemStatus.Text = "Non-Active"
                End If

                MemEmail.Text = rows(0).Item("Email")
                MemRenewal.Text = rows(0).Item("Renewal Date")
                MemDateJoin.Text = rows(0).Item("Join Date")
                MemType.Text = rows(0).Item("Payment Method")
                'Medical Table
                If rows3.Length = 1 Then
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
                    If rows3(0).IsNull("Other") = True Then
                        OtherDescGM.Text = ""
                    Else
                        OtherDescGM.Text = rows3(0).Item("Other")

                    End If
                    DocReqCB.Checked = rows3(0).Item("Doctors Note Required")
                    DocPreCB.Checked = rows3(0).Item("Doctors Note Present")
                Else
                End If
                If rows4.Length = 1 Then

                    'Induction
                    BodyBCB.Checked = rows4(0).Item("Body Builder")
                    WeightRCB.Checked = rows4(0).Item("Weight Reduction")
                    FitterCB.Checked = rows4(0).Item("Get Fitter")
                    InjuryACB.Checked = rows4(0).Item("Injury Avoidance")
                    If rows4(0).IsNull("Other") = True Then
                        OtherDescGFA.Text = ""
                    Else
                        OtherDescGFA.Text = rows4(0).Item("Other")
                    End If
                    InductCB.Checked = rows5(0).Item("Inducted")
                    If rows5(0).IsNull("Inducted By ID") = True Then
                        InductName.Text = ""
                    Else
                        Dim rows7() As DataRow = KingswayFitnessDataSet1.Staff.Select("[Staff-ID] =" + rows5(0).Item("Inducted By ID").ToString)
                        InductName.Text = rows7(0).Item("Staff Name")
                    End If
                End If
                'Activity Log
                If rows6.Length = 0 Then

                    ActivityLog.Rows.Clear()

                Else
                    Dim i = 0
                    For Each rw In rows6

                        ActivityLog.Rows.Add(rows6(i).Item("Time Logged In"), rows6(i).Item("Time Logged Out"))
                        i = i + 1
                    Next rw


                End If
                '^^^ Had a stab at this
            End If


        Catch ex As SyntaxErrorException
            MsgBox("Please enter a members id ")
        End Try





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MembersID.Text)
            Dim rows2() As DataRow = KingswayFitnessDataSet1.Members_Address_Table.Select("MemberID =" + MembersID.Text)
            Dim rows3() As DataRow = KingswayFitnessDataSet1.Medical_Table.Select("MemberID =" + MembersID.Text)
            Dim rows4() As DataRow = KingswayFitnessDataSet1.Members_Reasons.Select("MemberID =" + MembersID.Text)
            Dim rows5() As DataRow = KingswayFitnessDataSet1.Inductions.Select("MemberID =" + MembersID.Text)
            Dim rows6() As DataRow = KingswayFitnessDataSet1.Member_Activity_Log.Select("MemberID =" + MembersID.Text)
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
                If MemStatus1 = True Then
                    MemStatus.Text = "Active"
                Else
                    MemStatus.Text = "Non-Active"
                End If

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
                If rows3(0).IsNull("Other") = True Then
                    OtherDescGM.Text = ""
                Else
                    OtherDescGM.Text = rows3(0).Item("Other")
                End If
                DocReqCB.Checked = rows3(0).Item("Doctors Note Required")
                DocPreCB.Checked = rows3(0).Item("Doctors Note Present")
                'Induction
                BodyBCB.Checked = rows4(0).Item("Body Builder")
                WeightRCB.Checked = rows4(0).Item("Weight Reduction")
                FitterCB.Checked = rows4(0).Item("Get Fitter")
                InjuryACB.Checked = rows4(0).Item("Injury Avoidance")
                If rows4(0).IsNull("Other") = True Then
                    OtherDescGFA.Text = ""
                Else
                    OtherDescGFA.Text = rows4(0).Item("Other")
                End If
                InductCB.Checked = rows5(0).Item("Inducted")
                If rows5(0).IsNull("Inducted By ID") = True Then
                    InductName.Text = ""
                Else
                    Dim rows7() As DataRow = KingswayFitnessDataSet1.Staff.Select("[Staff-ID] =" + rows5(0).Item("Inducted By ID").ToString)
                    InductName.Text = rows7(0).Item("Staff Name")
                End If

                'Activity Log
                If rows6.Length = 0 Then

                    ActivityLog.Rows.Clear()

                Else
                    Dim i = 0
                    For Each rw In rows6

                        ActivityLog.Rows.Add(rows6(i).Item("Time Logged In"), rows6(i).Item("Time Logged Out"))
                        i = i + 1
                    Next rw


                End If
                '^^^ Had a stab at this
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchBox.SelectedIndexChanged
        Try
            MembersID.Text = SearchBox.SelectedValue
            Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MembersID.Text)
            Dim rows2() As DataRow = KingswayFitnessDataSet1.Members_Address_Table.Select("MemberID =" + MembersID.Text)
            Dim rows3() As DataRow = KingswayFitnessDataSet1.Medical_Table.Select("MemberID =" + MembersID.Text)
            Dim rows4() As DataRow = KingswayFitnessDataSet1.Members_Reasons.Select("MemberID =" + MembersID.Text)
            Dim rows5() As DataRow = KingswayFitnessDataSet1.Inductions.Select("MemberID =" + MembersID.Text)
            Dim rows6() As DataRow = KingswayFitnessDataSet1.Member_Activity_Log.Select("MemberID =" + MembersID.Text)
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
                If MemStatus1 = True Then
                    MemStatus.Text = "Active"
                Else
                    MemStatus.Text = "Non-Active"
                End If

                MemEmail.Text = rows(0).Item("Email")
                MemRenewal.Text = rows(0).Item("Renewal Date")
                MemDateJoin.Text = rows(0).Item("Join Date")
                MemType.Text = rows(0).Item("Payment Method")
                'Medical Table
                If rows3.Length = 1 Then
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
                    If rows3(0).IsNull("Other") = True Then
                        OtherDescGM.Text = ""
                    Else
                        OtherDescGM.Text = rows3(0).Item("Other")

                    End If
                    DocReqCB.Checked = rows3(0).Item("Doctors Note Required")
                    DocPreCB.Checked = rows3(0).Item("Doctors Note Present")
                Else
                End If
                If rows4.Length = 1 Then

                    'Induction
                    BodyBCB.Checked = rows4(0).Item("Body Builder")
                    WeightRCB.Checked = rows4(0).Item("Weight Reduction")
                    FitterCB.Checked = rows4(0).Item("Get Fitter")
                    InjuryACB.Checked = rows4(0).Item("Injury Avoidance")
                    If rows4(0).IsNull("Other") = True Then
                        OtherDescGFA.Text = ""
                    Else
                        OtherDescGFA.Text = rows4(0).Item("Other")
                    End If
                    InductCB.Checked = rows5(0).Item("Inducted")
                    If rows5(0).IsNull("Inducted By ID") = True Then
                        InductName.Text = ""
                    Else
                        Dim rows7() As DataRow = KingswayFitnessDataSet1.Staff.Select("[Staff-ID] =" + rows5(0).Item("Inducted By ID").ToString)
                        InductName.Text = rows7(0).Item("Staff Name")
                    End If
                End If
                'Activity Log
                If rows6.Length = 0 Then

                    ActivityLog.Rows.Clear()

                Else
                    Dim i = 0
                    For Each rw In rows6

                        ActivityLog.Rows.Add(rows6(i).Item("Time Logged In"), rows6(i).Item("Time Logged Out"))
                        i = i + 1
                    Next rw


                End If
                '^^^ Had a stab at this
            End If
        Catch
        End Try
    End Sub


End Class