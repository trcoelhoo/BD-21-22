Public Class Cupao

    Private _cupaoid As String
    Private _cupaodatain As String
    Private _cupaodataen As String
    Private _cupaopontos As String

    Property Cupaoid() As String
        Get
            Cupaoid = _cupaoid
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _cupaoid = value
        End Set
    End Property

    Property Cupaopontos() As String
        Get
            Cupaopontos = _cupaopontos
        End Get
        Set(ByVal value As String)
            If value < 0 Then
                Throw New Exception("Desconto Should be between 0 and 100")
                Exit Property
            End If
            _cupaopontos = value
        End Set
    End Property

    Property Cupaodatain() As String
        Get
            Cupaodatain = _cupaodatain
        End Get
        Set(ByVal value As String)
            _cupaodatain = value
        End Set
    End Property

    Property Cupaodataen() As String
        Get
            Cupaodataen = _cupaodataen
        End Get
        Set(ByVal value As String)
            _cupaodataen = value
        End Set
    End Property



    Overrides Function ToString() As String
        Return Cupaoid + " | " + Cupaopontos + "Points"
    End Function
End Class
