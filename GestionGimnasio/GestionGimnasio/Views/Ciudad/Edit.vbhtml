
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />

    <meta name="viewport" content="width=device-width" />
    <title>Edit</title>
</head>
<body>
    <div class="container">

        <h1>Formulario para modificar una ciudad</h1>
        <form method="post" action="~/Ciudad/Edit">
            <div class="form-group">
                <input type="hidden" name="id" value="@Model.CiudadId1" />
                Ciudad:
                <input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="txtCiudad" value="@Model.Descripcion1" />
                <br /><br />
                <input class="btn btn-primary col-md-6 col-lg-2 col-sm-2" type="submit" value="Modificar" />
        </form>
    </div>

    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
