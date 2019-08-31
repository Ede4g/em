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
    Estado INT(1) NOT NULL,
	IDEmpleado INT(10) NOT NULL,
	IDRol INT(10) NOT NULL,
	PRIMARY KEY (IDUsuario),
    FOREIGN KEY (IDRol) REFERENCES bdsysffarm.roles(IDRol)
)ENGINE = InnoDB;