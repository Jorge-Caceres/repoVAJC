
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
    <title>Ciudades</title>


    <link href="https://fonts.googleapis.com/css?family=Krub" rel="stylesheet">

    <style>
            body{


        font-family: 'Krub', sans-serif;


            }
    </style>
</head>
<body>
    <div class="container">
        <h1 class="display-4">Manteninimiento de ciudades</h1>

        <a href="~/Ciudad/Create" class="btn btn-primary">Nueva Ciudad</a>
        <a href="~/Ciudad/Edit" class="btn btn-primary">Modificar Ciudad</a>
        <table width=50 class="table table-hover table-bordered">
            <thead class="thead-light">
                <tr>
                    <th>Codigo</th>
                    <th>Nombre</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                @For Each row In ViewData("listaCiudades")
                    @<tr>
                        <td>@row("CiudadId")</td>
                        <td>@row("Descripcion")</td>
                        <td>
                            <a href="~/Ciudad/Edit/@row("CiudadId")" class="btn btn-outline-warning">Modificar</a>
                            <a href="~/Ciudad/Delete/@row("CiudadId")" class="btn btn-outline-danger">Eliminar</a>
                        </td>
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
