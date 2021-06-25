-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-06-2021 a las 23:02:04
-- Versión del servidor: 10.4.16-MariaDB
-- Versión de PHP: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `chamiben`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `backupchami` ()  SET @TS = DATE_FORMAT(NOW(),'_%Y_%m_%d_%H_%i_%s')$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `backupmake` ()  BEGIN
 
    SET @TS = DATE_FORMAT(NOW(),'_%Y_%m_%d_%H_%i_%s');
		 
		SET @FOLDER = 'c:/tmp/';
		SET @PREFIX = 'backup';
		SET @EXT    = '.csv';
		 
		SET @CMD = CONCAT("SELECT * FROM chamipedidosp1ben INTO OUTFILE '",@FOLDER,@PREFIX,@TS,@EXT,
						   "' FIELDS ENCLOSED BY '\' TERMINATED BY ',' ESCAPED BY '\'",
						   "  LINES TERMINATED BY '\r\n';");
		 
		PREPARE statement FROM @CMD;
		 
		EXECUTE statement;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarbebidas` ()  BEGIN
 
    SELECT * FROM bebidas
ORDER BY `Prod.` ;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarcomb` ()  BEGIN
    SELECT *  FROM `pcomb` ORDER BY `Prod.` ;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarcriollo` ()  BEGIN
 
    SELECT * FROM pcriollo
	ORDER BY `Prod.` ;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarentradas` ()  BEGIN
 
    SELECT * FROM entradas
ORDER BY `Prod.`;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarmarino` ()  BEGIN
 
    SELECT * FROM pmarino
	ORDER BY `Prod.` ;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarplatofondo` ()  BEGIN
 
    SELECT * FROM platofondo
ORDER BY `Prod.`;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listarpostres` ()  BEGIN
 
    SELECT * FROM postres
ORDER BY `Prod.`;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listbebidas` (IN `start` VARCHAR(16), IN `end` VARCHAR(16))  BEGIN
 
   select Producto,SUM(Unidades)  as `Uds.` FROM chamipedidosp1ben 
   WHERE FechaInc >= start
   AND FechaInc <= DATE_ADD(end, INTERVAL 1 DAY) and Tipo= "BEBIDAS"and Producto not like "%-- ELIMINADO%" GROUP BY Producto
   ORDER BY Producto ASC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listentradas` (IN `start` VARCHAR(16), IN `end` VARCHAR(16))  BEGIN
 
   select Producto,SUM(Unidades)  as `Uds.` 
   FROM chamipedidosp1ben 
   WHERE FechaInc >= start
   AND FechaInc <= DATE_ADD(end, INTERVAL 1 DAY) and Tipo= "ENTRADAS"and Producto not like "%-- ELIMINADO%" 
   GROUP BY Producto ORDER BY Producto ASC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listgeneral` (IN `start` VARCHAR(16), IN `end` VARCHAR(16))  BEGIN
 
    select idchamipedidos as id,Mozo,Mesa,Producto as `Prod.`,Precio,Unidades,Subtotal,FechaInc as FechaIns,Tipo FROM chamipedidosp1ben 
   WHERE FechaInc >= start
   AND FechaInc <= DATE_ADD(end, INTERVAL 1 DAY) and Producto not like "%-- ELIMINADO%";
   
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listplatosfondo` (IN `start` VARCHAR(16), IN `end` VARCHAR(16))  BEGIN
 
   select Producto,SUM(Unidades)  as `Uds.` FROM chamipedidosp1ben 
   WHERE FechaInc >= start
   AND FechaInc <= DATE_ADD(end, INTERVAL 1 DAY) and Tipo = "PLATOS FONDO"and Producto not like "%-- ELIMINADO%" 
   GROUP BY Producto ORDER BY Producto ASC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listpostres` (IN `start` VARCHAR(16), IN `end` VARCHAR(16))  BEGIN
 
   select Producto,SUM(Unidades)  as `Uds.` FROM chamipedidosp1ben 
   WHERE FechaInc >= start
   AND FechaInc <= DATE_ADD(end, INTERVAL 1 DAY) and Tipo= "POSTRES"and Producto not like "%-- ELIMINADO%" GROUP BY Producto
   ORDER BY Producto ASC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `listsearch` (IN `valueToSearch` VARCHAR(16), IN `start` VARCHAR(16), IN `end` VARCHAR(16))  BEGIN
  select idchamipedidos as id,Mozo,Mesa,Producto as `Prod.`,Precio,Unidades,Subtotal,FechaInc as FechaIns,Tipo FROM chamipedidosp1ben 
   WHERE CONCAT(Mozo, Mesa, Producto, Precio, FechaInc,Tipo) like CONCAT('%',valueToSearch,'%') and FechaInc >= start
   AND FechaInc <= DATE_ADD(end, INTERVAL 1 DAY) and Producto not like "%-- ELIMINADO%";


END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bebidas`
--

CREATE TABLE `bebidas` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bebidas`
--

INSERT INTO `bebidas` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'JUGO DE NARANJA # @', '8'),
(2, 'JUGO DE PAPAYA # @', '7'),
(3, 'JUGO DE PIÑA # @', '7'),
(4, 'JUGO ESPECIAL # @', '8'),
(5, 'JUGO SURTIDO # @', '7'),
(6, 'LIMONADA JARRA MEDIANA # @', '15'),
(7, 'LIMONADA VASO # @', '4'),
(8, 'CHICHA MORADA JARRA GRANDE  @', '16'),
(9, 'CHICHA MORADA VASO @', '4'),
(10, 'AGUA MINERAL 330ML @ &', '4'),
(11, 'INKA COLA @', '4'),
(12, 'COCA COLA @', '4'),
(13, 'FANTA @', '4'),
(14, 'SPRITE @', '4'),
(15, 'COCA COLA ZERO 500ML @', '5'),
(16, 'INKA COLA ZERO 500ML @', '5'),
(17, 'CAFE EXPRESS # ', '8'),
(18, 'CAFE PASADO AMERICANO #', '7'),
(19, 'CAPUCCINO #', '8'),
(20, 'MANZANILLA #', '5'),
(21, 'TE #', '5'),
(22, 'ANIS #', '5'),
(23, 'HIERBALUISA #', '5'),
(24, 'MATE DE COCA #', '5'),
(25, 'PISCO SOUR MARACUYA', '15'),
(26, 'PISCO SOUR', '15'),
(27, 'ALGARROBINA', '16'),
(28, 'DAIQUIRI DE DURAZNO @', '17'),
(29, 'PIÑA COLADA ', '17'),
(30, 'MENTA @', '12'),
(31, 'VODKA GIN TONIC ', '15'),
(32, 'VODKA CON NARANJA ', '15'),
(33, 'MOJITO', '16'),
(34, 'CUBA LIBRE @', '15'),
(35, 'CHILCANO DE PISCO @', '15'),
(36, 'SANGRIA COPA ', '15'),
(37, 'SANGRIA JARRA ', '45'),
(38, 'SANGRIA ESPECIAL JARRA ', '60'),
(39, 'COPA DE VINO ', '15'),
(40, 'TABERNERO BORGOÑA BOTELLA', '40'),
(41, 'TACAMA GRAN BLANCO', '50'),
(42, 'TACAMA GRAN TINTO', '50'),
(43, 'TACAMA ROSE', '40'),
(44, 'TACAMA BLANCO DE BLANCO', '55'),
(45, 'SANTIAGO QUEIROLO BORGOÑA', '45'),
(46, 'ANIS NAJAR', '10'),
(47, 'ANIS DE MONO', '10'),
(48, 'CERVEZA CUSQUEÑA BOTELLA 330ML ', '8'),
(49, 'CERVEZA PILSEN BOTELLA 330ML ', '8'),
(50, 'CERVEZA CRISTAL BOTELLA 330ML ', '8'),
(51, 'CERVEZA NEGRA BOTELLA 330ML ', '8'),
(52, 'CHICHA MORADA JARRA MEDIANA  @', '13'),
(53, 'LIMONADA FR JARRA GRANDE #', '15'),
(54, 'LIMONADA FR JARRA MEDIANA #', '12'),
(55, 'LIMONADA JARRA GRANDE # @', '18'),
(56, 'VASO DE AGUA @', '0'),
(57, 'VASO MARACUYA @  # ', '4'),
(58, 'JARRA DE MARACUYA @ # ', '16'),
(59, 'LIMONADA FR VASO #', '5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `chamipedidosp1ben`
--

CREATE TABLE `chamipedidosp1ben` (
  `idchamipedidos` int(11) NOT NULL,
  `Mozo` varchar(45) DEFAULT NULL,
  `Mesa` int(11) DEFAULT NULL,
  `Producto` varchar(45) DEFAULT NULL,
  `Precio` decimal(4,2) DEFAULT NULL,
  `Unidades` int(11) DEFAULT NULL,
  `Subtotal` decimal(4,2) DEFAULT NULL,
  `FechaInc` datetime DEFAULT NULL,
  `Tipo` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `chamipedidosp1ben`
--

INSERT INTO `chamipedidosp1ben` (`idchamipedidos`, `Mozo`, `Mesa`, `Producto`, `Precio`, `Unidades`, `Subtotal`, `FechaInc`, `Tipo`) VALUES
(549, 'JENKER', 1, '(M)JUGO ESPECIAL # @_HELAD@_NORMAL D AZUCAR.', '8.00', 1, '8.00', '2021-06-24 18:18:36', 'BEBIDAS'),
(550, 'JENKER', 1, '(M)OCOPA CHAMI &', '15.00', 1, '15.00', '2021-06-24 18:18:36', 'ENTRADAS'),
(551, 'JENKER', 1, '(M)TIRADITO A LA CREMA DE AJI AMARILLO &', '30.00', 1, '30.00', '2021-06-24 18:18:36', 'PLATOS FONDO'),
(552, 'JENKER', 1, '(M)PIE DE MANZANA', '10.00', 1, '10.00', '2021-06-24 18:18:36', 'POSTRES'),
(553, 'ALBERTO', 1, '(M)CREMA VOLTEADA', '12.00', 1, '12.00', '2021-06-24 18:24:22', 'POSTRES'),
(554, 'ALBERTO', 1, '(M)CEBICHE DE CONCHAS NEGRAS(SAB&DOM) &', '38.00', 1, '38.00', '2021-06-24 18:24:22', 'PLATOS FONDO'),
(555, 'ALBERTO', 1, '(M)PIE DE LIMON', '12.00', 1, '12.00', '2021-06-24 18:26:39', 'POSTRES'),
(556, 'ALBERTO', 1, '(M)CREMA VOLTEADA', '12.00', 3, '36.00', '2021-06-24 18:26:39', 'POSTRES'),
(557, 'ALBERTO', 1, '(M)CHICHA MORADA VASO @_HELAD@', '4.00', 1, '4.00', '2021-06-24 18:26:39', 'BEBIDAS'),
(558, 'ALBERTO', 1, '(M)PIE DE LIMON', '12.00', 1, '12.00', '2021-06-24 18:37:17', 'POSTRES'),
(559, 'ALBERTO', 1, '(M)MAZAMORRA MORADA &CALENTADO', '10.00', 3, '30.00', '2021-06-24 18:37:17', 'POSTRES'),
(560, 'ALBERTO', 1, '(M)TAMAL &', '10.00', 6, '60.00', '2021-06-24 18:37:17', 'ENTRADAS'),
(561, 'ALBERTO', 1, '(M)LIMONADA VASO # @_HELAD@_BAJO AZUCAR.', '4.00', 5, '20.00', '2021-06-24 18:37:17', 'BEBIDAS'),
(562, 'ALBERTO', 1, '(M)PICANTE DE CAMARON &', '40.00', 1, '40.00', '2021-06-24 18:37:17', 'PLATOS FONDO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradas`
--

CREATE TABLE `entradas` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `entradas`
--

INSERT INTO `entradas` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'PULPO AL OLIVO &', '25'),
(2, 'CAUSA DE POLLO &', '15'),
(3, 'CAUSA DE PULPA DE CANGREJO &', '22'),
(4, 'PAPA A LA HUANCAINA &', '15'),
(5, 'OCOPA CHAMI &', '15'),
(6, 'LECHE DE TIGRE &', '15'),
(7, 'TAMAL &', '10'),
(8, 'HUMITA &', '10'),
(9, 'CONCHITA A LA PARMESANA &', '20'),
(10, 'SOLTERITO &', '15'),
(11, 'PALTA A LA REINA &', '15'),
(12, 'YUQUITAS FRITAS &', '10'),
(13, 'TEQUEÑOS &', '15'),
(14, 'TEQUEÑOS RELLENOS CON PULPA DE CANGREJO &', '25'),
(15, 'ENSALADA CHAMI &', '15'),
(16, 'ENSALADA COCIDA &', '15'),
(17, 'SANDWICH DE APANADO &', '12'),
(18, 'SANDWICH DE ASADO &', '16'),
(19, 'BUTIFARRA &', '12'),
(20, 'SANDWICH DE CHORIZO &', '12'),
(21, 'SANDWICH DE LOMO &', '22'),
(22, 'SANDWICH DE POLLO &', '15');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lastorder`
--

CREATE TABLE `lastorder` (
  `id` int(11) NOT NULL,
  `numb` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lastorder`
--

INSERT INTO `lastorder` (`id`, `numb`) VALUES
(1, '351');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mozos`
--

CREATE TABLE `mozos` (
  `idMozos` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pcomb`
--

CREATE TABLE `pcomb` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pcomb`
--

INSERT INTO `pcomb` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'TACU T CON ADOBO &', '29'),
(2, 'TACU T C/ PSCADO PLANCH S/ JUGO &', '32'),
(3, 'TACU T C/ ASADO', '32'),
(4, 'TACU T C/ HUEVO FRITO', '18'),
(5, 'TACU T A LA CUBANA', '22'),
(6, 'TACU T A LA CRIOLLA  C/ APANADO', '32'),
(7, 'TACU T C/ POLLO PLANCHA', '32'),
(8, 'TACU T C/ MILANS POLLO', '32'),
(9, 'TACU T C/ MILANS PSCADO', '32'),
(10, 'TACU T C/ CABRITO', '38'),
(11, 'TALLR VRD  C/ PSCADO PLANCHA ', '32'),
(12, 'TALLR VRD C/ HUEVO FRITO &', '25'),
(13, 'TALLR VRD C/ MILANS POLLO &', '32'),
(14, 'TALLR VRD C/ MILANS PSCADO &', '32'),
(15, 'TALLR VRD C/ POLLO PLANCHA &', '32'),
(16, 'TALLR VRD C/ LOMO APANADO &', '40'),
(17, 'PURE C/ POLLO PLANCHA &', '32'),
(18, 'PURE C/ PSCADO PLANCHA &', '32'),
(19, 'PURE C/ MILANESA POLLO &', '32'),
(20, 'PURE C/ MILANESA PSCADO &', '32'),
(21, 'PURE C/ HUEVO FRITO &', '12'),
(22, 'PURE C/ HUEVO & PLATANO &', '15'),
(23, 'PURE C/ ARROZ &', '12'),
(24, 'PURE C/ ADOBO &', '29'),
(25, 'PURE C/ LOMO A LA PLANCHA &', '40'),
(26, 'CAU CAU C/ AJI GALLINA &', '28'),
(27, 'CAU CAU C/ PATITA &', '26'),
(28, 'CAU CAU C/ CARAPULC &', '26'),
(29, 'CAU CAU C/ MONDONG &', '28'),
(30, 'AJI GALLINA C/ CARAPULC &', '28'),
(31, 'CARAPULC C/ PATITA &', '26'),
(32, 'MONDONG C/ CARAPULC &', '26'),
(33, 'MONDONG C/ PATITA &', '26'),
(34, 'MONDONG C/ AJI D GALLINA &', '28'),
(35, 'ARR CRIOLLA C/ POLLO PLANCHA &', '32'),
(36, 'ARR CRIOLLA C/ MILANS POLLO &', '32'),
(37, 'ARR CRIOLLA C/ MILANS PSCADO &', '32'),
(38, 'ARR CRIOLLA C/ LOMO APANADO &', '42'),
(39, 'PIQU S/ PATITA C/ ADOBO &', '40'),
(40, 'PIQU S/ CARAPULC C/ ADOBO &', '40'),
(41, 'PIQU S/ CAU CAU C/ ADOBO &', '40'),
(42, 'PIQU S/ AJI GALLINA C/ ADOBO &', '40'),
(43, 'CABRITO C/ ENSAL CHAMI &', '38'),
(44, 'CABRITO C/ TACU TACU &', '38'),
(45, 'CABRITO C/ YUCA SOLO YUCA &', '38'),
(46, 'CABRITO SOLO &', '38'),
(47, 'CABRITO C/ PURE &', '38'),
(48, 'ENSAL CHAMI C/ POLLO PLANCHA &', '32'),
(49, 'ENSAL CHAMI C/ PSCADO PLANCHA &', '32'),
(50, 'ENSAL CHAMI C/ MILANS POLLO &', '32'),
(51, 'ENSAL CHAMI C/ LOMO PLANCHA &', '40'),
(52, 'ENSAL CHAMI C/ ADOBO &', '29'),
(53, 'ENSAL CHAMI C/ LOMO APANADO &', '40'),
(54, 'PIQU S/ AJI GALLINA S/ ADOBO &', '40'),
(55, 'MILANS PSCADO C/ ENSAL Y ARROZ &', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pcriollo`
--

CREATE TABLE `pcriollo` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pcriollo`
--

INSERT INTO `pcriollo` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'CHICHARRON DE POLLO &', '25'),
(2, 'ADOBO DE CHANCHO &', '29'),
(3, 'AJI DE GALLINA &', '28'),
(4, 'ARROZ A LA CRIOLLA MONTADO &', '30'),
(5, 'ARROZ CON POLLO &', '27'),
(6, 'CARAPULCRA &', '26'),
(7, 'CAU CAU &', '26'),
(8, 'MONDONGUITO A LA ITALIANA &', '28'),
(9, 'CABRITO A LA CHICLAYANA &', '38'),
(10, 'PATITA CON MANI &', '26'),
(11, 'RONDA CRIOLLISIMA &', '40'),
(12, 'ANTICUCHOS &', '20'),
(13, 'BROCHETA LOMO &', '38'),
(14, 'BROCHETA DE POLLO &', '28'),
(15, 'LOMO SALTADO &', '40'),
(16, 'LOMO A LO POBRE &', '42'),
(17, 'LOMO A LA CHORRILLANA &', '40'),
(18, 'LOMO A LA PIMIENTA &', '40'),
(19, 'LOMO A LA PARRILLA &', '40'),
(20, 'LOMO CON TACU TACU &', '40'),
(21, 'LOMO SALTADO CON TACU TACU &', '42'),
(22, 'ASADO CON ENSALADA CHAMI &', '32'),
(23, 'ASADO CON PURE Y ARROZ &', '32'),
(24, 'ASADO CON TACU TACU &', '32'),
(25, 'APANADO CON ENSALADA CHAMI &', '28'),
(26, 'APANADO C/ ARROZ A LA JARDINERA &', '25'),
(27, 'APANADO CON TACU TACU &', '25'),
(28, 'TALLARIN VERDE SOLO &', '20'),
(29, 'TALLARIN VERDE CON ASADO &', '35'),
(30, 'TALLARIN VERDE CON APANADO &', '30'),
(31, 'TALLARIN VERDE CON LOMO &', '40'),
(32, 'TALLARIN VERDE CON LOMO SALTADO &', '42'),
(33, 'FETUCCINI A LA HUANCAINA &', '20'),
(34, 'FETUCCINI C/ ASADO &', '35'),
(35, 'FETUCCINI C/ APANADO &', '30'),
(36, 'FETUCCINI C/ LOMO &', '40'),
(37, 'ARROZ CON PATO (MARTES) &', '38'),
(38, 'SANCOCHADO(MIERCOLES) &', '40'),
(39, 'TACU TACU CHAMI (JUEVES) &', '40'),
(40, 'PICARONES (SAB&DOM)', '12'),
(41, 'POLLO PLANCHA PP DORADA Y ARROZ', '32'),
(42, 'TACU TACU C/ PESCADO A LA PLANCHA', '32'),
(43, 'PORCION ARROZ &', '3'),
(44, 'PORCION PLATANO &', '3'),
(45, 'PORCION PP FRITA &', '6'),
(46, 'PORCION PURE &', '6'),
(47, 'PORCION HUANCAINA &', '10'),
(48, 'FETUCCINI  C/ LOMO PLANCHA &', '40'),
(80, 'APANADO C/ ARROZ A LA JARDINERA &', '25'),
(81, 'DIETA DE POLLO &', '25'),
(82, 'SOPA A LA MINUTA &', '30'),
(83, 'SOPA A LA CRIOLLA &', '30'),
(84, 'TALLARIN VRDE C/ POLLO PLANCHA &', '32'),
(85, 'TALLARIN VRDE C/ MILANESA POLLO &', '32'),
(86, 'TALLARIN VRDE CON PESCADO PLANCHA', '32'),
(87, 'TALLARIN VRDE CON LOMO PLANCHA &', '32'),
(88, 'TALLARIN VRDE CON HUEVO FRITO &', '23'),
(89, 'CHAMI C/ APANADO &', '28'),
(90, 'CHAMI C/ POLLO PLANCHA &', '32'),
(91, 'CHAMI C/ LOMO PLANCHA &', '40'),
(92, 'CHAMI C/ PESCADO PLANCHA &', '32'),
(93, 'APANADO PURÉ Y ARROZ &', '28'),
(94, 'APANADO C/ TACU TACU &', '28'),
(95, 'TACU T C/ LOMO POBRE &', '32'),
(96, 'TALLARIN SALTADO C/ LOMO', '32'),
(97, 'CHAMI C/ MILANESA POLLO Y PURE &', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `platofondo`
--

CREATE TABLE `platofondo` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `platofondo`
--

INSERT INTO `platofondo` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'CEBICHE MIXTO &', '38'),
(2, 'CEBICHE DE LENGUADO &', '45'),
(3, 'CEBICHE DE LA PESCA DEL DIA &', '30'),
(4, 'CEBICHE DE MARISCOS &', '35'),
(5, 'CEBICHE DE CONCHAS NEGRAS(SAB&DOM) &', '38'),
(6, 'TIRADITO A LA CREMA DE AJI AMARILLO &', '30'),
(7, 'TIRADITO 3 SABORES (ROJ,AMAR,BLAN) &', '32'),
(8, 'ARROZ CON MARISCOS &', '35'),
(9, 'CHAUFA DE MARISCOS &', '35'),
(10, 'ESCABECHE DE PESCADO &', '20'),
(11, 'PESCADO A LA CHORRILLANA &', '32'),
(12, 'CHITA FRITA AL AJILLO &', '45'),
(13, 'CHITA  A LO MACHO &', '50'),
(14, 'PICANTE DE CAMARON &', '40'),
(15, 'LENGUADO A LA MENIER &', '42'),
(16, 'SUDADO DE PESCADO &', '32'),
(17, 'LANGOSTINOS AL AJILLO &', '32'),
(18, 'PESCADO A LO MACHO &', '38'),
(19, 'MILANESA DE PESCADO C/ PURE &', '32'),
(20, 'CHICHARRON CALAMAR &', '28'),
(21, 'CHICHARRON PESCADO &', '30'),
(22, 'JALEA MIXTA &', '40'),
(23, 'JALEA DE PESCADO &', '35'),
(24, 'CHICHARRON DE POLLO &', '25'),
(25, 'ADOBO DE CHANCHO &', '29'),
(26, 'AJI DE GALLINA &', '28'),
(27, 'ARROZ CRIOLLA MONTADO &', '30'),
(28, 'ARROZ CON POLLO &', '27'),
(29, 'CARAPULCRA &', '26'),
(30, 'CAU CAU &', '26'),
(31, 'MONDONGUITO ITALIANA &', '28'),
(32, 'CABRITO CHICLAYANA &', '38'),
(33, 'PATITA CON MANI &', '26'),
(34, 'RONDA CRIOLLISIMA &', '40'),
(35, 'ANTICUCHOS &', '20'),
(36, 'BROCHETA LOMO &', '38'),
(37, 'BROCHETA DE POLLO &', '28'),
(38, 'BROCHETA DE PESCADO &', '30'),
(39, 'LOMO SALTADO &', '40'),
(40, 'LOMO A LO POBRE &', '42'),
(41, 'LOMO A LA CHORRILLANA &', '40'),
(42, 'LOMO A LA PIMIENTA &', '40'),
(43, 'LOMO A LA PARRILLA &', '40'),
(44, 'LOMO CON TACU  &', '40'),
(45, 'LOMO SALTADO CON TACU &', '42'),
(46, 'ASADO CON ENSALADA CHAMI &', '32'),
(47, 'ASADO CON PURE Y ARROZ &', '32'),
(48, 'ASADO CON TACU TACU &', '32'),
(49, 'APANADO CON ENSALADA CHAMI &', '28'),
(50, 'APANADO C/ ARROZ JARDINERA &', '25'),
(51, 'APANADO CON TACU &', '25'),
(52, 'TALLARIN VRDE SOLO &', '20'),
(53, 'TALLARIN VRDE CON ASADO &', '35'),
(54, 'TALLARIN VRDE CON APANADO &', '30'),
(55, 'TALLARIN VRDE CON LOMO &', '40'),
(56, 'TALLARIN VRDE CON LOMO SALTADO &', '42'),
(57, 'FETUCC A HUANCAINA &', '20'),
(58, 'FETUCC  C/ ASADO &', '35'),
(59, 'FETUCC  C/ APANADO &', '30'),
(60, 'FETUCC  C/ LOMO &', '40'),
(61, 'ARROZ CON PATO  &', '38'),
(62, 'SANCOCHADO &', '40'),
(63, 'TACU TACU CHAMI &', '40'),
(64, 'CHUPE CAMARONES &', '40'),
(65, 'PARIHUELA &', '40'),
(66, 'DUO &', '38'),
(67, 'TRIO &', '42'),
(71, 'PICARONES (SAB&DOM) &', '12'),
(72, 'POLLO PLANCH PP DORADA Y ARROZ &', '32'),
(73, 'TACU C/ PESCADO A LA PLANCHA &', '32'),
(74, 'PORCION ARROZ &', '3'),
(75, 'PORCION PLATANO &', '3'),
(76, 'PORCION PAPA FRITA &', '6'),
(77, 'PORCION PURE &', '6'),
(78, 'PORCION HUANCAINA &', '10'),
(79, 'FETUCC  C/ LOMO PLANCHA &', '40'),
(80, 'APANADO C/ ARROZ A LA JARDINERA &', '25'),
(81, 'DIETA DE POLLO &', '25'),
(82, 'SOPA A LA MINUTA &', '30'),
(83, 'SOPA A LA CRIOLLA &', '30'),
(84, 'TALLARIN VRDE C/ POLLO PLANCHA &', '32'),
(85, 'TALLARIN VRDE C/ MILANESA POLLO &', '32'),
(86, 'TALLARIN VRDE CON PESCADO PLANCHA', '32'),
(87, 'TALLARIN VRDE CON LOMO PLANCHA &', '32'),
(88, 'TALLARIN VRDE CON HUEVO FRITO &', '23'),
(89, 'CHAMI C/ APANADO &', '28'),
(90, 'CHAMI C/ POLLO PLANCHA &', '32'),
(91, 'CHAMI C/ LOMO PLANCHA &', '40'),
(92, 'CHAMI C/ PESCADO PLANCHA &', '32'),
(93, 'APANADO PURÉ Y ARROZ &', '28'),
(94, 'APANADO C/ TACU TACU &', '28'),
(95, 'TACU T C/ LOMO POBRE &', '32'),
(96, 'TALLARIN SALTADO C/ LOMO', '32'),
(97, 'CHAMI C/ MILANESA POLLO Y PURE &', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pmarino`
--

CREATE TABLE `pmarino` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pmarino`
--

INSERT INTO `pmarino` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'CEBICHE MIXTO &', '38'),
(2, 'CEBICHE DE LENGUADO &', '45'),
(3, 'CEBICHE DE LA PESCA DEL DIA &', '30'),
(4, 'CEBICHE DE MARISCOS &', '35'),
(5, 'CEBICHE DE CONCHAS NEGRAS(SAB&DOM) &', '38'),
(6, 'TIRADITO A LA CREMA DE AJI AMARILLO &', '30'),
(7, 'TIRADITO 3 SABORES (ROJ,AMAR,BLAN) &', '32'),
(8, 'ARROZ CON MARISCOS &', '35'),
(9, 'CHAUFA DE MARISCOS &', '35'),
(10, 'ESCABECHE DE PESCADO &', '20'),
(11, 'PESCADO A LA CHORRILLANA &', '32'),
(12, 'CHITA FRITA AL AJILLO &', '45'),
(13, 'CHITA  A LO MACHO &', '50'),
(14, 'PICANTE DE CAMARON &', '40'),
(15, 'LENGUADO A LA MENIER &', '42'),
(16, 'SUDADO DE PESCADO &', '32'),
(17, 'LANGOSTINOS AL AJILLO &', '32'),
(18, 'PESCADO A LO MACHO &', '38'),
(19, 'MILANESA DE PESCADO C/ PURE &', '32'),
(20, 'CHICHARRON DE CALAMAR &', '28'),
(21, 'CHICHARRON DE PESCADO &', '30'),
(22, 'JALEA MIXTA &', '40'),
(23, 'JALEA DE PESCADO &', '35'),
(24, 'DUO &', '38'),
(25, 'TRIO &', '42'),
(26, 'PARIHUELA &', '40'),
(27, 'CHUPE DE CAMARONES(SAB&DOM) &', '40'),
(28, 'BROCHETA DE PESCADO &', '30'),
(30, 'TACU TACU C/ PESCADO A LA PLANCHA &', '32'),
(31, 'PORCION ARROZ &', '3'),
(32, 'PORCION PLATANO &', '3'),
(33, 'PORCION PP FRITA &', '6'),
(34, 'PORCION PURE &', '6'),
(35, 'PORCION HUANCAINA &', '10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `postres`
--

CREATE TABLE `postres` (
  `id` int(11) NOT NULL,
  `Prod.` varchar(45) DEFAULT NULL,
  `Prec.` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `postres`
--

INSERT INTO `postres` (`id`, `Prod.`, `Prec.`) VALUES
(1, 'SUSPIRO A LA LIMEÑA', '12'),
(2, 'ALFAJORES', '3'),
(3, 'ARROZ CON LECHE &', '10'),
(4, 'CREMA VOLTEADA', '12'),
(5, 'MAZAMORRA MORADA &', '10'),
(6, 'PIE DE LIMON', '12'),
(7, 'PIE DE MANZANA', '10'),
(8, 'PIONONO', '10'),
(9, 'TORTA DE CHOCOLATE(SELVA NEGRA)', '10'),
(11, 'COMBINADO &', '14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `printer1`
--

CREATE TABLE `printer1` (
  `id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `printer1`
--

INSERT INTO `printer1` (`id`, `Name`) VALUES
(7, 'Microsoft XPS Document Writer'),
(8, 'Microsoft XPS Document Writer'),
(9, 'POS-80'),
(10, 'Y'),
(11, 'Y'),
(12, 'POS-80'),
(13, 'COCINA'),
(14, 'BARRA'),
(15, 'Microsoft XPS Document Writer'),
(17, 'COCINA'),
(18, 'COCINA'),
(19, 'COCINA'),
(20, 'CAJA'),
(21, 'COCINA'),
(22, 'BARRA'),
(23, 'COCINA'),
(24, 'BARRA'),
(25, 'COCINA'),
(26, 'BARRA'),
(27, 'BARRA'),
(28, 'BARRA'),
(29, 'COCINA'),
(30, 'BARRA'),
(31, 'COCINA'),
(32, 'COCINA'),
(33, 'Microsoft XPS Document Writer'),
(34, 'COCINA'),
(35, 'Microsoft XPS Document Writer'),
(36, 'Microsoft XPS Document Writer'),
(37, 'hrthrh');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `printer2`
--

CREATE TABLE `printer2` (
  `id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `printer2`
--

INSERT INTO `printer2` (`id`, `Name`) VALUES
(1, 'Microsoft XPS Document Writer'),
(2, ''),
(3, 'COCINA'),
(4, 'COCINA'),
(5, 'COCINA'),
(6, 'CAJA'),
(7, 'Microsoft XPS Document Writer'),
(9, 'BARRA'),
(10, 'BARRA'),
(11, 'BAR'),
(12, 'BARRA'),
(13, 'COCINA'),
(14, 'BARRA'),
(15, 'COCINA'),
(16, 'BARRA'),
(17, 'COCINA'),
(18, 'COCINA'),
(19, 'COCINA'),
(20, 'BARRA'),
(21, 'COCINA'),
(22, 'BARRA'),
(23, 'COCINA'),
(24, 'BARRA'),
(25, 'Microsoft XPS Document Writer'),
(26, 'BARRA'),
(27, 'gtygiykg'),
(28, 'Microsoft XPS Document Writer'),
(29, 'rthrt');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `printer3`
--

CREATE TABLE `printer3` (
  `id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `printer3`
--

INSERT INTO `printer3` (`id`, `Name`) VALUES
(1, 'Microsoft XPS Document Writer'),
(2, 'CAJA'),
(3, '0'),
(4, 'gogolo'),
(5, 'Microsoft XPS Document Writer'),
(6, 'rthrt');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bebidas`
--
ALTER TABLE `bebidas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `chamipedidosp1ben`
--
ALTER TABLE `chamipedidosp1ben`
  ADD PRIMARY KEY (`idchamipedidos`);

--
-- Indices de la tabla `entradas`
--
ALTER TABLE `entradas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `lastorder`
--
ALTER TABLE `lastorder`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `mozos`
--
ALTER TABLE `mozos`
  ADD PRIMARY KEY (`idMozos`);

--
-- Indices de la tabla `pcomb`
--
ALTER TABLE `pcomb`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pcriollo`
--
ALTER TABLE `pcriollo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `platofondo`
--
ALTER TABLE `platofondo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pmarino`
--
ALTER TABLE `pmarino`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `postres`
--
ALTER TABLE `postres`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `printer1`
--
ALTER TABLE `printer1`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `printer2`
--
ALTER TABLE `printer2`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `printer3`
--
ALTER TABLE `printer3`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bebidas`
--
ALTER TABLE `bebidas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;

--
-- AUTO_INCREMENT de la tabla `chamipedidosp1ben`
--
ALTER TABLE `chamipedidosp1ben`
  MODIFY `idchamipedidos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=563;

--
-- AUTO_INCREMENT de la tabla `entradas`
--
ALTER TABLE `entradas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `lastorder`
--
ALTER TABLE `lastorder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `pcomb`
--
ALTER TABLE `pcomb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT de la tabla `pcriollo`
--
ALTER TABLE `pcriollo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT de la tabla `platofondo`
--
ALTER TABLE `platofondo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT de la tabla `pmarino`
--
ALTER TABLE `pmarino`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT de la tabla `postres`
--
ALTER TABLE `postres`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `printer1`
--
ALTER TABLE `printer1`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de la tabla `printer2`
--
ALTER TABLE `printer2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT de la tabla `printer3`
--
ALTER TABLE `printer3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
