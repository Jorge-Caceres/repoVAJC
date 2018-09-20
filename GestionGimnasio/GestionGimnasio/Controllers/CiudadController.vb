Imports System.Web.Mvc
Imports ClasesGimnasio
Namespace Controllers
    Public Class CiudadController
        Inherits Controller

        ' GET: Ciudad
        Function Index() As ActionResult
            Dim tabla As New DataTable
            Dim ciudad As New Ciudad

            tabla = ciudad.ObtenerCiudades()
            ''funcion para convertir una tabla en una lista ASENUMERABLE
            ViewData("listaCiudades") = tabla.AsEnumerable

            Return View()
        End Function

        ''accion que llama a la vista que carga nuevas ciudades
        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            Dim ciudad As New Ciudad
            ''se carga la propiedad del objeto ciudad 
            ciudad.Descripcion1 = form("txtCiudad")
            ''se llama al metodo que a su vez llama al procedimiento de almacenado
            ciudad.Guardar()
            ''se redirecciona a la accion index
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim ciudad As New Ciudad

            ciudad = ciudad.ObtenerCiudad(id)

            Return View(ciudad)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            Dim ciudad As New Ciudad
            ''se cargan las propiedades del objeto ciudad 
            ciudad.Descripcion1 = form("txtCiudad")
            ciudad.CiudadId1 = form("id")
            ''se llama al metodo que a su vez llama al procedimiento de almacenado
            ciudad.Actualizar()
            ''se redirecciona a la accion index
            Return RedirectToAction("Index")
        End Function

        Function Delete(id As Integer) As ActionResult
            Dim ciudad As New Ciudad
            ciudad.CiudadId1 = id
            ciudad.Eliminar()

            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace