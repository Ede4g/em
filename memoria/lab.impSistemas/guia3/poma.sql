-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Sep 08, 2018 at 10:32 AM
-- Server version: 5.7.21
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `poma`
--

-- --------------------------------------------------------

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
CREATE TABLE IF NOT EXISTS `alumno` (
  `id_Alumno` int(11) NOT NULL,
  `Nombres` varchar(30) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `Fecha_nac` date NOT NULL,
  `Escuela` varchar(50) NOT NULL,
  `Grado` varchar(10) NOT NULL,
  `genero` varchar(2) NOT NULL,
  `Fecha_ingreso` date NOT NULL,
  PRIMARY KEY (`id_Alumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
CREATE TABLE IF NOT EXISTS `asistencia` (
  `id_Asistencia` int(11) NOT NULL,
  `id_Alumno` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `Estado` varchar(1) NOT NULL,
  PRIMARY KEY (`id_Asistencia`),
  KEY `id_Alumno` (`id_Alumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE IF NOT EXISTS `roles` (
  `id_Rol` int(11) NOT NULL,
  `rol` varchar(15) NOT NULL,
  PRIMARY KEY (`id_Rol`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id_Usuario` int(11) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  `Clave` varchar(200) NOT NULL,
  `id_Rol` int(11) NOT NULL,
  `id_Maestro` int(11) NOT NULL,
  `id_Alumno` int(11) NOT NULL,
  PRIMARY KEY (`id_Usuario`),
  KEY `id_Rol` (`id_Rol`),
  KEY `id_Maestro` (`id_Maestro`),
  KEY `id_Alumno` (`id_Alumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `vaiticos`
--

DROP TABLE IF EXISTS `vaiticos`;
CREATE TABLE IF NOT EXISTS `vaiticos` (
  `id_Viaticos` int(11) NOT NULL,
  `id_Alumno` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `Estado` varchar(1) NOT NULL,
  PRIMARY KEY (`id_Viaticos`),
  KEY `id_Alumno` (`id_Alumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `asistencia`
--
ALTER TABLE `asistencia`
  ADD CONSTRAINT `asistencia_ibfk_1` FOREIGN KEY (`id_Alumno`) REFERENCES `alumno` (`id_Alumno`);

--
-- Constraints for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`id_Maestro`) REFERENCES `roles` (`id_Rol`);

--
-- Constraints for table `vaiticos`
--
ALTER TABLE `vaiticos`
  ADD CONSTRAINT `vaiticos_ibfk_1` FOREIGN KEY (`id_Alumno`) REFERENCES `alumno` (`id_Alumno`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
