-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: setlist
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `albums`
--

DROP TABLE IF EXISTS `albums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `albums` (
  `idAlbum` int NOT NULL AUTO_INCREMENT,
  `AlbumName` varchar(45) NOT NULL,
  `YearAlbum` int NOT NULL,
  `Artist` int NOT NULL,
  PRIMARY KEY (`idAlbum`),
  UNIQUE KEY `NombreAlbum_UNIQUE` (`AlbumName`),
  KEY `FK_AL_AR_idx` (`Artist`),
  CONSTRAINT `FK_AL_AR` FOREIGN KEY (`Artist`) REFERENCES `artists` (`idArtist`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `albums`
--

LOCK TABLES `albums` WRITE;
/*!40000 ALTER TABLE `albums` DISABLE KEYS */;
INSERT INTO `albums` VALUES (1,'Night Visions',2012,10),(2,'Un Verano Sin Ti',2022,2),(3,'24K Magic',2016,4),(4,'Loba',2009,3),(5,'Master of Puppets',1986,7),(6,'Zapatillas',2005,8),(7,'Justice',2021,15),(8,'Mr. Bad Guy',1985,11),(9,'La Vida Mártir',2019,1),(10,'Remedies',2023,12),(11,'Endless Summer Vacation',2023,6),(12,'Prism',2013,9),(13,'A Las Cinco En El Astoria',2008,13),(14,'The Fame',2008,5),(15,'Take Me Home',2012,14),(16,'Persona',2019,16),(22,'Justice Light',2021,4),(23,'Remediese 54',2023,3);
/*!40000 ALTER TABLE `albums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `artists`
--

DROP TABLE IF EXISTS `artists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artists` (
  `idArtist` int NOT NULL AUTO_INCREMENT,
  `ArtistName` varchar(45) NOT NULL,
  `ArtistCountry` char(3) NOT NULL,
  PRIMARY KEY (`idArtist`),
  UNIQUE KEY `Nombre_UNIQUE` (`ArtistName`),
  KEY `FK_AR_PA_idx` (`ArtistCountry`),
  CONSTRAINT `FK_AR_PA` FOREIGN KEY (`ArtistCountry`) REFERENCES `country` (`idCountry`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artists`
--

LOCK TABLES `artists` WRITE;
/*!40000 ALTER TABLE `artists` DISABLE KEYS */;
INSERT INTO `artists` VALUES (1,'Omar Montes','SPA'),(2,'Bad Bunny','PRI'),(3,'Shakira','COL'),(4,'Bruno Mars','USA'),(5,'Lady Gaga','USA'),(6,'Miley Cirus','USA'),(7,'Metallica','USA'),(8,'El Canto del Loco','SPA'),(9,'Katy Perry','USA'),(10,'Imagine Dragons','USA'),(11,'Freddie Mercury','USA'),(12,'Toptiex','SPA'),(13,'La Oreja de Van Gogh','SPA'),(14,'One Direction','GBR'),(15,'Justin Bieber','USA'),(16,'Marracash','ITA');
/*!40000 ALTER TABLE `artists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concerts`
--

DROP TABLE IF EXISTS `concerts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `concerts` (
  `idConcert` int NOT NULL AUTO_INCREMENT,
  `Artist` int NOT NULL,
  `Venue` int NOT NULL,
  `ConcertDate` date NOT NULL,
  PRIMARY KEY (`idConcert`),
  KEY `FK_CO_AR_idx` (`Artist`),
  KEY `FK_CO_SI_idx` (`Venue`),
  CONSTRAINT `FK_CO_AR` FOREIGN KEY (`Artist`) REFERENCES `artists` (`idArtist`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_CO_SI` FOREIGN KEY (`Venue`) REFERENCES `venues` (`idVenue`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concerts`
--

LOCK TABLES `concerts` WRITE;
/*!40000 ALTER TABLE `concerts` DISABLE KEYS */;
INSERT INTO `concerts` VALUES (1,12,9,'2024-07-09'),(2,5,5,'2018-05-04'),(3,9,7,'2016-03-11'),(4,7,4,'1985-08-25'),(5,1,2,'2021-11-18'),(6,10,6,'2012-01-23'),(7,3,9,'2014-04-07'),(8,6,7,'2021-06-10'),(9,14,1,'2011-10-02'),(10,2,3,'2023-08-12'),(11,13,2,'2006-05-09'),(12,4,8,'2020-01-29'),(13,15,4,'2023-04-20'),(14,8,9,'2009-08-06'),(15,11,10,'1979-03-17'),(17,1,2,'2019-07-24'),(18,16,11,'2023-04-30');
/*!40000 ALTER TABLE `concerts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `copyalb`
--

DROP TABLE IF EXISTS `copyalb`;
/*!50001 DROP VIEW IF EXISTS `copyalb`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copyalb` AS SELECT 
 1 AS `idAlbum`,
 1 AS `AlbumName`,
 1 AS `YearAlbum`,
 1 AS `Artist`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `copyart`
--

DROP TABLE IF EXISTS `copyart`;
/*!50001 DROP VIEW IF EXISTS `copyart`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copyart` AS SELECT 
 1 AS `idArtist`,
 1 AS `ArtistName`,
 1 AS `ArtistCountry`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `copyconc`
--

DROP TABLE IF EXISTS `copyconc`;
/*!50001 DROP VIEW IF EXISTS `copyconc`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copyconc` AS SELECT 
 1 AS `idConcert`,
 1 AS `Artist`,
 1 AS `Venue`,
 1 AS `ConcertDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `copycountr`
--

DROP TABLE IF EXISTS `copycountr`;
/*!50001 DROP VIEW IF EXISTS `copycountr`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copycountr` AS SELECT 
 1 AS `idCountry`,
 1 AS `CountryName`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `copysetl`
--

DROP TABLE IF EXISTS `copysetl`;
/*!50001 DROP VIEW IF EXISTS `copysetl`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copysetl` AS SELECT 
 1 AS `Concert`,
 1 AS `Song`,
 1 AS `OrderInSetlist`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `copysong`
--

DROP TABLE IF EXISTS `copysong`;
/*!50001 DROP VIEW IF EXISTS `copysong`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copysong` AS SELECT 
 1 AS `idSong`,
 1 AS `SongName`,
 1 AS `SongLength`,
 1 AS `Album`,
 1 AS `SongOrder`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `copyven`
--

DROP TABLE IF EXISTS `copyven`;
/*!50001 DROP VIEW IF EXISTS `copyven`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `copyven` AS SELECT 
 1 AS `idVenue`,
 1 AS `VenueName`,
 1 AS `VenueCountry`,
 1 AS `VenueType`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `country` (
  `idCountry` char(3) NOT NULL,
  `CountryName` varchar(45) NOT NULL,
  PRIMARY KEY (`idCountry`),
  UNIQUE KEY `NombrePais_UNIQUE` (`CountryName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES ('ARG','Argentina'),('AUS','Australia'),('CAN','Canada'),('COL','Colombia'),('FRA','France'),('GER','Germany'),('GRE','Greece'),('ITA','Italy'),('JAP','Japan'),('MEX','Mexico'),('POR','Portugal'),('PRI','Puerto Rico'),('SPA','Spain'),('GBR','United Kingdom'),('USA','United States of America'),('URU','Uruguay');
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `setlists`
--

DROP TABLE IF EXISTS `setlists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `setlists` (
  `Concert` int NOT NULL,
  `Song` int NOT NULL,
  `OrderInSetlist` int NOT NULL,
  PRIMARY KEY (`Concert`,`Song`),
  KEY `FK_SE_CO_idx` (`Concert`),
  KEY `FK_SE_CA_idx` (`Song`),
  CONSTRAINT `FK_SE_CA` FOREIGN KEY (`Song`) REFERENCES `songs` (`idSong`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_SE_CO` FOREIGN KEY (`Concert`) REFERENCES `concerts` (`idConcert`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `setlists`
--

LOCK TABLES `setlists` WRITE;
/*!40000 ALTER TABLE `setlists` DISABLE KEYS */;
INSERT INTO `setlists` VALUES (1,13,3),(2,15,1),(3,12,4),(4,5,7),(5,8,8),(6,1,1),(7,9,1),(8,11,2),(9,10,3),(10,3,1),(11,7,8),(12,4,1),(13,14,4),(14,2,7),(15,6,9),(18,17,1),(18,18,2),(18,19,3);
/*!40000 ALTER TABLE `setlists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `songs`
--

DROP TABLE IF EXISTS `songs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `songs` (
  `idSong` int NOT NULL AUTO_INCREMENT,
  `SongName` varchar(45) NOT NULL,
  `SongLength` int NOT NULL,
  `Album` int NOT NULL,
  `SongOrder` int NOT NULL,
  PRIMARY KEY (`idSong`),
  UNIQUE KEY `NombreCancion_UNIQUE` (`SongName`),
  KEY `FK_CA_AL_idx` (`Album`),
  CONSTRAINT `FK_CA_AL` FOREIGN KEY (`Album`) REFERENCES `albums` (`idAlbum`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `songs`
--

LOCK TABLES `songs` WRITE;
/*!40000 ALTER TABLE `songs` DISABLE KEYS */;
INSERT INTO `songs` VALUES (1,'Bleeding Out',3,1,4),(2,'Zapatillas',2,6,5),(3,'Tití Me Preguntó',4,2,8),(4,'24K Magic',3,3,2),(5,'Master Of Puppets',8,5,1),(6,'Mr. Bad Guy',4,8,6),(7,'Jueves',4,13,9),(8,'Animales',3,9,7),(9,'Loba',3,4,8),(10,'Live While We\'re Young',3,15,6),(11,'You',3,11,3),(12,'Roar',3,12,2),(13,'Lay With Me',3,10,1),(14,'Unstable',2,7,5),(15,'Poker Face',4,14,7),(17,'BODY PARTS',3,16,1),(18,'GOAT',3,16,6),(19,'GRETA THUNBERG',4,16,7);
/*!40000 ALTER TABLE `songs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venues`
--

DROP TABLE IF EXISTS `venues`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venues` (
  `idVenue` int NOT NULL AUTO_INCREMENT,
  `VenueName` varchar(45) NOT NULL,
  `VenueCountry` char(3) NOT NULL,
  `VenueType` enum('hall','pavilion','stadium','festival') NOT NULL,
  PRIMARY KEY (`idVenue`),
  UNIQUE KEY `NombreSitio_UNIQUE` (`VenueName`),
  KEY `FK_SI_PA_idx` (`VenueCountry`),
  CONSTRAINT `FK_SI_PA` FOREIGN KEY (`VenueCountry`) REFERENCES `country` (`idCountry`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venues`
--

LOCK TABLES `venues` WRITE;
/*!40000 ALTER TABLE `venues` DISABLE KEYS */;
INSERT INTO `venues` VALUES (1,'Old Trafford','GBR','stadium'),(2,'Wizink Center','SPA','pavilion'),(3,'MEO Sudoeste','POR','festival'),(4,'Wembley','GBR','stadium'),(5,'Madison Square Garden','USA','pavilion'),(6,'Royal Albert Hall','GBR','hall'),(7,'Lumen Field','USA','stadium'),(8,'Festival Hall','AUS','hall'),(9,'Palau Sant Jordi','SPA','pavilion'),(10,'The O2 Arena','GBR','stadium'),(11,'San Nicola','ITA','stadium'),(12,'Auditorium Conciliazione','ITA','pavilion'),(13,'Razzmatazz','SPA','hall'),(14,'Coliseum','SPA','stadium'),(15,'Cosimo Puttilli','ITA','stadium'),(16,'Lollapalooza','USA','festival'),(17,'NOS Alive','POR','festival');
/*!40000 ALTER TABLE `venues` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `copyalb`
--

/*!50001 DROP VIEW IF EXISTS `copyalb`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copyalb` AS select `albums`.`idAlbum` AS `idAlbum`,`albums`.`AlbumName` AS `AlbumName`,`albums`.`YearAlbum` AS `YearAlbum`,`albums`.`Artist` AS `Artist` from `albums` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `copyart`
--

/*!50001 DROP VIEW IF EXISTS `copyart`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copyart` AS select `artists`.`idArtist` AS `idArtist`,`artists`.`ArtistName` AS `ArtistName`,`artists`.`ArtistCountry` AS `ArtistCountry` from `artists` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `copyconc`
--

/*!50001 DROP VIEW IF EXISTS `copyconc`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copyconc` AS select `concerts`.`idConcert` AS `idConcert`,`concerts`.`Artist` AS `Artist`,`concerts`.`Venue` AS `Venue`,`concerts`.`ConcertDate` AS `ConcertDate` from `concerts` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `copycountr`
--

/*!50001 DROP VIEW IF EXISTS `copycountr`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copycountr` AS select `country`.`idCountry` AS `idCountry`,`country`.`CountryName` AS `CountryName` from `country` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `copysetl`
--

/*!50001 DROP VIEW IF EXISTS `copysetl`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copysetl` AS select `setlists`.`Concert` AS `Concert`,`setlists`.`Song` AS `Song`,`setlists`.`OrderInSetlist` AS `OrderInSetlist` from `setlists` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `copysong`
--

/*!50001 DROP VIEW IF EXISTS `copysong`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copysong` AS select `songs`.`idSong` AS `idSong`,`songs`.`SongName` AS `SongName`,`songs`.`SongLength` AS `SongLength`,`songs`.`Album` AS `Album`,`songs`.`SongOrder` AS `SongOrder` from `songs` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `copyven`
--

/*!50001 DROP VIEW IF EXISTS `copyven`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `copyven` AS select `venues`.`idVenue` AS `idVenue`,`venues`.`VenueName` AS `VenueName`,`venues`.`VenueCountry` AS `VenueCountry`,`venues`.`VenueType` AS `VenueType` from `venues` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-02 22:44:27
