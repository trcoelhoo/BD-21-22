Imports System.Data.SqlClient
Public Class homepage
    Public Property cont_chosed As String

    Private Sub homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getallConteudo()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        Conteudo_list.Items.Clear()
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
            Conteudo_list.Items.Add(C)
        End While

        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN
        auth_page.CN.Close()
        auth_page.CN.Open()
        auth_page.CMD.CommandText = "SELECT * FROM getadmininfo()"

        RDR = auth_page.CMD.ExecuteReader
        Dim admins_list(100) As String
        Dim i = 0
        While RDR.Read
            Dim A As New Admin
            A.Adminemail = Convert.ToString(RDR.Item("email"))
            A.Adminnome = Convert.ToString(RDR.Item("nome"))
            A.Adminpass = Convert.ToString(RDR.Item("pass"))

            admins_list(i) = A.Adminemail
            i = i + 1
        End While

        If admins_list.Contains(auth_page.user_loged) Then
            operations_button.Visible = True
            homepage_profile_button.Visible = False
        Else
            operations_button.Visible = False
            homepage_profile_button.Visible = True
        End If
    End Sub


    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged

        auth_page.CMD = New SqlCommand("Conteudo_filter", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure

        If Not search_box.Text.Equals("") Then
            auth_page.CMD.Parameters.AddWithValue("@Titulo", search_box.Text)

            If order_box.SelectedIndex > -1 Then
                auth_page.CMD.Parameters.AddWithValue("@Categoria", category_box.SelectedItem.ToString())
            End If

            If order_box.SelectedIndex > -1 Then
                auth_page.CMD.Parameters.AddWithValue("@orderby", order_box.SelectedItem.ToString())
            End If
        Else
            If order_box.SelectedIndex > -1 Then
                auth_page.CMD.Parameters.AddWithValue("@Categoria", category_box.SelectedItem.ToString())
            End If

            If order_box.SelectedIndex > -1 Then
                auth_page.CMD.Parameters.AddWithValue("@orderby", order_box.SelectedItem.ToString())
            End If
        End If
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader

        Conteudo_list.Items.Clear()
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
            Conteudo_list.Items.Add(C)
        End While

    End Sub

    Private Sub filme_button_Click(sender As Object, e As EventArgs) Handles filme_button.Click
        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getallConteudo_filme()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        Conteudo_list.Items.Clear()
        While RDR.Read
            Dim C As New Conteudo
            C.ConteudoAno = Convert.ToString(RDR.Item("Ano"))
            C.Conteudopreco = Convert.ToString(RDR.Item("Preco"))
            C.ConteudoCategoria = Convert.ToString(RDR.Item("Categoria"))
            C.Conteudotaxaiva = Convert.ToString(RDR.Item("TaxaIva"))
            C.Conteudotitulo = Convert.ToString(RDR.Item("Titulo"))
            C.Conteudoidade = Convert.ToString(RDR.Item("Idade"))
            C.Conteudoduracao = Convert.ToString(RDR.Item("Duracao"))
            Conteudo_list.Items.Add(C)
        End While

    End Sub

    Private Sub serie_button_Click(sender As Object, e As EventArgs) Handles serie_button.Click
        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getallConteudo_serie()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        Conteudo_list.Items.Clear()
        While RDR.Read
            Dim C As New Conteudo
            C.ConteudoAno = Convert.ToString(RDR.Item("Ano"))
            C.Conteudopreco = Convert.ToString(RDR.Item("Preco"))
            C.ConteudoCategoria = Convert.ToString(RDR.Item("Categoria"))
            C.Conteudotaxaiva = Convert.ToString(RDR.Item("TaxaIva"))
            C.Conteudotitulo = Convert.ToString(RDR.Item("Titulo"))
            C.Conteudoidade = Convert.ToString(RDR.Item("Idade"))
            C.Conteudoduracao = Convert.ToString(RDR.Item("Duracao"))
            Conteudo_list.Items.Add(C)
        End While
    End Sub

    Private Sub Conteudo_list_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Conteudo_list.SelectedIndexChanged

        cont_chosed = Conteudo_list.Items(Conteudo_list.SelectedIndex).ToString()
        rent_cont_page.Show()

    End Sub


    Private Sub clear_filter_button_Click(sender As Object, e As EventArgs) Handles clear_filter_button.Click
        order_box.SelectedIndex = 0
        category_box.SelectedIndex = 0
        search_box.Text = ""
        auth_page.CMD = New SqlCommand
        auth_page.CMD.Connection = auth_page.CN

        auth_page.CMD.CommandText = "SELECT * FROM getallConteudo()"
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader
        Conteudo_list.Items.Clear()
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
            Conteudo_list.Items.Add(C)
        End While
    End Sub

    Private Sub category_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles category_box.SelectedIndexChanged
        auth_page.CMD = New SqlCommand("Conteudo_filter", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Parameters.AddWithValue("@Categoria", category_box.SelectedItem.ToString())
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader


        Conteudo_list.Items.Clear()
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
            Conteudo_list.Items.Add(C)
        End While

    End Sub

    Private Sub order_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles order_box.SelectedIndexChanged
        auth_page.CMD = New SqlCommand("Conteudo_filter", auth_page.CN)
        auth_page.CMD.CommandType = CommandType.StoredProcedure
        auth_page.CMD.Parameters.AddWithValue("@orderby", order_box.SelectedItem.ToString())
        auth_page.CN.Close()
        auth_page.CN.Open()
        Dim RDR As SqlDataReader
        RDR = auth_page.CMD.ExecuteReader


        Conteudo_list.Items.Clear()
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
            Conteudo_list.Items.Add(C)
        End While

    End Sub

    Private Sub operations_button_Click(sender As Object, e As EventArgs) Handles operations_button.Click
        Me.Hide()
        operation_page.Show()
    End Sub

    Private Sub promocouppage_button_Click(sender As Object, e As EventArgs) Handles promocouppage_button.Click
        promocouppage.Show()
        Me.Hide()
    End Sub

    Private Sub homepage_profile_button_Click(sender As Object, e As EventArgs) Handles homepage_profile_button.Click
        profile_page.Show()
        Me.Hide()
    End Sub
End Class