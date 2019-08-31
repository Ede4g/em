DROP DATABASE IF EXISTS bdsysffarm;
CREATE DATABASE bdsysffarm;
USE bdsysffarm;

CREATE TABLE IF NOT EXISTS bdsysffarm.categorias (
	IDCategoria INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Nombre VARCHAR(50) NOT NULL,
	Descripcion TEXT NULL,
	PRIMARY KEY (IDCategoria)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.clientes(
	IDCliente INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Nombres VARCHAR(50) NOT NULL,
	Apellidos VARCHAR(50) NOT NULL,
	Direccion VARCHAR(200) NULL,
	Telefono VARCHAR(9) NULL,
	PRIMARY KEY (IDCliente)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.productos(
	IDProducto INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Nombre VARCHAR(50) NOT NULL,
	Alias VARCHAR(50) NULL DEFAULT NULL,
	Codigo VARCHAR(50) NOT NULL,
    Imagen LONGBLOB,
	Descripcion TEXT NULL,
	IDCategoria INT(10) NOT NULL,
	PrecioDeVenta DOUBLE(10,2) NOT NULL,
	Costo DOUBLE(10,2) NOT NULL,
	PRIMARY KEY (IDProducto),
	FOREIGN KEY (IDCategoria) REFERENCES bdsysffarm.categorias(IDCategoria)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`empleados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.empleados(
	IDEmpleado INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Nombres VARCHAR(50) NOT NULL,
	Apellidos VARCHAR(50) NOT NULL,
	Direccion VARCHAR(50) NULL,
	Telefono VARCHAR(9) NOT NULL,
	FechaNacimiento DATE NULL,
    Email VARCHAR(50) NOT NULL,
	Genero ENUM('Masculino', 'Femenino') NOT NULL,
    DUI VARCHAR(10) NOT NULL,
    Foto LONGBLOB,
	PRIMARY KEY (IDEmpleado)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`Fotosempleados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.fotosempleados(
	IDFotoEmpleado INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	IDEmpleado INT(10) NOT NULL,
    Foto LONGBLOB,
	Fecha DATE NULL,
	PRIMARY KEY (IDFotoEmpleado),
	FOREIGN KEY (IDEmpleado) REFERENCES bdsysffarm.empleados(IDEmpleado)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`facturasdeventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.facturasdeventas(
	IDFacturaDeVenta INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
    NumeroDeFactura INT(8) NOT NULL,
	Fecha DATETIME NOT NULL,
	FormaDePago ENUM('Efectivo', 'Cheque', 'Targeta') NOT NULL,
	TotalAPagar DOUBLE(10,2) NOT NULL,
	IDEmpleado INT(10) NOT NULL,
	IDCliente INT(10) NOT NULL,
	PRIMARY KEY (IDFacturaDeVenta),
    FOREIGN KEY (IDEmpleado) REFERENCES bdsysffarm.empleados(IDEmpleado),
    FOREIGN KEY (IDCliente) REFERENCES bdsysffarm.clientes(IDCliente)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`detallesfacturas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.detallesfacturas(
	IDDetallesFactura INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Cantidad INT(11) NOT NULL,
	Precio DOUBLE(10,2) NOT NULL,
	NombreProducto VARCHAR(50) NOT NULL,
	IDProducto INT(10) NOT NULL,
	IDFacturaDeVenta INT(10) NOT NULL,
	Exento DOUBLE(10,2) NOT NULL,
	Gravado DOUBLE(10,2) NOT NULL,
	NoSujeto DOUBLE(10,2) NOT NULL,
	PRIMARY KEY (IDDetallesFactura),
    FOREIGN KEY (IDProducto) REFERENCES bdsysffarm.productos(IDProducto),
    FOREIGN KEY (IDFacturaDeVenta) REFERENCES bdsysffarm.facturasdeventas(IDFacturaDeVenta)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`opciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.opciones(
	IDOpcion INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Opcion VARCHAR(50) NOT NULL,
	Clasificacion VARCHAR(50) NOT NULL,
	PRIMARY KEY (IDOpcion)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.roles(
	IDRol INT(10) NOT NULL AUTO_INCREMENT,
	Rol VARCHAR(50) NOT NULL,
	PRIMARY KEY (`IDRol`)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`permisos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.permisos(
	IDPermiso INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	IDRol INT(10) NOT NULL,
	IDOpcion INT(10) NOT NULL,
	PRIMARY KEY (IDPermiso),
    FOREIGN KEY (IDRol) REFERENCES bdsysffarm.roles(IDRol),
    FOREIGN KEY (IDOpcion) REFERENCES bdsysffarm.opciones(IDOpcion)
)ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdsysffarm`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS bdsysffarm.usuarios(
	IDUsuario INT(10) NOT NULL UNIQUE AUTO_INCREMENT,
	Usuario VARCHAR(50) NOT NULL,
	Credencial VARCHAR(100) NOT NULL,
    Estado ENUM('ACTIVO','INACTIVO') NOT NULL,
	IDEmpleado INT(10) NOT NULL,
	IDRol INT(10) NOT NULL,
	PRIMARY KEY (IDUsuario),
    FOREIGN KEY (IDRol) REFERENCES bdsysffarm.roles(IDRol)
)ENGINE = InnoDB;

insert into opciones (Opcion, Clasificacion) values ('INICIAR SESION','SISTEMA'),('GESTION USUARIO','SISTEMA'),('GESTION CLIENTE','SISTEMA'),('GESTION CATEGORIA','SISTEMA'),('GESTION EMPLEADO','SISTEMA'),('GESTION PRODUCTO','SISTEMA'),('GESTION ROL','SISTEMA'),('GESTION FACTURAS','SISTEMA'),('GESTION DE PERMISOS','SISTEMA'),('REPORTES','SISTEMA'),('AGREGAR CLIENTE','SISTEMA'),('EDITAR CLIENTE','SISTEMA'),('AGREGAR FACTURAS','SISTEMA'),('EDITAR FACTURAS','SISTEMA'),('ELIMINAR FACTURAS','SISTEMA');
INSERT INTO clientes VALUES (1,'Pamela','Castillo','Sonsonate','70207658'),(2,'Eduardo','Quele','Sonzacate','75645748'),(3,'Jose','Padilla','Izalco','78674536');
INSERT INTO empleados VALUES (1,'Gabriela','Torres','Apaneca','63456789','1995-04-23','torresgabriela@gmail.com','Femenino','897645321',NULL),(2,'Luis','Muños','Sonsonate','79685674','1976-09-06','muñosluis@gmail.com','Masculino','231456879',NULL),(3,'Carmina','Perla','Sonzacate','78657429','1898-02-12','perlacarmina@gmail.com','Femenino','451234786',NULL),(4,'Gavino','López','San Salvador','65342819','1993-11-01','lopezgavino@gmail.com','Masculino','985674321',NULL),(5,'Edgardo','Avila','Juayua','74658932','1974-10-30','avilaedgardo@gmail.com','Masculino','271654897',NULL);
INSERT INTO categorias VALUES (1,'Analgésicos','En este grupo de tipos de medicamentos se encuentran todos los fármacos que tienen como finalidad aliviar el dolor físico, ya sea de cabeza, de articulaciones o cualquiera.'),(2,'Antiácidos',' la disminución de las secreciones gástricas. Si disminuye la acidez, se previene la aparición de úlceras.'),(3,'Antialérgicos','En esta categoría se agrupan fármacos que tienen la finalidad de combatir los efectos negativos de las reacciones alérgicas o la hipersensibilidad.'),(4,'Laxantes','Los laxantes son tipos de medicamentos que tienen como propósito aliviar y detener los efectos de la diarrea.'),(5,'Antiinfecciosos','Este tipo de medicamentos están recetados para hacer frente a infecciones. Dependiendo del agente infeccioso, se clasifican en antibióticos (contra bacterias), antifúngicos (contra hongos), antivirales (contra virus) y antiparasitarios (contra parásitos).'),(6,'Antiinflamatorios','Como el propio nombre indica, son fármacos que tienen como finalidad reducir los efecto de la inflamación.'),(7,'Antipiréticos','Como el propio nombre indica, son fármacos que tienen como finalidad reducir los efecto de la inflamación.'),(8,'Mucolíticos','Son fármacos que se recetan para tratar de reducir la tos no productiva, es decir, que no libera mucosidad. '),(9,'Anticonvulsivos','Estos medicamentos se usan para tratar las convulsiones propias de la epilepsia y de otros trastornos, así como para el trastorno bipolar; esto se debe a sus efectos estabilizadores sobre el estado de ánimo.');
insert into productos values (1,'Paracetamol','PCetamol','p001',' ','El paracetamol parece funcionar en las partes del cerebro que reciben los mensajes de dolor.',1,0.50,1.00),(2,'Anti-inflamatorios no esteroides','AINE','a002',' ','Los AINE reducen el nivel de sustancias similares a las hormonas (llamadas prostaglandinas) que produce su cuerpo.',1,1.00,1.20);
insert into roles values (1,'ADMINISTRADOR'),(2,'VENDEDOR'),(3,'CAJERO');
insert into facturasdeventas values (1,0001,'2018-06-03','Efectivo',0.50,1,1);
insert into detallesfacturas values (1,2,0.50,'Paracetamol',1,1,0.00,0.50,0.00);
insert into usuarios values (1,'Pamela','12345','ACTIVO',1,1),(2,'Eduardo','1234','ACTIVO',1,1),(3,'William','123','ACTIVO',1,1);
update usuarios set Credencial=sha1('12345') where IDUsuario = 1;
update usuarios set Credencial=sha1('1234') where IDUsuario = 2;
update usuarios set Credencial=sha1('123') where IDUsuario = 3;
insert into permisos values (1,1,1);