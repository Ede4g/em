-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema BDSYSFFARM
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema BDSYSFFARM
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `BDSYSFFARM` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `BDSYSFFARM` ;

-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Empleados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Empleados` (
  `IDEmpleado` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Nombres` VARCHAR(50) NOT NULL COMMENT '',
  `Apellidos` VARCHAR(50) NOT NULL COMMENT '',
  `Direccion` VARCHAR(50) NULL COMMENT '',
  `Telefono` VARCHAR(50) NOT NULL COMMENT '',
  `FechaNacimiento` DATE NULL COMMENT '',
  `Genero` ENUM('Masculino', 'Femenino') NULL COMMENT '',
  PRIMARY KEY (`IDEmpleado`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Roles` (
  `IDRol` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Rol` VARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`IDRol`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Usuarios` (
  `IDUsuario` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Usuario` VARCHAR(50) NOT NULL COMMENT '',
  `Credencial` VARCHAR(100) NOT NULL COMMENT '',
  `IDEmpleado` INT NOT NULL COMMENT '',
  `IDRol` INT NOT NULL COMMENT '',
  PRIMARY KEY (`IDUsuario`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Opciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Opciones` (
  `IDOpcion` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Opcion` VARCHAR(50) NOT NULL COMMENT '',
  `Clasificacion` VARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`IDOpcion`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Permisos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Permisos` (
  `IDPermiso` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `IDRol` INT NOT NULL COMMENT '',
  `IDOpcion` INT NOT NULL COMMENT '',
  PRIMARY KEY (`IDPermiso`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Clientes` (
  `IDCliente` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Nombres` VARCHAR(50) NOT NULL COMMENT '',
  `Apellidos` VARCHAR(50) NOT NULL COMMENT '',
  `Direccion` VARCHAR(200) NULL COMMENT '',
  `Telefono` VARCHAR(8) NULL COMMENT '',
  PRIMARY KEY (`IDCliente`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`FacturasDeVentas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`FacturasDeVentas` (
  `IDFacturaDeVenta` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Fecha` DATE NOT NULL COMMENT '',
  `FormasDePago` ENUM('Efectivo', 'Cheque', 'Tarjeta') NULL COMMENT '',
  `IDCliente` INT NOT NULL COMMENT '',
  `IDEmpleado` INT NOT NULL COMMENT '',
  `TotalAPagar` DECIMAL(10,2) NOT NULL COMMENT '',
  PRIMARY KEY (`IDFacturaDeVenta`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Categorias` (
  `IDCategoria` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Nombre` VARCHAR(50) NOT NULL COMMENT '',
  `Descripcion` TEXT NULL COMMENT '',
  PRIMARY KEY (`IDCategoria`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`Productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`Productos` (
  `IDProducto` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Nombre` VARCHAR(50) NOT NULL COMMENT '',
  `Alias` VARCHAR(50) NULL COMMENT '',
  `Codigo` VARCHAR(50) NOT NULL COMMENT '',
  `Descripcion` TEXT NULL COMMENT '',
  `IDCategoria` INT NOT NULL COMMENT '',
  `PrecioDeVenta` INT NOT NULL COMMENT '',
  `Costo` DECIMAL(10,2) NOT NULL COMMENT '',
  PRIMARY KEY (`IDProducto`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BDSYSFFARM`.`DetallesFacturas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BDSYSFFARM`.`DetallesFacturas` (
  `IDDetallesFactura` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
  `Cantidad` INT NOT NULL COMMENT '',
  `Precio` DOUBLE(10,2) NOT NULL COMMENT '',
  `NombreProducto` VARCHAR(50) NOT NULL COMMENT '',
  `IDProducto` INT NOT NULL COMMENT '',
  `IDFacturaDeVenta` INT NOT NULL COMMENT '',
  `Descripcion` TEXT NULL COMMENT '',
  `Excento` DOUBLE(10,2) NULL COMMENT '',
  `Gravado` DOUBLE(10,2) NULL COMMENT '',
  `NoSujeto` DOUBLE(10,2) NULL COMMENT '',
  `MontoDeIVA` DECIMAL(10,2) NOT NULL COMMENT '',
  `SubTotal` DOUBLE(10,2) NOT NULL COMMENT '',
  PRIMARY KEY (`IDDetallesFactura`)  COMMENT '')
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
