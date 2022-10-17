<Serializable()> Public Class Conteudo
    Private _conteudoid As String
    Private _conteudoano As String
    Private _conteudopreco As String
    Private _conteudocategoria As String
    Private _conteudotaxaiva As String
    Private _conteudotitulo As String
    Private _conteudoidade As String
    Private _conteudoduracao As String

    Property ConteudoID As String
        Get
            Return _conteudoid
        End Get
        Set(ByVal value As String)
            _conteudoid = value
        End Set
    End Property


    Property Conteudotitulo() As String
        Get
            Conteudotitulo = _conteudotitulo
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Titulo field can’t be empty")
                Exit Property
            End If
            _conteudotitulo = value
        End Set
    End Property

    Property Conteudopreco() As String
        Get
            Conteudopreco = _conteudopreco
        End Get
        Set(ByVal value As String)
            _conteudopreco = value
        End Set
    End Property

    Property ConteudoCategoria() As String
        Get
            ConteudoCategoria = _conteudocategoria
        End Get
        Set(ByVal value As String)
            _conteudocategoria = value
        End Set
    End Property

    Property Conteudotaxaiva() As String
        Get
            Conteudotaxaiva = _conteudotaxaiva
        End Get
        Set(ByVal value As String)
            _conteudotaxaiva = value
        End Set
    End Property

    Property ConteudoAno() As String
        Get
            ConteudoAno = _conteudoano
        End Get
        Set(ByVal value As String)
            _conteudoano = value
        End Set
    End Property

    Property Conteudoidade() As String
        Get
            Conteudoidade = _conteudoidade
        End Get
        Set(ByVal value As String)
            _conteudoidade = value
        End Set
    End Property

    Property Conteudoduracao() As String
        Get
            Conteudoduracao = _conteudoduracao
        End Get
        Set(ByVal value As String)
            _conteudoduracao = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return Conteudotitulo
    End Function
End Class
