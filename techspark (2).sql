-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2023 at 02:33 AM
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
-- Database: `techspark`
--

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `id` int(11) NOT NULL,
  `feedback_text` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`id`, `feedback_text`) VALUES
(1, 'Great experience, loved the service!'),
(2, 'Suggestions for improvement: faster response times.'),
(3, 'Excellent customer support.'),
(4, 'The product exceeded my expectations.'),
(5, 'Some features need enhancement.'),
(6, 'Prompt delivery, satisfied with the purchase.'),
(7, 'User-friendly interface, easy to navigate.'),
(8, 'Would appreciate more discounts in the future.'),
(9, 'Overall, a positive experience with the company.'),
(10, 'Found the product pricing competitive and reasonable.');

-- --------------------------------------------------------

--
-- Table structure for table `parkingreservations`
--

CREATE TABLE `parkingreservations` (
  `id` int(11) NOT NULL,
  `plate_number` varchar(255) NOT NULL,
  `slot_number` int(11) DEFAULT NULL,
  `checkin_time` datetime DEFAULT NULL,
  `checkout_time` datetime DEFAULT NULL,
  `date` date DEFAULT NULL,
  `user_credentials_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `parkingreservations`
--

INSERT INTO `parkingreservations` (`id`, `plate_number`, `slot_number`, `checkin_time`, `checkout_time`, `date`, `user_credentials_id`) VALUES
(1, 'ABC-1234', 1, '2023-12-10 09:26:00', '2023-12-10 10:26:00', '2023-12-10', 1),
(2, 'DEF-5678', 2, '2023-12-10 10:00:00', '2023-12-10 11:00:00', '2023-12-10', 2),
(3, 'GHI-9012', 3, '2023-12-10 11:30:00', '2023-12-10 12:30:00', '2023-12-10', 3),
(4, 'JKL-3456', 4, '2023-12-10 12:00:00', '2023-12-10 13:00:00', '2023-12-10', 4),
(5, 'MNO-7890', 5, '2023-12-10 13:30:00', '2023-12-10 14:30:00', '2023-12-10', 5),
(6, 'PQR-1234', 6, '2023-12-10 14:00:00', '2023-12-10 15:00:00', '2023-12-10', 6),
(7, 'STU-5678', 7, '2023-12-10 15:30:00', '2023-12-10 16:30:00', '2023-12-10', 7),
(8, 'VWX-9012', 8, '2023-12-10 16:00:00', '2023-12-10 17:00:00', '2023-12-10', 8),
(9, 'YZA-3456', 9, '2023-12-10 17:30:00', '2023-12-10 18:30:00', '2023-12-10', 9),
(10, 'BCD-7890', 10, '2023-12-10 18:00:00', '2023-12-10 19:00:00', '2023-12-10', 10);

-- --------------------------------------------------------

--
-- Table structure for table `usercredentials`
--

CREATE TABLE `usercredentials` (
  `ID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usercredentials`
--

INSERT INTO `usercredentials` (`ID`, `Username`, `Password`) VALUES
(1, 'admin', 'admin123'),
(2, 'Kane', 'acielo'),
(3, 'Brian', 'Tolentino'),
(4, 'Alice', 'Wonderland'),
(5, 'Charlie', 'ChocolateFactory'),
(6, 'David', 'DancingDragon'),
(7, 'Eva', 'EnchantedForest'),
(8, 'Frank', 'FlyingHigh'),
(9, 'Grace', 'GoldenGate'),
(10, 'Henry', 'HarmonyHub'),
(11, 'Isabel', 'IslandBreeze');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `parkingreservations`
--
ALTER TABLE `parkingreservations`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_parkingreservations_usercredentials` (`user_credentials_id`);

--
-- Indexes for table `usercredentials`
--
ALTER TABLE `usercredentials`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `parkingreservations`
--
ALTER TABLE `parkingreservations`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `usercredentials`
--
ALTER TABLE `usercredentials`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `parkingreservations`
--
ALTER TABLE `parkingreservations`
  ADD CONSTRAINT `FK_parkingreservations_usercredentials` FOREIGN KEY (`user_credentials_id`) REFERENCES `usercredentials` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
