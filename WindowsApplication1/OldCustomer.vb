Public Class OldCustomer
    Private Sub OldCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Old_Members' table. You can move, or remove it, as needed.
        Me.Old_MembersTableAdapter.Fill(Me.KingswayFitnessDataSet1.Old_Members)

    End Sub

End Class