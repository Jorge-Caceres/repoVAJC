Public Class Propietario

    Private Propietario As Integer
    Private Nombre As String
    Private Apellido As String
    Private Sexo As String
    Private Nacimiento As Date

    Public Property Propietario1 As Integer
        Get
            Return Propietario
        End Get
        Set(value As Integer)
            Propietario = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property

    Public Property Sexo1 As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
        End Set
    End Property

    Public Property Nacimiento1 As Date
        Get
            Return Nacimiento
        End Get
        Set(value As Date)
            Nacimiento = value
        End Set
    End Property
End Class
