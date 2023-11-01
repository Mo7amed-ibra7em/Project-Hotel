-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 20, 2023 at 03:49 AM
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
(4, 'ahmad', 'asd', 5645666, 'ahmad@gmail.com', 'asdasd123');

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
('محمد', 'ضياء', 23, 'سوري', 234234, 342, '2023-08-04', '2023-08-02', '', '', 0, 0, 0, 0, 0, 'third');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
