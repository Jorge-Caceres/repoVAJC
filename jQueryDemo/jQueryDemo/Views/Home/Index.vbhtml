
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
    <input type="button" value="Calcular" onclick="javascript:Calcular()"/>
    
    <script src="~/scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        function Calcular() {
            alert("Prueba de JS");
            alert($("#valor1").val());
            $("#valor2").val(150);

        }
    </script>
</body>
</html>
