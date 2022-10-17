Imports System.Data.SqlClient
Public Class auth_page
    Public Property CN As SqlConnection
    Public Property CMD As SqlCommand

    Public Property user_loged As String
    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles auth_username.TextChanged

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles auth_password.TextChanged

    End Sub

    Private Sub regis_button_Click(sender As Object, e As EventArgs) Handles regis_button.Click
        regis_page.Show()
        Me.Hide()
    End Sub

    Private Sub auth_log_button_Click(sender As Object, e As EventArgs) Handles auth_log_button.Click

        CMD = New SqlCommand("login", CN)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN

        Dim ex As Boolean
        ex = True

        Try
            If auth_username.Text.Equals("") Then
                MessageBox.Show("Username can't be empty")
                ex = False
            Else
                CMD.Parameters.AddWithValue("@email", auth_username.Text)
            End If

            If auth_password.Text.Equals("") Then
                MessageBox.Show("Password can't be empty")
                ex = False
            Else
                CMD.Parameters.AddWithValue("@pass", auth_password.Text)
            End If
        Catch
            MessageBox.Show("Error Occured")
        End Try
        CMD.Parameters.Add("@type", SqlDbType.Bit).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@outemail", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output

        If ex.Equals(True) Then
            CMD.ExecuteNonQuery()
            If CMD.Parameters("@type").Value.ToString().Equals("True") Then
                user_loged = CMD.Parameters("@outemail").Value.ToString()
                MessageBox.Show(CMD.Parameters("@responseMessage").Value.ToString())
                homepage.Show()
                Me.Hide()
            End If

        Else
            MessageBox.Show("Something went Wrong, Try Again")
        End If
    End Sub

    Private Sub auth_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbServer = " tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbName = "p2g7"
        Dim userName = "p2g7"
        Dim userPass = "Fredericoomaior@"
        CN = New SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass)
        CN.Open()
    End Sub
End Class
