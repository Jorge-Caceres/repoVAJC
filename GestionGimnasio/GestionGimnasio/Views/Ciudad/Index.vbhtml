
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
    <table width=50>
        <tr>
            <th>Codigo</th>
            <th>Nombre</th>
        </tr>
            @For Each row In ViewData("listaCiudades")
                @<tr>
                    <td>@row("CiudadId")</td>
                    <td>@row("Descripcion")</td>
                 </tr>
            Next
     </table>
</body>
</html>
