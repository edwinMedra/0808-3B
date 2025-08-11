-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-08-2025 a las 10:09:42
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `minibank`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial_transacciones`
--

CREATE TABLE `historial_transacciones` (
  `id` int(11) NOT NULL,
  `numDui` varchar(20) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT current_timestamp(),
  `monto` decimal(10,2) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `numCuentaDestino` varchar(20) NOT NULL,
  `detalle` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `historial_transacciones`
--

INSERT INTO `historial_transacciones` (`id`, `numDui`, `fecha`, `monto`, `tipo`, `numCuentaDestino`, `detalle`) VALUES
(1, 'e', '2025-08-11 01:39:09', 10.00, 'envío', '47518161', 'Transferencia a e'),
(2, '07550380-3', '2025-08-11 02:03:56', 5.00, 'envío', '12345678', 'Transferencia a 1'),
(3, 'e', '2025-08-11 02:04:52', 10.00, 'envío', '47518161', 'Transferencia a 1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `numDui` varchar(10) NOT NULL,
  `pass` varchar(200) NOT NULL,
  `saldo` double DEFAULT NULL,
  `numCuenta` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `apellido`, `email`, `numDui`, `pass`, `saldo`, `numCuenta`) VALUES
(1, 'edwin', 'e', 'e', 'e', 'e', 0, '12345678'),
(3, 'Edwin', 'Medrano', 'gabriel.medray7@gmail.com', '07550380-3', '123', 15, '47518161');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `historial_transacciones`
--
ALTER TABLE `historial_transacciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `historial_transacciones`
--
ALTER TABLE `historial_transacciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
