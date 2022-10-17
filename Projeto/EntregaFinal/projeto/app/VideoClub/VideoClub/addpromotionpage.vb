Imports System.Data.SqlClient
Public Class addpromotionpage

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        auth_page.CMD = New SqlCommand("addPromocao", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Connection = auth_page.CN
        Dim ex As Boolean
        ex = True
        If addpromo_namebox.Text.Equals("") Then
            MessageBox.Show("Name can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@nome", addpromo_namebox.Text)
        End If

        If addpromo_descontobox.Text > 0 And addpromo_descontobox.Text < 100 Then
            auth_page.CMD.Parameters.AddWithValue("@desconto", addpromo_descontobox.Text)
        Else
            MessageBox.Show("Discount need to be bigger than 0")
            ex = False
        End If

        auth_page.CMD.Parameters.AddWithValue("@datain", addpromo_startbox.Text)
        auth_page.CMD.Parameters.AddWithValue("@dataen", addpromo_finalbox.Text)
        auth_page.CMD.Parameters.AddWithValue("@emailadmin", auth_page.user_loged)
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