Imports System.Data.SqlClient
Public Class promocouppage
    Private Sub promocoup_returnbutton_Click(sender As Object, e As EventArgs) Handles promocoup_returnbutton.Click
        homepage.Show()
        Me.Hide()
    End Sub

    Private Sub promocouppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getPromocoes()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        Promotion_list.Items.Clear()
        Coupons_list.Items.Clear()
        While RDR.Read
            Dim P As New Promocao
            P.Promocaodesconto = Convert.ToString(RDR.Item("desconto"))
            P.Promocaodatain = Convert.ToString(RDR.Item("datain"))
            P.Promocaodataen = Convert.ToString(RDR.Item("dataen"))
            P.Promocaonome = Convert.ToString(RDR.Item("nome"))
            Promotion_list.Items.Add(P)
        End While

        auth_page.CMD.CommandText = "SELECT * FROM getCupao()"
        auth_page.CN.Close()
        auth_page.CN.Open()

        RDR = auth_page.CMD.ExecuteReader
        While RDR.Read
            Dim P As New Cupao
            P.Cupaoid = Convert.ToString(RDR.Item("id"))
            P.Cupaodatain = Convert.ToString(RDR.Item("datain"))
            P.Cupaodataen = Convert.ToString(RDR.Item("dataen"))
            P.Cupaopontos = Convert.ToString(RDR.Item("pontos"))
            Coupons_list.Items.Add(P)
        End While
    End Sub

    Private Sub Promotion_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Promotion_list.SelectedIndexChanged
        Dim x As String = Promotion_list.Items(Promotion_list.SelectedIndex).ToString()
        Dim arx() As String = x.Split(" ")
        homepage.cont_chosed = arx(0)
        rent_cont_page.Show()
    End Sub

    Private Sub Coupons_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Coupons_list.SelectedIndexChanged

        Dim x As String = Coupons_list.Items(Coupons_list.SelectedIndex).ToString()
        Dim arx() As String = x.Split(" ")

        auth_page.CMD = New SqlCommand("user_usa_cupao", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Parameters.AddWithValue("@cupao_id", arx(0))
        auth_page.CMD.Parameters.AddWithValue("@usuario_email", auth_page.user_loged)
        auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader

        If auth_page.CMD.Parameters("@responseMessage").Value.ToString().Equals("Success") Then
            MessageBox.Show("You Got " + arx(2) + " New Points")
        Else
            MessageBox.Show("Something went wrong, Try again later")
        End If

    End Sub
End Class