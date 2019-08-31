<?php include "funciones_mysql.php"; 
function insertar(){
	$conexion = conectar();
	INSERT INTO nombre_de_Tabla(campos) VALUES (valores);
	$sql = "INSERT INTO roles(Rol) VALUES(?)";
	$rol = $_REQUEST["rol"]; 
	$sql = "INSERT INTO roles(Nivel) VALUES(?)";
	$rol = $_REQUEST["Nivel"]; 
	$sql = "INSERT INTO roles(Descripcion) VALUES(?)";
	$rol = $_REQUEST["Descripcion"]; 
	$stm = $conexion->prepare($sql);
	$stm->bind_param("s",$rol); 


}
 	
?> 