Imports System.Web.Mvc

Namespace Controllers
    Public Class IndexController
        Inherits Controller

        ' GET: Index
        Function Index() As ActionResult
            Return View()
        End Function

        Function CalcularImpuesto(form As FormCollection) As ActionResult

        End Function
    End Class
End Namespace