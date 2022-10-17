Imports System.Data.SqlClient
Public Class AddContent

    Private Sub add_content_add_button_Click(sender As Object, e As EventArgs) Handles add_content_add_button.Click

        auth_page.CMD = New SqlCommand("addConteudo", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Connection = auth_page.CN
        Dim ex As Boolean
        Dim allCategorias(11) As String

        allCategorias(0) = "Comedia"
        allCategorias(1) = "Terror"
        allCategorias(2) = "Drama"
        allCategorias(3) = "Romance"
        allCategorias(4) = "Thriller"
        allCategorias(5) = "Fantasia"
        allCategorias(6) = "Ficcao Cientifica"
        allCategorias(7) = "Acao"
        allCategorias(8) = "Aventura"
        allCategorias(9) = "Danca"
        allCategorias(10) = "Documentario"
        ex = True
        If addconteudo_titulo_box.Text.Equals("") Then
            MessageBox.Show("Titulo can't be empty")
            ex = False
        Else
            auth_page.CMD.Parameters.AddWithValue("@titulo", addconteudo_titulo_box.Text)
        End If

        If allCategorias.Contains(addconteudo_categoria_box.Text) Then
            auth_page.CMD.Parameters.AddWithValue("@categoria", addconteudo_categoria_box.Text)
        Else
            MessageBox.Show("Categoria não existe")
            ex = False
        End If

        If addconteudo_ano_box.Text > 0 And addconteudo_ano_box.Text < 2023 Then
            auth_page.CMD.Parameters.AddWithValue("@ano", addconteudo_ano_box.Text)
        Else
            MessageBox.Show("Ano não existe")
            ex = False
        End If

        If addconteudo_preco_box.Text > 0 Then
            auth_page.CMD.Parameters.AddWithValue("@preco", Convert.ToDouble(addconteudo_preco_box.Text))
        Else
            MessageBox.Show("Preço needs to be bigger than 0")
            ex = False
        End If
        If addconteudo_taxa_box.Text.Equals("23") Then
            auth_page.CMD.Parameters.AddWithValue("@taxaiva", addconteudo_taxa_box.Text)
        Else
            MessageBox.Show("Taxa needs to be 23")
            ex = False
        End If
        If addconteudo_idade_box.Text > 0 And addconteudo_idade_box.Text < 100 Then

            auth_page.CMD.Parameters.AddWithValue("@idade", addconteudo_idade_box.Text)
        Else
            MessageBox.Show("Idade should be between 0 and 100")
            ex = False
        End If
        If addconteudo_duracao_box.Text > 0 And addconteudo_duracao_box.Text < 500 Then

            auth_page.CMD.Parameters.AddWithValue("@duracao", addconteudo_duracao_box.Text)
        Else
            MessageBox.Show("Idade should be between 0 and 500")
            ex = False
        End If
        auth_page.CMD.Parameters.AddWithValue("@emailadmin", auth_page.user_loged)
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