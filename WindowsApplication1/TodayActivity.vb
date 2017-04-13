Public Class TodayActivity
    Private Sub TodayActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.TodayActive' table. You can move, or remove it, as needed.
        Me.TodayActiveTableAdapter.Fill(Me.KingswayFitnessDataSet1.TodayActive)

    End Sub
End Class