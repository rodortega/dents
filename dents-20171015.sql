-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.13-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.4.0.5174
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for dents
DROP DATABASE IF EXISTS `dents`;
CREATE DATABASE IF NOT EXISTS `dents` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dents`;

-- Dumping structure for table dents.appointments
DROP TABLE IF EXISTS `appointments`;
CREATE TABLE IF NOT EXISTS `appointments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  `schedule` datetime NOT NULL,
  `patient_id` int(11) unsigned NOT NULL,
  `created_on` datetime DEFAULT NULL,
  `modified_on` datetime DEFAULT NULL,
  `status` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `FK_appointments_patients` (`patient_id`),
  CONSTRAINT `FK_appointments_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.appointments: ~13 rows (approximately)
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` (`id`, `title`, `description`, `schedule`, `patient_id`, `created_on`, `modified_on`, `status`) VALUES
	(1, 'extraction', 'askjd askd askd askj', '2017-08-29 15:31:00', 1, NULL, NULL, 0),
	(2, 'extraction', 'sdsd asdsa', '2017-08-29 16:04:00', 1, NULL, NULL, 0),
	(3, 'extraction', 'sada asdas asd', '2017-09-14 00:00:00', 2, NULL, NULL, 0),
	(4, 'extraction', 'das asd hh4h4', '2017-09-04 11:42:00', 1, NULL, NULL, 0),
	(5, 'dental floss', 'drd trdr tdrtdrttr', '2017-09-07 14:45:00', 1, NULL, NULL, 0),
	(6, 'pasta', 'pahwerrrr', '2017-09-08 08:22:00', 5, NULL, NULL, 0),
	(7, 'pasta', 'ytrf', '2017-09-09 08:49:00', 4, NULL, NULL, 0),
	(8, 'dental floss', 'sadaf', '2017-09-29 21:44:00', 3, NULL, NULL, 0),
	(9, 'extraction', 'sss', '2017-10-05 21:40:00', 3, NULL, NULL, 0),
	(10, 'dental floss', 'asdasdsad', '2017-10-09 00:11:00', 1, NULL, NULL, 0),
	(11, 'dental floss', 'asdasdsa asdsad', '2017-10-09 03:20:00', 2, NULL, NULL, 0),
	(12, 'extraction', 'asdasdas', '2017-10-21 18:17:00', 2, NULL, NULL, 0),
	(13, 'dental floss', 'asdasdasd', '2017-10-19 20:04:00', 1, NULL, NULL, 0);
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;

-- Dumping structure for table dents.audit_appointments
DROP TABLE IF EXISTS `audit_appointments`;
CREATE TABLE IF NOT EXISTS `audit_appointments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fieldname` varchar(100) NOT NULL,
  `old_value` varchar(100) NOT NULL,
  `new_value` varchar(100) NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.audit_appointments: ~0 rows (approximately)
/*!40000 ALTER TABLE `audit_appointments` DISABLE KEYS */;
/*!40000 ALTER TABLE `audit_appointments` ENABLE KEYS */;

-- Dumping structure for table dents.audit_patients
DROP TABLE IF EXISTS `audit_patients`;
CREATE TABLE IF NOT EXISTS `audit_patients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(11) NOT NULL DEFAULT '0',
  `fieldname` varchar(50) NOT NULL,
  `old_value` varchar(50) NOT NULL,
  `new_value` varchar(50) NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.audit_patients: ~1 rows (approximately)
/*!40000 ALTER TABLE `audit_patients` DISABLE KEYS */;
INSERT INTO `audit_patients` (`id`, `patient_id`, `fieldname`, `old_value`, `new_value`, `datetime_create`) VALUES
	(2, 6, 'phone', '09123456789', '09123456782', '2017-10-15 14:21:33');
/*!40000 ALTER TABLE `audit_patients` ENABLE KEYS */;

-- Dumping structure for table dents.audit_procedures
DROP TABLE IF EXISTS `audit_procedures`;
CREATE TABLE IF NOT EXISTS `audit_procedures` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `procedure_id` int(11) NOT NULL,
  `procedure_name` varchar(50) NOT NULL,
  `fieldname` varchar(50) NOT NULL,
  `old_value` varchar(50) NOT NULL,
  `new_value` varchar(50) NOT NULL,
  `deleted_on` datetime DEFAULT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.audit_procedures: ~0 rows (approximately)
/*!40000 ALTER TABLE `audit_procedures` DISABLE KEYS */;
/*!40000 ALTER TABLE `audit_procedures` ENABLE KEYS */;

-- Dumping structure for table dents.audit_users
DROP TABLE IF EXISTS `audit_users`;
CREATE TABLE IF NOT EXISTS `audit_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `fieldname` varchar(50) NOT NULL,
  `old_value` varchar(50) NOT NULL,
  `new_value` varchar(50) NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dents.audit_users: ~0 rows (approximately)
/*!40000 ALTER TABLE `audit_users` DISABLE KEYS */;
/*!40000 ALTER TABLE `audit_users` ENABLE KEYS */;

-- Dumping structure for table dents.backup_patients
DROP TABLE IF EXISTS `backup_patients`;
CREATE TABLE IF NOT EXISTS `backup_patients` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `patient_id` int(4) unsigned NOT NULL DEFAULT '0',
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `birthday` date NOT NULL,
  `gender` varchar(1) NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `status` int(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.backup_patients: ~1 rows (approximately)
/*!40000 ALTER TABLE `backup_patients` DISABLE KEYS */;
INSERT INTO `backup_patients` (`id`, `patient_id`, `firstname`, `lastname`, `phone`, `address`, `birthday`, `gender`, `datetime_create`, `status`) VALUES
	(0001, 9, 'asdagg', 'gagaga', '325235235', 'asgasdad', '2017-10-15', 'm', '2017-10-15 14:38:35', 1);
/*!40000 ALTER TABLE `backup_patients` ENABLE KEYS */;

-- Dumping structure for table dents.backup_procedures
DROP TABLE IF EXISTS `backup_procedures`;
CREATE TABLE IF NOT EXISTS `backup_procedures` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `procedure_id` int(11) NOT NULL,
  `procedure_name` varchar(50) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  `deleted_on` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.backup_procedures: ~0 rows (approximately)
/*!40000 ALTER TABLE `backup_procedures` DISABLE KEYS */;
/*!40000 ALTER TABLE `backup_procedures` ENABLE KEYS */;

-- Dumping structure for table dents.backup_users
DROP TABLE IF EXISTS `backup_users`;
CREATE TABLE IF NOT EXISTS `backup_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `deleted_on` datetime DEFAULT NULL,
  `created_on` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dents.backup_users: ~0 rows (approximately)
/*!40000 ALTER TABLE `backup_users` DISABLE KEYS */;
/*!40000 ALTER TABLE `backup_users` ENABLE KEYS */;

-- Dumping structure for table dents.history
DROP TABLE IF EXISTS `history`;
CREATE TABLE IF NOT EXISTS `history` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(4) unsigned NOT NULL,
  `procedure_name` varchar(50) NOT NULL,
  `teeth_number` varchar(50) NOT NULL,
  `amount` int(11) NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `FK_history_patients` (`patient_id`),
  CONSTRAINT `FK_history_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.history: ~16 rows (approximately)
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` (`id`, `patient_id`, `procedure_name`, `teeth_number`, `amount`, `datetime_create`) VALUES
	(1, 1, 'extraction', '14', 250, '2017-08-28 15:38:31'),
	(2, 1, 'extraction', '1', 250, '2017-08-28 15:38:31'),
	(3, 2, 'extraction', '4', 250, '2017-09-03 11:43:22'),
	(4, 3, 'extraction', '10', 250, '2017-09-03 17:48:10'),
	(5, 3, 'dental floss', '14', 500, '2017-09-03 17:48:10'),
	(6, 2, 'extraction', '24', 250, '2017-09-05 14:48:23'),
	(7, 2, 'pasta', '14', 100, '2017-09-05 14:48:23'),
	(8, 5, 'pasta', '16', 100, '2017-09-07 08:21:56'),
	(9, 5, 'pasta', '21', 100, '2017-09-07 08:21:56'),
	(10, 5, 'extraction', '32', 250, '2017-09-07 08:21:56'),
	(11, 5, 'extraction', '15', 250, '2017-09-07 08:47:28'),
	(12, 5, 'pasta', '23', 100, '2017-09-07 08:47:28'),
	(17, 6, 'extraction', '2', 250, '2017-10-05 04:02:02'),
	(18, 2, 'extraction', '16', 250, '2017-10-14 19:24:18'),
	(19, 2, 'asd', '18', 200, '2017-10-14 20:06:37'),
	(20, 2, 'dental floss', '18', 500, '2017-10-14 20:06:37');
/*!40000 ALTER TABLE `history` ENABLE KEYS */;

-- Dumping structure for table dents.logs
DROP TABLE IF EXISTS `logs`;
CREATE TABLE IF NOT EXISTS `logs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(50) NOT NULL,
  `user_id` int(4) unsigned zerofill NOT NULL,
  `datetime_create` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `FK_logs_users` (`user_id`),
  CONSTRAINT `FK_logs_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=337 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.logs: ~36 rows (approximately)
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` (`id`, `title`, `description`, `user_id`, `datetime_create`) VALUES
	(301, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 18:43:33'),
	(302, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 18:59:25'),
	(303, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:02:23'),
	(304, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:08:51'),
	(305, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 11 ][ PATIENT ID: 11 ]', 0001, '2017-10-14 19:08:54'),
	(306, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:10:05'),
	(307, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 11 ][ PATIENT ID: 11 ]', 0001, '2017-10-14 19:10:10'),
	(308, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:10:28'),
	(309, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 11 ][ PATIENT ID: 11 ]', 0001, '2017-10-14 19:10:30'),
	(310, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:11:14'),
	(311, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 11 ][ PATIENT ID: 11 ]', 0001, '2017-10-14 19:11:17'),
	(312, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:17:15'),
	(313, 'ADD APPOINTMENT', '[ PATIENT ID: 2 ]', 0001, '2017-10-14 19:17:30'),
	(314, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 19:23:52'),
	(315, 'ADD TRANSACTION', '[ PATIENT ID: 2 ]', 0001, '2017-10-14 19:24:18'),
	(316, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:04:50'),
	(317, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 12 ][ PATIENT ID: 12 ]', 0001, '2017-10-14 20:05:13'),
	(318, 'ADD APPOINTMENT', '[ PATIENT ID: 1 ]', 0001, '2017-10-14 20:05:43'),
	(319, 'ACKNOWLEDGE APPOINTMENT', '[ ACK ID: 13 ][ PATIENT ID: 13 ]', 0001, '2017-10-14 20:05:56'),
	(320, 'ADD TRANSACTION', '[ PATIENT ID: 2 ]', 0001, '2017-10-14 20:06:37'),
	(321, 'UPDATE PATIENT', '[ PATIENT ID: 1 ]', 0001, '2017-10-14 20:07:16'),
	(322, 'ADD PATIENT', '[ PATIENT ID: 0 ]', 0001, '2017-10-14 20:07:42'),
	(323, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:08:57'),
	(324, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:11:44'),
	(325, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:26:10'),
	(326, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:27:11'),
	(327, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:28:57'),
	(328, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 20:30:34'),
	(329, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 22:40:14'),
	(330, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 22:43:39'),
	(331, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 23:02:08'),
	(332, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 23:08:33'),
	(333, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 23:21:30'),
	(334, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 23:22:17'),
	(335, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 23:23:24'),
	(336, 'LOGIN', '[ USER ID: 1 ]', 0001, '2017-10-14 23:27:02');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;

-- Dumping structure for table dents.patients
DROP TABLE IF EXISTS `patients`;
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.patients: ~8 rows (approximately)
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` (`id`, `firstname`, `lastname`, `phone`, `address`, `birthday`, `gender`, `status`) VALUES
	(0001, 'asds', 'asds', 'asds', 'asds', '2017-05-05', 'f', 1),
	(0002, 'Angel ', 'Dasalla', '09151562929', 'dsfsegsegs dfdf', '2017-08-28', 'f', 1),
	(0003, 'Elise', 'Lazatin', '09161584230', 'sada a sdas asd asd ', '1996-09-03', 'f', 1),
	(0004, 'Nowel', 'Domingo', '909465645645654', 'esrsd srs rs', '2017-09-04', 'f', 0),
	(0005, 'Kc', 'Sayasaya', '0649421979979', 'ejhsodhjod', '2017-09-07', 'f', 1),
	(0006, 'rod', 'ortegas', '09123456782', 'asdasdas', '2017-10-05', 'm', 1),
	(0008, 'dsadas', 'dsadsa', 'asdasdasd', 'asagaggg', '2017-10-07', 'm', 1),
	(0009, 'asdagg', 'gagaga', '325235235', 'asgasdad', '2017-10-15', 'm', 1);
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;

-- Dumping structure for table dents.procedures
DROP TABLE IF EXISTS `procedures`;
CREATE TABLE IF NOT EXISTS `procedures` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `procedure_name` varchar(50) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.procedures: ~7 rows (approximately)
/*!40000 ALTER TABLE `procedures` DISABLE KEYS */;
INSERT INTO `procedures` (`id`, `procedure_name`, `amount`) VALUES
	(1, 'asds', 200),
	(2, 'dental floss', 500),
	(4, 'fasf', 0),
	(5, 'asdsa', 232),
	(6, 'dsa', 25),
	(7, 'dsa', 21),
	(10, 'ggg', 22);
/*!40000 ALTER TABLE `procedures` ENABLE KEYS */;

-- Dumping structure for table dents.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table dents.users: ~5 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `password`, `firstname`, `lastname`) VALUES
	(0001, 'admin', 'admin', 'John', 'Does'),
	(0003, 'asd', 'adminer', 'asd', 'asd'),
	(0005, 'asd', 'asd', 'asd', 'asd'),
	(0006, 'asd', 'asd', 'asd', 'asd'),
	(0007, 'sagasg', 'asgasga', 'sgaasg', 'asfas');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- Dumping structure for procedure dents._DELETE_PROCEDURE_BY_ID
DROP PROCEDURE IF EXISTS `_DELETE_PROCEDURE_BY_ID`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_DELETE_PROCEDURE_BY_ID`(
	IN `in_id` INT
)
BEGIN
DELETE FROM procedures WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._DELETE_USER_BY_ID
DROP PROCEDURE IF EXISTS `_DELETE_USER_BY_ID`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_DELETE_USER_BY_ID`(
	IN `in_id` INT
)
BEGIN
DELETE FROM users WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._INSERT_TO_APPOINTMENTS
DROP PROCEDURE IF EXISTS `_INSERT_TO_APPOINTMENTS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_INSERT_TO_APPOINTMENTS`(
	IN `in_title` VARCHAR(50),
	IN `in_description` VARCHAR(50),
	IN `in_schedule` DATETIME,
	IN `in_patient_id` INT,
	IN `in_status` INT
)
BEGIN
INSERT INTO appointments(title,description,schedule,patient_id,status) VALUES (in_title,in_description,in_schedule,in_patient_id,in_status);
END//
DELIMITER ;

-- Dumping structure for procedure dents._INSERT_TO_HISTORY
DROP PROCEDURE IF EXISTS `_INSERT_TO_HISTORY`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_INSERT_TO_HISTORY`(
	IN `in_patient_id` INT,
	IN `in_procedure_name` VARCHAR(50),
	IN `in_teeth_number` VARCHAR(50),
	IN `in_amount` INT
)
BEGIN
INSERT INTO history(patient_id,procedure_name,teeth_number,amount) 
VALUES (in_patient_id,in_procedure_name,in_teeth_number,in_amount);
END//
DELIMITER ;

-- Dumping structure for procedure dents._INSERT_TO_LOGS
DROP PROCEDURE IF EXISTS `_INSERT_TO_LOGS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_INSERT_TO_LOGS`(
	IN `in_title` VARCHAR(50),
	IN `in_description` VARCHAR(50),
	IN `in_user_id` INT



)
BEGIN
    INSERT INTO LOGS(title,description,user_id) VALUES (in_title,in_description,in_user_id);
END//
DELIMITER ;

-- Dumping structure for procedure dents._INSERT_TO_PATIENTS
DROP PROCEDURE IF EXISTS `_INSERT_TO_PATIENTS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_INSERT_TO_PATIENTS`(
	IN `in_firstname` VARCHAR(50),
	IN `in_lastname` VARCHAR(50),
	IN `in_phone` VARCHAR(50),
	IN `in_address` VARCHAR(50),
	IN `in_birthday` DATE,
	IN `in_gender` VARCHAR(50),
	IN `in_status` TINYINT

)
BEGIN
INSERT INTO patients (firstname, lastname, phone, address, birthday, gender, status) 
VALUES (in_firstname, in_lastname, in_phone, in_address, in_birthday, in_gender, in_status);

SELECT id FROM patients WHERE id = LAST_INSERT_ID();
END//
DELIMITER ;

-- Dumping structure for procedure dents._INSERT_TO_PROCEDURES
DROP PROCEDURE IF EXISTS `_INSERT_TO_PROCEDURES`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_INSERT_TO_PROCEDURES`(
	IN `in_procedure_name` VARCHAR(50),
	IN `in_procedure_amount` INT

)
BEGIN
INSERT INTO procedures(procedure_name,amount) VALUES(in_procedure_name,in_procedure_amount);
SELECT id FROM procedures WHERE id = LAST_INSERT_ID();
END//
DELIMITER ;

-- Dumping structure for procedure dents._INSERT_TO_USERS
DROP PROCEDURE IF EXISTS `_INSERT_TO_USERS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_INSERT_TO_USERS`(
	IN `in_username` VARCHAR(50),
	IN `in_password` VARCHAR(50),
	IN `in_firstname` VARCHAR(50),
	IN `in_lastname` VARCHAR(50)

)
BEGIN
INSERT INTO users(username, password, firstname, lastname) VALUES(in_username, in_password, in_firstname, in_lastname);
SELECT id FROM users WHERE id = LAST_INSERT_ID();
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_APPOINTMENTS
DROP PROCEDURE IF EXISTS `_SELECT_ALL_APPOINTMENTS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_APPOINTMENTS`()
BEGIN
	SELECT 
		appointments.*,  
		patients.firstname, patients.lastname, patients.phone, patients.address 
	FROM appointments 
	LEFT JOIN patients 
	ON patients.id = appointments.patient_id 
	WHERE appointments.status = 1 
	ORDER BY appointments.schedule ASC;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_APPOINTMENTS_BY_PATIENT_ID
DROP PROCEDURE IF EXISTS `_SELECT_ALL_APPOINTMENTS_BY_PATIENT_ID`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_APPOINTMENTS_BY_PATIENT_ID`(
	IN `in_patient_id` INT

)
BEGIN
SELECT * FROM appointments WHERE patient_id = in_patient_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_HISTORY_BY_PATIENT_ID
DROP PROCEDURE IF EXISTS `_SELECT_ALL_HISTORY_BY_PATIENT_ID`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_HISTORY_BY_PATIENT_ID`(
	IN `in_patient_id` INT
)
BEGIN
SELECT * FROM history WHERE patient_id = in_patient_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_PATIENTS
DROP PROCEDURE IF EXISTS `_SELECT_ALL_PATIENTS`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_PATIENTS`()
BEGIN
SELECT id, firstname, lastname FROM patients;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_PATIENTS_BY_ID
DROP PROCEDURE IF EXISTS `_SELECT_ALL_PATIENTS_BY_ID`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_PATIENTS_BY_ID`(
	IN `in_patient_id` INT
)
BEGIN
SELECT * FROM patients WHERE id = in_patient_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_PROCEDURES
DROP PROCEDURE IF EXISTS `_SELECT_ALL_PROCEDURES`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_PROCEDURES`()
BEGIN
SELECT * FROM procedures;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_USERS_BY_ID
DROP PROCEDURE IF EXISTS `_SELECT_ALL_USERS_BY_ID`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_USERS_BY_ID`(
	IN `in_id` INT
)
BEGIN
SELECT * FROM users WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_USERS_BY_USERNAME_AND_PASSWORD
DROP PROCEDURE IF EXISTS `_SELECT_ALL_USERS_BY_USERNAME_AND_PASSWORD`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_USERS_BY_USERNAME_AND_PASSWORD`(
	IN `in_username` VARCHAR(50),
	IN `in_password` VARCHAR(50)
)
BEGIN
SELECT * FROM users WHERE username=in_username AND password=in_password;
END//
DELIMITER ;

-- Dumping structure for procedure dents._SELECT_ALL_USERS_NOT_ADMIN
DROP PROCEDURE IF EXISTS `_SELECT_ALL_USERS_NOT_ADMIN`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_SELECT_ALL_USERS_NOT_ADMIN`()
BEGIN
SELECT id, username, firstname, lastname FROM users WHERE id != 1;
END//
DELIMITER ;

-- Dumping structure for procedure dents._UPDATE_APPOINTMENT
DROP PROCEDURE IF EXISTS `_UPDATE_APPOINTMENT`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_UPDATE_APPOINTMENT`(
	IN `in_id` INT
)
BEGIN
UPDATE appointments SET status = 0 WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._UPDATE_PATIENT
DROP PROCEDURE IF EXISTS `_UPDATE_PATIENT`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_UPDATE_PATIENT`(
	IN `in_firstname` VARCHAR(50),
	IN `in_lastname` VARCHAR(50),
	IN `in_phone` VARCHAR(50),
	IN `in_address` VARCHAR(50),
	IN `in_birthday` DATE,
	IN `in_gender` CHAR(50),
	IN `in_status` TINYINT,
	IN `in_patient_id` INT
)
BEGIN
UPDATE patients SET 
firstname = in_firstname, 
lastname = in_lastname, 
phone = in_phone, 
address = in_address, 
birthday = in_birthday, 
gender = in_gender, 
status = in_status 
WHERE id = in_patient_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._UPDATE_PROCEDURE
DROP PROCEDURE IF EXISTS `_UPDATE_PROCEDURE`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_UPDATE_PROCEDURE`(
	IN `in_procedure_name` VARCHAR(50),
	IN `in_procedure_amount` INT,
	IN `in_id` INT
)
BEGIN
UPDATE procedures SET procedure_name = in_procedure_name, amount = in_procedure_amount WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._UPDATE_USER
DROP PROCEDURE IF EXISTS `_UPDATE_USER`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_UPDATE_USER`(
	IN `in_username` VARCHAR(50),
	IN `in_firstname` VARCHAR(50),
	IN `in_lastname` VARCHAR(50),
	IN `in_id` INT
)
BEGIN
UPDATE users 
SET 
username = in_username, 
firstname = in_firstname, 
lastname = in_lastname 
WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for procedure dents._UPDATE_USER_ONLY_PASSWORD
DROP PROCEDURE IF EXISTS `_UPDATE_USER_ONLY_PASSWORD`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `_UPDATE_USER_ONLY_PASSWORD`(
	IN `in_id` INT,
	IN `in_password` VARCHAR(50)

)
BEGIN
UPDATE users SET password = in_password WHERE id = in_id;
END//
DELIMITER ;

-- Dumping structure for trigger dents.appointments_after_update
DROP TRIGGER IF EXISTS `appointments_after_update`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `appointments_after_update` AFTER UPDATE ON `appointments` FOR EACH ROW BEGIN
	IF (NEW.status != OLD.status) THEN
		INSERT INTO audit_appointments 
		(fieldname, old_value, new_value) 
		VALUES 
		('status', OLD.status, NEW.status);
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.patients_after_insert
DROP TRIGGER IF EXISTS `patients_after_insert`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `patients_after_insert` AFTER INSERT ON `patients` FOR EACH ROW BEGIN
	INSERT INTO backup_patients 
	(patient_id,firstname, lastname, phone, address, birthday, gender, status) VALUES 
	(NEW.id,NEW.firstname, NEW.lastname, NEW.phone, NEW.address, NEW.birthday, NEW.gender, NEW.status);
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.patients_after_update
DROP TRIGGER IF EXISTS `patients_after_update`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `patients_after_update` AFTER UPDATE ON `patients` FOR EACH ROW BEGIN
	-- firstname
	IF (NEW.firstname != OLD.firstname) THEN
		INSERT INTO audit_patients
		(patient_id,fieldname, old_value, new_value) 
		VALUES 
		(OLD.id,'firstname', OLD.firstname, NEW.firstname);
	END IF;
	-- lastname
	IF (NEW.lastname != OLD.lastname) THEN
		INSERT INTO audit_patients
		(patient_id,fieldname, old_value, new_value) 
		VALUES 
		(OLD.id,'lastname', OLD.lastname, NEW.lastname);
	END IF;
	-- phone
	IF (NEW.phone != OLD.phone) THEN
		INSERT INTO audit_patients
		(patient_id,fieldname, old_value, new_value) 
		VALUES 
		(OLD.id,'phone', OLD.phone, NEW.phone);
	END IF;
	-- address
	IF (NEW.address != OLD.address) THEN
		INSERT INTO audit_patients
		(patient_id,fieldname, old_value, new_value) 
		VALUES 
		(OLD.id,'address', OLD.address, NEW.address);
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.procedures_after_delete
DROP TRIGGER IF EXISTS `procedures_after_delete`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `procedures_after_delete` AFTER DELETE ON `procedures` FOR EACH ROW BEGIN
	UPDATE audit_procedures 
	SET deleted_on = SYSDATE()
	WHERE procedure_id = OLD.id;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.procedures_after_insert
DROP TRIGGER IF EXISTS `procedures_after_insert`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `procedures_after_insert` AFTER INSERT ON `procedures` FOR EACH ROW BEGIN
	INSERT INTO backup_procedures (procedure_id, procedure_name, amount) 
	VALUES (NEW.id, NEW.procedure_name, NEW.amount);
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.procedures_after_update
DROP TRIGGER IF EXISTS `procedures_after_update`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `procedures_after_update` AFTER UPDATE ON `procedures` FOR EACH ROW BEGIN
	-- procedure_name
	IF (NEW.procedure_name != OLD.procedure_name) THEN
		INSERT INTO audit_procedures
		(procedure_id,procedure_name,fieldname, old_value, new_value) 
		VALUES 
		(OLD.id,OLD.procedure_name,'procedure_name', OLD.procedure_name, NEW.procedure_name);
	END IF;
	-- amount
	IF (NEW.amount != OLD.amount) THEN
		INSERT INTO audit_procedures
		(procedure_id,procedure_name,fieldname, old_value, new_value) 
		VALUES 
		(OLD.id,OLD.procedure_name,'amount', OLD.amount, NEW.amount);
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.users_after_delete
DROP TRIGGER IF EXISTS `users_after_delete`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `users_after_delete` AFTER DELETE ON `users` FOR EACH ROW BEGIN
	UPDATE backup_users 
	SET deleted_on = SYSDATE()
	WHERE user_id = OLD.id;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.users_after_insert
DROP TRIGGER IF EXISTS `users_after_insert`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `users_after_insert` AFTER INSERT ON `users` FOR EACH ROW BEGIN
	INSERT INTO backup_users 
	(user_id, username, password, firstname, lastname) VALUES 
	(NEW.id, NEW.username, NEW.password, NEW.firstname, NEW.lastname);
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger dents.users_after_update
DROP TRIGGER IF EXISTS `users_after_update`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `users_after_update` AFTER UPDATE ON `users` FOR EACH ROW BEGIN
	INSERT INTO audit_users
	(user_id, username, password, firstname, lastname) VALUES
	(OLD.id, OLD.username, OLD.password, OLD.firstname, OLD.lastname);
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
