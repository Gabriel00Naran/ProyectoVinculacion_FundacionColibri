-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-05-2021 a las 23:14:45
-- Versión del servidor: 8.0.24
-- Versión de PHP: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `fundacioncolibri`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int NOT NULL,
  `RoleId` varchar(767) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `ClaimType` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `ClaimValue` text CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(767) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedName` varchar(256) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `ConcurrencyStamp` text CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL,
  `UserId` varchar(767) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `ClaimType` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `ClaimValue` text CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(767) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedUserName` varchar(256) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `NormalizedEmail` varchar(256) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `SecurityStamp` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `ConcurrencyStamp` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `PhoneNumber` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('73d339e2-4967-4e41-991d-ebd5ec72d938', 'Gabriel', 'GABRIEL', 'user@example.com', 'USER@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEDF2KHATtNv14WLXf3Nvh9jfCPPsMCqqydmor5WAX5Erb41c+6roXlYXwXC5iH9uYA==', 'VYHUS6RQPNQXIVQT5HUOXSBZ2CKAHEOM', '6526c371-6d70-4d7a-9d02-c945ad7103aa', NULL, 0, 0, NULL, 1, 0),
('b68aa48c-b0dc-4575-92ca-d35555ed966e', 'Geronimo', 'GERONIMO', 'user@example.com', 'USER@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEBLgIMD6gszYc73gwBeXf/QF3UPpXUWw349SdBAbnvKRYe7+2zcXTD88ztW7maHLAQ==', 'J5DN76P4LCS4SITUY7QSR2JMTY46M6I3', '0192187b-1b17-4450-9e6e-bbce9fb6c3aa', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `canton`
--

CREATE TABLE `canton` (
  `idcanton` int NOT NULL,
  `descripcioncanton` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `idprovincia` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `canton`
--

INSERT INTO `canton` (`idcanton`, `descripcioncanton`, `idprovincia`) VALUES
(1, 'Cuenca', 1),
(2, 'Girón', 1),
(3, 'Gualaceo', 1),
(4, 'Nabón', 1),
(5, 'Paute', 1),
(6, 'Pucara', 1),
(7, 'San Fernando', 1),
(8, 'Santa Isabel', 1),
(9, 'Sigsig', 1),
(10, 'Oña', 1),
(11, 'Chordeleg', 1),
(12, 'El Pan', 1),
(13, 'Sevilla de Oro', 1),
(14, 'Guachapala', 1),
(15, 'Camilo Ponce Enríquez', 1),
(16, 'Guaranda', 2),
(17, 'Chillanes', 2),
(18, 'Chimbo', 2),
(19, 'Echeandía', 2),
(20, 'San Miguel', 2),
(21, 'Caluma', 2),
(22, 'Las Naves', 2),
(23, 'Azogues', 3),
(24, 'Biblián', 3),
(25, 'Cañar', 3),
(26, 'La Troncal', 3),
(27, 'El Tambo', 3),
(28, 'Déleg', 3),
(29, 'Suscal', 3),
(30, 'Tulcán', 4),
(31, 'Bolívar', 4),
(32, 'Espejo', 4),
(33, 'Mira', 4),
(34, 'Montúfar', 4),
(35, 'San Pedro de Huaca', 4),
(36, 'Latacunga', 5),
(37, 'La Maná', 5),
(38, 'Pangua', 5),
(39, 'Pujili', 5),
(40, 'Salcedo', 5),
(41, 'Saquisilí', 5),
(42, 'Sigchos', 5),
(43, 'Riobamba', 6),
(44, 'Alausi', 6),
(45, 'Colta', 6),
(46, 'Chambo', 6),
(47, 'Chunchi', 6),
(48, 'Guamote', 6),
(49, 'Guano', 6),
(50, 'Pallatanga', 6),
(51, 'Penipe', 6),
(52, 'Cumandá', 6),
(53, 'Machala', 7),
(54, 'Arenillas', 7),
(55, 'Atahualpa', 7),
(56, 'Balsas', 7),
(57, 'Chilla', 7),
(58, 'El Guabo', 7),
(59, 'Huaquillas', 7),
(60, 'Marcabelí', 7),
(61, 'Pasaje', 7),
(62, 'Piñas', 7),
(63, 'Portovelo', 7),
(64, 'Santa Rosa', 7),
(65, 'Zaruma', 7),
(66, 'Las Lajas', 7),
(67, 'Esmeraldas', 8),
(68, 'Eloy Alfaro', 8),
(69, 'Muisne', 8),
(70, 'Quinindé', 8),
(71, 'San Lorenzo', 8),
(72, 'Atacames', 8),
(73, 'Rioverde', 8),
(74, 'La Concordia', 8),
(75, 'Guayaquil', 9),
(76, 'Alfredo Baquerizo Moreno (Juján)', 9),
(77, 'Balao', 9),
(78, 'Balzar', 9),
(79, 'Colimes', 9),
(80, 'Daule', 9),
(81, 'Durán', 9),
(82, 'El Empalme', 9),
(83, 'El Triunfo', 9),
(84, 'Milagro', 9),
(85, 'Naranjal', 9),
(86, 'Naranjito', 9),
(87, 'Palestina', 9),
(88, 'Pedro Carbo', 9),
(89, 'Samborondón', 9),
(90, 'Santa Lucía', 9),
(91, 'Salitre (Urbina Jado)', 9),
(92, 'San Jacinto de Yaguachi', 9),
(93, 'Playas', 9),
(94, 'Simón Bolívar', 9),
(95, 'Coronel Marcelino Maridueña', 9),
(96, 'Lomas de Sargentillo', 9),
(97, 'Nobol', 9),
(98, 'General Antonio Elizalde', 9),
(99, 'Isidro Ayora', 9),
(100, 'Ibarra', 10),
(101, 'Antonio Ante', 10),
(102, 'Cotacachi', 10),
(103, 'Otavalo', 10),
(104, 'Pimampiro', 10),
(105, 'San Miguel de Urcuquí', 10),
(106, 'Loja', 11),
(107, 'Calvas', 11),
(108, 'Catamayo', 11),
(109, 'Celica', 11),
(110, 'Chaguarpamba', 11),
(111, 'Espíndola', 11),
(112, 'Gonzanamá', 11),
(113, 'Macará', 11),
(114, 'Paltas', 11),
(115, 'Puyango', 11),
(116, 'Saraguro', 11),
(117, 'Sozoranga', 11),
(118, 'Zapotillo', 11),
(119, 'Pindal', 11),
(120, 'Quilanga', 11),
(121, 'Olmedo', 11),
(122, 'Babahoyo', 12),
(123, 'Baba', 12),
(124, 'Montalvo', 12),
(125, 'Puebloviejo', 12),
(126, 'Quevedo', 12),
(127, 'Urdaneta', 12),
(128, 'Ventanas', 12),
(129, 'Vínces', 12),
(130, 'Palenque', 12),
(131, 'Buena Fé', 12),
(132, 'Valencia', 12),
(133, 'Mocache', 12),
(134, 'Quinsaloma', 12),
(135, 'Portoviejo', 13),
(136, 'Bolívar', 13),
(137, 'Chone', 13),
(138, 'El Carmen', 13),
(139, 'Flavio Alfaro', 13),
(140, 'Jipijapa', 13),
(141, 'Junín', 13),
(142, 'Manta', 13),
(143, 'Montecristi', 13),
(144, 'Paján', 13),
(145, 'Pichincha', 13),
(146, 'Rocafuerte', 13),
(147, 'Santa Ana', 13),
(148, 'Sucre', 13),
(149, 'Tosagua', 13),
(150, '24 de Mayo', 13),
(151, 'Pedernales', 13),
(152, 'Olmedo', 13),
(153, 'Puerto López', 13),
(154, 'Jama', 13),
(155, 'Jaramijó', 13),
(156, 'San Vicente', 13),
(157, 'Morona', 14),
(158, 'Gualaquiza', 14),
(159, 'Limón Indanza', 14),
(160, 'Palora', 14),
(161, 'Santiago', 14),
(162, 'Sucúa', 14),
(163, 'Huamboya', 14),
(164, 'San Juan Bosco', 14),
(165, 'Taisha', 14),
(166, 'Logroño', 14),
(167, 'Pablo Sexto', 14),
(168, 'Tiwintza', 14),
(169, 'Tena', 15),
(170, 'Archidona', 15),
(171, 'El Chaco', 15),
(172, 'Quijos', 15),
(173, 'Carlos Julio Arosemena Tola', 15),
(174, 'Pastaza', 16),
(175, 'Mera', 16),
(176, 'Santa Clara', 16),
(177, 'Arajuno', 16),
(178, 'Quito', 17),
(179, 'Cayambe', 17),
(180, 'Mejia', 17),
(181, 'Pedro Moncayo', 17),
(182, 'Rumiñahui', 17),
(183, 'San Miguel de Los Bancos', 17),
(184, 'Pedro Vicente Maldonado', 17),
(185, 'Puerto Quito', 17),
(186, 'Ambato', 18),
(187, 'Baños de Agua Santa', 18),
(188, 'Cevallos', 18),
(189, 'Mocha', 18),
(190, 'Patate', 18),
(191, 'Quero', 18),
(192, 'San Pedro de Pelileo', 18),
(193, 'Santiago de Píllaro', 18),
(194, 'Tisaleo', 18),
(195, 'Zamora', 19),
(196, 'Chinchipe', 19),
(197, 'Nangaritza', 19),
(198, 'Yacuambi', 19),
(199, 'Yantzaza (Yanzatza)', 19),
(200, 'El Pangui', 19),
(201, 'Centinela del Cóndor', 19),
(202, 'Palanda', 19),
(203, 'Paquisha', 19),
(204, 'San Cristóbal', 20),
(205, 'Isabela', 20),
(206, 'Santa Cruz', 20),
(207, 'Lago Agrio', 21),
(208, 'Gonzalo Pizarro', 21),
(209, 'Putumayo', 21),
(210, 'Shushufindi', 21),
(211, 'Sucumbíos', 21),
(212, 'Cascales', 21),
(213, 'Cuyabeno', 21),
(214, 'Orellana', 22),
(215, 'Aguarico', 22),
(216, 'La Joya de Los Sachas', 22),
(217, 'Loreto', 22),
(218, 'Santo Domingo', 23),
(219, 'Santa Elena', 24),
(220, 'La Libertad', 24),
(221, 'Salinas', 24),
(222, 'Las Golondrinas', 25),
(223, 'Manga del Cura', 25),
(224, 'El Piedrero', 25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `casaacogimiento`
--

CREATE TABLE `casaacogimiento` (
  `idnombrecasaanterior` int NOT NULL,
  `descripcioncasaacogimiento` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `casaacogimiento`
--

INSERT INTO `casaacogimiento` (`idnombrecasaanterior`, `descripcioncasaacogimiento`) VALUES
(1, 'No aplica'),
(2, 'Aldeas SOS Quito'),
(3, 'Aldeas SOS Imbabura'),
(4, 'Aldeas SOS Cuenca'),
(5, 'Aldeas SOS Esmeraldas'),
(6, 'Aldeas SOS Guayaquil'),
(7, 'Aldeas SOS Manabí'),
(8, 'ALIÑAMBI'),
(9, 'Árbol de la Esperanza'),
(10, 'Asociación Solidaridad y Acción ASA'),
(11, 'Buen Pastor'),
(12, 'Casa Hogar Semillas de Colores'),
(13, 'Casa Hogar Emanuel'),
(14, 'Casa Hogar Guayaquil'),
(15, 'Casa Hogar Infanto Juvenil de Varones'),
(16, 'Casa Hogar Infanto Juvenil Femenina'),
(17, 'Casa Hogar María Campi de Yóder'),
(18, 'Casa Hogar San Carlos'),
(19, 'Casa Linda'),
(20, 'Casita de mis sueños'),
(21, 'CEMESOL'),
(22, 'Centro de Acogimiento Municipal San Jerónimo Emiliani'),
(23, 'Centro de Acogimiento GAD Municipal de Pastaza'),
(24, 'Centro de Protección Especial Macas'),
(25, 'Dorotea Carrión'),
(26, 'Dueña de Mí'),
(27, 'Enríquez Gallo'),
(28, 'Flora Pallota'),
(29, 'Fundación Jardín del Cajas'),
(30, 'Fundación Acción Social Caritas'),
(31, 'Fundación Albergue La Dolorosa'),
(32, 'Fundación Caminos de Esperanza Talita Kumi'),
(33, 'Fundación Casa de Fe'),
(34, 'Fundación Casa Hogar de Jesús'),
(35, 'Fundación Construyamos un Sueño Proyecto un Hogar para Todos'),
(36, 'Fundación Cristo de la Calle'),
(37, 'Fundación Don Bosco'),
(38, 'Fundación Hacienda de Esperanza'),
(39, 'Fundación Henry Davis'),
(40, 'Fundación Juvilus'),
(41, 'Fundación Kairos'),
(42, 'Fundación Proyecto Salesiano Ecuador'),
(43, 'Fundación Proyecto Salesiano Guayaquil'),
(44, 'Fundación Pueblito La Ternura Obra Prisca'),
(45, 'Fundación Remar Azogues'),
(46, 'Fundación Santa María de la Esperanza'),
(47, 'SHEKINAH'),
(48, 'Fundación Sor Dominga Bocca'),
(49, 'Hilando Nuestros Sueños'),
(50, 'Hogar Belén'),
(51, 'Hogar de Nazaret'),
(52, 'Hogar El Amanecer'),
(53, 'Hogar Infantil Tadeo Torres'),
(54, 'Hogar Manuela Pérez'),
(55, 'Hogar Mercedes de Jesús Molina'),
(56, 'Hogar Nuestra Señora de Loreto'),
(57, 'Hogar Para Sus Niños'),
(58, 'Hogar Para Todos Azogues'),
(59, 'Hogar Santa Lucía'),
(60, 'Hogar Santa Marianita'),
(61, 'Hogar Valle Feliz'),
(62, 'HPSN'),
(63, 'Inés Chambers'),
(64, 'Jardín del Edén'),
(65, 'Laura Vicuña'),
(66, 'María Bordoni'),
(67, 'Mercedes de Jesús Molina'),
(68, 'Mi Hogar'),
(69, 'Mi Rinconcito'),
(70, 'Miguel León'),
(71, 'Mini Aldea Hogar Suizo'),
(72, 'Nuestra Casa'),
(73, 'Nueva Esperanza'),
(74, 'Padre Julio Villarroel'),
(75, 'Patricia Elena Cisneros Abad'),
(76, 'Proyecto Salesiano Mi Caleta'),
(77, 'Proyecto Salesiano Guayaquil'),
(78, 'Remar La Gasca'),
(79, 'Remar Mitad del Mundo'),
(80, 'San Camilo de Lellis'),
(81, 'San Leonardo Murialdo'),
(82, 'San Vicente de Paúl'),
(83, 'Santa Mariana de Jesus'),
(84, 'Manos Unidas Tejiendo Progreso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datosjudicialpenal`
--

CREATE TABLE `datosjudicialpenal` (
  `idjudicialpenal` int NOT NULL,
  `idpersona` int DEFAULT NULL,
  `idmedida` int DEFAULT NULL,
  `idprovincia` int DEFAULT NULL,
  `ncausaacogimiento` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `unidadjudicial` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `idcanton` int DEFAULT NULL,
  `idnudoscriticos` int DEFAULT NULL,
  `existecausapenal` bit(1) DEFAULT NULL,
  `encuentrainsert@spavt` bit(1) DEFAULT NULL,
  `idinfracciondenunciada` int DEFAULT NULL,
  `descripciondelito` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `ncasofiscalia` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `nprocesopenalesatje` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `idestadoprocesal` int DEFAULT NULL,
  `egresoporreinsercion` bit(1) DEFAULT NULL,
  `fechareinsercion` date DEFAULT NULL,
  `fechaegreso` date DEFAULT NULL,
  `fecharesoluciontraslado` date DEFAULT NULL,
  `unidadtraslado` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `fechasalidaunidadactual` date DEFAULT NULL,
  `observacion` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `datosjudicialpenal`
--

INSERT INTO `datosjudicialpenal` (`idjudicialpenal`, `idpersona`, `idmedida`, `idprovincia`, `ncausaacogimiento`, `unidadjudicial`, `idcanton`, `idnudoscriticos`, `existecausapenal`, `encuentrainsert@spavt`, `idinfracciondenunciada`, `descripciondelito`, `ncasofiscalia`, `nprocesopenalesatje`, `idestadoprocesal`, `egresoporreinsercion`, `fechareinsercion`, `fechaegreso`, `fecharesoluciontraslado`, `unidadtraslado`, `fechasalidaunidadactual`, `observacion`) VALUES
(1, 3, 1, 3, '123454435', 'dasfgfdgfhg', 25, 6, b'1', b'1', 1, 'mato alguinen', '12', '234', 2, b'1', '2021-05-24', NULL, '2021-04-17', 'nose', '2021-04-27', 'nada malo solo mato a alguien'),
(2, 4, 1, 2, '23456tfere', 'el penal ', 17, 4, b'1', b'1', 2, '', 'q12323', '123123231', 2, b'0', NULL, NULL, NULL, '', NULL, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datossalud`
--

CREATE TABLE `datossalud` (
  `iddatossalud` int NOT NULL,
  `idpersona` int DEFAULT NULL,
  `estadosalud` char(15) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `detalleenfermedad` varchar(120) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `medicacion` bit(1) DEFAULT NULL,
  `adolescenteperdiodogestacion` bit(1) DEFAULT NULL,
  `algunadiscapacidad` bit(1) DEFAULT NULL,
  `tipodiscapacidad` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `porcentajediscapacidad` varchar(6) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `numerocarnet` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `datossalud`
--

INSERT INTO `datossalud` (`iddatossalud`, `idpersona`, `estadosalud`, `detalleenfermedad`, `medicacion`, `adolescenteperdiodogestacion`, `algunadiscapacidad`, `tipodiscapacidad`, `porcentajediscapacidad`, `numerocarnet`) VALUES
(1, 3, 'Enferm@', 'mal', b'1', b'0', b'0', '', '', ''),
(2, 4, 'Enferm@', 'pulmonia', b'1', b'1', b'1', 'visual', '100', '124dr21');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoprocesal`
--

CREATE TABLE `estadoprocesal` (
  `idestadoprocesal` int NOT NULL,
  `descripcionprocesal` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `estadoprocesal`
--

INSERT INTO `estadoprocesal` (`idestadoprocesal`, `descripcionprocesal`) VALUES
(1, 'Noticia del delito'),
(2, 'nvestigación previa'),
(3, 'Instrucción fiscal'),
(4, 'Juicio,Sentencia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `etnia`
--

CREATE TABLE `etnia` (
  `idetnia` int NOT NULL,
  `descripcionetnia` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `etnia`
--

INSERT INTO `etnia` (`idetnia`, `descripcionetnia`) VALUES
(1, 'Afroecuatoriana'),
(2, 'Indígena'),
(3, 'Mestiza'),
(4, 'Montuvia'),
(5, 'Mulata');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `familiarreferente`
--

CREATE TABLE `familiarreferente` (
  `idfamiliarreferente` int NOT NULL,
  `descripcionfamiliarreferente` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `familiarreferente`
--

INSERT INTO `familiarreferente` (`idfamiliarreferente`, `descripcionfamiliarreferente`) VALUES
(1, 'Madre'),
(2, 'Padre'),
(3, 'Familia Nuclear (papá y mamá)'),
(4, 'Abuela'),
(5, 'Abuelo'),
(6, 'Abuel@s'),
(7, 'Bisabuelo'),
(8, 'Bisabuela'),
(9, 'Bisabuel@s'),
(10, 'Hermano'),
(11, 'Hermana'),
(12, 'Herman@s'),
(13, 'Tío'),
(14, 'Tía'),
(15, 'Tí@s'),
(16, 'No tiene referente familiar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genero`
--

CREATE TABLE `genero` (
  `idgenero` int NOT NULL,
  `descripciongenero` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `genero`
--

INSERT INTO `genero` (`idgenero`, `descripciongenero`) VALUES
(1, 'Masculino'),
(2, 'Femenino'),
(3, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historialcronologico`
--

CREATE TABLE `historialcronologico` (
  `idhistorial` int NOT NULL,
  `idpersona` int DEFAULT NULL,
  `estuboacogimiento` bit(1) DEFAULT NULL,
  `idnombrecasaanterior` int DEFAULT NULL,
  `fechaegreso` date DEFAULT NULL,
  `fechaingreso` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `historialcronologico`
--

INSERT INTO `historialcronologico` (`idhistorial`, `idpersona`, `estuboacogimiento`, `idnombrecasaanterior`, `fechaegreso`, `fechaingreso`) VALUES
(1, 3, b'0', 5, '2021-04-21', '2021-04-14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `infracciondenunciada`
--

CREATE TABLE `infracciondenunciada` (
  `idinfracciondenunciada` int NOT NULL,
  `descripcioninfracciondenuncia` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `infracciondenunciada`
--

INSERT INTO `infracciondenunciada` (`idinfracciondenunciada`, `descripcioninfracciondenuncia`) VALUES
(1, 'violencia Sexual'),
(2, 'Violencia Física'),
(3, 'Violencia psicológica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medida`
--

CREATE TABLE `medida` (
  `idmedida` int NOT NULL,
  `descripcionmedida` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `medida`
--

INSERT INTO `medida` (`idmedida`, `descripcionmedida`) VALUES
(1, 'Juducial'),
(2, 'Administrativa'),
(3, 'Sin medida');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modalidad`
--

CREATE TABLE `modalidad` (
  `idmodalidad` int NOT NULL,
  `descripcionmodalidad` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `modalidad`
--

INSERT INTO `modalidad` (`idmodalidad`, `descripcionmodalidad`) VALUES
(1, 'Custodia Familiar'),
(2, 'Acogimiento Familiar'),
(3, 'Acogimiento Institucional'),
(4, 'Apoyo Familiar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `motivoingreso`
--

CREATE TABLE `motivoingreso` (
  `idmotivoingreso` int NOT NULL,
  `descripcionmotivoingreso` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `motivoingreso`
--

INSERT INTO `motivoingreso` (`idmotivoingreso`, `descripcionmotivoingreso`) VALUES
(1, 'Abandono'),
(2, 'Abuso Sexual'),
(3, 'Callejización'),
(4, 'Falta de recursos'),
(5, 'Maltrato'),
(6, 'Maltrato y Negligencia'),
(7, 'Negligencia'),
(8, 'Orfandad'),
(9, 'ProgenitoresPPL'),
(10, 'Trata,Violación'),
(11, 'Hijo/a de adolescente en acogimiento institucional'),
(12, 'Otros');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nacionalidad`
--

CREATE TABLE `nacionalidad` (
  `idnacionalidad` int NOT NULL,
  `descripcionnacionalidad` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `nacionalidad`
--

INSERT INTO `nacionalidad` (`idnacionalidad`, `descripcionnacionalidad`) VALUES
(1, 'Ecuatoriana'),
(2, 'Peruana'),
(3, 'Española'),
(4, 'Guatemalteca'),
(5, 'Venezolana'),
(6, 'Colombiana'),
(7, 'Chilena'),
(8, 'Salvadoreña'),
(9, 'Boliviana'),
(10, 'Brasileña'),
(11, 'Mexicana'),
(12, 'Hondureña'),
(13, 'Costa Riquense'),
(14, 'Cubana'),
(15, 'Haitiana'),
(16, 'Nicaragüense'),
(17, 'Panameña'),
(18, 'Estadounidense'),
(19, 'Urugaya'),
(20, 'Dominicana'),
(21, 'Puerto Riquenses'),
(22, 'Paraguense');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nivelacademico`
--

CREATE TABLE `nivelacademico` (
  `idnivelacademico` int NOT NULL,
  `descripcionacademico` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `nivelacademico`
--

INSERT INTO `nivelacademico` (`idnivelacademico`, `descripcionacademico`) VALUES
(1, 'Inicial I'),
(2, 'Inicial II'),
(3, 'Primero de Básica'),
(4, 'Segundo de Básica'),
(5, 'Tercero de Básica'),
(6, 'Cuarto de Básica'),
(7, 'Quinto de Básica'),
(8, 'Sexto de Básica'),
(9, 'Séptimo de Básica'),
(10, 'Octavo de Básica'),
(11, 'Noveno de Básica'),
(12, 'Décimo de Básica'),
(13, 'Primero de Bachillerato'),
(14, 'Segundo de Bachillerato'),
(15, 'Tercero de Bachillerato'),
(16, 'Cuarto de Bachillerato'),
(17, 'Quinto de Bachillerato'),
(18, 'Sexo de Bachillerato'),
(19, 'Educación Superior');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nudoscriticos`
--

CREATE TABLE `nudoscriticos` (
  `idnudoscriticos` int NOT NULL,
  `descripcionnudoscriticos` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `nudoscriticos`
--

INSERT INTO `nudoscriticos` (`idnudoscriticos`, `descripcionnudoscriticos`) VALUES
(1, 'No existen nudos críticos'),
(2, 'Espera asignación de familia'),
(3, 'Espera emparentamiento'),
(4, 'Falta despacho judicial'),
(5, 'Falta Impulso Defensoría Pública'),
(6, 'Falta impulso entidad'),
(7, 'Falta informes esclarecimiento (Fiscalía - Dinapen - Oficina Técnica)'),
(8, 'Espera de egreso'),
(9, 'Situación por solventar antes del ingreso Unida ténica de Adopciones/Comité de Asignación Familiar'),
(10, 'Vínculo fuerte con su familia - pero no apta reinserción'),
(11, 'Negativa del adolescente para reinserción'),
(12, 'Negativa del adolescente para declaratoria de adoptabilidad'),
(13, 'Ausencia voluntaria');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `organizacion`
--

CREATE TABLE `organizacion` (
  `idorganizacion` int NOT NULL,
  `descripcionorganizacion` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `organizacion`
--

INSERT INTO `organizacion` (`idorganizacion`, `descripcionorganizacion`) VALUES
(1, 'No aplica'),
(2, 'Aldeas SOS Quito'),
(3, 'Aldeas SOS Imbabura'),
(4, 'Aldeas SOS Cuenca'),
(5, 'Aldeas SOS Esmeraldas'),
(6, 'Aldeas SOS Guayaquil'),
(7, 'Aldeas SOS Manabí'),
(8, 'Aliñambi'),
(9, 'Árbol de la Esperanza'),
(10, 'Asociación Solidaridad y Acción ASA'),
(11, 'Buen Pastor'),
(12, 'Casa Hogar Semillas de Colores'),
(13, 'Casa Hogar Emanuel'),
(14, 'Casa Hogar Guayaquil'),
(15, 'Casa Hogar Infanto Juvenil de Varones'),
(16, 'Casa Hogar Infanto Juvenil Femenina'),
(17, 'Casa Hogar María Campi de Yóder'),
(18, 'Casa Hogar San Carlos'),
(19, 'Casa Linda'),
(20, 'Casita de mis sueños'),
(21, 'CEMESOL'),
(22, 'Centro de Acogimiento Municipal San Jerónimo Emiliani'),
(23, 'Centro de Acogimiento GAD Municipal de Pastaza'),
(24, 'Centro de Protección Especial Macas'),
(25, 'Dorotea Carrión'),
(26, 'Dueña de Mí'),
(27, 'Enríquez Gallo'),
(28, 'Flora Pallota'),
(29, 'Fundación Jardín del Cajas'),
(30, 'Fundación Acción Social Caritas'),
(31, 'Fundación Albergue La Dolorosa'),
(32, 'Fundación Caminos de Esperanza Talita Kumi'),
(33, 'Fundación Casa de Fe'),
(34, 'Fundación Casa Hogar de Jesús'),
(35, 'Fundación Construyamos un Sueño Proyecto un Hogar para Todos'),
(36, 'Fundación Cristo de la Calle'),
(37, 'Fundación Don Bosco'),
(38, 'Fundación Hacienda de Esperanza'),
(39, 'Fundación Henry Davis'),
(40, 'Fundación Juvilus'),
(41, 'Fundación Kairos'),
(42, 'Fundación Proyecto Salesiano Ecuador'),
(43, 'Fundación Proyecto Salesiano Guayaquil'),
(44, 'Fundación Pueblito La Ternura Obra Prisca'),
(45, 'Fundación Remar Azogues'),
(46, 'Fundación Santa María de la Esperanza'),
(47, 'SHEKINAH'),
(48, 'Fundación Sor Dominga Bocca'),
(49, 'Hilando Nuestros Sueños'),
(50, 'Hogar Belén'),
(51, 'Hogar de Nazaret'),
(52, 'Hogar El Amanecer'),
(53, 'Hogar Infantil Tadeo Torres'),
(54, 'Hogar Manuela Pérez'),
(55, 'Hogar Mercedes de Jesús Molina'),
(56, 'Hogar Nuestra Señora de Loreto'),
(57, 'Hogar Para Sus Niños'),
(58, 'Hogar Para Todos Azogues'),
(59, 'Hogar Santa Lucía'),
(60, 'Hogar Santa Marianita'),
(61, 'Hogar Valle Feliz'),
(62, 'HPSN'),
(63, 'Inés Chambers'),
(64, 'Jardín del Edén'),
(65, 'Laura Vicuña'),
(66, 'María Bordoni'),
(67, 'Mercedes de Jesús Molina'),
(68, 'Mi Hogar'),
(69, 'Mi Rinconcito'),
(70, 'Miguel León'),
(71, 'Mini Aldea Hogar Suizo'),
(72, 'Nuestra Casa'),
(73, 'Nueva Esperanza'),
(74, 'Padre Julio Villarroel'),
(75, 'Patricia Elena Cisneros Abad'),
(76, 'Proyecto Salesiano Mi Caleta'),
(77, 'Proyecto Salesiano Guayaquil'),
(78, 'Remar La Gasca'),
(79, 'Remar Mitad del Mundo'),
(80, 'San Camilo de Lellis'),
(81, 'San Leonardo Murialdo'),
(82, 'San Vicente de Paúl'),
(83, 'Santa Mariana de Jesus'),
(84, 'Fundación Alas de Colibrí'),
(85, 'María de Bethlem'),
(86, 'Centro de Orientación Juvenil la Dolorosa');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `parroquia`
--

CREATE TABLE `parroquia` (
  `idparroquia` int NOT NULL,
  `descripcionparroquia` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `idcanton` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `parroquia`
--

INSERT INTO `parroquia` (`idparroquia`, `descripcionparroquia`, `idcanton`) VALUES
(1, 'Bellavista', 1),
(2, 'Cañaribamba', 1),
(3, 'El Batán', 1),
(4, 'El Sagrario', 1),
(5, 'El Vecino', 1),
(6, 'Gil Ramírez Dávalos', 1),
(7, 'Huaynacápac', 1),
(8, 'Machángara', 1),
(9, 'Monay', 1),
(10, 'San Blas', 1),
(11, 'San Sebastián', 1),
(12, 'Sucre', 1),
(13, 'Totoracocha', 1),
(14, 'Yanuncay', 1),
(15, 'Hermano Miguel', 1),
(16, 'Cuenca', 1),
(17, 'Baños', 1),
(18, 'Cumbe', 1),
(19, 'Chaucha', 1),
(20, 'Checa (Jidcay)', 1),
(21, 'Chiquintad', 1),
(22, 'Llacao', 1),
(23, 'Molleturo', 1),
(24, 'Nulti', 1),
(25, 'Octavio Cordero Palacios (Santa Rosa)', 1),
(26, 'Paccha', 1),
(27, 'Quingeo', 1),
(28, 'Ricaurte', 1),
(29, 'San Joaquín', 1),
(30, 'Santa Ana', 1),
(31, 'Sayausí', 1),
(32, 'Sidcay', 1),
(33, 'Sinincay', 1),
(34, 'Tarqui', 1),
(35, 'Turi', 1),
(36, 'Valle', 1),
(37, 'Victoria del Portete (Irquis)', 1),
(38, 'Girón', 2),
(39, 'Asunción', 2),
(40, 'San Gerardo', 2),
(41, 'Gualaceo', 3),
(42, 'Chordeleg', 3),
(43, 'Daniel Córdova Toral (El Oriente)', 3),
(44, 'Jadán', 3),
(45, 'Mariano Moreno', 3),
(46, 'Principal', 3),
(47, 'Remigio Crespo Toral (Gúlag)', 3),
(48, 'San Juan', 3),
(49, 'Zhidmad', 3),
(50, 'Luis Cordero Vega', 3),
(51, 'Simón Bolívar (Cab. En Gañanzol)', 3),
(52, 'Nabón', 4),
(53, 'Cochapata', 4),
(54, 'El Progreso (Cab.En Zhota)', 4),
(55, 'Las Nieves (Chaya)', 4),
(56, 'Oña', 4),
(57, 'Paute', 5),
(58, 'Amaluza', 5),
(59, 'Bulán (José Víctor Izquierdo)', 5),
(60, 'Chicán (Guillermo Ortega)', 5),
(61, 'El Cabo', 5),
(62, 'Guachapala', 5),
(63, 'Guarainag', 5),
(64, 'Palmas', 5),
(65, 'Pan', 5),
(66, 'San Cristóbal (Carlos Ordóñez Lazo)', 5),
(67, 'Sevilla de Oro', 5),
(68, 'Tomebamba', 5),
(69, 'Dug Dug', 5),
(70, 'Pucará', 6),
(71, 'Camilo Ponce Enríquez (Cab. En Río 7 de Mollepongo)', 6),
(72, 'San Rafael de Sharug', 6),
(73, 'San Fernando', 7),
(74, 'Chumblín', 7),
(75, 'Santa Isabel (Chaguarurco)', 8),
(76, 'Abdón Calderón (La Unión)', 8),
(77, 'El Carmen de Pijilí', 8),
(78, 'Zhaglli (Shaglli)', 8),
(79, 'San Salvador de Cañaribamba', 8),
(80, 'Sigsig', 9),
(81, 'Cuchil (Cutchil)', 9),
(82, 'Gima', 9),
(83, 'Guel', 9),
(84, 'Ludo', 9),
(85, 'San Bartolomé', 9),
(86, 'San José de Raranga', 9),
(87, 'San Felipe de Oña Cabecera Cantonal', 10),
(88, 'Susudel', 10),
(89, 'Chordeleg', 11),
(90, 'Principal', 11),
(91, 'La Unión', 11),
(92, 'Luis Galarza Orellana (Cab.En Delegsol)', 11),
(93, 'San Martín de Puzhio', 11),
(94, 'El Pan', 12),
(95, 'Amaluza', 12),
(96, 'Palmas', 12),
(97, 'San Vicente', 12),
(98, 'Sevilla de Oro', 13),
(99, 'Amaluza', 13),
(100, 'Palmas', 13),
(101, 'Guachapala', 14),
(102, 'Camilo Ponce Enríquez', 15),
(103, 'El Carmen de Pijilí', 15),
(104, 'Ángel Polibio Cháves', 16),
(105, 'Gabriel Ignacio Veintimilla', 16),
(106, 'Guanujo', 16),
(107, 'Guaranda', 16),
(108, 'Facundo Vela', 16),
(109, 'Guanujo', 16),
(110, 'Julio E. Moreno (Catanahuán Grande)', 16),
(111, 'Las Naves', 16),
(112, 'Salinas', 16),
(113, 'San Lorenzo', 16),
(114, 'San Simón (Yacoto)', 16),
(115, 'Santa Fé (Santa Fé)', 16),
(116, 'Simiátug', 16),
(117, 'San Luis de Pambil', 16),
(118, 'Chillanes', 17),
(119, 'San José del Tambo (Tambopamba)', 17),
(120, 'San José de Chimbo', 18),
(121, 'Asunción (Asancoto)', 18),
(122, 'Caluma', 18),
(123, 'Magdalena (Chapacoto)', 18),
(124, 'San Sebastián', 18),
(125, 'Telimbela', 18),
(126, 'Echeandía', 19),
(127, 'San Miguel', 20),
(128, 'Balsapamba', 20),
(129, 'Bilován', 20),
(130, 'Régulo de Mora', 20),
(131, 'San Pablo (San Pablo de Atenas)', 20),
(132, 'Santiago', 20),
(133, 'San Vicente', 20),
(134, 'Caluma', 21),
(135, 'Las Mercedes', 22),
(136, 'Las Naves', 22),
(137, 'Las Naves', 22),
(138, 'Aurelio Bayas Martínez', 23),
(139, 'Azogues', 23),
(140, 'Borrero', 23),
(141, 'San Francisco', 23),
(142, 'Azogues', 23),
(143, 'Cojitambo', 23),
(144, 'Déleg', 23),
(145, 'Guapán', 23),
(146, 'Javier Loyola (Chuquipata)', 23),
(147, 'Luis Cordero', 23),
(148, 'Pindilig', 23),
(149, 'Rivera', 23),
(150, 'San Miguel', 23),
(151, 'Solano', 23),
(152, 'Taday', 23),
(153, 'Biblián', 24),
(154, 'Nazón (Cab. En Pampa de Domínguez)', 24),
(155, 'San Francisco de Sageo', 24),
(156, 'Turupamba', 24),
(157, 'Jerusalén', 24),
(158, 'Cañar', 25),
(159, 'Chontamarca', 25),
(160, 'Chorocopte', 25),
(161, 'General Morales (Socarte)', 25),
(162, 'Gualleturo', 25),
(163, 'Honorato Vásquez (Tambo Viejo)', 25),
(164, 'Ingapirca', 25),
(165, 'Juncal', 25),
(166, 'San Antonio', 25),
(167, 'Suscal', 25),
(168, 'Tambo', 25),
(169, 'Zhud', 25),
(170, 'Ventura', 25),
(171, 'Ducur', 25),
(172, 'La Troncal', 26),
(173, 'Manuel J. Calle', 26),
(174, 'Pancho Negro', 26),
(175, 'El Tambo', 27),
(176, 'Déleg', 28),
(177, 'Solano', 28),
(178, 'Suscal', 29),
(179, 'González Suárez', 30),
(180, 'Tulcán', 30),
(181, 'Tulcán', 30),
(182, 'El Carmelo (El Pun)', 30),
(183, 'Huaca', 30),
(184, 'Julio Andrade (Orejuela)', 30),
(185, 'Maldonado', 30),
(186, 'Pioter', 30),
(187, 'Tobar Donoso (La Bocana de Camumbí)', 30),
(188, 'Tufiño', 30),
(189, 'Urbina (Taya)', 30),
(190, 'El Chical', 30),
(191, 'Mariscal Sucre', 30),
(192, 'Santa Martha de Cuba', 30),
(193, 'Bolívar', 31),
(194, 'García Moreno', 31),
(195, 'Los Andes', 31),
(196, 'Monte Olivo', 31),
(197, 'San Vicente de Pusir', 31),
(198, 'San Rafael', 31),
(199, 'El Ángel', 32),
(200, '27 de Septiembre', 32),
(201, 'El Angel', 32),
(202, 'El Goaltal', 32),
(203, 'La Libertad (Alizo)', 32),
(204, 'San Isidro', 32),
(205, 'Mira (Chontahuasi)', 33),
(206, 'Concepción', 33),
(207, 'Jijón Y Caamaño (Cab. En Río Blanco)', 33),
(208, 'Juan Montalvo (San Ignacio de Quil)', 33),
(209, 'González Suárez', 34),
(210, 'San José', 34),
(211, 'San Gabriel', 34),
(212, 'Cristóbal Colón', 34),
(213, 'Chitán de Navarrete', 34),
(214, 'Fernández Salvador', 34),
(215, 'La Paz', 34),
(216, 'Piartal', 34),
(217, 'Huaca', 35),
(218, 'Mariscal Sucre', 35),
(219, 'Eloy Alfaro (San Felipe)', 36),
(220, 'Ignacio Flores (Parque Flores)', 36),
(221, 'Juan Montalvo (San Sebastián)', 36),
(222, 'La Matriz', 36),
(223, 'San Buenaventura', 36),
(224, 'Latacunga', 36),
(225, 'Alaques (Aláquez)', 36),
(226, 'Belisario Quevedo (Guanailín)', 36),
(227, 'Guaitacama (Guaytacama)', 36),
(228, 'Joseguango Bajo', 36),
(229, 'Las Pampas', 36),
(230, 'Mulaló', 36),
(231, '11 de Noviembre (Ilinchisi)', 36),
(232, 'Poaló', 36),
(233, 'San Juan de Pastocalle', 36),
(234, 'Sigchos', 36),
(235, 'Tanicuchí', 36),
(236, 'Toacaso', 36),
(237, 'Palo Quemado', 36),
(238, 'El Carmen', 37),
(239, 'La Maná', 37),
(240, 'El Triunfo', 37),
(241, 'La Maná', 37),
(242, 'Guasaganda (Cab.En Guasaganda', 37),
(243, 'Pucayacu', 37),
(244, 'El Corazón', 38),
(245, 'Moraspungo', 38),
(246, 'Pinllopata', 38),
(247, 'Ramón Campaña', 38),
(248, 'Pujilí', 39),
(249, 'Angamarca', 39),
(250, 'Chucchilán (Chugchilán)', 39),
(251, 'Guangaje', 39),
(252, 'Isinlibí (Isinliví)', 39),
(253, 'La Victoria', 39),
(254, 'Pilaló', 39),
(255, 'Tingo', 39),
(256, 'Zumbahua', 39),
(257, 'San Miguel', 40),
(258, 'Antonio José Holguín (Santa Lucía)', 40),
(259, 'Cusubamba', 40),
(260, 'Mulalillo', 40),
(261, 'Mulliquindil (Santa Ana)', 40),
(262, 'Pansaleo', 40),
(263, 'Saquisilí', 41),
(264, 'Canchagua', 41),
(265, 'Chantilín', 41),
(266, 'Cochapamba', 41),
(267, 'Sigchos', 42),
(268, 'Chugchillán', 42),
(269, 'Isinliví', 42),
(270, 'Las Pampas', 42),
(271, 'Palo Quemado', 42),
(272, 'Lizarzaburu', 43),
(273, 'Maldonado', 43),
(274, 'Velasco', 43),
(275, 'Veloz', 43),
(276, 'Yaruquíes', 43),
(277, 'Riobamba', 43),
(278, 'Cacha (Cab. En Machángara)', 43),
(279, 'Calpi', 43),
(280, 'Cubijíes', 43),
(281, 'Flores', 43),
(282, 'Licán', 43),
(283, 'Licto', 43),
(284, 'Pungalá', 43),
(285, 'Punín', 43),
(286, 'Quimiag', 43),
(287, 'San Juan', 43),
(288, 'San Luis', 43),
(289, 'Alausí', 44),
(290, 'Achupallas', 44),
(291, 'Cumandá', 44),
(292, 'Guasuntos', 44),
(293, 'Huigra', 44),
(294, 'Multitud', 44),
(295, 'Pistishí (Nariz del Diablo)', 44),
(296, 'Pumallacta', 44),
(297, 'Sevilla', 44),
(298, 'Sibambe', 44),
(299, 'Tixán', 44),
(300, 'Cajabamba', 45),
(301, 'Sicalpa', 45),
(302, 'Villa La Unión (Cajabamba)', 45),
(303, 'Cañi', 45),
(304, 'Columbe', 45),
(305, 'Juan de Velasco (Pangor)', 45),
(306, 'Santiago de Quito (Cab. En San Antonio de Quito)', 45),
(307, 'Chambo', 46),
(308, 'Chunchi', 47),
(309, 'Capzol', 47),
(310, 'Compud', 47),
(311, 'Gonzol', 47),
(312, 'Llagos', 47),
(313, 'Guamote', 48),
(314, 'Cebadas', 48),
(315, 'Palmira', 48),
(316, 'El Rosario', 49),
(317, 'La Matriz', 49),
(318, 'Guano', 49),
(319, 'Guanando', 49),
(320, 'Ilapo', 49),
(321, 'La Providencia', 49),
(322, 'San Andrés', 49),
(323, 'San Gerardo de Pacaicaguán', 49),
(324, 'San Isidro de Patulú', 49),
(325, 'San José del Chazo', 49),
(326, 'Santa Fé de Galán', 49),
(327, 'Valparaíso', 49),
(328, 'Pallatanga', 50),
(329, 'Penipe', 51),
(330, 'El Altar', 51),
(331, 'Matus', 51),
(332, 'Puela', 51),
(333, 'San Antonio de Bayushig', 51),
(334, 'La Candelaria', 51),
(335, 'Bilbao (Cab.En Quilluyacu)', 51),
(336, 'Cumandá', 52),
(337, 'La Providencia', 53),
(338, 'Machala', 53),
(339, 'Puerto Bolívar', 53),
(340, 'Nueve de Mayo', 53),
(341, 'El Cambio', 53),
(342, 'Machala', 53),
(343, 'El Cambio', 53),
(344, 'El Retiro', 53),
(345, 'Arenillas', 54),
(346, 'Chacras', 54),
(347, 'La Libertad', 54),
(348, 'Las Lajas (Cab. En La Victoria)', 54),
(349, 'Palmales', 54),
(350, 'Carcabón', 54),
(351, 'Paccha', 55),
(352, 'Ayapamba', 55),
(353, 'Cordoncillo', 55),
(354, 'Milagro', 55),
(355, 'San José', 55),
(356, 'San Juan de Cerro Azul', 55),
(357, 'Balsas', 56),
(358, 'Bellamaría', 56),
(359, 'Chilla', 57),
(360, 'El Guabo', 58),
(361, 'Barbones (Sucre)', 58),
(362, 'La Iberia', 58),
(363, 'Tendales (Cab.En Puerto Tendales)', 58),
(364, 'Río Bonito', 58),
(365, 'Ecuador', 59),
(366, 'El Paraíso', 59),
(367, 'Hualtaco', 59),
(368, 'Milton Reyes', 59),
(369, 'Unión Lojana', 59),
(370, 'Huaquillas', 59),
(371, 'Marcabelí', 60),
(372, 'El Ingenio', 60),
(373, 'Bolívar', 61),
(374, 'Loma de Franco', 61),
(375, 'Ochoa León (Matriz)', 61),
(376, 'Tres Cerritos', 61),
(377, 'Pasaje', 61),
(378, 'Buenavista', 61),
(379, 'Casacay', 61),
(380, 'La Peaña', 61),
(381, 'Progreso', 61),
(382, 'Uzhcurrumi', 61),
(383, 'Cañaquemada', 61),
(384, 'La Matriz', 62),
(385, 'La Susaya', 62),
(386, 'Piñas Grande', 62),
(387, 'Piñas', 62),
(388, 'Capiro (Cab. En La Capilla de Capiro)', 62),
(389, 'La Bocana', 62),
(390, 'Moromoro (Cab. En El Vado)', 62),
(391, 'Piedras', 62),
(392, 'San Roque (Ambrosio Maldonado)', 62),
(393, 'Saracay', 62),
(394, 'Portovelo', 63),
(395, 'Curtincapa', 63),
(396, 'Morales', 63),
(397, 'Salatí', 63),
(398, 'Santa Rosa', 64),
(399, 'Puerto Jelí', 64),
(400, 'Balneario Jambelí (Satélite)', 64),
(401, 'Jumón (Satélite)', 64),
(402, 'Nuevo Santa Rosa', 64),
(403, 'Santa Rosa', 64),
(404, 'Bellavista', 64),
(405, 'Jambelí', 64),
(406, 'La Avanzada', 64),
(407, 'San Antonio', 64),
(408, 'Torata', 64),
(409, 'Victoria', 64),
(410, 'Bellamaría', 64),
(411, 'Zaruma', 65),
(412, 'Abañín', 65),
(413, 'Arcapamba', 65),
(414, 'Guanazán', 65),
(415, 'Guizhaguiña', 65),
(416, 'Huertas', 65),
(417, 'Malvas', 65),
(418, 'Muluncay Grande', 65),
(419, 'Sinsao', 65),
(420, 'Salvias', 65),
(421, 'La Victoria', 66),
(422, 'Platanillos', 66),
(423, 'Valle Hermoso', 66),
(424, 'La Victoria', 66),
(425, 'La Libertad', 66),
(426, 'El Paraíso', 66),
(427, 'San Isidro', 66),
(428, 'Bartolomé Ruiz (César Franco Carrión)', 67),
(429, '5 de Agosto', 67),
(430, 'Esmeraldas', 67),
(431, 'Luis Tello (Las Palmas)', 67),
(432, 'Simón Plata Torres', 67),
(433, 'Esmeraldas', 67),
(434, 'Atacames', 67),
(435, 'Camarones (Cab. En San Vicente)', 67),
(436, 'Crnel. Carlos Concha Torres (Cab.En Huele)', 67),
(437, 'Chinca', 67),
(438, 'Chontaduro', 67),
(439, 'Chumundé', 67),
(440, 'Lagarto', 67),
(441, 'La Unión', 67),
(442, 'Majua', 67),
(443, 'Montalvo (Cab. En Horqueta)', 67),
(444, 'Río Verde', 67),
(445, 'Rocafuerte', 67),
(446, 'San Mateo', 67),
(447, 'Súa (Cab. En La Bocana)', 67),
(448, 'Tabiazo', 67),
(449, 'Tachina', 67),
(450, 'Tonchigüe', 67),
(451, 'Vuelta Larga', 67),
(452, 'Valdez (Limones)', 68),
(453, 'Anchayacu', 68),
(454, 'Atahualpa (Cab. En Camarones)', 68),
(455, 'Borbón', 68),
(456, 'La Tola', 68),
(457, 'Luis Vargas Torres (Cab. En Playa de Oro)', 68),
(458, 'Maldonado', 68),
(459, 'Pampanal de Bolívar', 68),
(460, 'San Francisco de Onzole', 68),
(461, 'Santo Domingo de Onzole', 68),
(462, 'Selva Alegre', 68),
(463, 'Telembí', 68),
(464, 'Colón Eloy del María', 68),
(465, 'San José de Cayapas', 68),
(466, 'Timbiré', 68),
(467, 'Muisne', 69),
(468, 'Bolívar', 69),
(469, 'Daule', 69),
(470, 'Galera', 69),
(471, 'Quingue (Olmedo Perdomo Franco)', 69),
(472, 'Salima', 69),
(473, 'San Francisco', 69),
(474, 'San Gregorio', 69),
(475, 'San José de Chamanga (Cab.En Chamanga)', 69),
(476, 'Rosa Zárate (Quinindé)', 70),
(477, 'Cube', 70),
(478, 'Chura (Chancama) (Cab. En El Yerbero)', 70),
(479, 'Malimpia', 70),
(480, 'Viche', 70),
(481, 'La Unión', 70),
(482, 'San Lorenzo', 71),
(483, 'Alto Tambo (Cab. En Guadual)', 71),
(484, 'Ancón (Pichangal) (Cab. En Palma Real)', 71),
(485, 'Calderón', 71),
(486, 'Carondelet', 71),
(487, '5 de Junio (Cab. En Uimbi)', 71),
(488, 'Concepción', 71),
(489, 'Mataje (Cab. En Santander)', 71),
(490, 'San Javier de Cachaví (Cab. En San Javier)', 71),
(491, 'Santa Rita', 71),
(492, 'Tambillo', 71),
(493, 'Tululbí (Cab. En Ricaurte)', 71),
(494, 'Urbina', 71),
(495, 'Atacames', 72),
(496, 'La Unión', 72),
(497, 'Súa (Cab. En La Bocana)', 72),
(498, 'Tonchigüe', 72),
(499, 'Tonsupa', 72),
(500, 'Rioverde', 73),
(501, 'Chontaduro', 73),
(502, 'Chumundé', 73),
(503, 'Lagarto', 73),
(504, 'Montalvo (Cab. En Horqueta)', 73),
(505, 'Rocafuerte', 73),
(506, 'La Concordia', 74),
(507, 'Monterrey', 74),
(508, 'La Villegas', 74),
(509, 'Plan Piloto', 74),
(510, 'Ayacucho', 75),
(511, 'Bolívar (Sagrario)', 75),
(512, 'Carbo (Concepción)', 75),
(513, 'Febres Cordero', 75),
(514, 'García Moreno', 75),
(515, 'Letamendi', 75),
(516, 'Nueve de Octubre', 75),
(517, 'Olmedo (San Alejo)', 75),
(518, 'Roca', 75),
(519, 'Rocafuerte', 75),
(520, 'Sucre', 75),
(521, 'Tarqui', 75),
(522, 'Urdaneta', 75),
(523, 'Ximena', 75),
(524, 'Pascuales', 75),
(525, 'Guayaquil', 75),
(526, 'Chongón', 75),
(527, 'Juan Gómez Rendón (Progreso)', 75),
(528, 'Morro', 75),
(529, 'Pascuales', 75),
(530, 'Playas (Gral. Villamil)', 75),
(531, 'Posorja', 75),
(532, 'Puná', 75),
(533, 'Tenguel', 75),
(534, 'Alfredo Baquerizo Moreno (Juján)', 76),
(535, 'Balao', 77),
(536, 'Balzar', 78),
(537, 'Colimes', 79),
(538, 'San Jacinto', 79),
(539, 'Daule', 80),
(540, 'La Aurora (Satélite)', 80),
(541, 'Banife', 80),
(542, 'Emiliano Caicedo Marcos', 80),
(543, 'Magro', 80),
(544, 'Padre Juan Bautista Aguirre', 80),
(545, 'Santa Clara', 80),
(546, 'Vicente Piedrahita', 80),
(547, 'Daule', 80),
(548, 'Isidro Ayora (Soledad)', 80),
(549, 'Juan Bautista Aguirre (Los Tintos)', 80),
(550, 'Laurel', 80),
(551, 'Limonal', 80),
(552, 'Lomas de Sargentillo', 80),
(553, 'Los Lojas (Enrique Baquerizo Moreno)', 80),
(554, 'Piedrahita (Nobol)', 80),
(555, 'Eloy Alfaro (Durán)', 81),
(556, 'El Recreo', 81),
(557, 'Eloy Alfaro (Durán)', 81),
(558, 'Velasco Ibarra (El Empalme)', 82),
(559, 'Guayas (Pueblo Nuevo)', 82),
(560, 'El Rosario', 82),
(561, 'El Triunfo', 83),
(562, 'Milagro', 84),
(563, 'Chobo', 84),
(564, 'General Elizalde (Bucay)', 84),
(565, 'Mariscal Sucre (Huaques)', 84),
(566, 'Roberto Astudillo (Cab. En Cruce de Venecia)', 84),
(567, 'Naranjal', 85),
(568, 'Jesús María', 85),
(569, 'San Carlos', 85),
(570, 'Santa Rosa de Flandes', 85),
(571, 'Taura', 85),
(572, 'Naranjito', 86),
(573, 'Palestina', 87),
(574, 'Pedro Carbo', 88),
(575, 'Valle de La Virgen', 88),
(576, 'Sabanilla', 88),
(577, 'Samborondón', 89),
(578, 'La Puntilla (Satélite)', 89),
(579, 'Samborondón', 89),
(580, 'Tarifa', 89),
(581, 'Santa Lucía', 90),
(582, 'Bocana', 91),
(583, 'Candilejos', 91),
(584, 'Central', 91),
(585, 'Paraíso', 91),
(586, 'San Mateo', 91),
(587, 'El Salitre (Las Ramas)', 91),
(588, 'Gral. Vernaza (Dos Esteros)', 91),
(589, 'La Victoria (Ñauza)', 91),
(590, 'Junquillal', 91),
(591, 'San Jacinto de Yaguachi', 92),
(592, 'Crnel. Lorenzo de Garaicoa (Pedregal)', 92),
(593, 'Crnel. Marcelino Maridueña (San Carlos)', 92),
(594, 'Gral. Pedro J. Montero (Boliche)', 92),
(595, 'Simón Bolívar', 92),
(596, 'Yaguachi Viejo (Cone)', 92),
(597, 'Virgen de Fátima', 92),
(598, 'General Villamil (Playas)', 93),
(599, 'Simón Bolívar', 94),
(600, 'Crnel.Lorenzo de Garaicoa (Pedregal)', 94),
(601, 'Coronel Marcelino Maridueña (San Carlos)', 95),
(602, 'Lomas de Sargentillo', 96),
(603, 'Isidro Ayora (Soledad)', 96),
(604, 'Narcisa de Jesús', 97),
(605, 'General Antonio Elizalde (Bucay)', 98),
(606, 'Isidro Ayora', 99),
(607, 'Caranqui', 100),
(608, 'Guayaquil de Alpachaca', 100),
(609, 'Sagrario', 100),
(610, 'San Francisco', 100),
(611, 'La Dolorosa del Priorato', 100),
(612, 'San Miguel de Ibarra', 100),
(613, 'Ambuquí', 100),
(614, 'Angochagua', 100),
(615, 'Carolina', 100),
(616, 'La Esperanza', 100),
(617, 'Lita', 100),
(618, 'Salinas', 100),
(619, 'San Antonio', 100),
(620, 'Andrade Marín (Lourdes)', 101),
(621, 'Atuntaqui', 101),
(622, 'Atuntaqui', 101),
(623, 'Imbaya (San Luis de Cobuendo)', 101),
(624, 'San Francisco de Natabuela', 101),
(625, 'San José de Chaltura', 101),
(626, 'San Roque', 101),
(627, 'Sagrario', 102),
(628, 'San Francisco', 102),
(629, 'Cotacachi', 102),
(630, 'Apuela', 102),
(631, 'García Moreno (Llurimagua)', 102),
(632, 'Imantag', 102),
(633, 'Peñaherrera', 102),
(634, 'Plaza Gutiérrez (Calvario)', 102),
(635, 'Quiroga', 102),
(636, '6 de Julio de Cuellaje (Cab. En Cuellaje)', 102),
(637, 'Vacas Galindo (El Churo) (Cab.En San Miguel Alto', 102),
(638, 'Jordán', 103),
(639, 'San Luis', 103),
(640, 'Otavalo', 103),
(641, 'Dr. Miguel Egas Cabezas (Peguche)', 103),
(642, 'Eugenio Espejo (Calpaquí)', 103),
(643, 'González Suárez', 103),
(644, 'Pataquí', 103),
(645, 'San José de Quichinche', 103),
(646, 'San Juan de Ilumán', 103),
(647, 'San Pablo', 103),
(648, 'San Rafael', 103),
(649, 'Selva Alegre (Cab.En San Miguel de Pamplona)', 103),
(650, 'Pimampiro', 104),
(651, 'Chugá', 104),
(652, 'Mariano Acosta', 104),
(653, 'San Francisco de Sigsipamba', 104),
(654, 'Urcuquí Cabecera Cantonal', 105),
(655, 'Cahuasquí', 105),
(656, 'La Merced de Buenos Aires', 105),
(657, 'Pablo Arenas', 105),
(658, 'San Blas', 105),
(659, 'Tumbabiro', 105),
(660, 'El Sagrario', 106),
(661, 'San Sebastián', 106),
(662, 'Sucre', 106),
(663, 'Valle', 106),
(664, 'Loja', 106),
(665, 'Chantaco', 106),
(666, 'Chuquiribamba', 106),
(667, 'El Cisne', 106),
(668, 'Gualel', 106),
(669, 'Jimbilla', 106),
(670, 'Malacatos (Valladolid)', 106),
(671, 'San Lucas', 106),
(672, 'San Pedro de Vilcabamba', 106),
(673, 'Santiago', 106),
(674, 'Taquil (Miguel Riofrío)', 106),
(675, 'Vilcabamba (Victoria)', 106),
(676, 'Yangana (Arsenio Castillo)', 106),
(677, 'Quinara', 106),
(678, 'Cariamanga', 107),
(679, 'Chile', 107),
(680, 'San Vicente', 107),
(681, 'Cariamanga', 107),
(682, 'Colaisaca', 107),
(683, 'El Lucero', 107),
(684, 'Utuana', 107),
(685, 'Sanguillín', 107),
(686, 'Catamayo', 108),
(687, 'San José', 108),
(688, 'Catamayo (La Toma)', 108),
(689, 'El Tambo', 108),
(690, 'Guayquichuma', 108),
(691, 'San Pedro de La Bendita', 108),
(692, 'Zambi', 108),
(693, 'Celica', 109),
(694, 'Cruzpamba (Cab. En Carlos Bustamante)', 109),
(695, 'Chaquinal', 109),
(696, '12 de Diciembre (Cab. En Achiotes)', 109),
(697, 'Pindal (Federico Páez)', 109),
(698, 'Pozul (San Juan de Pozul)', 109),
(699, 'Sabanilla', 109),
(700, 'Tnte. Maximiliano Rodríguez Loaiza', 109),
(701, 'Chaguarpamba', 110),
(702, 'Buenavista', 110),
(703, 'El Rosario', 110),
(704, 'Santa Rufina', 110),
(705, 'Amarillos', 110),
(706, 'Amaluza', 111),
(707, 'Bellavista', 111),
(708, 'Jimbura', 111),
(709, 'Santa Teresita', 111),
(710, '27 de Abril (Cab. En La Naranja)', 111),
(711, 'El Ingenio', 111),
(712, 'El Airo', 111),
(713, 'Gonzanamá', 112),
(714, 'Changaimina (La Libertad)', 112),
(715, 'Fundochamba', 112),
(716, 'Nambacola', 112),
(717, 'Purunuma (Eguiguren)', 112),
(718, 'Quilanga (La Paz)', 112),
(719, 'Sacapalca', 112),
(720, 'San Antonio de Las Aradas (Cab. En Las Aradas)', 112),
(721, 'General Eloy Alfaro (San Sebastián)', 113),
(722, 'Macará (Manuel Enrique Rengel Suquilanda)', 113),
(723, 'Macará', 113),
(724, 'Larama', 113),
(725, 'La Victoria', 113),
(726, 'Sabiango (La Capilla)', 113),
(727, 'Catacocha', 114),
(728, 'Lourdes', 114),
(729, 'Catacocha', 114),
(730, 'Cangonamá', 114),
(731, 'Guachanamá', 114),
(732, 'La Tingue', 114),
(733, 'Lauro Guerrero', 114),
(734, 'Olmedo (Santa Bárbara)', 114),
(735, 'Orianga', 114),
(736, 'San Antonio', 114),
(737, 'Casanga', 114),
(738, 'Yamana', 114),
(739, 'Alamor', 115),
(740, 'Ciano', 115),
(741, 'El Arenal', 115),
(742, 'El Limo (Mariana de Jesús)', 115),
(743, 'Mercadillo', 115),
(744, 'Vicentino', 115),
(745, 'Saraguro', 116),
(746, 'El Paraíso de Celén', 116),
(747, 'El Tablón', 116),
(748, 'Lluzhapa', 116),
(749, 'Manú', 116),
(750, 'San Antonio de Qumbe (Cumbe)', 116),
(751, 'San Pablo de Tenta', 116),
(752, 'San Sebastián de Yúluc', 116),
(753, 'Selva Alegre', 116),
(754, 'Urdaneta (Paquishapa)', 116),
(755, 'Sumaypamba', 116),
(756, 'Sozoranga', 117),
(757, 'Nueva Fátima', 117),
(758, 'Tacamoros', 117),
(759, 'Zapotillo', 118),
(760, 'Mangahurco (Cazaderos)', 118),
(761, 'Garzareal', 118),
(762, 'Limones', 118),
(763, 'Paletillas', 118),
(764, 'Bolaspamba', 118),
(765, 'Pindal', 119),
(766, 'Chaquinal', 119),
(767, '12 de Diciembre (Cab.En Achiotes)', 119),
(768, 'Milagros', 119),
(769, 'Quilanga', 120),
(770, 'Fundochamba', 120),
(771, 'San Antonio de Las Aradas (Cab. En Las Aradas)', 120),
(772, 'Olmedo', 121),
(773, 'La Tingue', 121),
(774, 'Clemente Baquerizo', 122),
(775, 'Dr. Camilo Ponce', 122),
(776, 'Barreiro', 122),
(777, 'El Salto', 122),
(778, 'Babahoyo', 122),
(779, 'Barreiro (Santa Rita)', 122),
(780, 'Caracol', 122),
(781, 'Febres Cordero (Las Juntas)', 122),
(782, 'Pimocha', 122),
(783, 'La Unión', 122),
(784, 'Baba', 123),
(785, 'Guare', 123),
(786, 'Isla de Bejucal', 123),
(787, 'Montalvo', 124),
(788, 'Puebloviejo', 125),
(789, 'Puerto Pechiche', 125),
(790, 'San Juan', 125),
(791, 'Quevedo', 126),
(792, 'San Camilo', 126),
(793, 'San José', 126),
(794, 'Guayacán', 126),
(795, 'Nicolás Infante Díaz', 126),
(796, 'San Cristóbal', 126),
(797, 'Siete de Octubre', 126),
(798, '24 de Mayo', 126),
(799, 'Venus del Río Quevedo', 126),
(800, 'Viva Alfaro', 126),
(801, 'Quevedo', 126),
(802, 'Buena Fé', 126),
(803, 'Mocache', 126),
(804, 'San Carlos', 126),
(805, 'Valencia', 126),
(806, 'La Esperanza', 126),
(807, 'Catarama', 127),
(808, 'Ricaurte', 127),
(809, '10 de Noviembre', 128),
(810, 'Ventanas', 128),
(811, 'Quinsaloma', 128),
(812, 'Zapotal', 128),
(813, 'Chacarita', 128),
(814, 'Los Ángeles', 128),
(815, 'Vinces', 129),
(816, 'Antonio Sotomayor (Cab. En Playas de Vinces)', 129),
(817, 'Palenque', 129),
(818, 'Palenque', 130),
(819, 'San Jacinto de Buena Fé', 131),
(820, '7 de Agosto', 131),
(821, '11 de Octubre', 131),
(822, 'San Jacinto de Buena Fé', 131),
(823, 'Patricia Pilar', 131),
(824, 'Valencia', 132),
(825, 'Mocache', 133),
(826, 'Quinsaloma', 134),
(827, 'Portoviejo', 135),
(828, '12 de Marzo', 135),
(829, 'Colón', 135),
(830, 'Picoazá', 135),
(831, 'San Pablo', 135),
(832, 'Andrés de Vera', 135),
(833, 'Francisco Pacheco', 135),
(834, '18 de Octubre', 135),
(835, 'Simón Bolívar', 135),
(836, 'Portoviejo', 135),
(837, 'Abdón Calderón (San Francisco)', 135),
(838, 'Alhajuela (Bajo Grande)', 135),
(839, 'Crucita', 135),
(840, 'Pueblo Nuevo', 135),
(841, 'Riochico (Río Chico)', 135),
(842, 'San Plácido', 135),
(843, 'Chirijos', 135),
(844, 'Calceta', 136),
(845, 'Membrillo', 136),
(846, 'Quiroga', 136),
(847, 'Chone', 137),
(848, 'Santa Rita', 137),
(849, 'Chone', 137),
(850, 'Boyacá', 137),
(851, 'Canuto', 137),
(852, 'Convento', 137),
(853, 'Chibunga', 137),
(854, 'Eloy Alfaro', 137),
(855, 'Ricaurte', 137),
(856, 'San Antonio', 137),
(857, 'El Carmen', 138),
(858, '4 de Diciembre', 138),
(859, 'El Carmen', 138),
(860, 'Wilfrido Loor Moreira (Maicito)', 138),
(861, 'San Pedro de Suma', 138),
(862, 'Flavio Alfaro', 139),
(863, 'San Francisco de Novillo (Cab. En', 139),
(864, 'Zapallo', 139),
(865, 'Dr. Miguel Morán Lucio', 140),
(866, 'Manuel Inocencio Parrales Y Guale', 140),
(867, 'San Lorenzo de Jipijapa', 140),
(868, 'Jipijapa', 140),
(869, 'América', 140),
(870, 'El Anegado (Cab. En Eloy Alfaro)', 140),
(871, 'Julcuy', 140),
(872, 'La Unión', 140),
(873, 'Machalilla', 140),
(874, 'Membrillal', 140),
(875, 'Pedro Pablo Gómez', 140),
(876, 'Puerto de Cayo', 140),
(877, 'Puerto López', 140),
(878, 'Junín', 141),
(879, 'Los Esteros', 142),
(880, 'Manta', 142),
(881, 'San Mateo', 142),
(882, 'Tarqui', 142),
(883, 'Eloy Alfaro', 142),
(884, 'Manta', 142),
(885, 'San Lorenzo', 142),
(886, 'Santa Marianita (Boca de Pacoche)', 142),
(887, 'Anibal San Andrés', 143),
(888, 'Montecristi', 143),
(889, 'El Colorado', 143),
(890, 'General Eloy Alfaro', 143),
(891, 'Leonidas Proaño', 143),
(892, 'Montecristi', 143),
(893, 'Jaramijó', 143),
(894, 'La Pila', 143),
(895, 'Paján', 144),
(896, 'Campozano (La Palma de Paján)', 144),
(897, 'Cascol', 144),
(898, 'Guale', 144),
(899, 'Lascano', 144),
(900, 'Pichincha', 145),
(901, 'Barraganete', 145),
(902, 'San Sebastián', 145),
(903, 'Rocafuerte', 146),
(904, 'Santa Ana', 147),
(905, 'Lodana', 147),
(906, 'Santa Ana de Vuelta Larga', 147),
(907, 'Ayacucho', 147),
(908, 'Honorato Vásquez (Cab. En Vásquez)', 147),
(909, 'La Unión', 147),
(910, 'Olmedo', 147),
(911, 'San Pablo (Cab. En Pueblo Nuevo)', 147),
(912, 'Bahía de Caráquez', 148),
(913, 'Leonidas Plaza Gutiérrez', 148),
(914, 'Bahía de Caráquez', 148),
(915, 'Canoa', 148),
(916, 'Cojimíes', 148),
(917, 'Charapotó', 148),
(918, '10 de Agosto', 148),
(919, 'Jama', 148),
(920, 'Pedernales', 148),
(921, 'San Isidro', 148),
(922, 'San Vicente', 148),
(923, 'Tosagua', 149),
(924, 'Bachillero', 149),
(925, 'Angel Pedro Giler (La Estancilla)', 149),
(926, 'Sucre', 150),
(927, 'Bellavista', 150),
(928, 'Noboa', 150),
(929, 'Arq. Sixto Durán Ballén', 150),
(930, 'Pedernales', 151),
(931, 'Cojimíes', 151),
(932, '10 de Agosto', 151),
(933, 'Atahualpa', 151),
(934, 'Olmedo', 152),
(935, 'Puerto López', 153),
(936, 'Machalilla', 153),
(937, 'Salango', 153),
(938, 'Jama', 154),
(939, 'Jaramijó', 155),
(940, 'San Vicente', 156),
(941, 'Canoa', 156),
(942, 'Macas', 157),
(943, 'Alshi (Cab. En 9 de Octubre)', 157),
(944, 'Chiguaza', 157),
(945, 'General Proaño', 157),
(946, 'Huasaga (Cab.En Wampuik)', 157),
(947, 'Macuma', 157),
(948, 'San Isidro', 157),
(949, 'Sevilla Don Bosco', 157),
(950, 'Sinaí', 157),
(951, 'Taisha', 157),
(952, 'Zuña (Zúñac)', 157),
(953, 'Tuutinentza', 157),
(954, 'Cuchaentza', 157),
(955, 'San José de Morona', 157),
(956, 'Río Blanco', 157),
(957, 'Gualaquiza', 158),
(958, 'Mercedes Molina', 158),
(959, 'Gualaquiza', 158),
(960, 'Amazonas (Rosario de Cuyes)', 158),
(961, 'Bermejos', 158),
(962, 'Bomboiza', 158),
(963, 'Chigüinda', 158),
(964, 'El Rosario', 158),
(965, 'Nueva Tarqui', 158),
(966, 'San Miguel de Cuyes', 158),
(967, 'El Ideal', 158),
(968, 'General Leonidas Plaza Gutiérrez (Limón)', 159),
(969, 'Indanza', 159),
(970, 'Pan de Azúcar', 159),
(971, 'San Antonio (Cab. En San Antonio Centro', 159),
(972, 'San Carlos de Limón (San Carlos del', 159),
(973, 'San Juan Bosco', 159),
(974, 'San Miguel de Conchay', 159),
(975, 'Santa Susana de Chiviaza (Cab. En Chiviaza)', 159),
(976, 'Yunganza (Cab. En El Rosario)', 159),
(977, 'Palora (Metzera)', 160),
(978, 'Arapicos', 160),
(979, 'Cumandá (Cab. En Colonia Agrícola Sevilla del Oro)', 160),
(980, 'Huamboya', 160),
(981, 'Sangay (Cab. En Nayamanaca)', 160),
(982, 'Santiago de Méndez', 161),
(983, 'Copal', 161),
(984, 'Chupianza', 161),
(985, 'Patuca', 161),
(986, 'San Luis de El Acho (Cab. En El Acho)', 161),
(987, 'Santiago', 161),
(988, 'Tayuza', 161),
(989, 'San Francisco de Chinimbimi', 161),
(990, 'Sucúa', 162),
(991, 'Asunción', 162),
(992, 'Huambi', 162),
(993, 'Logroño', 162),
(994, 'Yaupi', 162),
(995, 'Santa Marianita de Jesús', 162),
(996, 'Huamboya', 163),
(997, 'Chiguaza', 163),
(998, 'Pablo Sexto', 163),
(999, 'San Juan Bosco', 164),
(1000, 'Pan de Azúcar', 164),
(1001, 'San Carlos de Limón', 164),
(1002, 'San Jacinto de Wakambeis', 164),
(1003, 'Santiago de Pananza', 164),
(1004, 'Taisha', 165),
(1005, 'Huasaga (Cab. En Wampuik)', 165),
(1006, 'Macuma', 165),
(1007, 'Tuutinentza', 165),
(1008, 'Pumpuentsa', 165),
(1009, 'Logroño', 166),
(1010, 'Yaupi', 166),
(1011, 'Shimpis', 166),
(1012, 'Pablo Sexto', 167),
(1013, 'Santiago', 168),
(1014, 'San José de Morona', 168),
(1015, 'Tena', 169),
(1016, 'Ahuano', 169),
(1017, 'Carlos Julio Arosemena Tola (Zatza-Yacu)', 169),
(1018, 'Chontapunta', 169),
(1019, 'Pano', 169),
(1020, 'Puerto Misahualli', 169),
(1021, 'Puerto Napo', 169),
(1022, 'Tálag', 169),
(1023, 'San Juan de Muyuna', 169),
(1024, 'Archidona', 170),
(1025, 'Avila', 170),
(1026, 'Cotundo', 170),
(1027, 'Loreto', 170),
(1028, 'San Pablo de Ushpayacu', 170),
(1029, 'Puerto Murialdo', 170),
(1030, 'El Chaco', 171),
(1031, 'Gonzalo Díaz de Pineda (El Bombón)', 171),
(1032, 'Linares', 171),
(1033, 'Oyacachi', 171),
(1034, 'Santa Rosa', 171),
(1035, 'Sardinas', 171),
(1036, 'Baeza', 172),
(1037, 'Cosanga', 172),
(1038, 'Cuyuja', 172),
(1039, 'Papallacta', 172),
(1040, 'San Francisco de Borja (Virgilio Dávila)', 172),
(1041, 'San José del Payamino', 172),
(1042, 'Sumaco', 172),
(1043, 'Carlos Julio Arosemena Tola', 173),
(1044, 'Puyo', 174),
(1045, 'Arajuno', 174),
(1046, 'Canelos', 174),
(1047, 'Curaray', 174),
(1048, 'Diez de Agosto', 174),
(1049, 'Fátima', 174),
(1050, 'Montalvo (Andoas)', 174),
(1051, 'Pomona', 174),
(1052, 'Río Corrientes', 174),
(1053, 'Río Tigre', 174),
(1054, 'Santa Clara', 174),
(1055, 'Sarayacu', 174),
(1056, 'Simón Bolívar (Cab. En Mushullacta)', 174),
(1057, 'Tarqui', 174),
(1058, 'Teniente Hugo Ortiz', 174),
(1059, 'Veracruz (Indillama) (Cab. En Indillama)', 174),
(1060, 'El Triunfo', 174),
(1061, 'Mera', 175),
(1062, 'Madre Tierra', 175),
(1063, 'Shell', 175),
(1064, 'Santa Clara', 176),
(1065, 'San José', 176),
(1066, 'Arajuno', 177),
(1067, 'Curaray', 177),
(1068, 'Belisario Quevedo', 178),
(1069, 'Carcelén', 178),
(1070, 'Centro Histórico', 178),
(1071, 'Cochapamba', 178),
(1072, 'Comité del Pueblo', 178),
(1073, 'Cotocollao', 178),
(1074, 'Chilibulo', 178),
(1075, 'Chillogallo', 178),
(1076, 'Chimbacalle', 178),
(1077, 'El Condado', 178),
(1078, 'Guamaní', 178),
(1079, 'Iñaquito', 178),
(1080, 'Itchimbía', 178),
(1081, 'Jipijapa', 178),
(1082, 'Kennedy', 178),
(1083, 'La Argelia', 178),
(1084, 'La Concepción', 178),
(1085, 'La Ecuatoriana', 178),
(1086, 'La Ferroviaria', 178),
(1087, 'La Libertad', 178),
(1088, 'La Magdalena', 178),
(1089, 'La Mena', 178),
(1090, 'Mariscal Sucre', 178),
(1091, 'Ponceano', 178),
(1092, 'Puengasí', 178),
(1093, 'Quitumbe', 178),
(1094, 'Rumipamba', 178),
(1095, 'San Bartolo', 178),
(1096, 'San Isidro del Inca', 178),
(1097, 'San Juan', 178),
(1098, 'Solanda', 178),
(1099, 'Turubamba', 178),
(1100, 'Quito Distrito Metropolitano', 178),
(1101, 'Alangasí', 178),
(1102, 'Amaguaña', 178),
(1103, 'Atahualpa', 178),
(1104, 'Calacalí', 178),
(1105, 'Calderón', 178),
(1106, 'Conocoto', 178),
(1107, 'Cumbayá', 178),
(1108, 'Chavezpamba', 178),
(1109, 'Checa', 178),
(1110, 'El Quinche', 178),
(1111, 'Gualea', 178),
(1112, 'Guangopolo', 178),
(1113, 'Guayllabamba', 178),
(1114, 'La Merced', 178),
(1115, 'Llano Chico', 178),
(1116, 'Lloa', 178),
(1117, 'Mindo', 178),
(1118, 'Nanegal', 178),
(1119, 'Nanegalito', 178),
(1120, 'Nayón', 178),
(1121, 'Nono', 178),
(1122, 'Pacto', 178),
(1123, 'Pedro Vicente Maldonado', 178),
(1124, 'Perucho', 178),
(1125, 'Pifo', 178),
(1126, 'Píntag', 178),
(1127, 'Pomasqui', 178),
(1128, 'Puéllaro', 178),
(1129, 'Puembo', 178),
(1130, 'San Antonio', 178),
(1131, 'San José de Minas', 178),
(1132, 'San Miguel de Los Bancos', 178),
(1133, 'Tababela', 178),
(1134, 'Tumbaco', 178),
(1135, 'Yaruquí', 178),
(1136, 'Zambiza', 178),
(1137, 'Puerto Quito', 178),
(1138, 'Ayora', 179),
(1139, 'Cayambe', 179),
(1140, 'Juan Montalvo', 179),
(1141, 'Cayambe', 179),
(1142, 'Ascázubi', 179),
(1143, 'Cangahua', 179),
(1144, 'Olmedo (Pesillo)', 179),
(1145, 'Otón', 179),
(1146, 'Santa Rosa de Cuzubamba', 179),
(1147, 'Machachi', 180),
(1148, 'Alóag', 180),
(1149, 'Aloasí', 180),
(1150, 'Cutuglahua', 180),
(1151, 'El Chaupi', 180),
(1152, 'Manuel Cornejo Astorga (Tandapi)', 180),
(1153, 'Tambillo', 180),
(1154, 'Uyumbicho', 180),
(1155, 'Tabacundo', 181),
(1156, 'La Esperanza', 181),
(1157, 'Malchinguí', 181),
(1158, 'Tocachi', 181),
(1159, 'Tupigachi', 181),
(1160, 'Sangolquí', 182),
(1161, 'San Pedro de Taboada', 182),
(1162, 'San Rafael', 182),
(1163, 'Sangolqui', 182),
(1164, 'Cotogchoa', 182),
(1165, 'Rumipamba', 182),
(1166, 'San Miguel de Los Bancos', 183),
(1167, 'Mindo', 183),
(1168, 'Pedro Vicente Maldonado', 183),
(1169, 'Puerto Quito', 183),
(1170, 'Pedro Vicente Maldonado', 184),
(1171, 'Puerto Quito', 185),
(1172, 'Atocha – Ficoa', 186),
(1173, 'Celiano Monge', 186),
(1174, 'Huachi Chico', 186),
(1175, 'Huachi Loreto', 186),
(1176, 'La Merced', 186),
(1177, 'La Península', 186),
(1178, 'Matriz', 186),
(1179, 'Pishilata', 186),
(1180, 'San Francisco', 186),
(1181, 'Ambato', 186),
(1182, 'Ambatillo', 186),
(1183, 'Atahualpa (Chisalata)', 186),
(1184, 'Augusto N. Martínez (Mundugleo)', 186),
(1185, 'Constantino Fernández (Cab. En Cullitahua)', 186),
(1186, 'Huachi Grande', 186),
(1187, 'Izamba', 186),
(1188, 'Juan Benigno Vela', 186),
(1189, 'Montalvo', 186),
(1190, 'Pasa', 186),
(1191, 'Picaigua', 186),
(1192, 'Pilagüín (Pilahüín)', 186),
(1193, 'Quisapincha (Quizapincha)', 186),
(1194, 'San Bartolomé de Pinllog', 186),
(1195, 'San Fernando (Pasa San Fernando)', 186),
(1196, 'Santa Rosa', 186),
(1197, 'Totoras', 186),
(1198, 'Cunchibamba', 186),
(1199, 'Unamuncho', 186),
(1200, 'Baños de Agua Santa', 187),
(1201, 'Lligua', 187),
(1202, 'Río Negro', 187),
(1203, 'Río Verde', 187),
(1204, 'Ulba', 187),
(1205, 'Cevallos', 188),
(1206, 'Mocha', 189),
(1207, 'Pinguilí', 189),
(1208, 'Patate', 190),
(1209, 'El Triunfo', 190),
(1210, 'Los Andes (Cab. En Poatug)', 190),
(1211, 'Sucre (Cab. En Sucre-Patate Urcu)', 190),
(1212, 'Quero', 191),
(1213, 'Rumipamba', 191),
(1214, 'Yanayacu - Mochapata (Cab. En Yanayacu)', 191),
(1215, 'Pelileo', 192),
(1216, 'Pelileo Grande', 192),
(1217, 'Pelileo', 192),
(1218, 'Benítez (Pachanlica)', 192),
(1219, 'Bolívar', 192),
(1220, 'Cotaló', 192),
(1221, 'Chiquicha (Cab. En Chiquicha Grande)', 192),
(1222, 'El Rosario (Rumichaca)', 192),
(1223, 'García Moreno (Chumaqui)', 192),
(1224, 'Guambaló (Huambaló)', 192),
(1225, 'Salasaca', 192),
(1226, 'Ciudad Nueva', 193),
(1227, 'Píllaro', 193),
(1228, 'Píllaro', 193),
(1229, 'Baquerizo Moreno', 193),
(1230, 'Emilio María Terán (Rumipamba)', 193),
(1231, 'Marcos Espinel (Chacata)', 193),
(1232, 'Presidente Urbina (Chagrapamba -Patzucul)', 193),
(1233, 'San Andrés', 193),
(1234, 'San José de Poaló', 193),
(1235, 'San Miguelito', 193),
(1236, 'Tisaleo', 194),
(1237, 'Quinchicoto', 194),
(1238, 'El Limón', 195),
(1239, 'Zamora', 195),
(1240, 'Zamora', 195),
(1241, 'Cumbaratza', 195),
(1242, 'Guadalupe', 195),
(1243, 'Imbana (La Victoria de Imbana)', 195),
(1244, 'Paquisha', 195),
(1245, 'Sabanilla', 195),
(1246, 'Timbara', 195),
(1247, 'Zumbi', 195),
(1248, 'San Carlos de Las Minas', 195),
(1249, 'Zumba', 196),
(1250, 'Chito', 196),
(1251, 'El Chorro', 196),
(1252, 'El Porvenir del Carmen', 196),
(1253, 'La Chonta', 196),
(1254, 'Palanda', 196),
(1255, 'Pucapamba', 196),
(1256, 'San Francisco del Vergel', 196),
(1257, 'Valladolid', 196),
(1258, 'San Andrés', 196),
(1259, 'Guayzimi', 197),
(1260, 'Zurmi', 197),
(1261, 'Nuevo Paraíso', 197),
(1262, '28 de Mayo (San José de Yacuambi)', 198),
(1263, 'La Paz', 198),
(1264, 'Tutupali', 198),
(1265, 'Yantzaza (Yanzatza)', 199),
(1266, 'Chicaña', 199),
(1267, 'El Pangui', 199),
(1268, 'Los Encuentros', 199),
(1269, 'El Pangui', 200),
(1270, 'El Guisme', 200),
(1271, 'Pachicutza', 200),
(1272, 'Tundayme', 200),
(1273, 'Zumbi', 201),
(1274, 'Paquisha', 201),
(1275, 'Triunfo-Dorado', 201),
(1276, 'Panguintza', 201),
(1277, 'Palanda', 202),
(1278, 'El Porvenir del Carmen', 202),
(1279, 'San Francisco del Vergel', 202),
(1280, 'Valladolid', 202),
(1281, 'La Canela', 202),
(1282, 'Paquisha', 203),
(1283, 'Bellavista', 203),
(1284, 'Nuevo Quito', 203),
(1285, 'Puerto Baquerizo Moreno', 204),
(1286, 'El Progreso', 204),
(1287, 'Isla Santa María (Floreana) (Cab. En Pto. Velasco Ibarra)', 204),
(1288, 'Puerto Villamil', 205),
(1289, 'Tomás de Berlanga (Santo Tomás)', 205),
(1290, 'Puerto Ayora', 206),
(1291, 'Bellavista', 206),
(1292, 'Santa Rosa (Incluye La Isla Baltra)', 206),
(1293, 'Nueva Loja', 207),
(1294, 'Cuyabeno', 207),
(1295, 'Dureno', 207),
(1296, 'General Farfán', 207),
(1297, 'Tarapoa', 207),
(1298, 'El Eno', 207),
(1299, 'Pacayacu', 207),
(1300, 'Jambelí', 207),
(1301, 'Santa Cecilia', 207),
(1302, 'Aguas Negras', 207),
(1303, 'El Dorado de Cascales', 208),
(1304, 'El Reventador', 208),
(1305, 'Gonzalo Pizarro', 208),
(1306, 'Lumbaquí', 208),
(1307, 'Puerto Libre', 208),
(1308, 'Santa Rosa de Sucumbíos', 208),
(1309, 'Puerto El Carmen del Putumayo', 209),
(1310, 'Palma Roja', 209),
(1311, 'Puerto Bolívar (Puerto Montúfar)', 209),
(1312, 'Puerto Rodríguez', 209),
(1313, 'Santa Elena', 209),
(1314, 'Shushufindi', 210),
(1315, 'Limoncocha', 210),
(1316, 'Pañacocha', 210),
(1317, 'San Roque (Cab. En San Vicente)', 210),
(1318, 'San Pedro de Los Cofanes', 210),
(1319, 'Siete de Julio', 210),
(1320, 'La Bonita', 211),
(1321, 'El Playón de San Francisco', 211),
(1322, 'La Sofía', 211),
(1323, 'Rosa Florida', 211),
(1324, 'Santa Bárbara', 211),
(1325, 'El Dorado de Cascales', 212),
(1326, 'Santa Rosa de Sucumbíos', 212),
(1327, 'Sevilla', 212),
(1328, 'Tarapoa', 213),
(1329, 'Cuyabeno', 213),
(1330, 'Aguas Negras', 213),
(1331, 'Puerto Francisco de Orellana (El Coca)', 214),
(1332, 'Dayuma', 214),
(1333, 'Taracoa (Nueva Esperanza: Yuca)', 214),
(1334, 'Alejandro Labaka', 214),
(1335, 'El Dorado', 214),
(1336, 'El Edén', 214),
(1337, 'García Moreno', 214),
(1338, 'Inés Arango (Cab. En Western)', 214),
(1339, 'La Belleza', 214),
(1340, 'Nuevo Paraíso (Cab. En Unión', 214),
(1341, 'San José de Guayusa', 214),
(1342, 'San Luis de Armenia', 214),
(1343, 'Tipitini', 215),
(1344, 'Nuevo Rocafuerte', 215),
(1345, 'Capitán Augusto Rivadeneyra', 215),
(1346, 'Cononaco', 215),
(1347, 'Santa María de Huiririma', 215),
(1348, 'Tiputini', 215),
(1349, 'Yasuní', 215),
(1350, 'La Joya de Los Sachas', 216),
(1351, 'Enokanqui', 216),
(1352, 'Pompeya', 216),
(1353, 'San Carlos', 216),
(1354, 'San Sebastián del Coca', 216),
(1355, 'Lago San Pedro', 216),
(1356, 'Rumipamba', 216),
(1357, 'Tres de Noviembre', 216),
(1358, 'Unión Milagreña', 216),
(1359, 'Loreto', 217),
(1360, 'Avila (Cab. En Huiruno)', 217),
(1361, 'Puerto Murialdo', 217),
(1362, 'San José de Payamino', 217),
(1363, 'San José de Dahuano', 217),
(1364, 'San Vicente de Huaticocha', 217),
(1365, 'Abraham Calazacón', 218),
(1366, 'Bombolí', 218),
(1367, 'Chiguilpe', 218),
(1368, 'Río Toachi', 218),
(1369, 'Río Verde', 218),
(1370, 'Santo Domingo de Los Colorados', 218),
(1371, 'Zaracay', 218),
(1372, 'Santo Domingo de Los Colorados', 218),
(1373, 'Alluriquín', 218),
(1374, 'Puerto Limón', 218),
(1375, 'Luz de América', 218),
(1376, 'San Jacinto del Búa', 218),
(1377, 'Valle Hermoso', 218),
(1378, 'El Esfuerzo', 218),
(1379, 'Santa María del Toachi', 218),
(1380, 'Ballenita', 219),
(1381, 'Santa Elena', 219),
(1382, 'Santa Elena', 219),
(1383, 'Atahualpa', 219),
(1384, 'Colonche', 219),
(1385, 'Chanduy', 219),
(1386, 'Manglaralto', 219),
(1387, 'Simón Bolívar (Julio Moreno)', 219),
(1388, 'San José de Ancón', 219),
(1389, 'La Libertad', 220),
(1390, 'Carlos Espinoza Larrea', 221),
(1391, 'Gral. Alberto Enríquez Gallo', 221),
(1392, 'Vicente Rocafuerte', 221),
(1393, 'Santa Rosa', 221),
(1394, 'Salinas', 221),
(1395, 'Anconcito', 221),
(1396, 'José Luis Tamayo (Muey)', 221),
(1397, 'Las Golondrinas', 222),
(1398, 'Manga del Cura', 222),
(1399, 'El Piedrero', 222);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `idpersona` int NOT NULL,
  `idorganizacion` int DEFAULT NULL,
  `idmodalidad` int DEFAULT NULL,
  `nombres` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `apellidos` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `nombrecompleto` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `telefono` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `documentoidentidad` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `idgenero` int DEFAULT NULL,
  `idetnia` int DEFAULT NULL,
  `idnacionalidad` int DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `fecharegistro` datetime(6) DEFAULT NULL,
  `edad` char(3) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `idprovincia` int DEFAULT NULL,
  `idcanton` int DEFAULT NULL,
  `idparroquia` int DEFAULT NULL,
  `barrio` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `direccion` varchar(120) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `fechadeingresounidadatencion` date DEFAULT NULL,
  `edadingreso` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `tiempopermanenciaaños` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `idmotivoingreso` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`idpersona`, `idorganizacion`, `idmodalidad`, `nombres`, `apellidos`, `nombrecompleto`, `telefono`, `documentoidentidad`, `idgenero`, `idetnia`, `idnacionalidad`, `fechanacimiento`, `fecharegistro`, `edad`, `idprovincia`, `idcanton`, `idparroquia`, `barrio`, `direccion`, `fechadeingresounidadatencion`, `edadingreso`, `tiempopermanenciaaños`, `idmotivoingreso`) VALUES
(1, 3, 3, 'JOSE RODOLFO', 'OBANDO MALDONADO', 'JOSE RODOLFO OBANDO MALDONADO', '0992746856', '1718552365', 1, 1, 18, '2005-06-15', '2021-04-21 22:47:09.798159', '15', 18, 18, 24, 'La Armenia', 'LUIS CORDERO Y 6 DE DICIEMBRE', '2021-04-15', '17', '4 meses, 6 dias', 4),
(2, 2, 3, 'HUMBERTO PATRICIO', 'ESPIN JARAMILLO', 'HUMBERTO PATRICIO ESPIN JARAMILLO', '0992746856', '1102186705', 1, 1, 19, '2000-11-30', '2021-04-21 23:25:39.384845', '20', 13, 14, 13, 'W', 'LUIS CORDERO Y 6 DE DICIEMBRE', '2021-04-24', '13', '3 meses, 2 dias', 9),
(3, 84, 2, 'Gabriel', 'Aguirre', 'Gabriel Aguirre', '0987676545', '1725643426', 1, 2, 18, '1999-01-08', '2021-05-24 20:06:19.487705', '22', 3, 25, 161, 'Santa Rosa', 'aqui en la es', '2021-05-21', '12', '13', 7),
(4, 84, 2, 'Fernanda ', 'Castellana', 'Fernanda  Castellana', '0999939443', '1728976455', 2, 3, 10, '1997-08-11', '2021-05-25 14:05:53.270119', '23', 7, 55, 352, 'santa elena', 'barrio los olivos av 10 de agosto', '2021-05-14', '12', '4', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pgf`
--

CREATE TABLE `pgf` (
  `idpgf` int NOT NULL,
  `idperonsa` int DEFAULT NULL,
  `idfamiliarreferente` int DEFAULT NULL,
  `nombrefamiliar` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `idprovincia` int DEFAULT NULL,
  `idcanton` int DEFAULT NULL,
  `direccion` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `telefono` char(15) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `nna_insertosistemaeducativo` bit(1) DEFAULT NULL,
  `idnivelacademico` int DEFAULT NULL,
  `nombreunidad` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provincia`
--

CREATE TABLE `provincia` (
  `idprovincia` int NOT NULL,
  `descripcionprovincia` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `provincia`
--

INSERT INTO `provincia` (`idprovincia`, `descripcionprovincia`) VALUES
(1, 'Azuay'),
(2, 'Bolívar'),
(3, 'Cañar'),
(4, 'Carchi'),
(5, 'Cotopaxi'),
(6, 'Chimborazo'),
(7, 'El Oro'),
(8, 'Esmeraldas'),
(9, 'Guayas'),
(10, 'Imbabura'),
(11, 'Loja'),
(12, 'Los Rios'),
(13, 'Manabi'),
(14, 'Morona Santiago'),
(15, 'Napo'),
(16, 'Pastaza'),
(17, 'Pichincha'),
(18, 'Tungurahua'),
(19, 'Zamora Chinchipe'),
(20, 'Galápagos'),
(21, 'Sucumbíos'),
(22, 'Orellana'),
(23, 'Santo Domingo de Los Tsáchilas'),
(24, 'Santa Elena'),
(25, 'Zonas No Delimitadas');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_AspNetRoleClaims_AspNetRoles_RoleId` (`RoleId`);

--
-- Indices de la tabla `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_AspNetUserClaims_AspNetUsers_UserId` (`UserId`);

--
-- Indices de la tabla `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `canton`
--
ALTER TABLE `canton`
  ADD PRIMARY KEY (`idcanton`),
  ADD KEY `fk_canton_provincia` (`idprovincia`);

--
-- Indices de la tabla `casaacogimiento`
--
ALTER TABLE `casaacogimiento`
  ADD PRIMARY KEY (`idnombrecasaanterior`);

--
-- Indices de la tabla `datosjudicialpenal`
--
ALTER TABLE `datosjudicialpenal`
  ADD PRIMARY KEY (`idjudicialpenal`),
  ADD KEY `fk_datosjudicialpenal_estadoprocesal` (`idestadoprocesal`),
  ADD KEY `fk_datosjudicialpenal_infracciondenunciada` (`idinfracciondenunciada`),
  ADD KEY `fk_datosjudicialpenal_medida` (`idmedida`),
  ADD KEY `fk_datosjudicialpenal_nudoscriticos` (`idnudoscriticos`),
  ADD KEY `fk_datosjudicialpenal_persona` (`idpersona`);

--
-- Indices de la tabla `datossalud`
--
ALTER TABLE `datossalud`
  ADD PRIMARY KEY (`iddatossalud`),
  ADD KEY `fk_datossalud_persona` (`idpersona`);

--
-- Indices de la tabla `estadoprocesal`
--
ALTER TABLE `estadoprocesal`
  ADD PRIMARY KEY (`idestadoprocesal`);

--
-- Indices de la tabla `etnia`
--
ALTER TABLE `etnia`
  ADD PRIMARY KEY (`idetnia`);

--
-- Indices de la tabla `familiarreferente`
--
ALTER TABLE `familiarreferente`
  ADD PRIMARY KEY (`idfamiliarreferente`);

--
-- Indices de la tabla `genero`
--
ALTER TABLE `genero`
  ADD PRIMARY KEY (`idgenero`);

--
-- Indices de la tabla `historialcronologico`
--
ALTER TABLE `historialcronologico`
  ADD PRIMARY KEY (`idhistorial`),
  ADD KEY `fk_historialcronologico_casaacogimiento` (`idnombrecasaanterior`),
  ADD KEY `fk_historialcronologico_persona` (`idpersona`);

--
-- Indices de la tabla `infracciondenunciada`
--
ALTER TABLE `infracciondenunciada`
  ADD PRIMARY KEY (`idinfracciondenunciada`);

--
-- Indices de la tabla `medida`
--
ALTER TABLE `medida`
  ADD PRIMARY KEY (`idmedida`);

--
-- Indices de la tabla `modalidad`
--
ALTER TABLE `modalidad`
  ADD PRIMARY KEY (`idmodalidad`);

--
-- Indices de la tabla `motivoingreso`
--
ALTER TABLE `motivoingreso`
  ADD PRIMARY KEY (`idmotivoingreso`);

--
-- Indices de la tabla `nacionalidad`
--
ALTER TABLE `nacionalidad`
  ADD PRIMARY KEY (`idnacionalidad`);

--
-- Indices de la tabla `nivelacademico`
--
ALTER TABLE `nivelacademico`
  ADD PRIMARY KEY (`idnivelacademico`);

--
-- Indices de la tabla `nudoscriticos`
--
ALTER TABLE `nudoscriticos`
  ADD PRIMARY KEY (`idnudoscriticos`);

--
-- Indices de la tabla `organizacion`
--
ALTER TABLE `organizacion`
  ADD PRIMARY KEY (`idorganizacion`);

--
-- Indices de la tabla `parroquia`
--
ALTER TABLE `parroquia`
  ADD PRIMARY KEY (`idparroquia`),
  ADD KEY `fk_parroquia_canton` (`idcanton`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`idpersona`),
  ADD KEY `fk_persona_canton` (`idcanton`),
  ADD KEY `fk_persona_etnia` (`idetnia`),
  ADD KEY `fk_persona_genero` (`idgenero`),
  ADD KEY `fk_persona_modalidad` (`idmodalidad`),
  ADD KEY `fk_persona_motivoingreso` (`idmotivoingreso`),
  ADD KEY `fk_persona_nacionalidad` (`idnacionalidad`),
  ADD KEY `fk_persona_organizacion` (`idorganizacion`),
  ADD KEY `fk_persona_parroquia` (`idparroquia`),
  ADD KEY `fk_persona_provincia` (`idprovincia`);

--
-- Indices de la tabla `pgf`
--
ALTER TABLE `pgf`
  ADD PRIMARY KEY (`idpgf`),
  ADD KEY `fk_pgf_canton` (`idcanton`),
  ADD KEY `fk_pgf_familiarreferente` (`idfamiliarreferente`),
  ADD KEY `fk_pgf_idnivelacademico` (`idnivelacademico`),
  ADD KEY `fk_pgf_provincia` (`idprovincia`),
  ADD KEY `fk_pgf_persona` (`idperonsa`);

--
-- Indices de la tabla `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`idprovincia`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `datosjudicialpenal`
--
ALTER TABLE `datosjudicialpenal`
  MODIFY `idjudicialpenal` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `datossalud`
--
ALTER TABLE `datossalud`
  MODIFY `iddatossalud` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `historialcronologico`
--
ALTER TABLE `historialcronologico`
  MODIFY `idhistorial` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `idpersona` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `pgf`
--
ALTER TABLE `pgf`
  MODIFY `idpgf` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `canton`
--
ALTER TABLE `canton`
  ADD CONSTRAINT `fk_canton_provincia` FOREIGN KEY (`idprovincia`) REFERENCES `provincia` (`idprovincia`);

--
-- Filtros para la tabla `datosjudicialpenal`
--
ALTER TABLE `datosjudicialpenal`
  ADD CONSTRAINT `fk_datosjudicialpenal_estadoprocesal` FOREIGN KEY (`idestadoprocesal`) REFERENCES `estadoprocesal` (`idestadoprocesal`),
  ADD CONSTRAINT `fk_datosjudicialpenal_infracciondenunciada` FOREIGN KEY (`idinfracciondenunciada`) REFERENCES `infracciondenunciada` (`idinfracciondenunciada`),
  ADD CONSTRAINT `fk_datosjudicialpenal_medida` FOREIGN KEY (`idmedida`) REFERENCES `medida` (`idmedida`),
  ADD CONSTRAINT `fk_datosjudicialpenal_nudoscriticos` FOREIGN KEY (`idnudoscriticos`) REFERENCES `nudoscriticos` (`idnudoscriticos`),
  ADD CONSTRAINT `fk_datosjudicialpenal_persona` FOREIGN KEY (`idpersona`) REFERENCES `persona` (`idpersona`);

--
-- Filtros para la tabla `historialcronologico`
--
ALTER TABLE `historialcronologico`
  ADD CONSTRAINT `fk_historialcronologico_casaacogimiento` FOREIGN KEY (`idnombrecasaanterior`) REFERENCES `casaacogimiento` (`idnombrecasaanterior`),
  ADD CONSTRAINT `fk_historialcronologico_persona` FOREIGN KEY (`idpersona`) REFERENCES `persona` (`idpersona`);

--
-- Filtros para la tabla `parroquia`
--
ALTER TABLE `parroquia`
  ADD CONSTRAINT `fk_parroquia_canton` FOREIGN KEY (`idcanton`) REFERENCES `canton` (`idcanton`);

--
-- Filtros para la tabla `persona`
--
ALTER TABLE `persona`
  ADD CONSTRAINT `fk_persona_canton` FOREIGN KEY (`idcanton`) REFERENCES `canton` (`idcanton`),
  ADD CONSTRAINT `fk_persona_etnia` FOREIGN KEY (`idetnia`) REFERENCES `etnia` (`idetnia`),
  ADD CONSTRAINT `fk_persona_genero` FOREIGN KEY (`idgenero`) REFERENCES `genero` (`idgenero`),
  ADD CONSTRAINT `fk_persona_modalidad` FOREIGN KEY (`idmodalidad`) REFERENCES `modalidad` (`idmodalidad`),
  ADD CONSTRAINT `fk_persona_motivoingreso` FOREIGN KEY (`idmotivoingreso`) REFERENCES `motivoingreso` (`idmotivoingreso`),
  ADD CONSTRAINT `fk_persona_nacionalidad` FOREIGN KEY (`idnacionalidad`) REFERENCES `nacionalidad` (`idnacionalidad`),
  ADD CONSTRAINT `fk_persona_organizacion` FOREIGN KEY (`idorganizacion`) REFERENCES `organizacion` (`idorganizacion`),
  ADD CONSTRAINT `fk_persona_parroquia` FOREIGN KEY (`idparroquia`) REFERENCES `parroquia` (`idparroquia`),
  ADD CONSTRAINT `fk_persona_provincia` FOREIGN KEY (`idprovincia`) REFERENCES `provincia` (`idprovincia`);

--
-- Filtros para la tabla `pgf`
--
ALTER TABLE `pgf`
  ADD CONSTRAINT `fk_pgf_canton` FOREIGN KEY (`idcanton`) REFERENCES `canton` (`idcanton`),
  ADD CONSTRAINT `fk_pgf_familiarreferente` FOREIGN KEY (`idfamiliarreferente`) REFERENCES `familiarreferente` (`idfamiliarreferente`),
  ADD CONSTRAINT `fk_pgf_idnivelacademico` FOREIGN KEY (`idnivelacademico`) REFERENCES `nivelacademico` (`idnivelacademico`),
  ADD CONSTRAINT `fk_pgf_persona` FOREIGN KEY (`idperonsa`) REFERENCES `persona` (`idpersona`),
  ADD CONSTRAINT `fk_pgf_provincia` FOREIGN KEY (`idprovincia`) REFERENCES `provincia` (`idprovincia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
