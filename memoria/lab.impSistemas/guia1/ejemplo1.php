<html>
    <head>
        <title>Uso del if simple</title>
    </head>
    <body>
        <form action="ejemplo_if_.php" method="post">
            Nombre: <input type="text" name="Nombre"/><br/>
            <input type="submit" value="Enviar"/><br/>
        </form>
        <?php
             if(isset($_POST['nombre']))
             {
                 echo"Bienvenido".$_POST['nombre'];
             }
             else
                {
                    echo"bienvenido desconocido";
                }
        
        ?>
    </body>
</html>