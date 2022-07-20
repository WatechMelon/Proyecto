-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-07-2022 a las 22:29:10
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asocia`
--

CREATE TABLE `asocia` (
  `Especie1` varchar(50) NOT NULL,
  `Especie2` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `calendario`
--

CREATE TABLE `calendario` (
  `NombreEspecie` varchar(50) NOT NULL,
  `Meses` int(11) NOT NULL,
  `Tiempo_Cosecha` date DEFAULT NULL,
  `Tiempo_Trasplante` date DEFAULT NULL,
  `Tiempo_Germinacion` date DEFAULT NULL,
  `Siembra_Inicio` date DEFAULT NULL,
  `Siembra_Fin` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `ID_Cliente` int(11) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Contrasena` varchar(20) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Barrio` varchar(50) DEFAULT NULL,
  `Numero` varchar(50) DEFAULT NULL,
  `Esquina` varchar(50) DEFAULT NULL,
  `Calle` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_empresa`
--

CREATE TABLE `cliente_empresa` (
  `ID_Cliente` int(11) NOT NULL,
  `RUT` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_terminal`
--

CREATE TABLE `cliente_terminal` (
  `ID_Cliente` int(11) NOT NULL,
  `CI` int(11) DEFAULT NULL,
  `PrimerNombre` varchar(50) DEFAULT NULL,
  `SegundoNombre` varchar(50) DEFAULT NULL,
  `PrimerApellido` varchar(50) DEFAULT NULL,
  `SegundoApellido` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entrega`
--

CREATE TABLE `entrega` (
  `ID_Estado` int(11) NOT NULL,
  `ID_Repartidor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especie`
--

CREATE TABLE `especie` (
  `NombreEspecie` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esta`
--

CREATE TABLE `esta` (
  `ID_Estado` int(11) NOT NULL,
  `NumPedido` int(11) DEFAULT NULL,
  `FechaInic` date DEFAULT NULL,
  `FechaFin` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadopedido`
--

CREATE TABLE `estadopedido` (
  `ID_Estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `he`
--

CREATE TABLE `he` (
  `ID_HE` int(11) NOT NULL,
  `Tamaño` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `NumPedido` int(11) NOT NULL,
  `CantidadProductos` int(11) DEFAULT NULL,
  `ListaProductos` varchar(1000) DEFAULT NULL,
  `MetodoPago` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planta`
--

CREATE TABLE `planta` (
  `ID_HE` int(11) NOT NULL,
  `NombreVariedad` varchar(50) NOT NULL,
  `EstadoCultivo` varchar(50) DEFAULT NULL,
  `MetaCultivos` int(11) DEFAULT NULL,
  `FechaCultvio` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `posee`
--

CREATE TABLE `posee` (
  `NumPedido` int(11) NOT NULL,
  `NombreVariedad` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `realiza`
--

CREATE TABLE `realiza` (
  `NumPedido` int(11) NOT NULL,
  `ID_Cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `repartidor`
--

CREATE TABLE `repartidor` (
  `ID_Repartidor` int(11) NOT NULL,
  `ID_Sucursal` int(11) NOT NULL,
  `Contrasena` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE `sucursal` (
  `ID_Sucursal` int(11) NOT NULL,
  `Barrio` varchar(50) DEFAULT NULL,
  `Numero` varchar(50) DEFAULT NULL,
  `ESQUINA` varchar(50) DEFAULT NULL,
  `CALLE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `variedad`
--

CREATE TABLE `variedad` (
  `NombreVariedad` varchar(50) NOT NULL,
  `Stock` int(11) DEFAULT NULL,
  `NombreEspecie` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asocia`
--
ALTER TABLE `asocia`
  ADD PRIMARY KEY (`Especie1`,`Especie2`);

--
-- Indices de la tabla `calendario`
--
ALTER TABLE `calendario`
  ADD PRIMARY KEY (`NombreEspecie`,`Meses`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ID_Cliente`);

--
-- Indices de la tabla `cliente_empresa`
--
ALTER TABLE `cliente_empresa`
  ADD PRIMARY KEY (`ID_Cliente`);

--
-- Indices de la tabla `cliente_terminal`
--
ALTER TABLE `cliente_terminal`
  ADD PRIMARY KEY (`ID_Cliente`);

--
-- Indices de la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`ID_Estado`),
  ADD KEY `ID_Repartidor` (`ID_Repartidor`);

--
-- Indices de la tabla `especie`
--
ALTER TABLE `especie`
  ADD PRIMARY KEY (`NombreEspecie`);

--
-- Indices de la tabla `esta`
--
ALTER TABLE `esta`
  ADD PRIMARY KEY (`ID_Estado`),
  ADD KEY `NumPedido` (`NumPedido`);

--
-- Indices de la tabla `estadopedido`
--
ALTER TABLE `estadopedido`
  ADD PRIMARY KEY (`ID_Estado`);

--
-- Indices de la tabla `he`
--
ALTER TABLE `he`
  ADD PRIMARY KEY (`ID_HE`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`NumPedido`);

--
-- Indices de la tabla `planta`
--
ALTER TABLE `planta`
  ADD PRIMARY KEY (`ID_HE`,`NombreVariedad`),
  ADD KEY `NombreVariedad` (`NombreVariedad`);

--
-- Indices de la tabla `posee`
--
ALTER TABLE `posee`
  ADD PRIMARY KEY (`NumPedido`,`NombreVariedad`),
  ADD KEY `NombreVariedad` (`NombreVariedad`);

--
-- Indices de la tabla `realiza`
--
ALTER TABLE `realiza`
  ADD PRIMARY KEY (`NumPedido`),
  ADD KEY `ID_Cliente` (`ID_Cliente`);

--
-- Indices de la tabla `repartidor`
--
ALTER TABLE `repartidor`
  ADD PRIMARY KEY (`ID_Repartidor`),
  ADD KEY `ID_Sucursal` (`ID_Sucursal`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  ADD PRIMARY KEY (`ID_Sucursal`);

--
-- Indices de la tabla `variedad`
--
ALTER TABLE `variedad`
  ADD PRIMARY KEY (`NombreVariedad`),
  ADD KEY `NombreEspecie` (`NombreEspecie`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `calendario`
--
ALTER TABLE `calendario`
  ADD CONSTRAINT `calendario_ibfk_1` FOREIGN KEY (`NombreEspecie`) REFERENCES `especie` (`NombreEspecie`);

--
-- Filtros para la tabla `cliente_empresa`
--
ALTER TABLE `cliente_empresa`
  ADD CONSTRAINT `cliente_empresa_ibfk_1` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`);

--
-- Filtros para la tabla `cliente_terminal`
--
ALTER TABLE `cliente_terminal`
  ADD CONSTRAINT `cliente_terminal_ibfk_1` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`);

--
-- Filtros para la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD CONSTRAINT `entrega_ibfk_1` FOREIGN KEY (`ID_Estado`) REFERENCES `estadopedido` (`ID_Estado`),
  ADD CONSTRAINT `entrega_ibfk_2` FOREIGN KEY (`ID_Repartidor`) REFERENCES `repartidor` (`ID_Repartidor`);

--
-- Filtros para la tabla `esta`
--
ALTER TABLE `esta`
  ADD CONSTRAINT `esta_ibfk_1` FOREIGN KEY (`ID_Estado`) REFERENCES `estadopedido` (`ID_Estado`),
  ADD CONSTRAINT `esta_ibfk_2` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`);

--
-- Filtros para la tabla `planta`
--
ALTER TABLE `planta`
  ADD CONSTRAINT `planta_ibfk_1` FOREIGN KEY (`ID_HE`) REFERENCES `he` (`ID_HE`),
  ADD CONSTRAINT `planta_ibfk_2` FOREIGN KEY (`NombreVariedad`) REFERENCES `variedad` (`NombreVariedad`);

--
-- Filtros para la tabla `posee`
--
ALTER TABLE `posee`
  ADD CONSTRAINT `posee_ibfk_1` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`),
  ADD CONSTRAINT `posee_ibfk_2` FOREIGN KEY (`NombreVariedad`) REFERENCES `variedad` (`NombreVariedad`);

--
-- Filtros para la tabla `realiza`
--
ALTER TABLE `realiza`
  ADD CONSTRAINT `realiza_ibfk_1` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`),
  ADD CONSTRAINT `realiza_ibfk_2` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`);

--
-- Filtros para la tabla `repartidor`
--
ALTER TABLE `repartidor`
  ADD CONSTRAINT `repartidor_ibfk_1` FOREIGN KEY (`ID_Sucursal`) REFERENCES `sucursal` (`ID_Sucursal`);

--
-- Filtros para la tabla `variedad`
--
ALTER TABLE `variedad`
  ADD CONSTRAINT `variedad_ibfk_1` FOREIGN KEY (`NombreEspecie`) REFERENCES `especie` (`NombreEspecie`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
