<!DOCTYPE html> 
<html> 
    <head> 
        <meta charset="utf-8"> 
        <title>proceso ejercicio 1</title> 
    </head> 
    <body>  
        <?php   
        //Captura de datos del form    
        echo "El nombre ingresado es:";  
        echo $_REQUEST['nombre']; 
        echo "<br>";
        echo "El apellido ingresado es:";  
        echo $_REQUEST['apellido'];
        echo "<br>";
        echo "El usuario ingresado es:";  
        echo $_REQUEST['usuario'];
        echo "<br>";
        echo "la contraseña ingresada es:";  
        echo $_REQUEST['password'];
        ?> 
    </body> 
</html>