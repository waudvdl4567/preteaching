CREATE DATABASE  IF NOT EXISTS `itprodb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `itprodb`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: itprodb
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
-- Table structure for table `landen`
--

DROP TABLE IF EXISTS `landen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `landen` (
  `landID` int(11) NOT NULL AUTO_INCREMENT,
  `landNaam` varchar(255) NOT NULL,
  PRIMARY KEY (`landID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `landen`
--

LOCK TABLES `landen` WRITE;
/*!40000 ALTER TABLE `landen` DISABLE KEYS */;
INSERT INTO `landen` VALUES (1,'België'),(2,'Nederland'),(3,'Frankrijk'),(4,'Duitsland'),(5,'Luxemburg'),(6,'Spanje'),(7,'Italië'),(8,'Verenigd Koninkrijk');
/*!40000 ALTER TABLE `landen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personen`
--

DROP TABLE IF EXISTS `personen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personen` (
  `persoonID` int(11) NOT NULL AUTO_INCREMENT,
  `voornaam` varchar(255) NOT NULL,
  `naam` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `geboortedatum` date DEFAULT NULL,
  `straat` varchar(255) DEFAULT NULL,
  `huisnummer` varchar(10) DEFAULT NULL,
  `woonplaatsID` int(11) DEFAULT NULL,
  PRIMARY KEY (`persoonID`,`naam`),
  KEY `woonplaatsID` (`woonplaatsID`),
  CONSTRAINT `personen_ibfk_1` FOREIGN KEY (`woonplaatsID`) REFERENCES `woonplaatsen` (`woonplaatsID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personen`
--

LOCK TABLES `personen` WRITE;
/*!40000 ALTER TABLE `personen` DISABLE KEYS */;
INSERT INTO `personen` VALUES (1,'Jos','Doe','jos.doe@vlit.org','1990-09-01','Threadstraat','12',1),(2,'Jef','De Bok','jef.debok2@gymail.com','1980-04-01','Overflowdreef','220X4',4),(3,'Karel','Weetal','Karel.weetal@overal.be','1996-12-11','Exceptieplein','33',5),(4,'Griet','Doeal','grietd@vlit.org','1992-09-01','Interpretersteeg','33',1),(5,'Anke','Sekwel','ankesekwel67@gymail.com','1988-11-21','Bytecodedreef','30A2',1),(6,'Tess','allemaal-Niesimpel','tessacool@hier.be','2000-03-27','Crashstraat','34',1);
/*!40000 ALTER TABLE `personen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vaardigheden`
--

DROP TABLE IF EXISTS `vaardigheden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vaardigheden` (
  `vaardigheidID` int(11) NOT NULL AUTO_INCREMENT,
  `vaardigheidNaam` varchar(255) NOT NULL,
  PRIMARY KEY (`vaardigheidID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vaardigheden`
--

LOCK TABLES `vaardigheden` WRITE;
/*!40000 ALTER TABLE `vaardigheden` DISABLE KEYS */;
INSERT INTO `vaardigheden` VALUES (2,'organisatie'),(4,'innovatief'),(5,'coaching'),(6,'probleemoplossend denken'),(7,'MySQL'),(8,'Kotlin'),(9,'.NET'),(10,'microcontrollers'),(11,'PLC'),(12,'Python'),(13,'C++'),(14,'Java'),(18,'SAP'),(21,'ASP.NET'),(22,'Management'),(24,'Cisco CCNA'),(26,'adviseren');
/*!40000 ALTER TABLE `vaardigheden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vaardigheden_personen`
--

DROP TABLE IF EXISTS `vaardigheden_personen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vaardigheden_personen` (
  `persoon_vaardigheidID` int(11) NOT NULL AUTO_INCREMENT,
  `persoonID` int(11) NOT NULL,
  `vaardigheidID` int(11) NOT NULL,
  PRIMARY KEY (`persoon_vaardigheidID`),
  KEY `persoonID` (`persoonID`),
  KEY `vaardigheidID` (`vaardigheidID`),
  CONSTRAINT `vaardigheden_personen_ibfk_1` FOREIGN KEY (`persoonID`) REFERENCES `personen` (`persoonID`),
  CONSTRAINT `vaardigheden_personen_ibfk_2` FOREIGN KEY (`vaardigheidID`) REFERENCES `vaardigheden` (`vaardigheidID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vaardigheden_personen`
--

LOCK TABLES `vaardigheden_personen` WRITE;
/*!40000 ALTER TABLE `vaardigheden_personen` DISABLE KEYS */;
INSERT INTO `vaardigheden_personen` VALUES (2,1,5),(3,3,9),(4,2,6),(5,3,7),(6,1,4),(11,5,9),(12,6,12),(13,4,9),(15,4,5),(16,5,11),(17,5,11),(24,5,2);
/*!40000 ALTER TABLE `vaardigheden_personen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `woonplaatsen`
--

DROP TABLE IF EXISTS `woonplaatsen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `woonplaatsen` (
  `woonplaatsID` int(11) NOT NULL AUTO_INCREMENT,
  `landID` int(11) NOT NULL,
  `postnummer` varchar(255) NOT NULL,
  `stad` varchar(255) NOT NULL,
  PRIMARY KEY (`woonplaatsID`,`landID`,`postnummer`),
  KEY `landID` (`landID`),
  CONSTRAINT `woonplaatsen_ibfk_1` FOREIGN KEY (`landID`) REFERENCES `landen` (`landID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `woonplaatsen`
--

LOCK TABLES `woonplaatsen` WRITE;
/*!40000 ALTER TABLE `woonplaatsen` DISABLE KEYS */;
INSERT INTO `woonplaatsen` VALUES (1,1,'9160','Lokeren'),(2,2,'8011 PK','Zwolle'),(3,3,'97100','Basse-Terre'),(4,1,'9240','Zele'),(5,1,'9080','Beervelde');
/*!40000 ALTER TABLE `woonplaatsen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'itprodb'
--
/*!50003 DROP PROCEDURE IF EXISTS `GetPersonenMetVaardigheden` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPersonenMetVaardigheden`(in vaardigheid varchar(255))
begin
	select  vaardigheden_personen.persoon_vaardigheidID,
			vaardigheden.vaardigheidNaam, 
			personen.voornaam,
			personen.naam
	from    vaardigheden_personen
	inner join  personen     on (personen.persoonID=vaardigheden_personen.persoonID)
	inner join  vaardigheden on (vaardigheden.vaardigheidID = vaardigheden_personen.vaardigheidID)
    where vaardigheidNaam = vaardigheid;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetVaardigheden` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetVaardigheden`()
begin
	select  vaardigheden.vaardigheidNaam, 
			personen.voornaam,
			personen.naam
	from    vaardigheden_personen
	inner join  personen     on (personen.persoonID=vaardigheden_personen.persoonID)
	inner join  vaardigheden on (vaardigheden.vaardigheidID = vaardigheden_personen.vaardigheidID);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-26 16:25:32
