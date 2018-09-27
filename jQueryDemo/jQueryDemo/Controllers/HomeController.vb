Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function

        Function Calcular(valor1 As Integer, valor2 As Integer) As ActionResult
            Dim vSuma As Integer

            vSuma = valor1 + valor2
            ''se retorna el contenido y dentro va el resultado de esta suma
            Return Content(vSuma)
        End Function
    End Class
End Namespace