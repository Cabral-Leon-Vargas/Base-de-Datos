-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-10-2020 a las 00:09:58
-- Versión del servidor: 8.0.21
-- Versión de PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `datospersonales`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos personales`
--

CREATE TABLE `datos personales` (
  `ID` bigint NOT NULL,
  `Nombre(s)` varchar(20) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Apellido Paterno` varchar(20) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Apellido Materno` varchar(20) CHARACTER SET ascii COLLATE ascii_general_ci NOT NULL,
  `Edad` int NOT NULL,
  `Direccion` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=ascii;

--
-- Volcado de datos para la tabla `datos personales`
--

INSERT INTO `datos personales` (`ID`, `Nombre(s)`, `Apellido Paterno`, `Apellido Materno`, `Edad`, `Direccion`) VALUES
(1, 'Marco Jean', 'Leon', 'Torres', 22, 'Hacienda del Predregal No. 55'),
(2, 'Jose', 'Madero', 'Perez', 35, 'No se'),
(3, 'Jonathan Yael', 'Leon', 'Torres', 17, 'hacienda nueva No. 54'),
(4, 'Jose', 'Madero', 'Perez', 35, 'CDMX'),
(5, 'Jose', 'Madero', 'Perez', 35, 'CDMX');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `datos personales`
--
ALTER TABLE `datos personales`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `datos personales`
--
ALTER TABLE `datos personales`
  MODIFY `ID` bigint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
