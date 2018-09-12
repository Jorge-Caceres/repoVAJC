
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>CalcularMonto</title>
</head>
<body>
    <h2>Placa</h2>
    @ViewData("CodPlaca")
    <h2>Monto a pagar</h2>
    @ViewData("Monto")
</body>
</html>
