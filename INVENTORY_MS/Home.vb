Public Class Home

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        If MsgBox("Are you sure you want to logout?", vbYesNo + vbQuestion, "Logout") = vbYes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        Product_Management.lbl_username.Text = lbl_username.Text
        Product_Management.Show()
        Me.Close()
    End Sub

    Private Sub btn_category_Click(sender As Object, e As EventArgs) Handles btn_category.Click
        Category_Management.lbl_username.Text = lbl_username.Text
        Category_Management.Show()
        Me.Close()
    End Sub

    Private Sub btn_userinfo_Click(sender As Object, e As EventArgs) Handles btn_userinfo.Click
        UserInfo_Management.lbl_username.Text = lbl_username.Text
        UserInfo_Management.Show()
        Me.Close()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Order_Management.lbl_username.Text = lbl_username.Text
        Order_Management.Show()
        Me.Close()
    End Sub

    Private Sub btn_custominfo_Click(sender As Object, e As EventArgs) Handles btn_custominfo.Click
        CustomerInfo_Management.lbl_username.Text = lbl_username.Text
        CustomerInfo_Management.Show()
        Me.Close()
    End Sub

End Class