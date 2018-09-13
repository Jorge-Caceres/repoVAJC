Public Class Ciudad

    Private CiudadId As Integer
    Private Descripcion As String

    Public Property CiudadId1 As Integer
        Get
            Return CiudadId
        End Get
        Set(value As Integer)
            CiudadId = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property
End Class
