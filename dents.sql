-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.13-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for dents
CREATE DATABASE IF NOT EXISTS `dents` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dents`;

-- Dumping structure for table dents.appointments
CREATE TABLE IF NOT EXISTS `appointments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  `schedule` datetime NOT NULL,
  `patient_id` int(11) unsigned NOT NULL,
  `status` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `FK_appointments_patients` (`patient_id`),
  CONSTRAINT `FK_appointments_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.appointments: ~3 rows (approximately)
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` (`id`, `title`, `description`, `schedule`, `patient_id`, `status`) VALUES
	(1, 'extraction', 'askjd askd askd askj', '2017-08-29 15:31:00', 1, 0),
	(2, 'extraction', 'sdsd asdsa', '2017-08-29 16:04:00', 1, 0),
	(3, 'extraction', 'sada asdas asd', '2017-09-14 00:00:00', 2, 0);
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;

-- Dumping structure for table dents.history
CREATE TABLE IF NOT EXISTS `history` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(4) unsigned NOT NULL,
  `procedure_name` varchar(50) NOT NULL,
  `teeth_number` varchar(50) NOT NULL,
  `amount` int(11) NOT NULL,
  `datetime_create` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_history_patients` (`patient_id`),
  CONSTRAINT `FK_history_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.history: ~2 rows (approximately)
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` (`id`, `patient_id`, `procedure_name`, `teeth_number`, `amount`, `datetime_create`) VALUES
	(1, 1, 'extraction', '14', 250, '2017-08-28 15:38:31'),
	(2, 1, 'extraction', '1', 250, '2017-08-28 15:38:31');
/*!40000 ALTER TABLE `history` ENABLE KEYS */;

-- Dumping structure for table dents.logs
CREATE TABLE IF NOT EXISTS `logs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(50) NOT NULL,
  `user_id` int(4) unsigned zerofill NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `FK_logs_users` (`user_id`),
  CONSTRAINT `FK_logs_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=183 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.logs: ~48 rows (approximately)
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` (`id`, `title`, `description`, `user_id`, `datetime_create`) VALUES
	(131, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-23 18:30:58'),
	(132, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-28 15:29:47'),
	(133, 'ADD PATIENT', '[ PATIENT ID: 1 ]', 0001, '2017-08-28 15:31:10'),
	(134, 'ADD APPOINTMENT', '[ PATIENT ID: 1 ]', 0001, '2017-08-28 15:32:10'),
	(135, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-28 15:35:07'),
	(136, 'ADD PATIENT', '[ PATIENT ID: 2 ]', 0001, '2017-08-28 15:36:09'),
	(137, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 1 ][ PATIENT ID: 1 ]', 0001, '2017-08-28 15:37:24'),
	(138, 'ADD TRANSACTION', '[ PATIENT ID: 1 ]', 0001, '2017-08-28 15:38:31'),
	(139, 'UPDATE PATIENT', '[ PATIENT ID: 1 ]', 0001, '2017-08-28 15:38:53'),
	(140, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 17:21:23'),
	(141, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 17:39:20'),
	(142, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 17:40:17'),
	(143, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 17:41:54'),
	(144, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 17:42:46'),
	(145, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 17:44:21'),
	(146, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:13:32'),
	(147, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:26:01'),
	(148, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:29:03'),
	(149, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:29:45'),
	(150, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:30:14'),
	(151, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:30:36'),
	(152, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:33:15'),
	(153, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:34:23'),
	(154, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:36:30'),
	(155, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:36:42'),
	(156, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:37:47'),
	(157, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:38:23'),
	(158, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-08-30 18:40:14'),
	(159, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 13:26:50'),
	(160, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 13:41:13'),
	(161, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 13:42:40'),
	(162, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 14:00:15'),
	(163, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 14:39:28'),
	(164, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 14:40:59'),
	(165, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 14:54:44'),
	(166, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 14:59:47'),
	(167, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:03:09'),
	(168, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:06:27'),
	(169, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:28:01'),
	(170, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:29:08'),
	(171, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:31:07'),
	(172, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:34:15'),
	(173, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 15:40:04'),
	(174, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 16:23:09'),
	(175, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 16:39:04'),
	(176, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 16:58:35'),
	(177, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 17:00:11'),
	(178, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 17:08:41'),
	(179, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 17:27:38'),
	(180, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 17:28:58'),
	(181, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-09-01 17:42:59'),
	(182, 'UPDATE PATIENT', '[ PATIENT ID: 2 ]', 0001, '2017-09-01 17:44:04');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;

-- Dumping structure for table dents.patients
CREATE TABLE IF NOT EXISTS `patients` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `birthday` date NOT NULL,
  `gender` varchar(1) NOT NULL,
  `status` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.patients: ~2 rows (approximately)
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` (`id`, `firstname`, `lastname`, `phone`, `address`, `birthday`, `gender`, `status`) VALUES
	(0001, 'Elvis', 'Presley', '091234456789', 'asdas asdasd jsad', '2005-08-28', 'm', 1),
	(0002, 'angel ', 'dasalla', '09151562929', 'dsfsegsegs', '2017-08-28', 'f', 1);
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;

-- Dumping structure for table dents.procedures
CREATE TABLE IF NOT EXISTS `procedures` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `procedure_name` varchar(50) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.procedures: ~2 rows (approximately)
/*!40000 ALTER TABLE `procedures` DISABLE KEYS */;
INSERT INTO `procedures` (`id`, `procedure_name`, `amount`) VALUES
	(1, 'extraction', 250),
	(2, 'dental floss', 500);
/*!40000 ALTER TABLE `procedures` ENABLE KEYS */;

-- Dumping structure for table dents.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.users: ~0 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `password`, `firstname`, `lastname`) VALUES
	(0001, 'admin', 'admin', 'John', 'Does');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
