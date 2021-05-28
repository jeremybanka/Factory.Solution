-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: factory
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20210528165914_Initial','5.0.0'),('20210528215432_LicenseIdIsString','5.0.0');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Engineers`
--

DROP TABLE IF EXISTS `Engineers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Engineers` (
  `EngineerId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`EngineerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Engineers`
--

LOCK TABLES `Engineers` WRITE;
/*!40000 ALTER TABLE `Engineers` DISABLE KEYS */;
INSERT INTO `Engineers` VALUES ('1a8b8a71-2cfc-4d7c-b619-de96dbd262a9','DONKLETON'),('708055c6-7afa-480e-9cde-537f986bc75b','DElfador');
/*!40000 ALTER TABLE `Engineers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Licenses`
--

DROP TABLE IF EXISTS `Licenses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Licenses` (
  `LicenseId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `EngineerId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `MachineId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`LicenseId`),
  KEY `IX_Licenses_EngineerId` (`EngineerId`),
  KEY `IX_Licenses_MachineId` (`MachineId`),
  CONSTRAINT `FK_Licenses_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Licenses_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Licenses`
--

LOCK TABLES `Licenses` WRITE;
/*!40000 ALTER TABLE `Licenses` DISABLE KEYS */;
INSERT INTO `Licenses` VALUES ('3f27c04e-1d7c-4540-ab51-2fc609a884d9','708055c6-7afa-480e-9cde-537f986bc75b','65d7de7a-68e4-4b03-9d4f-13224a7a4f86'),('ad63f99f-c740-470c-a345-eb3a52a7f9ee','708055c6-7afa-480e-9cde-537f986bc75b','0a43225d-2f93-486f-a180-dc4a85dd8458'),('f3ae6528-287e-4b54-9098-592ddf19d311','1a8b8a71-2cfc-4d7c-b619-de96dbd262a9','65d7de7a-68e4-4b03-9d4f-13224a7a4f86');
/*!40000 ALTER TABLE `Licenses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Machines`
--

DROP TABLE IF EXISTS `Machines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Machines` (
  `MachineId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`MachineId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Machines`
--

LOCK TABLES `Machines` WRITE;
/*!40000 ALTER TABLE `Machines` DISABLE KEYS */;
INSERT INTO `Machines` VALUES ('0a43225d-2f93-486f-a180-dc4a85dd8458','WHIZMAJIG'),('65d7de7a-68e4-4b03-9d4f-13224a7a4f86','FIZZMAJIG');
/*!40000 ALTER TABLE `Machines` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-28 15:50:14
