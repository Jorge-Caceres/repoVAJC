
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Krub" rel="stylesheet">

    <style>
        body {
            font-family: 'Krub', sans-serif;
        }
    </style>



    <meta name="viewport" content="width=device-width" />
    <title>Agregar ciudad</title>
</head>
<body>
    <div class="container">
        <h1>Formulario para agregar una ciudad</h1>
        <form method="post" action="~/Ciudad/Create">
            <div class="form-group">
                Ciudad:
                <input class="form-control col-md-6 col-lg-4 col-sm-4" type="text" name="txtCiudad" required placeholder="Ingrese el nombre de la ciudad" />
            </div>
            <br /><br />
            <input class="btn btn-primary col-lg-2 col-sm-12 col-md-6" type="submit" value="Guardar" />

        </form>
    </div>

    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
