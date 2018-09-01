Imports System.Web.Mvc

Namespace Controllers
    Public Class VehiculoController
        Inherits Controller

        ' GET: Vehiculo
        Function Index() As ActionResult
            Return View()
        End Function

        Function CalcularMonto(form As FormCollection) As ActionResult

        End Function
    End Class
End Namespace