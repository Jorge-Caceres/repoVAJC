Public MustInherit Class Vehiculo

    Protected CodPlaca As String
    Protected NumeroChasis As String
    Protected Marca As String
    Protected Modelo As String
    Protected PaisProcedencia As String
    Protected Monto As Double

    Public Property CodPlaca1 As String
        Get
            Return CodPlaca
        End Get
        Set(value As String)
            CodPlaca = value
        End Set
    End Property

    Public Property NumeroChasis1 As String
        Get
            Return NumeroChasis
        End Get
        Set(value As String)
            NumeroChasis = value
        End Set
    End Property

    Public Property Marca1 As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property

    Public Property Modelo1 As String
        Get
            Return Modelo
        End Get
        Set(value As String)
            Modelo = value
        End Set
    End Property

    Public Property PaisProcedencia1 As String
        Get
            Return PaisProcedencia
        End Get
        Set(value As String)
            PaisProcedencia = value
        End Set
    End Property

    Public Property Monto1 As Double
        Get
            Return Monto
        End Get
        Set(value As Double)
            Monto = value
        End Set
    End Property
End Class

Public Class Traccion
    Inherits Vehiculo
    Private NumeroMotor As String

    Public Property NumeroMotor1 As String
        Get
            Return NumeroMotor
        End Get
        Set(value As String)
            NumeroMotor = value
        End Set
    End Property
End Class

Public Class SinTraccion
    Inherits Vehiculo
    Private Descripcion As String

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property
End Class

Public Class Automovil
    Inherits Traccion

End Class

Public Class Utilitario
    Inherits Traccion

End Class

Public Class Motocicleta
    Inherits Traccion

End Class

