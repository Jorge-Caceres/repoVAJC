Imports System.Web.Mvc
Imports ClasesGimnasio
Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            ''se inicializa la conexion a la BD
            Util.inicializaSesion("M203-13", "Gym", "sa", "@lumno123")

            Return View()
        End Function
    End Class
End Namespace