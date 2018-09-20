
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Edit</title>
</head>
<body>
    <h1>Formulario para modificar una ciudad</h1>
<form method="post" action="Ciudad/Edit">
    <input type="hidden" name="id" value="@Model.CiudadId1" />    
    Ciudad:
    <input type="text" name="txtCiudad" value="@Model.Descripcion1"/>
    <br /><br />
    <input type="submit" value="Modificar" />
</form>
</body>
</html>
