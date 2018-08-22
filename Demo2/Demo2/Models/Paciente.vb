Public Class Paciente

    'atributos
    Private Nombre As String
    Private Edad As Integer
    Private CI As String
    Private Sexo As String
    Private Peso As Double
    Private Altura As Double

    'properties

    Public Property pNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property pEdad As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property

    Public Property pCI As String
        Get
            Return CI
        End Get
        Set(value As String)
            CI = value
        End Set
    End Property

    Public Property pSexo As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
        End Set
    End Property

    Public Property pPeso As Double
        Get
            Return Peso
        End Get
        Set(value As Double)
            Peso = value
        End Set
    End Property

    Public Property pAltura As Double
        Get
            Return Altura
        End Get
        Set(value As Double)
            Altura = value
        End Set
    End Property
    'metodos

    Public Function CalcularIMC() As String
        Dim imc As Decimal = 0
        Dim retorno As String = ""
        imc = Me.Peso / (Me.Altura ^ 2)
        Select Case imc
            Case < 20
                retorno = "Usted es delgado"
            Case 20 To 25
                retorno = "Usted està en su Peso ideal"
            Case > 25
                retorno = "Usted tiene Sobrepeso"
        End Select
        Return retorno

    End Function




End Class
