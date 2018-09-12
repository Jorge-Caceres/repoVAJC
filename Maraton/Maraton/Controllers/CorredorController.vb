Imports System.Web.Mvc

Namespace Controllers
    Public Class CorredorController
        Inherits Controller

        ' GET: Corredor
        Function Index() As ActionResult
            Return View()
        End Function

        Function CalcularMontoInscripcion(form As FormCollection) As ActionResult
            Dim vMonto As Double
            Dim aficionado As New Aficionado
            Dim elite As New Elite


            ''determinar el tipo de corredor
            If form("numero") > 50 Then
                Aficionado.Email1 = form("email")
                Aficionado.FechaNacimiento1 = form("fecha")
                aficionado.Telefono1 = form("telefono")
                aficionado.Nombre1 = form("nombre")
                aficionado.Nacionalidad1 = form("cboNacionalidad")
                aficionado.Sexo1 = form("cboSexo")
                aficionado.NroDocumento1 = form("documento")
                vMonto = aficionado.GetMontoInscripcion()
            Else
                Elite.Hotel1 = form("hotel")
                Elite.FechaNacimiento1 = form("fecha")
                elite.Nombre1 = form("nombre")
                elite.Nacionalidad1 = form("cboNacionalidad")
                elite.Sexo1 = form("cboSexo")
                elite.NroDocumento1 = form("documento")
                vMonto = elite.GetMontoInscripcion()
            End If
            ViewData("Monto") = vMonto
            ViewData("Nombre") = form("nombre")
            Return View()
        End Function
    End Class
End Namespace