<?php
	include "config_mysql.php"; 
	//conectarse con la base de datos
	function conectar(){   
	$dbconn = new mysqli(localhost,root,pass,poma);     
	if ($dbconn->connect_errno) { 
	 echo "Fallo al conectar a MySQL: 
	 (" . $dbconn->connect_errno . ") " . $dbconn->connect_error; 
	} 
  
	return $dbconn; 
	} 
	//$conexion=conecta();
	//echo $conexion->host_info;
?>