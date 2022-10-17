Imports System.Data.SqlClient
Public Class addadminpage

    Private Sub addadmin_addbutton_Click(sender As Object, e As EventArgs) Handles addadmin_addbutton.Click

        auth_page.CMD = New SqlCommand("Register_Admin", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Connection = auth_page.CN
        Dim ex As Boolean
        ex = True
        If addadmin_emailbox.Text.Equals("") Then
            MessageBox.Show("Email can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@email", addadmin_emailbox.Text)
        End If

        If addadmin_namebox.Text.Equals("") Then
            MessageBox.Show("Name can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@nome", addadmin_namebox.Text)
        End If

        auth_page.CMD.Parameters.AddWithValue("@pass", addadmin_passbox.Text)

        auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output

        If ex.Equals(True) Then
            auth_page.CN.Close()
            auth_page.CN.Open()
            auth_page.CMD.ExecuteNonQuery()
            MessageBox.Show(auth_page.CMD.Parameters("@responseMessage").Value.ToString())
        Else
            MessageBox.Show("Something went Wrong, Try Again")
        End If

        Me.Hide()
    End Sub


End Class