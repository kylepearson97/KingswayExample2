﻿Public Class CustomerForm
    Private Sub Forename_Click(sender As Object, e As EventArgs) Handles Forename.Click

    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.KingswayFitnessDataSet1.Members)

    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KingswayFitnessDataSet)

    End Sub

    Private Sub MembersID_TextChanged(sender As Object, e As EventArgs) Handles MembersID.TextChanged
        Dim rows() As DataRow = KingswayFitnessDataSet1.Members.Select("MemberID =" + MembersID.Text)
        Dim rows2() As DataRow = KingswayFitnessDataSet1.Members_Address_Table.Select("MemberID =" + MembersID.Text)
        'rows 2 not working at min'
        Firstname.Text = rows(0).Item("Forename")
        Lastname.Text = rows(0).Item("Surname")



    End Sub

    Private Sub Address1_TextChanged(sender As Object, e As EventArgs) Handles Address1.TextChanged

    End Sub
End Class