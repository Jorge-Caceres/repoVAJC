
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <style>
    body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;}

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

input[type=submit] {
    background-color: #4CAF50;
    color: white;
    padding: 12px 20px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}input[type=reset] {
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
    </style><title>Registrar corredor</title>
</head>
<body>
    <div class="container">
        <form method="post" action="CalcularMontoInscripcion">
           Nombre del Corredor<input type="text" name="nombre" placeholder="Ingrese su nombre" />

                    Numero de documento<input type="text" name="documento" placeholder="Ingrese su documento" />
                    Numero de corredor<input type="text" name="numero" placeholder="Ingrese su numero de corredor" />
                    Fecha de nacimiento<input type="text" name="fecha" /><br />
                    Nacionalidad
                            <select name="cboNacionalidad">
                            <option value="Paraguaya">Paraguaya</option>
                            <option value="Argentina">Argentina</option>
                            <option value="Brasilera">Brasilera</option>
                        </select>
                    
                   Sexo
                        <select name="cboSexo">
                            <option value="M">Masculino</option>
                            <option value="F">Femenino</option>
                        </select>

                    Hotel:<input type="text" name="hotel" placeholder="Ingrese el hotel donde se hospeda  " />
                    
                    Email: <input type="text" name="email" placeholder="Ingrese se email" />
                    
                   Telefono: <input type="text" name="telefono" placeholder="Ingrese su telefono" />
                    <input type="submit" value="Calcular Monto" />
                    <input type="reset" value="Reset campos" />
        </form>
    </div>

</body>
</html>
