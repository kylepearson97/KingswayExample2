Public Class ActivityLogForm
    Private Sub formclose(sender As Object, e As EventArgs) Handles Me.FormClosed


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Member_Activity_Log' table. You can move, or remove it, as needed.
        Me.Member_Activity_LogTableAdapter.Fill(Me.KingswayFitnessDataSet1.Member_Activity_Log)

    End Sub
End Class