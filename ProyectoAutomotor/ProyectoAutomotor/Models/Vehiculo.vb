Public MustInherit Class Vehiculo

    Protected CodPlaca As String
    Protected NumeroChasis As String
    Protected Marca As String
    Protected Modelo As Integer
    Protected PaisProcedencia As String
    Protected Monto As Decimal

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

    Public Property Modelo1 As Integer
        Get
            Return Modelo
        End Get
        Set(value As Integer)
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

    Public Property Monto1 As Decimal
        Get
            Return Monto
        End Get
        Set(value As Decimal)
            Monto = value
        End Set
    End Property

    Public Overridable Sub CalcularImpuesto()
        ''Se define como procedimiento para poder usar la propiedad en las clases hijas y devolver su impuesto 
        Select Case Me.Modelo
            Case 1950 To 1970
                Monto1 = 300000
            Case 1971 To 1990
                Monto1 = 450000
            Case 1991 To 2002
                Monto1 = 650000
            Case Is > 2002
                Monto1 = 105000
        End Select
    End Sub


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

    Public Function CalcularImpuestoST() As Decimal
        Dim vImpuestoTotal As Decimal
        MyBase.CalcularImpuesto()
        vImpuestoTotal = Monto1 * 1.01
        Return vImpuestoTotal
    End Function

End Class

Public Class Automovil
    Inherits Traccion

    Public Function CalcularImpuestoT() As Decimal

        Dim vMontoRecargado As Decimal
        CalcularImpuesto()
        vMontoRecargado = Monto1 * 1.3
        Return vMontoRecargado
    End Function

End Class

Public Class Utilitario
    Inherits Traccion
    Public Function CalcularImpuestoT() As Decimal

        Dim vMontoRecargado As Decimal
        MyBase.CalcularImpuesto()
        vMontoRecargado = Monto1 * 1.1
        Return vMontoRecargado
    End Function

End Class

Public Class Motocicleta
    Inherits Traccion

End Class

