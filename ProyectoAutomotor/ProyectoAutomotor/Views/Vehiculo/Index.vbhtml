
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        * {
            box-sizing: border-box;
        }

        input[type=text], select, textarea {
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-top: 6px;
            margin-bottom: 16px;
            resize: vertical;
        }
        input[type=number], select, textarea {
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-top: 6px;
            margin-bottom: 16px;
            resize: vertical;
        }

        input[type=submit] {
            background-color: #4CAF50;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type=reset] {
            background-color: #4CAF50;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type=submit]:hover {
            background-color: #45a049;
        }

        .container {
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 20px;
        }
    </style>
    <title>Index</title>
</head>
<body>
    <div class="container">
        <form method="post" action="CalcularMontoPagar">
            <h3>Datos del vehiculo</h3>
            Tipo Vehiculo<select name="cboTipo" required>
                <option value="T">Con Traccion</option>
                <option value="ST">Sin Traccion</option>
            </select>

            Tipo Vehiculo CON TRACCION <select name="cboConT" required>
                <option value="A">Automovil</option>
                <option value="U">Utilitario</option>
                <option value="M">Motocicleta</option>
            </select>

            Modelo<input type="number" name="modelo" min="1950" max="2019"/>

            Nº Chasis<input type="text" name="chasis" placeholder="Ingrese el numero de chasis" required maxlength="50" />

            Cod. Placa<input type="text" name="placa" placeholder="Ingrese el codigo de la placa" required maxlength="6" />
            
            Procedencia<select name="cboProc" required>
                <option value="J">Japon</option>
                <option value="B">Brasil</option>
                <option value="A">Alemania</option>
            </select>
            
            Marca<input type="text" name="marca" placeholder="Ingrese la marca" required maxlength="30" />

            Nº Motor<input type="text" name="motor" placeholder="Ingrese el numero de motor" required maxlength="30" />
            
            Descripcion<input type="text" name="descripcion" placeholder="Ingrese descripcion" required maxlength="50" />
                        
            
            <input type="submit" value="Calcular"/>
            <input type="reset" value="Reset campos" />
        </form>
    </div>
</body>
</html>
