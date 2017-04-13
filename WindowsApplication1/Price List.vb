Public Class MembershipType
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles LogoPicBox.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KingswayFitnessDataSet1.Membership_Type' table. You can move, or remove it, as needed.
        Me.Membership_TypeTableAdapter.Fill(Me.KingswayFitnessDataSet1.Membership_Type)

    End Sub
End Class