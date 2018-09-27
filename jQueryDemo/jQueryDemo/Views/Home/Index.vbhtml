
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <h1>Calculadora de prueba jQuery</h1>
    Valor 1:<input type="text" id="valor1" />
    <br /><br />
    Valor 2:<input type="text" id="valor2" />
    
    <br /><br />
    Resultado: <input type="text" id="resultado" />
    <br /><br />
    <table>
        <tr>
            <td id="titulo"></td>
        </tr>
    </table>
        <br /><br />
    <input type="button" value="Calcular" onclick="javascript:Calcular()" />
    <script src="~/scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        function Calcular() {
            //alert("Prueba de JS");
            //alert($("#valor1").val());
            //$("#valor2").val(150);

            $.ajax({
                //La url para la petición
                url: '/Home/Calcular',
                //Definimos parametros que se va enviar
                data: { valor1: $("#valor1").val(), valor2: $("#valor2").val() },
                //La forma de envio Post o get
                type: 'GET',
                //El tipo de dato de dato que va retornar la acción
                dateType: 'json',
                success: function (retorno) {
                    $("#resultado").val(retorno);
                    $("#titulo").html("<td>" + retorno+"</td>");
                }
            })//fin del ajax
        }//fin de la funcion JS
    </script>
</body>
</html>
