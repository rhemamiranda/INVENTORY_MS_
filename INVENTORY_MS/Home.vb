Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Login.Show()
        Me.Close()
    End Sub
End Class