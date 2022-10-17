Imports System.Data.SqlClient
Public Class profile_page

    Private Sub profile_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getUsuarioInfo('" & auth_page.user_loged & "')"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        profile_emailbox.Text = ""
        profile_namebox.Text = ""
        profile_contribuintebox.Text = ""
        profile_datebox.Text = ""
        profile_pointsbox.Text = ""
        While RDR.Read
            Dim U As New Usuario
            U.Usuarioemail = Convert.ToString(RDR.Item("email"))
            U.Usuarionome = Convert.ToString(RDR.Item("nome"))
            U.Usuariocontribuinte = Convert.ToString(RDR.Item("contribuinte"))
            U.Usuariopass = Convert.ToString(RDR.Item("pass"))
            U.UsuariodataNasc = Convert.ToString(RDR.Item("dataNasc"))
            U.Usuariopontos = Convert.ToString(RDR.Item("pontos"))

            profile_emailbox.Text = U.Usuarioemail
            profile_namebox.Text = U.Usuarionome
            profile_contribuintebox.Text = U.Usuariocontribuinte
            profile_datebox.Text = U.UsuariodataNasc
            profile_pointsbox.Text = U.Usuariopontos

        End While
    End Sub

    Private Sub profile_returnbutton_Click(sender As Object, e As EventArgs) Handles profile_returnbutton.Click
        homepage.Show()

        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem.ToString().Equals("Coupons") Then
            profile_list.Items.Clear()
            auth_page.CMD = New SqlCommand
            auth_page.CMD.Connection = auth_page.CN

            auth_page.CMD.CommandText = "SELECT * FROM getUsuarioCoupao('" & auth_page.user_loged & "')"
            auth_page.CN.Close()
            auth_page.CN.Open()
            Dim RDR As SqlDataReader
            RDR = auth_page.CMD.ExecuteReader
            While RDR.Read
                Dim C As New Cupao
                C.Cupaoid = Convert.ToString(RDR.Item("id"))
                C.Cupaodatain = Convert.ToString(RDR.Item("datain"))
                C.Cupaodataen = Convert.ToString(RDR.Item("dataen"))
                C.Cupaopontos = Convert.ToString(RDR.Item("pontos"))
                profile_list.Items.Add(C)
            End While

        End If

        If ComboBox1.SelectedItem.ToString().Equals("History") Then
            profile_list.Items.Clear()
            auth_page.CMD = New SqlCommand
            auth_page.CMD.Connection = auth_page.CN

            auth_page.CMD.CommandText = "SELECT * FROM historico_aluguer('" + auth_page.user_loged + "')"
            auth_page.CN.Close()
            auth_page.CN.Open()
            Dim RDR As SqlDataReader
            RDR = auth_page.CMD.ExecuteReader

            While RDR.Read

                Dim i As String = Convert.ToString(RDR.Item("pagamento")) + ": " + Convert.ToString(RDR.Item("Titulo")) + "- " + Convert.ToString(RDR.Item("Preco")) + "$ | " + "New Points: " + Convert.ToString(RDR.Item("pontos_acumulados"))
                profile_list.Items.Add(i)
            End While
        End If

    End Sub

End Class