
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Agregar ciudad</title>
</head>
<body>
    <h1>Formulario para agregar una ciudad</h1>
    <form method="post" action="~/Ciudad/Create">
        Ciudad:
        <input type="text" name="txtCiudad" placeholder="Ingrese el nombre de la ciudad"/>
        <br /><br />
        <input type="submit" value="Guardar"/>
    </form>
</body>
</html>
