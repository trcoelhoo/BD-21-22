<Serializable()> Public Class Usuario
    Private _usuarioemail As String
    Private _usuarionome As String
    Private _usuariocontribuinte As String
    Private _usuariopass As String
    Private _usuariodataNasc As String
    Private _usuariopontos As String
    Private _usuariodate As Date

    Property Usuarioemail() As String
        Get
            Usuarioemail = _usuarioemail
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Email field can’t be empty")
                Exit Property
            End If
            _usuarioemail = value
        End Set
    End Property



    Property Usuarionome() As String
        Get
            Usuarionome = _usuarionome
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _usuarionome = value
        End Set
    End Property
    Property Usuariocontribuinte() As String
        Get
            Usuariocontribuinte = _usuariocontribuinte
        End Get
        Set(ByVal value As String)
            _usuariocontribuinte = value
        End Set
    End Property

    Property Usuariopass() As String
        Get
            Usuariopass = _usuariopass
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Password field can’t be empty")
                Exit Property
            End If
            _usuariopass = value
        End Set
    End Property

    Property UsuariodataNasc() As String
        Get
            UsuariodataNasc = _usuariodataNasc
        End Get
        Set(ByVal value As String)
            _usuariodataNasc = value
        End Set
    End Property

    Property Usuariopontos() As String
        Get
            Usuariopontos = _usuariopontos
        End Get
        Set(ByVal value As String)
            If value < 0 Then
                Throw New Exception("Points Should be bigger than 0")
                Exit Property
            End If
            _usuariopontos = value
        End Set
    End Property

    Property Usuariodate() As Date
        Get
            Usuariodate = _usuariodate
        End Get
        Set(ByVal value As Date)
            _usuariodate = value
        End Set
    End Property

End Class
