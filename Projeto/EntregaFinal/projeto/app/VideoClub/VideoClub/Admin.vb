<Serializable()> Public Class Admin
    Private _adminemail As String
    Private _adminnome As String
    Private _adminpass As String


    Property Adminemail() As String
        Get
            Adminemail = _adminemail
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Email field can’t be empty")
                Exit Property
            End If
            _adminemail = value
        End Set
    End Property

    Property Adminnome() As String
        Get
            Adminnome = _adminnome
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _adminnome = value
        End Set
    End Property



    Property Adminpass() As String
        Get
            Adminpass = _adminpass
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Password field can’t be empty")
                Exit Property
            End If
            _adminpass = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return Adminnome + " " + Adminemail
    End Function

End Class