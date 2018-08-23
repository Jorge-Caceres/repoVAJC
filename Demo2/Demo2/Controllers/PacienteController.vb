Imports System.Web.Mvc


Namespace Controllers
    Public Class PacienteController
        Inherits Controller

        ' GET: Paciente
        Function Index() As ActionResult
            Return View()
        End Function

        Function CalculoIMC(form As FormCollection) As ActionResult

            Dim vPaciente As New Paciente

            vPaciente.pAltura = form("txtAltura")
            vPaciente.pCI = form("txtCi")
            vPaciente.pNombre = form("txtNombre")
            vPaciente.pEdad = form("txtEdad")
            vPaciente.pPeso = form("txtPeso")
            vPaciente.pSexo = form("txtSexo")

            ViewData("Nombre") = vPaciente.pNombre
            ViewData("EstadoPaciente") = vPaciente.CalcularIMC()
            Return View()
        End Function
    End Class
End Namespace