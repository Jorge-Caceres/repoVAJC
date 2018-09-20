
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Ciudades</title>
    <style>
       body {
    background-color: lightblue;
}
table {
    border-collapse: collapse;
    width: 50%;
    font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    table-layout: fixed;

}

th, td {
    text-align: left;
    padding: 8px;
}

tr:nth-child(even){background-color: #f2f2f2}

th {
    background-color: #4CAF50;
    color: white;
}
        </style>
</head>
<body>
    <h1>Manteninimiento de ciudades</h1>

    <a href="~/Ciudad/Create">Nueva Ciudad</a>
    <a href="~/Ciudad/Edit">Modificar Ciudad</a>
    <table width=50>
        <tr>
            <th>Codigo</th>
            <th>Nombre</th>
        </tr>
            @For Each row In ViewData("listaCiudades")
                @<tr>
                    <td>@row("CiudadId")</td>
                    <td>@row("Descripcion")</td>
                    <td><a href="~/Ciudad/Edit/@row("CiudadId")">Modificar</a></td>
                    <td>><a href="~/Ciudad/Delete/@row("CiudadId")">Eliminar</a></td>
                 </tr>
            Next
     </table>
</body>
</html>
