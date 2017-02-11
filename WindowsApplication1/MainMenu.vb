Public Class MainMenu

    Private Sub FileM_MouseHover(sender As Object, e As EventArgs) Handles FileM.MouseHover
        FileM.Image = My.Resources.Blue2Click

    End Sub

    Private Sub FileM_MouseLeave(sender As Object, e As EventArgs) Handles FileM.MouseLeave
        FileM.Image = My.Resources.Blue2Unclick
    End Sub

    Private Sub FileM_Click(sender As Object, e As EventArgs) Handles FileM.Click
        Dim oForm As New FileManagement
        Hide()
        oForm.Show()
    End Sub
    Private Sub Customer_MouseHover(sender As Object, e As EventArgs) Handles Customer.MouseHover
        Customer.Image = My.Resources.BlueClick

    End Sub

    Private Sub Customer_MouseLeave(sender As Object, e As EventArgs) Handles Customer.MouseLeave
        Customer.Image = My.Resources.BlueUnclick
    End Sub

    Private Sub Reactive_MouseHover(sender As Object, e As EventArgs) Handles Reactive.MouseHover
        Reactive.Image = My.Resources.GreenClick

    End Sub

    Private Sub Reactive_MouseLeave(sender As Object, e As EventArgs) Handles Reactive.MouseLeave
        Reactive.Image = My.Resources.GreenUnclick
    End Sub

    Private Sub Renewal_MouseHover(sender As Object, e As EventArgs) Handles Renewal.MouseHover
        Renewal.Image = My.Resources.OrangeClick

    End Sub

    Private Sub Renewal_MouseLeave(sender As Object, e As EventArgs) Handles Renewal.MouseLeave
        Renewal.Image = My.Resources.OrangeUnclick
    End Sub

    Private Sub Lapsed_MouseHover(sender As Object, e As EventArgs) Handles Lapsed.MouseHover
        Lapsed.Image = My.Resources.YellowClick

    End Sub

    Private Sub Lapsed_MouseLeave(sender As Object, e As EventArgs) Handles Lapsed.MouseLeave
        Lapsed.Image = My.Resources.YellowUnclick
    End Sub

    Private Sub Price_MouseHover(sender As Object, e As EventArgs) Handles Price.MouseHover
        Price.Image = My.Resources.RedClick

    End Sub

    Private Sub Price_MouseLeave(sender As Object, e As EventArgs) Handles Price.MouseLeave
        Price.Image = My.Resources.RedUnclick
    End Sub

    Private Sub Reports_MouseHover(sender As Object, e As EventArgs) Handles Reports.MouseHover
        Reports.Image = My.Resources.PurpleClick

    End Sub

    Private Sub Reports_MouseLeave(sender As Object, e As EventArgs) Handles Reports.MouseLeave
        Reports.Image = My.Resources.PurpleUnclick
    End Sub

    Private Sub Routine_MouseHover(sender As Object, e As EventArgs) Handles Routine.MouseHover
        Routine.Image = My.Resources.Purple2Click

    End Sub

    Private Sub Routine_MouseLeave(sender As Object, e As EventArgs) Handles Routine.MouseLeave
        Routine.Image = My.Resources.Purple2Unclick
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
