CREATE DATABASE  IF NOT EXISTS `productendb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `productendb`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: productendb
-- ------------------------------------------------------
-- Server version	5.6.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `klanten`
--

DROP TABLE IF EXISTS `klanten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klanten` (
  `klantID` int(11) NOT NULL AUTO_INCREMENT,
  `klantNaam` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`klantID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klanten`
--

LOCK TABLES `klanten` WRITE;
/*!40000 ALTER TABLE `klanten` DISABLE KEYS */;
INSERT INTO `klanten` VALUES (1,'AZ Sint Blasius Dendermonde'),(2,'Apotheek De Rijbel Aalst'),(3,'Colruyt NV Halle'),(4,'Departement Welzijn, Gezondheid en Gezin - Vlaamse Gemeenschap'),(5,'Rode Kruis afdeling Oost-Vlaanderen');
/*!40000 ALTER TABLE `klanten` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `orderID` int(11) NOT NULL AUTO_INCREMENT,
  `bestelDatum` date NOT NULL,
  `klantID` int(11) DEFAULT NULL,
  `productID` int(11) DEFAULT NULL,
  `bestelHoeveelheid` int(11) DEFAULT NULL,
  `afgehandeld` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`orderID`),
  KEY `productID` (`productID`),
  KEY `klantID` (`klantID`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `producten` (`productID`),
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`klantID`) REFERENCES `klanten` (`klantID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2020-03-15',3,7,10,0),(2,'2020-03-17',2,2,5,0),(3,'2020-03-17',1,3,15,0),(4,'2020-03-17',4,6,10,0),(5,'2020-04-02',5,4,100,0),(6,'2020-04-02',1,1,20,0),(7,'2020-04-02',4,5,2,0),(8,'2020-04-02',3,8,10,0),(9,'2020-04-02',1,5,5,0),(10,'2020-04-02',3,3,10,0);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producten`
--

DROP TABLE IF EXISTS `producten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producten` (
  `productID` int(11) NOT NULL AUTO_INCREMENT,
  `productNaam` varchar(255) DEFAULT NULL,
  `productStock` int(11) DEFAULT NULL,
  PRIMARY KEY (`productID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producten`
--

LOCK TABLES `producten` WRITE;
/*!40000 ALTER TABLE `producten` DISABLE KEYS */;
INSERT INTO `producten` VALUES (1,'3 laags chirurgisch wegwerp mondmaskers medium 25st/doos',500),(2,'3 laags chirurgisch wegwerp mondmaskers large 25 st/doos',500),(3,'FFP2 mondmaskers large 25 st/doos',30),(4,'FFP3 mondmaskers medium 2 st/verpakking',1000),(5,'Thermoscan 6000 Pro thermometer',20),(6,'Alcogel 70% + citrus bag-N-box 1000 ml',200),(7,'Nitrilhandschoenen blauw medium 100 st/doos',50),(8,'Nitrilhandschoenen blauw large 100 st/doos',40);
/*!40000 ALTER TABLE `producten` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-21  9:01:47
