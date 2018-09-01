Imports System.Web.Mvc

Namespace Controllers
    Public Class VehiculoController
        Inherits Controller

        ' GET: Vehiculo
        Function Index() As ActionResult
            Return View()
        End Function

        Function CalcularMonto(form As FormCollection) As ActionResult

            Dim Monto As Decimal

            If form("cboTipo") = "T" Then
                If form("cboConT") = "A" Then
                    Dim vehiculo As New Automovil
                    With vehiculo
                        .CodPlaca1 = form("placa")
                        .Marca1 = form("marca")
                        .NumeroChasis1 = form("chasis")
                        .PaisProcedencia1 = form("cboProc")
                        .NumeroMotor1 = form("motor")
                        .Modelo1 = form("modelo")
                        .CalcularImpuesto()
                    End With
                    Monto = vehiculo.Monto1

                ElseIf form("cboConT") = "U" Then
                    Dim vehiculo As New Utilitario
                    With vehiculo
                        .CodPlaca1 = form("placa")
                        .Marca1 = form("marca")
                        .NumeroChasis1 = form("chasis")
                        .PaisProcedencia1 = form("cboProc")
                        .NumeroMotor1 = form("motor")
                        .Modelo1 = form("modelo")
                        .CalcularImpuesto()
                    End With
                    Monto = vehiculo.Monto1

                Else
                    Dim vehiculo As New Motocicleta
                    With vehiculo
                        .CodPlaca1 = form("placa")
                        .Marca1 = form("marca")
                        .NumeroChasis1 = form("chasis")
                        .PaisProcedencia1 = form("cboProc")
                        .NumeroMotor1 = form("motor")
                        .Modelo1 = form("modelo")
                        .CalcularImpuesto()

                    End With
                    Monto = vehiculo.Monto1
                End If

            Else
                Dim vehiculo As New SinTraccion
                With vehiculo
                    .CodPlaca1 = form("placa")
                    .Marca1 = form("marca")
                    .NumeroChasis1 = form("chasis")
                    .PaisProcedencia1 = form("cboProc")
                    .Modelo1 = form("modelo")
                    .Descripcion1 = form("descripcion")
                    .CalcularImpuesto()
                End With
                Monto = vehiculo.Monto1

            End If

            ViewData("CodPlaca") = form("placa")
            ViewData("Monto") = Monto

            Return View()
        End Function
    End Class
End Namespace