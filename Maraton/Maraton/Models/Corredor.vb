
''definicion de la clase como   CLASE BASE no instanciable
Public MustInherit Class Corredor

    Protected NroCorredor As Integer
    Protected NroDocumento As Integer
    Protected Nombre As String
    Protected FechaNacimiento As Date
    Protected Sexo As String
    Protected Nacionalidad As String
    Protected MontoInscripcion As Double

    Public Property NroCorredor1 As Integer
        Get
            Return NroCorredor
        End Get
        Set(value As Integer)
            NroCorredor = value
        End Set
    End Property

    Public Property NroDocumento1 As Integer
        Get
            Return NroDocumento
        End Get
        Set(value As Integer)
            NroDocumento = value
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

    Public Property FechaNacimiento1 As Date
        Get
            Return FechaNacimiento
        End Get
        Set(value As Date)
            FechaNacimiento = value
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

    Public Property Nacionalidad1 As String
        Get
            Return Nacionalidad
        End Get
        Set(value As String)
            Nacionalidad = value
        End Set
    End Property

    Public Property MontoInscripcion1 As Double
        Get
            Return MontoInscripcion
        End Get
        Set(value As Double)
            MontoInscripcion = value
        End Set
    End Property

    'metodos de la clase padre
    Public Function GetMontoInscripcion() As Double
        ''18 a 29 40 dolares
        ''30 a  39 30d\
        ''40 y mas 20d
        Dim vEdad As Integer
        Dim monto As Double
        Dim afic As New Aficionado
        vEdad = DateDiff(DateInterval.Year, Me.FechaNacimiento1, Date.Today)

        If Me.NroCorredor <= 50 Then
            ''los primeros cincuenta corredores corresponden al subtipo ELITE y no se les cobra nada
            monto = 0
        Else
            Select Case vEdad
                Case 18 To 29
                    monto = 40
                Case 30 To 39
                    monto = 30
                Case >= 40
                    monto = 20
            End Select
        End If
        Return monto
    End Function



End Class

'CLASE QUE HEREDA 
Public Class Elite
    Inherits Corredor
    Private Hotel As String

    Public Property Hotel1 As String
        Get
            Return Hotel
        End Get
        Set(value As String)
            Hotel = value
        End Set
    End Property
End Class

Public Class Aficionado
    Inherits Corredor

    Private Telefono As String
    Private Email As String

    Public Property Telefono1 As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
End Class

