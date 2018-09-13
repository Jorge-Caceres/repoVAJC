Imports ClasesGimnasio.Util


Public Class Ciudad

    Private CiudadId As Integer
    Private Descripcion As String

    Public Property CiudadId1 As Integer
        Get
            Return CiudadId
        End Get
        Set(value As Integer)
            CiudadId = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Public Function ObtenerCiudades() As DataTable
        Return gDatos.TraerDataTable("spConsultarCiudades")
    End Function

    Sub Eliminar()
        gDatos.Ejecutar("spEliminarCiudad", Me.CiudadId)
    End Sub

    Sub Guardar()
        gDatos.Ejecutar("spInsertarCiudad", Me.Descripcion)
    End Sub

    Sub Actualizar()
        gDatos.Ejecutar("spActualizarCiudad", Me.CiudadId, Me.Descripcion)
    End Sub

    Public Function ObtenerCiudad(codigo As Integer) As Ciudad
        Dim tabla As New DataTable

        tabla = gDatos.TraerDataTable("spConsultarCiudadPorCodigo", codigo)

        If tabla.Rows.Count > 0 Then
            Dim vCiudad As New Ciudad
            ''se pasa de la tabla temporal a cada propiedad del objeto y luego retorno este objeto
            vCiudad.CiudadId = tabla.Rows(0).Item("CiudadId")
            vCiudad.Descripcion = tabla.Rows(0).Item("Descripcion")
            Return vCiudad
        Else
            Return Nothing
        End If

    End Function
End Class
