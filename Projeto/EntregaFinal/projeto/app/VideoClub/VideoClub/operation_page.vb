
Public Class operation_page

    Private Sub return_button_Click(sender As Object, e As EventArgs) Handles return_button.Click
        homepage.Show()
        Me.Hide()
    End Sub

    Private Sub add_conteudo_button_Click(sender As Object, e As EventArgs) Handles add_conteudo_button.Click
        AddContent.Show()
    End Sub

    Private Sub add_coupon_button_Click(sender As Object, e As EventArgs) Handles add_coupon_button.Click
        add_coupon_page.Show()
    End Sub

    Private Sub add_promotion_button_Click(sender As Object, e As EventArgs) Handles add_promotion_button.Click
        addpromotionpage.Show()
    End Sub

    Private Sub add_admin_button_Click(sender As Object, e As EventArgs) Handles add_admin_button.Click
        addadminpage.Show()
    End Sub

    Private Sub operation_editcont_button_Click(sender As Object, e As EventArgs) Handles operation_editcont_button.Click
        editcontent.Show()
    End Sub
End Class