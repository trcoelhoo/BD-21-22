Imports System.Data.SqlClient
Public Class editcontent
    Private Sub editcontent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getallConteudo()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        editcont_list.Items.Clear()
        While RDR.Read
            Dim C As New Conteudo
            C.ConteudoID = Convert.ToString(RDR.Item("ID"))
            C.ConteudoAno = Convert.ToString(RDR.Item("Ano"))
            C.Conteudopreco = Convert.ToString(RDR.Item("Preco"))
            C.ConteudoCategoria = Convert.ToString(RDR.Item("Categoria"))
            C.Conteudotaxaiva = Convert.ToString(RDR.Item("TaxaIva"))
            C.Conteudotitulo = Convert.ToString(RDR.Item("Titulo"))
            C.Conteudoidade = Convert.ToString(RDR.Item("Idade"))
            C.Conteudoduracao = Convert.ToString(RDR.Item("Duracao"))

            editcont_list.Items.Add(C)
        End While
    End Sub

    Private Sub editcont_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles editcont_list.SelectedIndexChanged
        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getConteudobytitulo('" + editcont_list.SelectedItem().ToString() + "')"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        While RDR.Read
            Dim C As New Conteudo
            C.ConteudoID = Convert.ToString(RDR.Item("ID"))
            C.ConteudoAno = Convert.ToString(RDR.Item("Ano"))
            C.Conteudopreco = Convert.ToString(RDR.Item("Preco"))
            C.ConteudoCategoria = Convert.ToString(RDR.Item("Categoria"))
            C.Conteudotaxaiva = Convert.ToString(RDR.Item("TaxaIva"))
            C.Conteudotitulo = Convert.ToString(RDR.Item("Titulo"))
            C.Conteudoidade = Convert.ToString(RDR.Item("Idade"))
            C.Conteudoduracao = Convert.ToString(RDR.Item("Duracao"))

            editcont_idbox.Text = C.ConteudoID
            editcont_anobox.Text = C.ConteudoAno
            editcont_precobox.Text = C.Conteudopreco
            editcont_categoriabox.Text = C.ConteudoCategoria
            editcont_titulobox.Text = C.Conteudotitulo
            editcont_idadebox.Text = C.Conteudoidade
            editcont_duracaobox.Text = C.Conteudoduracao

        End While

    End Sub

    Private Sub editcont_editbutton_Click(sender As Object, e As EventArgs) Handles editcont_editbutton.Click
        auth_page.CMD = New SqlCommand("ChangeConteudo", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure

        auth_page.CMD.Parameters.AddWithValue("@id", editcont_idbox.Text)

        If editcont_anobox.Text > 0 Then
            auth_page.CMD.Parameters.AddWithValue("@ano", editcont_anobox.Text)
        End If

        If editcont_precobox.Text > 0.0 Then
            auth_page.CMD.Parameters.AddWithValue("@preco", Convert.ToDouble(editcont_precobox.Text))
        End If

        If editcont_idadebox.Text > 0 Then
            auth_page.CMD.Parameters.AddWithValue("@idade", editcont_idadebox.Text)
        End If

        If editcont_duracaobox.Text > 0 Then
            auth_page.CMD.Parameters.AddWithValue("@duracao", editcont_duracaobox.Text)
        End If
        If Not editcont_titulobox.Text.Equals("") Then
            auth_page.CMD.Parameters.AddWithValue("@titulo", editcont_titulobox.Text)
        End If

        If Not editcont_categoriabox.Text.Equals("") Then
            auth_page.CMD.Parameters.AddWithValue("@categoria", editcont_categoriabox.Text)
        End If
        auth_page.CMD.Parameters.AddWithValue("@taxaiva", 23)
        auth_page.CMD.Parameters.AddWithValue("@emailadmin", auth_page.user_loged)
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader

        MessageBox.Show("Success on Change")

    End Sub
End Class