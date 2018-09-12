Public Class Estacionamiento


    Private Cliente As String
    Private Horas As Integer
    Private Fecha As Date

    Public Property Cliente1 As String
        Get
            Return Cliente
        End Get
        Set(value As String)
            Cliente = value
        End Set
    End Property

    Public Property Horas1 As Integer
        Get
            Return Horas
        End Get
        Set(value As Integer)
            Horas = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

    Public Function CalcularMonto() As Integer
        '' Crea un programa que calcule el costo del estacionamiento en un parking de modo que las 3 primeras horas se cobran a 15.000 Gs. y las siguientes a 7.000 Gs. Si permanece estacionado más de un día se cobrarían 100.000 Gs. al día y 5000 las horas siguientes. Se debe ingresar la cantidad de horas, el nombre del cliente y la fecha actual.Mostrar el precio del estacionamiento.

        ''
        Dim vMonto As Integer
        Dim vDias As Integer
        Dim resto As Decimal
        Select Case Horas1
            Case 1 To 3
                vMonto = Horas1 * 15000
            Case 4 To 23
                vMonto = 45000
                vMonto = vMonto + ((Horas1 - 3) * 7000)
            Case = 24
                vMonto = 100000
            Case > 24
                vDias = Me.Horas / 24
                resto = Horas Mod 24
                vMonto = resto * 5000
        End Select

        Return vMonto
    End Function
End Class
