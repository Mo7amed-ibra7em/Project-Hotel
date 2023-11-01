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
-- Table structure for table `coustomer_info`
--

CREATE TABLE `coustomer_info` (
  `firstname` varchar(10) NOT NULL,
  `lastname` varchar(10) NOT NULL,
  `age` int(11) NOT NULL,
  `nationality` varchar(10) NOT NULL,
  `id_number` int(11) NOT NULL,
  `number` int(11) NOT NULL,
  `date_in` date NOT NULL,
  `date_out` date NOT NULL,
  `wifefirstname` varchar(10) NOT NULL,
  `wife_lastname` varchar(10) NOT NULL,
  `id_number_wife` int(11) NOT NULL,
  `num_people` int(11) NOT NULL,
  `last_12` int(11) NOT NULL,
  `between_12` int(11) NOT NULL,
  `more_12` int(11) NOT NULL,
  `rom_type` enum('single','dual','sweet','third') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `coustomer_info`
--

INSERT INTO `coustomer_info` (`firstname`, `lastname`, `age`, `nationality`, `id_number`, `number`, `date_in`, `date_out`, `wifefirstname`, `wife_lastname`, `id_number_wife`, `num_people`, `last_12`, `between_12`, `more_12`, `rom_type`) VALUES
('محمد', 'ضياء', 23, 'سوري', 2147483647, 844456658, '2023-08-05', '2023-08-03', '', '', 0, 4, 2, 1, 1, 'sweet'),
('محمد', 'احمد', 32, 'سوري', 45546, 64685, '2023-08-09', '2023-08-02', 'سوسو', 'الحلوة', 6565, 4, 2, 1, 1, 'dual'),
('محمد', 'ضياء', 23, 'سوري', 234234, 342, '2023-08-04', '2023-08-02', '', '', 0, 0, 0, 0, 0, 'sweet'),
('محمد', 'ضياء', 23, 'سوري', 234234, 342, '2023-08-04', '2023-08-02', '', '', 0, 0, 0, 0, 0, ''),
('محمد', 'ضياء', 23, 'سوري', 234234, 342, '2023-08-04', '2023-08-02', '', '', 0, 0, 0, 0, 0, 'third'),
('محمد', 'احمد', 23, 'سوري', 23423, 23, '2023-09-01', '2023-08-29', 'سوسو', 'asma', 234234, 3, 2, 1, 2, 'sweet');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
