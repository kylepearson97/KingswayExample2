Public Class CustomerForm
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
        Dim setRow As String
        setRow = MembersID.Text
   
        Firstname.Text = KingswayFitnessDataSet1.Members.Rows(setRow).Item("Forename")
    End Sub

    Private Sub Firstname_TextChanged(sender As Object, e As EventArgs) Handles Firstname.TextChanged

    End Sub
End Class