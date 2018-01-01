-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 14, 2017 at 04:47 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `general_hospital`
--

-- --------------------------------------------------------

--
-- Table structure for table `counterdrugbill`
--

CREATE TABLE `counterdrugbill` (
  `ID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `DrugID` int(11) NOT NULL,
  `DrugName` varchar(20) NOT NULL,
  `Price` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Totals` int(11) NOT NULL,
  `EDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `counterdrugbill`
--

INSERT INTO `counterdrugbill` (`ID`, `SaleID`, `DrugID`, `DrugName`, `Price`, `Quantity`, `Totals`, `EDate`) VALUES
(1, 0, 1001, 'malaria tab', 100, 20, 2000, '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `counterdrugtotals`
--

CREATE TABLE `counterdrugtotals` (
  `ID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `Totals` int(11) NOT NULL,
  `Paid` int(11) NOT NULL,
  `Balance` int(11) NOT NULL,
  `Edate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis`
--

CREATE TABLE `diagnosis` (
  `Id` int(11) NOT NULL,
  `Code` int(50) NOT NULL,
  `DiagName` varchar(500) NOT NULL,
  `Sub_diag` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `drugentry`
--

CREATE TABLE `drugentry` (
  `DrugCode` int(11) NOT NULL,
  `Batch` varchar(50) NOT NULL,
  `Drug_Name` varchar(100) NOT NULL,
  `Strength` varchar(50) NOT NULL,
  `Form` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `discount` int(11) NOT NULL,
  `Buying_Price` int(11) NOT NULL,
  `Selling_Price` int(11) NOT NULL,
  `Expiry_Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `drugentry`
--

INSERT INTO `drugentry` (`DrugCode`, `Batch`, `Drug_Name`, `Strength`, `Form`, `Quantity`, `discount`, `Buying_Price`, `Selling_Price`, `Expiry_Date`) VALUES
(1001, '1234567', 'malaria tab', '500mg', 'Tablets', 45, 0, 50, 100, '11/04/2017');

-- --------------------------------------------------------

--
-- Table structure for table `fplanning`
--

CREATE TABLE `fplanning` (
  `ID` int(11) NOT NULL,
  `PatientNo` int(11) NOT NULL,
  `Patient_Name` varchar(100) NOT NULL,
  `Age` varchar(50) NOT NULL,
  `Method` varchar(100) NOT NULL,
  `Period` varchar(50) NOT NULL,
  `Tel` varchar(50) NOT NULL,
  `Weight` varchar(50) NOT NULL,
  `Bp` int(50) NOT NULL,
  `Price` int(11) NOT NULL,
  `Entry_Date` datetime NOT NULL,
  `Status` varchar(10) NOT NULL,
  `Remarks` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `immunization`
--

CREATE TABLE `immunization` (
  `ID` int(11) NOT NULL,
  `PatientNo` int(11) NOT NULL,
  `Patient_Name` varchar(1000) NOT NULL,
  `Age` varchar(500) NOT NULL,
  `ParentName` varchar(20) NOT NULL,
  `Parent_Tel` varchar(20) NOT NULL,
  `Weight` varchar(15) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  `Charges` int(11) NOT NULL,
  `Remarks` varchar(1000) NOT NULL,
  `Entry_Date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `imm_vaccine`
--

CREATE TABLE `imm_vaccine` (
  `ID` int(11) NOT NULL,
  `PatientNo` varchar(50) NOT NULL,
  `PatientName` varchar(100) NOT NULL,
  `Age` int(11) NOT NULL,
  `Telephone` varchar(35) NOT NULL,
  `Vaccine_Name` varchar(50) NOT NULL,
  `Entry_Date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `labtest`
--

CREATE TABLE `labtest` (
  `ID` int(11) NOT NULL,
  `TestName` varchar(50) NOT NULL,
  `Duration` int(11) NOT NULL,
  `Charges` int(11) NOT NULL,
  `Edate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `labtest`
--

INSERT INTO `labtest` (`ID`, `TestName`, `Duration`, `Charges`, `Edate`) VALUES
(1, 'Bs/Mps', 10, 200, '11/04/2017 '),
(2, 'Widal', 20, 500, '11/04/2017 '),
(3, 'Stool', 10, 200, '11/04/2017 ');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `Aid` int(11) NOT NULL,
  `UserName` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `Role` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Aid`, `UserName`, `password`, `Role`) VALUES
(1, 'Benson', '2016', 'Administrator'),
(2, 'Jane', '1000', 'Receptionist'),
(3, 'guest', '0000', 'Lab_Tec');

-- --------------------------------------------------------

--
-- Table structure for table `other_procedures`
--

CREATE TABLE `other_procedures` (
  `ID` int(11) NOT NULL,
  `PatientNo` varchar(50) NOT NULL,
  `PatientName` varchar(100) NOT NULL,
  `Age` varchar(20) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Tel` varchar(20) NOT NULL,
  `Procedure_Name` varchar(50) NOT NULL,
  `Reason` varchar(200) NOT NULL,
  `Charges` int(11) NOT NULL,
  `Entry_Date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `outpatbill`
--

CREATE TABLE `outpatbill` (
  `BillID` int(11) NOT NULL,
  `PatientNO` varchar(1000) NOT NULL,
  `Patient_Name` varchar(1000) NOT NULL,
  `LabCost` varchar(100) NOT NULL,
  `DrugCost` varchar(100) NOT NULL,
  `ConsultFee` varchar(100) NOT NULL,
  `Totals` int(100) NOT NULL,
  `Paid` int(100) NOT NULL DEFAULT '0',
  `balance` int(100) NOT NULL,
  `BillDate` date NOT NULL,
  `Status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `outpatdrugbill`
--

CREATE TABLE `outpatdrugbill` (
  `ID` int(11) NOT NULL,
  `PatientNo` varchar(50) NOT NULL,
  `PatientName` varchar(100) NOT NULL,
  `Edate` date NOT NULL,
  `Drug_Name` varchar(1000) NOT NULL,
  `Price` varchar(1000) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Totals` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `outpatdrugtotal`
--

CREATE TABLE `outpatdrugtotal` (
  `ID` int(11) NOT NULL,
  `PatientNo` int(50) NOT NULL,
  `PatientName` varchar(50) NOT NULL,
  `Totals` int(11) NOT NULL,
  `Edate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatdrugtotal`
--

INSERT INTO `outpatdrugtotal` (`ID`, `PatientNo`, `PatientName`, `Totals`, `Edate`) VALUES
(5, 1001, 'BENSON MAWIRA MATHINJA', 100, '2017-11-09'),
(6, 1001, 'BENSON MAWIRA MATHINJA', 100, '2017-11-12'),
(7, 1001, 'BENSON MAWIRA MATHINJA', 100, '2017-11-14');

-- --------------------------------------------------------

--
-- Table structure for table `outpatfinaldrugbill`
--

CREATE TABLE `outpatfinaldrugbill` (
  `ID` int(11) NOT NULL,
  `PatientNo` int(11) NOT NULL,
  `PatientName` varchar(50) NOT NULL,
  `Batch` varchar(50) NOT NULL,
  `MedName` varchar(50) NOT NULL,
  `Strength` varchar(50) NOT NULL,
  `Dose` varchar(50) NOT NULL,
  `Quantity` varchar(20) NOT NULL,
  `Cost` int(11) NOT NULL,
  `Entry_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatfinaldrugbill`
--

INSERT INTO `outpatfinaldrugbill` (`ID`, `PatientNo`, `PatientName`, `Batch`, `MedName`, `Strength`, `Dose`, `Quantity`, `Cost`, `Entry_Date`) VALUES
(5, 1001, 'BENSON MAWIRA MATHINJA', '1234567', 'malaria tab', '500mg', 'Q5 X 5', '1', 100, '2017-11-09'),
(6, 1001, 'BENSON MAWIRA MATHINJA', '1234567', 'malaria tab', '500mg', 'BD X 2', '1', 100, '2017-11-12'),
(7, 1001, 'BENSON MAWIRA MATHINJA', '1234567', 'malaria tab', '500mg', 'Q5 X 5', '1', 100, '2017-11-14');

-- --------------------------------------------------------

--
-- Table structure for table `outpatientlabrequest`
--

CREATE TABLE `outpatientlabrequest` (
  `LabNo` int(11) NOT NULL,
  `PatientNO` varchar(200) NOT NULL,
  `Patient_Name` varchar(500) NOT NULL,
  `TestNO` int(11) NOT NULL,
  `TestName` varchar(50) NOT NULL,
  `Charges` int(200) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Edate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatientlabrequest`
--

INSERT INTO `outpatientlabrequest` (`LabNo`, `PatientNO`, `Patient_Name`, `TestNO`, `TestName`, `Charges`, `Status`, `Edate`) VALUES
(5, '1001', 'BENSON MAWIRA MATHINJA', 1, 'Bs/Mps', 200, 'NP', '2017-11-09');

-- --------------------------------------------------------

--
-- Table structure for table `outpatientlabresult`
--

CREATE TABLE `outpatientlabresult` (
  `LabNo` int(11) NOT NULL,
  `PatientNO` varchar(200) NOT NULL,
  `Patient_Name` varchar(500) NOT NULL,
  `Lab_Results` varchar(1500) NOT NULL,
  `Diagnosis` varchar(200) NOT NULL,
  `Edate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatientlabresult`
--

INSERT INTO `outpatientlabresult` (`LabNo`, `PatientNO`, `Patient_Name`, `Lab_Results`, `Diagnosis`, `Edate`) VALUES
(3, '1001', 'BENSON MAWIRA MATHINJA', 'Bs/Mps ++', '', '2017-11-09');

-- --------------------------------------------------------

--
-- Table structure for table `outpatientvitals`
--

CREATE TABLE `outpatientvitals` (
  `No` int(11) NOT NULL,
  `PatientNo` varchar(100) NOT NULL,
  `PatientName` varchar(100) NOT NULL,
  `Temp` varchar(50) NOT NULL,
  `BP` varchar(50) NOT NULL,
  `RR` varchar(50) NOT NULL,
  `PR` varchar(50) NOT NULL,
  `Weight` varchar(50) NOT NULL,
  `Edate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatientvitals`
--

INSERT INTO `outpatientvitals` (`No`, `PatientNo`, `PatientName`, `Temp`, `BP`, `RR`, `PR`, `Weight`, `Edate`) VALUES
(3, '1001', 'BENSON MAWIRA MATHINJA', '36.5', '120/80', '72', '73', '69', '2017-11-09');

-- --------------------------------------------------------

--
-- Table structure for table `outpatpayments`
--

CREATE TABLE `outpatpayments` (
  `PID` int(11) NOT NULL,
  `RecNo` int(11) NOT NULL,
  `PatientNO` varchar(50) NOT NULL,
  `Patient_Name` varchar(50) NOT NULL,
  `drug` int(11) NOT NULL,
  `Consult_Fee` int(11) NOT NULL,
  `FP` int(11) NOT NULL,
  `Lab` int(11) NOT NULL,
  `MCH` int(11) NOT NULL,
  `Others` int(11) NOT NULL,
  `TotalBill` int(11) NOT NULL,
  `Paid` int(11) NOT NULL,
  `Balance` int(11) NOT NULL,
  `PaymentDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatpayments`
--

INSERT INTO `outpatpayments` (`PID`, `RecNo`, `PatientNO`, `Patient_Name`, `drug`, `Consult_Fee`, `FP`, `Lab`, `MCH`, `Others`, `TotalBill`, `Paid`, `Balance`, `PaymentDate`) VALUES
(17, 1001, '1001', 'BENSON MAWIRA MATHINJA', 200, 100, 0, 0, 0, 0, 300, 200, 100, '2017-11-14'),
(18, 1002, '1001', 'BENSON MAWIRA MATHINJA', 200, 100, 0, 0, 0, 0, 300, 300, 0, '2017-11-14');

-- --------------------------------------------------------

--
-- Table structure for table `outpatpresciption`
--

CREATE TABLE `outpatpresciption` (
  `ID` int(11) NOT NULL,
  `PatientNo` varchar(50) NOT NULL,
  `PatientName` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Batch` varchar(50) NOT NULL,
  `Medicine` varchar(50) NOT NULL,
  `Strength` varchar(50) NOT NULL,
  `Dose` varchar(50) NOT NULL,
  `Duration` varchar(20) NOT NULL,
  `status` varchar(20) NOT NULL,
  `EDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatpresciption`
--

INSERT INTO `outpatpresciption` (`ID`, `PatientNo`, `PatientName`, `Gender`, `Batch`, `Medicine`, `Strength`, `Dose`, `Duration`, `status`, `EDate`) VALUES
(4, '1001', 'BENSON MAWIRA MATHINJA', 'Male', '1234567', 'malaria tab', '500mg', 'Q5 X 5', '5', 'NF', '2017-11-08'),
(6, '1001', 'BENSON MAWIRA MATHINJA', 'Male', '1234567', 'malaria tab', '500mg', 'Q5 X 5', '5', 'NF', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `outpatregistration`
--

CREATE TABLE `outpatregistration` (
  `PatientNO` int(11) NOT NULL,
  `PName` varchar(50) NOT NULL,
  `Age` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Location` varchar(50) NOT NULL,
  `Tel` varchar(50) NOT NULL,
  `Pay_Mode` varchar(50) NOT NULL,
  `Charges` int(11) NOT NULL,
  `Entry_Date` date NOT NULL,
  `Status` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatregistration`
--

INSERT INTO `outpatregistration` (`PatientNO`, `PName`, `Age`, `Gender`, `Location`, `Tel`, `Pay_Mode`, `Charges`, `Entry_Date`, `Status`) VALUES
(1001, 'BENSON MAWIRA MATHINJA', '25', 'Male', 'Makongeni', '0715205238', 'Cash', 200, '2017-11-09', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `outpattreatment`
--

CREATE TABLE `outpattreatment` (
  `T_ID` int(11) NOT NULL,
  `PatientNO` varchar(50) NOT NULL,
  `Patient_Name` varchar(50) NOT NULL,
  `Age` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Tel` varchar(50) NOT NULL,
  `Complains` varchar(255) NOT NULL,
  `History` varchar(255) NOT NULL,
  `Examination` varchar(255) NOT NULL,
  `Diagnosis` varchar(255) NOT NULL,
  `LabInvestigation` varchar(255) NOT NULL,
  `NextReview` varchar(50) NOT NULL,
  `Entry_Date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpattreatment`
--

INSERT INTO `outpattreatment` (`T_ID`, `PatientNO`, `Patient_Name`, `Age`, `Gender`, `Tel`, `Complains`, `History`, `Examination`, `Diagnosis`, `LabInvestigation`, `NextReview`, `Entry_Date`) VALUES
(4, '1001', 'BENSON MAWIRA MATHINJA', '25', 'Male', '0715205238', 'FCG', 'GE', '', 'Malaria', 'Bs/Mps ++', '11/09/2017', '2017-11-09'),
(5, '1001', 'BENSON MAWIRA MATHINJA', '25', 'Male', '0715205238', 'jhkijljl', 'ljok', '', 'kjjjj', 'iljljjj', '11/14/2017', '2017-11-14');

-- --------------------------------------------------------

--
-- Table structure for table `outsidepresc`
--

CREATE TABLE `outsidepresc` (
  `PID` int(11) NOT NULL,
  `PatientNo` varchar(11) NOT NULL,
  `PatientName` varchar(50) NOT NULL,
  `MedName` varchar(255) NOT NULL,
  `Entry_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `proce_entry`
--

CREATE TABLE `proce_entry` (
  `PID` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Cost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sick_off`
--

CREATE TABLE `sick_off` (
  `PatientNO` int(11) NOT NULL,
  `PName` varchar(50) NOT NULL,
  `Age` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Location` varchar(50) NOT NULL,
  `Tel` varchar(11) NOT NULL,
  `Compains` varchar(500) NOT NULL,
  `History` varchar(500) NOT NULL,
  `Examination` varchar(500) NOT NULL,
  `impression` varchar(500) NOT NULL,
  `LabInvestigation` varchar(500) NOT NULL,
  `Charges` int(11) NOT NULL,
  `NextReview` varchar(11) NOT NULL,
  `Entry_Date` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `vendor`
--

CREATE TABLE `vendor` (
  `VendorNO` int(11) NOT NULL,
  `VendorName` varchar(100) NOT NULL,
  `Company` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Telephone` varchar(20) NOT NULL,
  `City` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `EntryDate` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `counterdrugbill`
--
ALTER TABLE `counterdrugbill`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `counterdrugtotals`
--
ALTER TABLE `counterdrugtotals`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `diagnosis`
--
ALTER TABLE `diagnosis`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `fplanning`
--
ALTER TABLE `fplanning`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `immunization`
--
ALTER TABLE `immunization`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `imm_vaccine`
--
ALTER TABLE `imm_vaccine`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `labtest`
--
ALTER TABLE `labtest`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`Aid`);

--
-- Indexes for table `other_procedures`
--
ALTER TABLE `other_procedures`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `outpatbill`
--
ALTER TABLE `outpatbill`
  ADD PRIMARY KEY (`BillID`);

--
-- Indexes for table `outpatdrugbill`
--
ALTER TABLE `outpatdrugbill`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `outpatdrugtotal`
--
ALTER TABLE `outpatdrugtotal`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `outpatfinaldrugbill`
--
ALTER TABLE `outpatfinaldrugbill`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `outpatientlabrequest`
--
ALTER TABLE `outpatientlabrequest`
  ADD PRIMARY KEY (`LabNo`);

--
-- Indexes for table `outpatientlabresult`
--
ALTER TABLE `outpatientlabresult`
  ADD PRIMARY KEY (`LabNo`);

--
-- Indexes for table `outpatientvitals`
--
ALTER TABLE `outpatientvitals`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `outpatpayments`
--
ALTER TABLE `outpatpayments`
  ADD PRIMARY KEY (`PID`);

--
-- Indexes for table `outpatpresciption`
--
ALTER TABLE `outpatpresciption`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `outpatregistration`
--
ALTER TABLE `outpatregistration`
  ADD PRIMARY KEY (`PatientNO`);

--
-- Indexes for table `outpattreatment`
--
ALTER TABLE `outpattreatment`
  ADD PRIMARY KEY (`T_ID`);

--
-- Indexes for table `outsidepresc`
--
ALTER TABLE `outsidepresc`
  ADD PRIMARY KEY (`PID`);

--
-- Indexes for table `vendor`
--
ALTER TABLE `vendor`
  ADD PRIMARY KEY (`VendorNO`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `counterdrugbill`
--
ALTER TABLE `counterdrugbill`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `counterdrugtotals`
--
ALTER TABLE `counterdrugtotals`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `diagnosis`
--
ALTER TABLE `diagnosis`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `fplanning`
--
ALTER TABLE `fplanning`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `immunization`
--
ALTER TABLE `immunization`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `imm_vaccine`
--
ALTER TABLE `imm_vaccine`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `labtest`
--
ALTER TABLE `labtest`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `Aid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `other_procedures`
--
ALTER TABLE `other_procedures`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `outpatbill`
--
ALTER TABLE `outpatbill`
  MODIFY `BillID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `outpatdrugbill`
--
ALTER TABLE `outpatdrugbill`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `outpatdrugtotal`
--
ALTER TABLE `outpatdrugtotal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `outpatfinaldrugbill`
--
ALTER TABLE `outpatfinaldrugbill`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `outpatientlabrequest`
--
ALTER TABLE `outpatientlabrequest`
  MODIFY `LabNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `outpatientlabresult`
--
ALTER TABLE `outpatientlabresult`
  MODIFY `LabNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `outpatientvitals`
--
ALTER TABLE `outpatientvitals`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `outpatpayments`
--
ALTER TABLE `outpatpayments`
  MODIFY `PID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `outpatpresciption`
--
ALTER TABLE `outpatpresciption`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `outpattreatment`
--
ALTER TABLE `outpattreatment`
  MODIFY `T_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `outsidepresc`
--
ALTER TABLE `outsidepresc`
  MODIFY `PID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `vendor`
--
ALTER TABLE `vendor`
  MODIFY `VendorNO` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
