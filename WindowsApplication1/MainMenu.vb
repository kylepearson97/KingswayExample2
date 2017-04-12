Public Class MainMenu

    Private Sub AddCustomer_MouseHover(sender As Object, e As EventArgs) Handles AddCustomer.MouseHover
        AddCustomer.Image = My.Resources.AddCustomerClick

    End Sub

    Private Sub AddCustomer_MouseLeave(sender As Object, e As EventArgs) Handles AddCustomer.MouseLeave
        AddCustomer.Image = My.Resources.AddCustomerNoClick
    End Sub

    Private Sub AddCustomer_Click(sender As Object, e As EventArgs) Handles AddCustomer.Click
        Dim oForm As New AddCustomer

        oForm.Show()
    End Sub
    Private Sub ViewEditCustomer_MouseHover(sender As Object, e As EventArgs) Handles ViewEditCustomer.MouseHover
        ViewEditCustomer.Image = My.Resources.ViewEditClick

    End Sub

    Private Sub ViewEditCustomer_MouseLeave(sender As Object, e As EventArgs) Handles ViewEditCustomer.MouseLeave
        ViewEditCustomer.Image = My.Resources.ViewEditNoClick
    End Sub

    Private Sub ViewEditCustomer_Click(sender As Object, e As EventArgs) Handles ViewEditCustomer.Click
        Dim oForm As New CustomerForm
        oForm.Show()
    End Sub
    Private Sub CurrentClient_MouseHover(sender As Object, e As EventArgs) Handles CurrentClient.MouseHover
        CurrentClient.Image = My.Resources.CurrentClientClick

    End Sub

    Private Sub CurentClient_MouseLeave(sender As Object, e As EventArgs) Handles CurrentClient.MouseLeave
        CurrentClient.Image = My.Resources.CurrentClientNoclick
    End Sub

    Private Sub Price_MouseHover(sender As Object, e As EventArgs) Handles PriceList.MouseHover
        PriceList.Image = My.Resources.PriceListClick

    End Sub

    Private Sub PriceList_MouseLeave(sender As Object, e As EventArgs) Handles PriceList.MouseLeave
        PriceList.Image = My.Resources.PriceListNoClick
    End Sub

    Private Sub Report_MouseHover(sender As Object, e As EventArgs) Handles Report.MouseHover
        Report.Image = My.Resources.ReportsClick

    End Sub

    Private Sub Report_MouseLeave(sender As Object, e As EventArgs) Handles Report.MouseLeave
        Report.Image = My.Resources.ReportsNoClick
    End Sub

    Private Sub Admin_MouseHover(sender As Object, e As EventArgs) Handles Admin.MouseHover
        Admin.Image = My.Resources.AdminClick

    End Sub

    Private Sub Admin_MouseLeave(sender As Object, e As EventArgs) Handles Admin.MouseLeave
        Admin.Image = My.Resources.AdminNoClick
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CurrentClient_Click(sender As Object, e As EventArgs) Handles CurrentClient.Click
        CurrentClientList.Show()
    End Sub

    Private Sub Membership_Click(sender As Object, e As EventArgs) Handles PriceList.Click
        Dim oForm As New MembershipType
        oForm.Show()
    End Sub
End Class
