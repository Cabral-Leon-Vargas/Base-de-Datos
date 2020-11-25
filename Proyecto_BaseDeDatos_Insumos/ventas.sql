-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-11-2020 a las 06:46:51
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
-- Base de datos: `ventas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `ID` bigint NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `apellido` varchar(200) NOT NULL,
  `numero de contacto` varchar(200) NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `hospital` varchar(200) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `psw` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`ID`, `nombre`, `apellido`, `numero de contacto`, `direccion`, `hospital`, `usuario`, `psw`) VALUES
(1, 'Jose', 'Francisco', '554892284', 'Calle x', 'La raza', 'Jose22', '12345'),
(2, 'Manuel', 'nose', '5548962178', 'sdfghjk', 'sdfghjk', 'm2298', '8cb2237d0679ca88db6464eac60da96345513964');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumos`
--

CREATE TABLE `insumos` (
  `serie` bigint NOT NULL,
  `producto` text NOT NULL,
  `descripcion` varchar(2000) NOT NULL,
  `precio` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `insumos`
--

INSERT INTO `insumos` (`serie`, `producto`, `descripcion`, `precio`) VALUES
(7, 'AGUJA CON BISEL TIPO TOUHI ', '18 G X 2\", EMPAQUE INDIVIDUAL ESTERIL, DESCARTABLE', '$150'),
(8, 'AGUJA CON BISEL TIPO TOUHI', '20 G X 2\", EMPAQUE INDIVIDUAL ESTERIL, DESCARTABLE', '$150'),
(9, 'AGUJA DE PUNCION EPIDURAL ', ' Nº 17, DE 3 1/2\" PARED DELGADA, TIPO TOUHI, DESCARTABLE, EMPAQUE INDIVIDUAL ESTERIL', '$30'),
(10, 'AGUJA DE PUNCION EPIDURAL', 'Nº 18, DE ( 3 1/4 - 3 1/2) \" PARED DELGADA, TIPO TOUHI, DESCARTABLE, EMPAQUE INDIVIDUAL ESTERIL', '$30'),
(11, 'AGUJA DE PUNCION EPIDURAL ', 'Nº 19, DE (3 1/4\" - 3 1/2\") PARED DELGADA, TIPO TOUHI, DESCARTABLE, EMPAQUE INDIVIDUAL ESTERIL', '$30'),
(12, 'Bolsa de empaquetado mixta plana', '10 cm x 25 cm (250 bolsas)', '$180'),
(13, 'Bolsa de empaquetado mixta plana', '10 cm x 30 cm (1000 bolsas)', '$960.90');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedores`
--

CREATE TABLE `vendedores` (
  `ID` bigint NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `apellido` varchar(200) NOT NULL,
  `numero de contacto` varchar(20) NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `psw` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `vendedores`
--

INSERT INTO `vendedores` (`ID`, `nombre`, `apellido`, `numero de contacto`, `direccion`, `usuario`, `psw`) VALUES
(3, 'Milis', 'Cabral', '5548962448', 'Granjas de Guadalupe', 'Milis11', '3564591bf9ed28fdaac06d4d6b37868a8021a371'),
(4, 'Marco Jean', 'Leon', '55483125458', '454444', 'mj222', '3f0c202b24e124ad1a65c033e0237698e75e94dc');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `insumos`
--
ALTER TABLE `insumos`
  ADD PRIMARY KEY (`serie`);

--
-- Indices de la tabla `vendedores`
--
ALTER TABLE `vendedores`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `ID` bigint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `insumos`
--
ALTER TABLE `insumos`
  MODIFY `serie` bigint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `vendedores`
--
ALTER TABLE `vendedores`
  MODIFY `ID` bigint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
