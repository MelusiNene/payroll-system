-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 26, 2015 at 10:48 AM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `pay_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `deduction`
--

CREATE TABLE IF NOT EXISTS `deduction` (
  `deduction_id` int(11) NOT NULL DEFAULT '0',
  `sss` double DEFAULT NULL,
  `pag_ibig` double DEFAULT NULL,
  `late` double DEFAULT NULL,
  `others` double DEFAULT NULL,
  `deduction_date` date DEFAULT NULL,
  PRIMARY KEY (`deduction_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deduction`
--


-- --------------------------------------------------------

--
-- Table structure for table `designation`
--

CREATE TABLE IF NOT EXISTS `designation` (
  `designation_id` int(11) NOT NULL DEFAULT '0',
  `designation_name` varchar(255) DEFAULT NULL,
  `designation_amount` double DEFAULT NULL,
  PRIMARY KEY (`designation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `designation`
--

INSERT INTO `designation` (`designation_id`, `designation_name`, `designation_amount`) VALUES
(4, 'Operator', 40),
(1, 'Janitor', 35),
(2, 'Driver', 40),
(3, 'Labor', 50);

-- --------------------------------------------------------

--
-- Table structure for table `dtr`
--

CREATE TABLE IF NOT EXISTS `dtr` (
  `worker_id` int(11) DEFAULT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL,
  `date` date DEFAULT NULL,
  KEY `worker_id` (`worker_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dtr`
--


-- --------------------------------------------------------

--
-- Table structure for table `log_history`
--

CREATE TABLE IF NOT EXISTS `log_history` (
  `id` int(11) DEFAULT NULL,
  `date_time` datetime DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `log_history`
--


-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `id` int(11) NOT NULL DEFAULT '0',
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `secret_question` varchar(255) DEFAULT NULL,
  `secret_answer` varchar(255) DEFAULT NULL,
  `login_type` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`id`, `username`, `password`, `secret_question`, `secret_answer`, `login_type`) VALUES
(1, 'admin', 'admin', 'What is my name?', 'admin', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `wage`
--

CREATE TABLE IF NOT EXISTS `wage` (
  `wage_id` int(11) NOT NULL DEFAULT '0',
  `days_work` int(11) DEFAULT NULL,
  `hours_pay` double DEFAULT NULL,
  `overtime_pay` double DEFAULT NULL,
  `wage_date` date DEFAULT NULL,
  `worker_id` int(11) DEFAULT NULL,
  `deduction_id` int(11) DEFAULT NULL,
  `id` int(11) DEFAULT NULL,
  PRIMARY KEY (`wage_id`),
  KEY `worker_id` (`worker_id`),
  KEY `deduction_id` (`deduction_id`),
  KEY `id` (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `wage`
--


-- --------------------------------------------------------

--
-- Table structure for table `worker`
--

CREATE TABLE IF NOT EXISTS `worker` (
  `worker_id` int(11) NOT NULL DEFAULT '0',
  `worker_fullname` varchar(255) DEFAULT NULL,
  `worker_password` varchar(255) DEFAULT NULL,
  `worker_address` varchar(255) DEFAULT NULL,
  `worker_birthdate` date DEFAULT NULL,
  `worker_gender` varchar(255) DEFAULT NULL,
  `date_hired` date DEFAULT NULL,
  `contact_no` varchar(255) DEFAULT NULL,
  `designation_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`worker_id`),
  KEY `designation_id` (`designation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `worker`
--

INSERT INTO `worker` (`worker_id`, `worker_fullname`, `worker_password`, `worker_address`, `worker_birthdate`, `worker_gender`, `date_hired`, `contact_no`, `designation_id`) VALUES
(1, 'Skribblez', '123', 'Virgin Island', '1992-10-08', 'Female', '1992-10-08', '341-42-33', 3),
(2, 'Snowkel', '123', 'Rainbow', '1992-12-08', 'Male', '2009-12-08', '341-55-11', 1),
(3, 'Muy', '123', 'Rainbow Island', '1992-10-08', 'Female', '1992-10-08', '341-43-00', 4);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
