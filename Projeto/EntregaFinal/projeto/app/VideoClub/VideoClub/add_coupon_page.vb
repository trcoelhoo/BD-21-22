Imports System.Data.SqlClient
Public Class add_coupon_page

    Private Sub addcoupon_add_button_Click(sender As Object, e As EventArgs) Handles addcoupon_add_button.Click

        auth_page.CMD = New SqlCommand("addCoupon", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Connection = auth_page.CN
        Dim ex As Boolean
        ex = True
        Try
            If addcoupon_idname_box.Text.Equals("") Then
                MessageBox.Show("Name can't be empty")
                ex = False
            Else
                auth_page.CMD.Parameters.AddWithValue("@id", addcoupon_idname_box.Text)
            End If


            auth_page.CMD.Parameters.AddWithValue("@datain", addcoupon_startdate_box.Text)
            auth_page.CMD.Parameters.AddWithValue("@dataen", addcoupon_finaldate_box.Text)

            If addcoupon_points_box.Text > 0 Then
                auth_page.CMD.Parameters.AddWithValue("@pontos", addcoupon_points_box.Text)
            Else
                MessageBox.Show("Points need to be bigger than 0")
                ex = False
            End If
        Catch
            MessageBox.Show("Something went Wrong")
            ex=False
        End Try
        auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output

        If ex.Equals(True) Then
            auth_page.CMD.ExecuteNonQuery()
            MessageBox.Show(auth_page.CMD.Parameters("@responseMessage").Value.ToString())
        Else
            MessageBox.Show("Something went Wrong, Try Again")
        End If

        Me.Hide()
    End Sub

End Class