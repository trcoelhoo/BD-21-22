<Serializable()> Public Class Promocao

    Private _promocaoid As String
    Private _promocaodesconto As String
    Private _promocaodatain As String
    Private _promocaodataen As String
    Private _promocaonome As String


    Property Promocaoid() As String
        Get
            Return _promocaoid
        End Get
        Set(ByVal value As String)
            _promocaoid = value
        End Set
    End Property


    Property Promocaodesconto() As String
        Get
            Promocaodesconto = _promocaodesconto
        End Get
        Set(ByVal value As String)
            If value < 0 Or value > 100 Then
                Throw New Exception("Desconto Should be between 0 and 100")
                Exit Property
            End If
            _promocaodesconto = value
        End Set
    End Property

    Property Promocaodatain() As String
        Get
            Promocaodatain = _promocaodatain
        End Get
        Set(ByVal value As String)
            _promocaodatain = value
        End Set
    End Property

    Property Promocaodataen() As String
        Get
            Promocaodataen = _promocaodataen
        End Get
        Set(ByVal value As String)
            _promocaodataen = value
        End Set
    End Property

    Property Promocaonome() As String
        Get
            Promocaonome = _promocaonome
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _promocaonome = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return Promocaonome + " | -" + Promocaodesconto + "%"
    End Function

End Class
