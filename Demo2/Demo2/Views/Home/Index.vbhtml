
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Calculo IMC</title>
    <style>
        body {
            background-color: aliceblue;
            font-family: 'Gill Sans', 'Gill Sans MT','Trebuchet MS';
            color: black;
        }

        div {
            background-color: aliceblue;
            margin: auto;
        }

        table {
            background-color: azure;
        }
    </style>
</head>
<body>
    <h1>Datos del paciente</h1>
    <div>
        <form action="Paciente/CalculoIMC" method="post">
            <table>
                <tr>
                    <td>
                        Nombre:
                    </td>
                    <td>
                        <input type="text" name="txtNombre" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Sexo:
                    </td>
                    <td>
                        <input type="text" name="txtSexo" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Peso:
                    </td>
                    <td>
                        <input type="text" name="txtPeso" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Altura:
                    </td>
                    <td>
                        <input type="text" name="txtAltura" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Cedula:
                    </td>
                    <td>
                        <input type="text" name="txtCi" />
                    </td>
                </tr>
                <tr>
                    <input type="submit" value="Calcular" />

                </tr>
            </table>
        </form>
    </div>
</body>
</html>
