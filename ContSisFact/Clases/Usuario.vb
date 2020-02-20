Public Class Usuario
    Private iId As Integer
    Private strUsuario As String
    Private strNombre As String
    Private iPerfil As Integer


    Public Property Id() As Integer
        Get
            Return iId
        End Get
        Set(value As Integer)
            iId = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return strUsuario
        End Get
        Set(value As String)
            strUsuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return strNombre
        End Get
        Set(value As String)
            strNombre = value
        End Set
    End Property

    Public Property Perfil As Integer
        Get
            Return iPerfil
        End Get
        Set(value As Integer)
            iPerfil = value
        End Set
    End Property
End Class
