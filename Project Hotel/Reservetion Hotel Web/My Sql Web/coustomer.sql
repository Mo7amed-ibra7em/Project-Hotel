-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 10, 2023 at 07:02 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `coustomer`
--

CREATE TABLE `coustomer` (
  `id` int(11) NOT NULL,
  `firstname` varchar(10) NOT NULL,
  `lastname` varchar(10) NOT NULL,
  `number` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `coustomer`
--

INSERT INTO `coustomer` (`id`, `firstname`, `lastname`, `number`, `email`, `password`) VALUES
(1, 'ahmad', 'asd', 656464, 'ahmad@gmail.com', 'asdasd123'),
(2, 'mohmad', 'diaa', 34646, 'mohmaddiaa@gmail.com', 'asdasd123'),
(3, 'ahmad', 'aasd', 54764, 'ahmad?@gmail.com', 'asdasd123'),
(4, 'ahmad', 'asd', 5645666, 'ahmad@gmail.com', 'asdasd123'),
(5, 'ahmad', 'asd', 342534, 'ahmadasd@gmail.com', '123123'),
(6, 'احمد', 'محمد', 324235, 'ahmad@gmail.com', '123123'),
(7, 'محمد', 'عضو', 43234234, 'mhm@gmail.com', '123123'),
(8, 'محمد', 'علي', 55646, 'ma@gmail.com', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coustomer`
--
ALTER TABLE `coustomer`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `coustomer`
--
ALTER TABLE `coustomer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
