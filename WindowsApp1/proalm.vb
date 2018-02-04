Public Class proalm
    Private _pe As Integer
    Private _po As Integer
    Private _pract As Integer
    Private _valores As Integer
    Private _nota As Integer
    Private _prue As Integer
    Private _resul As String
    Private _lit As String
    Public Property pe() As Integer
        Get
            Return _pe


        End Get
        Set(value As Integer)

            _pe = value


        End Set
    End Property

    Public Property po() As Integer
        Get
            Return _po


        End Get
        Set(value As Integer)
            _po = value
        End Set
    End Property


    Public Property pract() As Integer
        Get
            Return _pract

        End Get
        Set(value As Integer)
            _pract = value

        End Set
    End Property

    Public Property valores() As Integer
        Get
            Return _valores



        End Get
        Set(value As Integer)
            _valores = value

        End Set
    End Property
    Public Property prue() As Integer
        Get
            Return _prue


        End Get
        Set(value As Integer)
            _prue = value

        End Set
    End Property

    Public Property nota() As Integer
        Get
            Return _nota

        End Get
        Set(value As Integer)
            _nota = value
        End Set
    End Property
    Public Property resul() As String
        Get
            Return _resul

        End Get
        Set(value As String)
            _resul = value

        End Set
    End Property

    Public Property lit() As String
        Get
            Return _lit
        End Get
        Set(value As String)
            _lit = value

        End Set
    End Property
End Class
