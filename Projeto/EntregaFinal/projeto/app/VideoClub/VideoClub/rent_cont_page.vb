Imports System.Data.SqlClient
Public Class rent_cont_page

    Dim points_user As String
    Dim original_price As String
    Dim titulo_cont As String
    Private Sub rent_cont_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        content_name_label.Text = homepage.cont_chosed
        payment_box.SelectedIndex = 0

        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getUsuarioInfo('" & auth_page.user_loged & "')"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        While RDR.Read
            Dim U As New Usuario
            U.Usuarioemail = Convert.ToString(RDR.Item("email"))
            U.Usuarionome = Convert.ToString(RDR.Item("nome"))
            U.Usuariocontribuinte = Convert.ToString(RDR.Item("contribuinte"))
            U.Usuariopass = Convert.ToString(RDR.Item("pass"))
            U.UsuariodataNasc = Convert.ToString(RDR.Item("dataNasc"))
            U.Usuariopontos = Convert.ToString(RDR.Item("pontos"))
            points_user = U.Usuariopontos
        End While

        auth_page.CMD.CommandText = "SELECT * FROM getConteudobytitulo('" & homepage.cont_chosed & "')"
        auth_page.CN.Close()
        auth_page.CN.Open()
        RDR = auth_page.CMD.ExecuteReader
        Dim C As New Conteudo
        While RDR.Read
            C.ConteudoID = Convert.ToString(RDR.Item("ID"))
            C.ConteudoAno = Convert.ToString(RDR.Item("Ano"))
            C.Conteudopreco = Convert.ToString(RDR.Item("Preco"))
            C.ConteudoCategoria = Convert.ToString(RDR.Item("Categoria"))
            C.Conteudotaxaiva = Convert.ToString(RDR.Item("TaxaIva"))
            C.Conteudotitulo = Convert.ToString(RDR.Item("Titulo"))
            C.Conteudoidade = Convert.ToString(RDR.Item("Idade"))
            C.Conteudoduracao = Convert.ToString(RDR.Item("Duracao"))
            titulo_cont = C.Conteudotitulo
            original_price = C.Conteudopreco
        End While

        totalprice_label.Text = original_price
        auth_page.CMD.CommandText = "SELECT * FROM getPromocoes()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        RDR = auth_page.CMD.ExecuteReader

        While RDR.Read
            Dim P As New Promocao
            P.Promocaodesconto = Convert.ToString(RDR.Item("desconto"))
            P.Promocaodatain = Convert.ToString(RDR.Item("datain"))
            P.Promocaodataen = Convert.ToString(RDR.Item("dataen"))
            P.Promocaonome = Convert.ToString(RDR.Item("nome"))
            If titulo_cont.Equals(P.Promocaonome) Then
                original_price = original_price - (original_price * (P.Promocaodesconto / 100))
                totalprice_label.Text = original_price
            End If
        End While

        rent_usepointsbox.Text = "0"
    End Sub

    Private Sub rent_usepointsbox_TextChanged(sender As Object, e As EventArgs) Handles rent_usepointsbox.TextChanged
        If (rent_usepointsbox.Text.Equals("")) Then
            rent_usepointsbox.Text = "0"
        End If
        If (rent_usepointsbox.Text < 0) Then
            rent_usepointsbox.Text = "0"
        End If
        If (points_user - rent_usepointsbox.Text) <= 0 Then
            rent_usepointsbox.Text = "0"
            MessageBox.Show("You only have " + points_user + " Points")
        End If
        totalprice_label.Text = original_price - (rent_usepointsbox.Text / 100)
        If totalprice_label.Text < 0 Then
            totalprice_label.Text = "0"
        End If
    End Sub

    Private Sub rent_button_Click(sender As Object, e As EventArgs) Handles rent_button.Click
        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getUsuarioInfo('" & auth_page.user_loged & "')"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        Dim U As New Usuario
        While RDR.Read
            U.Usuarioemail = Convert.ToString(RDR.Item("email"))
            U.Usuarionome = Convert.ToString(RDR.Item("nome"))
            U.Usuariocontribuinte = Convert.ToString(RDR.Item("contribuinte"))
            U.Usuariopass = Convert.ToString(RDR.Item("pass"))
            U.UsuariodataNasc = Convert.ToString(RDR.Item("dataNasc"))
            U.Usuariopontos = Convert.ToString(RDR.Item("pontos"))
            U.Usuariodate = RDR.Item("dataNasc")
        End While
        auth_page.CMD.CommandText = "SELECT * FROM getConteudobytitulo('" & homepage.cont_chosed & "')"
        auth_page.CN.Close()
        auth_page.CN.Open()

        RDR = auth_page.CMD.ExecuteReader
        Dim C As New Conteudo
        While RDR.Read
            C.ConteudoID = Convert.ToString(RDR.Item("ID"))
            C.ConteudoAno = Convert.ToString(RDR.Item("Ano"))
            C.Conteudopreco = Convert.ToString(RDR.Item("Preco"))
            C.ConteudoCategoria = Convert.ToString(RDR.Item("Categoria"))
            C.Conteudotaxaiva = Convert.ToString(RDR.Item("TaxaIva"))
            C.Conteudotitulo = Convert.ToString(RDR.Item("Titulo"))
            C.Conteudoidade = Convert.ToString(RDR.Item("Idade"))
            C.Conteudoduracao = Convert.ToString(RDR.Item("Duracao"))
        End While

        auth_page.CMD = New SqlCommand("novoAluguer", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure

        auth_page.CMD.Parameters.AddWithValue("@pagamento", payment_box.Text)
        auth_page.CMD.Parameters.AddWithValue("@usuario_email", U.Usuarioemail)
        auth_page.CMD.Parameters.AddWithValue("@contribuinte", U.Usuariocontribuinte)
        auth_page.CMD.Parameters.AddWithValue("@pontos_usados", rent_usepointsbox.Text)
        auth_page.CMD.Parameters.AddWithValue("@pontos_acumulados", totalprice_label.Text * 100)
        auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
        auth_page.CN.Close()
        auth_page.CN.Open()
        auth_page.CMD.ExecuteNonQuery()
        If auth_page.CMD.Parameters("@responseMessage").Value.ToString().Equals("Success") Then
            auth_page.CMD = New SqlCommand("updateUsuario", auth_page.CN)
            auth_page.CMD.CommandType = CommandType.StoredProcedure

            auth_page.CMD.Parameters.AddWithValue("@email", U.Usuarioemail)
            auth_page.CMD.Parameters.AddWithValue("@pontos", U.Usuariopontos + (totalprice_label.Text * 100) - rent_usepointsbox.Text)
            auth_page.CMD.Parameters.Add("@responseMsg", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
            auth_page.CN.Close()
            auth_page.CN.Open()
            auth_page.CMD.ExecuteNonQuery()

            auth_page.CMD = New SqlCommand("getlastaluguer", auth_page.CN)
            auth_page.CMD.CommandType = CommandType.StoredProcedure
            auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
            auth_page.CN.Close()
            auth_page.CN.Open()
            auth_page.CMD.ExecuteNonQuery()

            Dim aluguer_id As String = auth_page.CMD.Parameters("@responseMessage").Value.ToString()

            auth_page.CMD = New SqlCommand("AlugarConteudo", auth_page.CN)
            auth_page.CMD.CommandType = CommandType.StoredProcedure

            auth_page.CMD.Parameters.AddWithValue("@id_aluguer", aluguer_id)
            auth_page.CMD.Parameters.AddWithValue("@id_conteudo", C.ConteudoID)
            auth_page.CMD.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250).Direction = ParameterDirection.Output
            auth_page.CN.Close()
            auth_page.CN.Open()
            auth_page.CMD.ExecuteNonQuery()

            MessageBox.Show("Successfully rented content")
        Else
            MessageBox.Show("Something Went Wrong try Again")
        End If


        Me.Hide()

    End Sub

End Class