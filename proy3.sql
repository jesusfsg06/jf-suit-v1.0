/*
SQLyog Community Edition- MySQL GUI v8.05 
MySQL - 5.5.32 : Database - proyecto3
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`proyecto3` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `proyecto3`;

/*Table structure for table `pr_abogados` */

DROP TABLE IF EXISTS `pr_abogados`;

CREATE TABLE `pr_abogados` (
  `cedula` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `genero` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `contacto` varchar(20) DEFAULT NULL,
  `pais` varchar(25) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `municipio` varchar(50) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `estado_civil` int(11) DEFAULT NULL,
  `oficialia_civil` varchar(50) DEFAULT NULL,
  `fizcalia` varchar(50) DEFAULT NULL,
  `notas` varchar(255) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pr_alquiler` */

DROP TABLE IF EXISTS `pr_alquiler`;

CREATE TABLE `pr_alquiler` (
  `alquiler_Id` int(11) NOT NULL AUTO_INCREMENT,
  `cedula_c` varchar(50) DEFAULT NULL,
  `nombre_c` varchar(50) DEFAULT NULL,
  `apellido_c` varchar(50) DEFAULT NULL,
  `genero_c` varchar(50) DEFAULT NULL,
  `telefono_c` varchar(50) DEFAULT NULL,
  `celular_c` varchar(50) DEFAULT NULL,
  `direccion_c` varchar(50) DEFAULT NULL,
  `estado_civil_c` varchar(50) DEFAULT NULL,
  `cedula_i` varchar(50) DEFAULT NULL,
  `nombre_i` varchar(50) DEFAULT NULL,
  `apellido_i` varchar(50) DEFAULT NULL,
  `genero_i` varchar(50) DEFAULT NULL,
  `telefono_i` varchar(50) DEFAULT NULL,
  `celular_i` varchar(50) DEFAULT NULL,
  `direccion_i` varchar(50) DEFAULT NULL,
  `estado_civil_i` varchar(50) DEFAULT NULL,
  `cedula_g` varchar(50) DEFAULT NULL,
  `nombre_g` varchar(50) DEFAULT NULL,
  `apellido_g` varchar(50) DEFAULT NULL,
  `genero_g` varchar(50) DEFAULT NULL,
  `telefono_g` varchar(50) DEFAULT NULL,
  `celular_g` varchar(50) DEFAULT NULL,
  `direccion_g` varchar(50) DEFAULT NULL,
  `estado_civil_g` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `actual` varchar(50) DEFAULT NULL,
  `contrato` varchar(50) DEFAULT NULL,
  `alquiler` decimal(11,2) DEFAULT '0.00',
  `impuesto` decimal(11,2) DEFAULT NULL,
  `deposito` decimal(11,2) DEFAULT '0.00',
  `vigencia` varchar(50) DEFAULT NULL,
  `servicio_total` decimal(11,2) DEFAULT '0.00',
  `servicio_mensual` decimal(11,2) DEFAULT '0.00',
  `notario` varchar(50) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`alquiler_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_clientes` */

DROP TABLE IF EXISTS `pr_clientes`;

CREATE TABLE `pr_clientes` (
  `client_Id` int(11) NOT NULL AUTO_INCREMENT,
  `no` int(11) DEFAULT NULL,
  `cedula` varchar(50) DEFAULT NULL,
  `pasaporte` varchar(50) DEFAULT NULL,
  `img` longblob,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `apodo` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `nacimiento` varchar(50) DEFAULT NULL,
  `genero` varchar(50) DEFAULT NULL,
  `contacto` varchar(20) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `pais` varchar(50) DEFAULT NULL,
  `sector` varchar(50) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `tel_trabajo` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `estado_civil` varchar(20) DEFAULT NULL,
  `empresa` varchar(50) DEFAULT NULL,
  `direccion_trabajo` varchar(50) DEFAULT NULL,
  `oficialia_civil` varchar(50) DEFAULT NULL,
  `trabajo_realizar` varchar(50) DEFAULT NULL,
  `costo_servicio` varchar(50) DEFAULT NULL,
  `abonos` decimal(11,2) DEFAULT NULL,
  `fizcalia` varchar(50) DEFAULT NULL,
  `procurador` varchar(50) DEFAULT NULL,
  `notas` varchar(255) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`client_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_compra` */

DROP TABLE IF EXISTS `pr_compra`;

CREATE TABLE `pr_compra` (
  `compra_Id` int(11) NOT NULL AUTO_INCREMENT,
  `parent` int(11) DEFAULT NULL,
  `prefix` int(11) NOT NULL,
  `cedula_c` varchar(50) DEFAULT NULL,
  `nombre_c` varchar(50) DEFAULT NULL,
  `apellido_c` varchar(50) DEFAULT NULL,
  `genero_c` varchar(50) DEFAULT NULL,
  `telefono_c` varchar(50) DEFAULT NULL,
  `celular_c` varchar(50) DEFAULT NULL,
  `direccion_c` varchar(50) DEFAULT NULL,
  `estado_civil_c` varchar(50) DEFAULT NULL,
  `cedula_i` varchar(50) DEFAULT NULL,
  `nombre_i` varchar(50) DEFAULT NULL,
  `apellido_i` varchar(50) DEFAULT NULL,
  `genero_i` varchar(50) DEFAULT NULL,
  `telefono_i` varchar(50) DEFAULT NULL,
  `celular_i` varchar(50) DEFAULT NULL,
  `direccion_i` varchar(50) DEFAULT NULL,
  `estado_civil_i` varchar(50) DEFAULT NULL,
  `cedula_g` varchar(50) DEFAULT NULL,
  `nombre_g` varchar(50) DEFAULT NULL,
  `apellido_g` varchar(50) DEFAULT NULL,
  `genero_g` varchar(50) DEFAULT NULL,
  `telefono_g` varchar(50) DEFAULT NULL,
  `celular_g` varchar(50) DEFAULT NULL,
  `direccion_g` varchar(50) DEFAULT NULL,
  `estado_civil_g` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `actual` varchar(50) DEFAULT NULL,
  `contrato` varchar(50) DEFAULT NULL,
  `objeto` decimal(11,2) DEFAULT '0.00',
  `monto` decimal(11,2) DEFAULT '0.00',
  `honorarios` varchar(50) DEFAULT NULL,
  `gastos` decimal(11,2) DEFAULT '0.00',
  `longitud` decimal(11,2) DEFAULT '0.00',
  `descripcion` varchar(50) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`compra_Id`,`prefix`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_divorcios` */

DROP TABLE IF EXISTS `pr_divorcios`;

CREATE TABLE `pr_divorcios` (
  `divorcio_Id` int(11) NOT NULL AUTO_INCREMENT,
  `cedula_c` varchar(50) DEFAULT NULL,
  `cliente` varchar(25) DEFAULT NULL,
  `abogado` varchar(25) DEFAULT NULL,
  `juez` varchar(25) DEFAULT NULL,
  `procurador` varchar(25) DEFAULT NULL,
  `razon` varchar(50) DEFAULT NULL,
  `costo` decimal(11,2) DEFAULT NULL,
  `abonos` decimal(11,2) DEFAULT NULL,
  `impuestos` decimal(11,2) DEFAULT NULL,
  `notas` varchar(255) DEFAULT NULL,
  `date` varchar(50) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`divorcio_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_fiscalia` */

DROP TABLE IF EXISTS `pr_fiscalia`;

CREATE TABLE `pr_fiscalia` (
  `fiscalia_Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `pais` varchar(50) DEFAULT NULL,
  `fiscal` varchar(50) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`fiscalia_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_jueces` */

DROP TABLE IF EXISTS `pr_jueces`;

CREATE TABLE `pr_jueces` (
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `cedula` varchar(20) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `sexo` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `genero` varchar(20) DEFAULT NULL,
  `cedula/pasaporte` varchar(20) DEFAULT NULL,
  `fizcalia` varchar(25) DEFAULT NULL,
  `juzgado` varchar(20) DEFAULT NULL,
  `jurisdiccion` varchar(30) DEFAULT NULL,
  `estado_civil` varchar(10) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pr_jurisdiccion` */

DROP TABLE IF EXISTS `pr_jurisdiccion`;

CREATE TABLE `pr_jurisdiccion` (
  `nonbre` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `pais` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pr_juzgado_paz` */

DROP TABLE IF EXISTS `pr_juzgado_paz`;

CREATE TABLE `pr_juzgado_paz` (
  `circunscripcion` varchar(20) DEFAULT NULL,
  `direccion` varchar(25) DEFAULT NULL,
  `pais` varchar(20) DEFAULT NULL,
  `juez` varchar(15) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pr_procurador` */

DROP TABLE IF EXISTS `pr_procurador`;

CREATE TABLE `pr_procurador` (
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `cedula` varchar(20) NOT NULL,
  `genero` varchar(20) DEFAULT NULL,
  `tipo_procurador` varchar(25) DEFAULT NULL,
  `procu_id` varchar(20) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pr_procuraduria` */

DROP TABLE IF EXISTS `pr_procuraduria`;

CREATE TABLE `pr_procuraduria` (
  `procu_id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) DEFAULT NULL,
  `direccion` varchar(25) DEFAULT NULL,
  `pais` varchar(20) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`procu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_provincias` */

DROP TABLE IF EXISTS `pr_provincias`;

CREATE TABLE `pr_provincias` (
  `provincia_Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `pais` varchar(50) DEFAULT NULL,
  `hidden` int(1) DEFAULT '0',
  PRIMARY KEY (`provincia_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_sectores` */

DROP TABLE IF EXISTS `pr_sectores`;

CREATE TABLE `pr_sectores` (
  `sector_Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `hidden` int(1) DEFAULT '0',
  PRIMARY KEY (`sector_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_servicios` */

DROP TABLE IF EXISTS `pr_servicios`;

CREATE TABLE `pr_servicios` (
  `serv_Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  `cliente` varchar(25) DEFAULT NULL,
  `abogado` varchar(25) DEFAULT NULL,
  `procurador` varchar(25) DEFAULT NULL,
  `fizcalia` varchar(25) DEFAULT NULL,
  `costo` decimal(11,2) DEFAULT NULL,
  `abonos` decimal(11,2) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`serv_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pr_terceros` */

DROP TABLE IF EXISTS `pr_terceros`;

CREATE TABLE `pr_terceros` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `no` int(11) DEFAULT NULL,
  `cedula` varchar(50) DEFAULT NULL,
  `img` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `apodo` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `contacto` varchar(20) DEFAULT NULL,
  `direccion` varchar(20) DEFAULT NULL,
  `genero` varchar(20) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `municipio` varchar(50) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `tel_trabajo` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `estado_civil` int(11) DEFAULT NULL,
  `empleado` varchar(50) DEFAULT NULL,
  `direccion_trabajo` varchar(50) DEFAULT NULL,
  `oficialia_civil` varchar(50) DEFAULT NULL,
  `trabajo_realizar` varchar(50) DEFAULT NULL,
  `costo_servicio` varchar(50) DEFAULT NULL,
  `abonos` decimal(50,0) DEFAULT NULL,
  `fizcalia` varchar(50) DEFAULT NULL,
  `empresa` varchar(50) DEFAULT NULL,
  `procurador` varchar(50) DEFAULT NULL,
  `notas` varchar(255) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_users` */

DROP TABLE IF EXISTS `pr_users`;

CREATE TABLE `pr_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `pr_venta` */

DROP TABLE IF EXISTS `pr_venta`;

CREATE TABLE `pr_venta` (
  `venta_Id` int(11) NOT NULL AUTO_INCREMENT,
  `cedula_c` varchar(50) DEFAULT NULL,
  `nombre_c` varchar(50) DEFAULT NULL,
  `apellido_c` varchar(50) DEFAULT NULL,
  `genero_c` varchar(50) DEFAULT NULL,
  `telefono_c` varchar(50) DEFAULT NULL,
  `celular_c` varchar(50) DEFAULT NULL,
  `direccion_c` varchar(50) DEFAULT NULL,
  `estado_civil_c` varchar(50) DEFAULT NULL,
  `cedula_i` varchar(50) DEFAULT NULL,
  `nombre_i` varchar(50) DEFAULT NULL,
  `apellido_i` varchar(50) DEFAULT NULL,
  `genero_i` varchar(50) DEFAULT NULL,
  `telefono_i` varchar(50) DEFAULT NULL,
  `celular_i` varchar(50) DEFAULT NULL,
  `direccion_i` varchar(50) DEFAULT NULL,
  `estado_civil_i` varchar(50) DEFAULT NULL,
  `cedula_g` varchar(50) DEFAULT NULL,
  `nombre_g` varchar(50) DEFAULT NULL,
  `apellido_g` varchar(50) DEFAULT NULL,
  `genero_g` varchar(50) DEFAULT NULL,
  `telefono_g` varchar(50) DEFAULT NULL,
  `celular_g` varchar(50) DEFAULT NULL,
  `direccion_g` varchar(50) DEFAULT NULL,
  `estado_civil_g` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `actual` varchar(50) DEFAULT NULL,
  `contrato` varchar(50) DEFAULT NULL,
  `objeto` decimal(11,2) DEFAULT '0.00',
  `monto` decimal(11,2) DEFAULT '0.00',
  `honorarios` varchar(50) DEFAULT NULL,
  `gastos` decimal(11,2) DEFAULT '0.00',
  `longitud` decimal(11,2) DEFAULT '0.00',
  `descripcion` varchar(50) DEFAULT NULL,
  `hidden` int(11) DEFAULT '0',
  PRIMARY KEY (`venta_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
