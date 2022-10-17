Imports System.Data.SqlClient
Public Class regis_page

    Private Sub sign_up_button_Click(sender As Object, e As EventArgs) Handles sign_up_button.Click

        auth_page.CMD = New SqlCommand("RegisterUsuario", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Connection = auth_page.CN

        Dim ex As Boolean
        ex = True

        If register_email_box.Text.Equals("") Then
            MessageBox.Show("Email can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@email", register_email_box.Text)
        End If

        If register_nome_box.Text.Equals("") Then
            MessageBox.Show("Nome can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@nome", register_nome_box.Text)
        End If

        If register_pass_box.Text.Equals("") Then
            MessageBox.Show("Password can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@pass", register_pass_box.Text)
        End If

        auth_page.CMD.Parameters.AddWithValue("@contribuinte", register_contribuinte_box.Text)
        auth_page.CMD.Parameters.AddWithValue("@dataNasc", register_data_box.Text)
        auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output

        If ex.Equals(True) Then
            auth_page.CN.Close()
            auth_page.CN.Open()
            auth_page.CMD.ExecuteNonQuery()
            MessageBox.Show(auth_page.CMD.Parameters("@responseMessage").Value.ToString())
        Else
            MessageBox.Show("Something went Wrong, Try Again")
        End If
        auth_page.Show()
        Me.Hide()

    End Sub
End Class