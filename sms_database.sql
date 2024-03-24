-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2024 at 10:34 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sms_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `academic`
--

CREATE TABLE `academic` (
  `AID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `NIC` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `DOB` date NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Mobile_no` int(10) NOT NULL,
  `TID` int(11) DEFAULT NULL,
  `Religion` varchar(20) NOT NULL,
  `Admission_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `academic`
--

INSERT INTO `academic` (`AID`, `Name`, `NIC`, `Address`, `Gender`, `DOB`, `Password`, `Username`, `Mobile_no`, `TID`, `Religion`, `Admission_date`) VALUES
(1, 'bbb', '1234', 'ffvfv', 'female', '2024-03-24', 'efef', 'vfv', 3456, NULL, 'System.Windows.Forms', '2024-03-24'),
(2, 'hmhmh', '1221', 'gbgb', 'male', '2024-03-24', 'academic', 'academic', 34344, NULL, 'www', '2024-03-24'),
(2003, 'mmmm', '12212', 'ffff', 'male', '2024-03-24', 'academic1', 'academic1', 12345, NULL, 'ddd', '2024-03-24');

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('admin', 'admin'),
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `CID` int(11) NOT NULL,
  `Year_start_date` date NOT NULL,
  `Year_end_date` date NOT NULL,
  `Term_start_date` date NOT NULL,
  `Term_end_date` date NOT NULL,
  `AID` int(11) DEFAULT NULL,
  `Grade` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`CID`, `Year_start_date`, `Year_end_date`, `Term_start_date`, `Term_end_date`, `AID`, `Grade`) VALUES
(1, '0000-00-00', '0000-00-00', '0000-00-00', '0000-00-00', NULL, ''),
(2, '0000-00-00', '0000-00-00', '0000-00-00', '0000-00-00', NULL, ''),
(3, '0000-00-00', '0000-00-00', '0000-00-00', '0000-00-00', NULL, ''),
(4, '2024-03-18', '2024-03-28', '2024-03-28', '2024-07-06', NULL, '');

-- --------------------------------------------------------

--
-- Table structure for table `non-academic_staff`
--

CREATE TABLE `non-academic_staff` (
  `NAID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `DOB` date NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Mobile_no` int(10) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `NIC` int(11) NOT NULL,
  `Religion` varchar(20) NOT NULL,
  `Admission_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `non-academic_staff`
--

INSERT INTO `non-academic_staff` (`NAID`, `Name`, `DOB`, `Gender`, `Address`, `Password`, `Mobile_no`, `Username`, `NIC`, `Religion`, `Admission_date`) VALUES
(2002, '', '2024-03-24', '', '', 'n', 0, 'n', 0, '', '2024-03-24');

-- --------------------------------------------------------

--
-- Table structure for table `parant`
--

CREATE TABLE `parant` (
  `PID` int(11) NOT NULL,
  `NIC` int(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `relationship` varchar(10) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Mobile_no` int(10) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `SID` int(11) DEFAULT NULL,
  `Occupation` varchar(100) NOT NULL,
  `DOB` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Religion` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `parant`
--

INSERT INTO `parant` (`PID`, `NIC`, `Address`, `password`, `relationship`, `Name`, `Mobile_no`, `Username`, `SID`, `Occupation`, `DOB`, `Gender`, `Religion`) VALUES
(1, 0, 'cdcd', '', 'ff', 'kkk', 101, '', 127, 'ddd', '2024-03-24', 'female', 'cc');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `SID` int(11) NOT NULL,
  `Mobile_No` int(10) NOT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `Username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `Father_name` varchar(100) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `TID` int(11) DEFAULT NULL,
  `Admission_number` int(11) DEFAULT NULL,
  `Religion` varchar(10) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Mother_name` varchar(100) DEFAULT NULL,
  `Grade` varchar(11) DEFAULT NULL,
  `Class` varchar(1) DEFAULT NULL,
  `image_data` blob DEFAULT NULL,
  `Admission_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`SID`, `Mobile_No`, `gender`, `Username`, `password`, `Father_name`, `DOB`, `Name`, `TID`, `Admission_number`, `Religion`, `Address`, `Mother_name`, `Grade`, `Class`, `image_data`, `Admission_date`) VALUES
(123, 0, '', 'student', 'student', 'mmmm', '2024-03-06', 'dddd', NULL, 456, 'gg', 'fff', 'ff', '', '', NULL, '0000-00-00'),
(127, 0, 'male', 's1', 's1', 'vvv', '2024-03-23', 'lakshan', NULL, 1, 'hhhh', 'ddd', 'bbb', 'Grade 1', 'C', NULL, '2024-03-23'),
(128, 0, 'female', 's2', 's2', 'vvv', '2024-03-23', 'sithara', NULL, 1, 'hhhh', 'ddd', 'bbb', 'Grade 2', 'C', NULL, '2024-03-23');

-- --------------------------------------------------------

--
-- Table structure for table `student_class`
--

CREATE TABLE `student_class` (
  `SID` int(11) NOT NULL,
  `CID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `SuID` int(11) NOT NULL,
  `Subject_Name` varchar(50) NOT NULL,
  `Marks` int(10) NOT NULL,
  `CID` int(11) DEFAULT NULL,
  `AID` int(11) DEFAULT NULL,
  `TID` int(11) DEFAULT NULL,
  `SID` int(11) DEFAULT NULL,
  `Term` varchar(20) NOT NULL,
  `Year` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`SuID`, `Subject_Name`, `Marks`, `CID`, `AID`, `TID`, `SID`, `Term`, `Year`) VALUES
(1, 'su', 20, NULL, NULL, NULL, 127, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `time_table`
--

CREATE TABLE `time_table` (
  `TID` int(11) NOT NULL,
  `Time` time(6) NOT NULL,
  `Subject` varchar(20) NOT NULL,
  `Date` varchar(20) NOT NULL,
  `Day` varchar(20) NOT NULL,
  `Grade` varchar(20) NOT NULL,
  `Class` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `time_table`
--

INSERT INTO `time_table` (`TID`, `Time`, `Subject`, `Date`, `Day`, `Grade`, `Class`) VALUES
(3, '01:58:25.000000', 'sinhala', '', 'Monday', 'Grade 1', 'A'),
(4, '02:20:03.000000', 'english', '', 'Tuesday', 'Grade 2', 'B');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `academic`
--
ALTER TABLE `academic`
  ADD PRIMARY KEY (`AID`),
  ADD KEY `fk_academic_tid` (`TID`);

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`CID`),
  ADD KEY `fk_class_aid` (`AID`);

--
-- Indexes for table `non-academic_staff`
--
ALTER TABLE `non-academic_staff`
  ADD PRIMARY KEY (`NAID`);

--
-- Indexes for table `parant`
--
ALTER TABLE `parant`
  ADD PRIMARY KEY (`PID`),
  ADD KEY `fk_parant_sid` (`SID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`SID`),
  ADD KEY `fk_student_tid` (`TID`);

--
-- Indexes for table `student_class`
--
ALTER TABLE `student_class`
  ADD KEY `SID` (`SID`),
  ADD KEY `CID` (`CID`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`SuID`),
  ADD KEY `fk_subject_cid` (`CID`),
  ADD KEY `fk_subject_aid` (`AID`),
  ADD KEY `fk_subject_tid` (`TID`),
  ADD KEY `fk_subject_sid` (`SID`);

--
-- Indexes for table `time_table`
--
ALTER TABLE `time_table`
  ADD PRIMARY KEY (`TID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `class`
--
ALTER TABLE `class`
  MODIFY `CID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `SID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=129;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `SuID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `time_table`
--
ALTER TABLE `time_table`
  MODIFY `TID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `academic`
--
ALTER TABLE `academic`
  ADD CONSTRAINT `fk_academic_tid` FOREIGN KEY (`TID`) REFERENCES `time_table` (`TID`);

--
-- Constraints for table `class`
--
ALTER TABLE `class`
  ADD CONSTRAINT `fk_class_aid` FOREIGN KEY (`AID`) REFERENCES `academic` (`AID`);

--
-- Constraints for table `parant`
--
ALTER TABLE `parant`
  ADD CONSTRAINT `fk_parant_sid` FOREIGN KEY (`SID`) REFERENCES `student` (`SID`);

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `fk_student_tid` FOREIGN KEY (`TID`) REFERENCES `time_table` (`TID`);

--
-- Constraints for table `student_class`
--
ALTER TABLE `student_class`
  ADD CONSTRAINT `CID` FOREIGN KEY (`CID`) REFERENCES `class` (`CID`),
  ADD CONSTRAINT `SID` FOREIGN KEY (`SID`) REFERENCES `student` (`SID`);

--
-- Constraints for table `subject`
--
ALTER TABLE `subject`
  ADD CONSTRAINT `fk_subject_aid` FOREIGN KEY (`AID`) REFERENCES `academic` (`AID`),
  ADD CONSTRAINT `fk_subject_cid` FOREIGN KEY (`CID`) REFERENCES `class` (`CID`),
  ADD CONSTRAINT `fk_subject_sid` FOREIGN KEY (`SID`) REFERENCES `student` (`SID`),
  ADD CONSTRAINT `fk_subject_tid` FOREIGN KEY (`TID`) REFERENCES `time_table` (`TID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
