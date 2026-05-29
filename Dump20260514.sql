-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: mysql-1b282e9e-dem.h.aivencloud.com    Database: default_db_dem
-- ------------------------------------------------------
-- Server version	8.4.8

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
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '2fa45d66-4ede-11f1-85fe-ee93f8984fe9:1-163';

--
-- Table structure for table `addres`
--

DROP TABLE IF EXISTS `addres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addres` (
  `idaddres` int NOT NULL,
  `addres` varchar(45) NOT NULL,
  PRIMARY KEY (`idaddres`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addres`
--

LOCK TABLES `addres` WRITE;
/*!40000 ALTER TABLE `addres` DISABLE KEYS */;
INSERT INTO `addres` VALUES (1,'ул.Ленина 15'),(2,'пр.Мира 2'),(3,'ул.Пушкина 10'),(4,'ул. Гагарина, 8'),(5,'пр. Строителей, 1'),(6,'ул. Чехова, 33'),(7,'ул. Кирова, 12'),(8,'пер. Тихий, 4'),(9,'бульвар Роз, 7'),(10,'ул. Садовая, 19'),(11,'пр. Победы, 50'),(12,'ул. Новая, 2'),(13,'ул. Северная, 9'),(14,'ул. Южная, 11'),(15,'пр. Ленина, 100'),(16,'ул. Советская, 3'),(17,'ул. Труда, 14'),(18,'ул. Зеленая, 8'),(19,'пер. Школьный, 1'),(20,'ул. Цветочная, 5');
/*!40000 ALTER TABLE `addres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `idcategoria` int NOT NULL AUTO_INCREMENT,
  `categoria_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idcategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Мячи'),(2,'Обувь'),(3,'Тренажеры'),(4,'Лыжный спорт'),(5,'Экипировка'),(6,'Силовые'),(7,'Кардио'),(8,'Фитнес'),(9,'Одежда'),(10,'Туризм'),(11,'Единоборства'),(12,'Теннис'),(13,'Плавание');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `idclient` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `fio` varchar(45) NOT NULL,
  `patronomik` varchar(45) DEFAULT NULL,
  `role` int NOT NULL,
  `email` varchar(45) NOT NULL,
  `phone` bigint NOT NULL,
  PRIMARY KEY (`idclient`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Сидоров','Алексей','Михайлович',1,'sidorov@mail.ru',79110001122),(2,'Кузнецова','Елена','Владимировна',1,'kuz_el@ya.ru',89120002233),(3,'Попов','Дмитрий','Николаевич',1,'popov_d@gmail.com',89140004455),(4,'Васильева','Мария','Александровна',1,'vasya_m@mail.ru',79150005566),(5,'Васильева','Мария','Александровна',1,'vasya_m@mail.ru',79150005566),(6,'Михайлова','Дарья','Юрьевна',1,'mikh_d@gmail.com',89170007788),(7,'Федоров','Артем','Викторович',1,'fedorov_a@mail.ru',89170007788),(8,'Морозова','Екатерина','Олеговна',1,'fedorov_a@mail.ru',79200001111),(9,'Волков','Илья','Павлович',1,'lebedev_n@ya.ru',79230444466),(10,'Алексеева','Екатерина','Денисовна',1,'alekseeva@mail.ru',89220003333),(11,'Лебедев','Никита','Олеговна',1,'moroz_e@ya.ru',79200001111),(12,'Семенова','Ольга','Константиновна',1,'volkov_i@gmail.com',89210002222),(13,'Егоров','Павел','',1,'alekseeva@mail.ru',89220003333),(14,'Павлова','Никита','Евгеньевна',1,'lebedev_n@ya.ru',79230444466),(15,'Козлов','Роман','Борисович',1,'semenova_o@gmail.com',79240005555),(16,'Егоров','Павел','',1,'egorov_p@mail.ru',79250006666),(17,'Николаев','Глеб','Степанович',1,'nikolaev_g@ya.ru',79290123466),(18,'Орлова','Виктория','',1,'kozlov_r@gmail.com',79270008888),(19,'Макаров','Даниил','Аркадьевна',1,'stepanova_y@mail.ru',89280009999),(20,'Николаев','Глеб','Степанович',1,'nikolaev_g@ya.ru',79290123466),(21,'Захаров','Кирилл','Леонидович',1,'zaharov_k@gmail.com',89310003456),(22,'Зайцева','Полина','Вячеславовна',1,'zaitseva_a@mail.ru',79340678966),(23,'Соловьев','Владислав','Игоревич',1,'andreeva_p@ya.ru',89320004567),(24,'Борисова','Яна','Станиславовна',1,'borisova_y@gmail.com',79360008901),(25,'Яковлев','Арсений','Станиславовна',1,'zaharov_k@gmail.com',79330005678),(27,'Соловьев','Владислав','Игоревич',1,'soloviev_v@ya.ru',89350007890);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manufacturer` (
  `idmanufacturer` int NOT NULL AUTO_INCREMENT,
  `manufactur_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idmanufacturer`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturer`
--

LOCK TABLES `manufacturer` WRITE;
/*!40000 ALTER TABLE `manufacturer` DISABLE KEYS */;
INSERT INTO `manufacturer` VALUES (1,'Adidas'),(2,'Nike'),(3,'Kettler'),(4,'Fischer'),(5,'СпортМастер'),(6,'Spalding'),(7,'Mikasa'),(8,'Demix'),(9,'Torneo'),(10,'Barbell'),(11,'Reebok'),(12,'Puma'),(13,'Under Armour'),(14,'Outventure'),(15,'Nordway'),(16,'Deuter'),(17,'Stanley'),(18,'Everlast'),(19,'Venum'),(20,'Wilson'),(21,'Head'),(22,'Speedo'),(23,'Joss');
/*!40000 ALTER TABLE `manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `idorder` int NOT NULL AUTO_INCREMENT,
  `article` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `patronomic` varchar(45) DEFAULT NULL,
  `status_id` int NOT NULL,
  `addres_id` int NOT NULL,
  `data_order` date NOT NULL,
  `data_deliviry` date DEFAULT NULL,
  `order_structure` varchar(45) NOT NULL,
  PRIMARY KEY (`idorder`),
  KEY `status_id_idx` (`status_id`),
  KEY `addres_id_idx` (`addres_id`),
  CONSTRAINT `addres_id` FOREIGN KEY (`addres_id`) REFERENCES `addres` (`idaddres`),
  CONSTRAINT `status_id` FOREIGN KEY (`status_id`) REFERENCES `status` (`idstatus`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,'ORD-1001','Сидоров','Алексей','Михайлович',1,1,'2023-09-01','2023-09-05','P-001 (2 шт); P-011 (1 шт)'),(3,'ORD-1003','Попов','Дмитрий','Николаевич',1,3,'2023-09-05','2023-09-08','P-014 (1 шт); P-018 (2 шт)'),(4,'ORD-1004','Сидоров','Алексей','Михайлович',3,1,'2023-10-25','2023-10-30','P-004 (1 шт)'),(5,'ORD-1005','Васильева','Мария','Александровна',4,4,'2023-10-24','2023-10-29','P-020 (1 шт); P-021 (2 шт); P-023 (1 шт)'),(6,'ORD-1006','Соколов','Максим','Андреевич',1,5,'2023-09-10','2023-09-15','P-002 (1 шт)'),(7,'ORD-1007','Михайлова','Дарья','Юрьевна',1,6,'2023-09-11','2023-09-14','P-006 (1 шт); P-007 (4 шт)'),(8,'ORD-1008','Яковлев','Арсений','Максимович',3,7,'2023-10-26','2023-11-01','P-024 (1 шт); P-025 (1 шт)'),(9,'ORD-1009','Морозова','Екатерина','Олеговна',4,8,'2023-10-23','2023-10-28','P-027 (1 шт); P-028 (3 шт)'),(11,'ORD-1011','Алексеева','Анастасия','Денисовна',1,10,'2023-09-18','2023-09-22','P-015 (1 шт)'),(12,'ORD-1012','Макаров','Даниил','Антонович',1,11,'2023-09-20','2023-09-25','P-019 (1 шт)'),(13,'ORD-1013','Михайлова','Дарья','Юрьевна',3,12,'2023-10-26','2023-10-31','P-013 (5 шт)'),(14,'ORD-1014','Яковлев','Арсений','Максимович',4,13,'2023-10-25','2023-10-29','P-012 (2 шт)'),(15,'ORD-1015','Павлова','Татьяна','Евгеньевна',1,14,'2023-09-22','2023-09-26','P-003 (1 шт)'),(17,'ORD-1017','Козлов','Роман','Борисович',1,15,'2023-09-25','2023-09-28','P-017 (2 шт)'),(18,'ORD-1018','Михайлова','Дарья','Юрьевна',3,16,'2023-10-26','2023-11-02','P-029 (1 шт); P-030 (2 шт)'),(19,'ORD-1019','Николаев','Глеб','Степанович',4,17,'2023-10-22','2023-10-27','P-001 (10 шт)'),(20,'ORD-1020','Орлова','Виктория','Ильинична',1,18,'2023-10-05','2023-10-09','P-016 (1 шт)'),(21,'ORD-1021','Яковлев','Арсений','Максимович',1,19,'2023-10-08','2023-10-12','P-026 (1 шт)'),(23,'ORD-1023','Михайлова','Дарья','Юрьевна',3,2,'2023-10-26','2023-11-01','P-005 (2 шт)'),(24,'ORD-1024','Зайцева','Алина','Федоровна',4,4,'2023-10-24','2023-10-29','P-006 (1 шт)'),(25,'ORD-1025','Соловьев','Владислав','Игоревич',1,6,'2023-10-12','2023-10-16','P-011 (3 шт)'),(26,'ORD-1026','Макаров','Даниил','Антонович',1,9,'2023-10-15','2023-10-18','P-012 (1 шт)'),(27,'ORD-1027','Яковлев','Арсений','Максимович',3,5,'2023-10-26','2023-11-03','P-024 (2 шт)'),(28,'ORD-1028','Михайлова','Дарья','Юрьевна',4,7,'2023-10-25','2023-10-30','P-029 (2 шт)'),(29,'ORD-1029','Романов','Вадим','Алексеевич',1,10,'2023-10-18','2023-10-22','P-020 (1 шт)');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `idproduct` int NOT NULL AUTO_INCREMENT,
  `article` varchar(45) DEFAULT NULL,
  `name` varchar(45) NOT NULL,
  `category_id` int NOT NULL,
  `description` varchar(45) NOT NULL,
  `manufacturer_id` int NOT NULL,
  `suppliers_id` int NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `discount` int DEFAULT NULL,
  `count` int NOT NULL,
  `unit_id` int NOT NULL,
  `photo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idproduct`),
  KEY `category_id_idx` (`category_id`),
  KEY `manufacturer_id_idx` (`manufacturer_id`),
  KEY `suppliers_id_idx` (`suppliers_id`),
  KEY `unit_id_idx` (`unit_id`),
  CONSTRAINT `category_id` FOREIGN KEY (`category_id`) REFERENCES `categoria` (`idcategoria`),
  CONSTRAINT `manufacturer_id` FOREIGN KEY (`manufacturer_id`) REFERENCES `manufacturer` (`idmanufacturer`),
  CONSTRAINT `suppliers_id` FOREIGN KEY (`suppliers_id`) REFERENCES `suppliers` (`idsuppliers`),
  CONSTRAINT `unit_id` FOREIGN KEY (`unit_id`) REFERENCES `unit` (`idunit`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'P-001','Мч футбольный Pro',1,'Профессиональный мяч',1,1,4500,10,15,1,''),(3,'P-003','елотренажер Fit-3',3,'Домашний велотренажер',3,1,25000,25,5,1,'bike fit.png'),(4,'P-004','Лыжи беговые Skat',4,'Коньковый ход',4,2,12500,5,0,2,'ski skate.jpg'),(5,'P-006','Гантели разборные 15кг',3,'Стальные гантели',4,3,3201,30,20,1,''),(6,'P-006','Спортивный костюм',5,'Хлопок 100%',3,1,6500,15,8,1,'suit.jpg'),(8,'P-008','Беговая дорожка RunMax',3,'Складная конструкция',3,2,45900,5,0,1,''),(9,'P-009','Бутсы футбольные',2,'Шиповки',2,1,7500,25,30,2,'boots.jpg'),(10,'P-010','Палки лыжные',4,'Карбоновые',4,2,4101,10,18,2,'poles.jpg'),(11,'P-011','Эспандер трубчатый',3,'Набор 5 шт',4,3,950,50,100,3,''),(13,'P-013','Мяч волейбольный',1,'Тренировочный',4,3,2200,15,25,1,'volley.png'),(14,'P-014','Перчатки для 8а',5,'Кожа/текстиль',2,2,1250,25,0,2,'gloves.jpg'),(15,'P-015','Мяч футбольный',1,'Профессиональный мяч для игр на газоне',1,1,4501,10,50,1,'adidas_ball.jpg'),(17,'P-017','Мяч волейбольный',1,'Мяч для классического волейбола',7,1,3801,5,120,1,'mikasa_vol.jpg'),(18,'P-018','Гантели разборные 15кг',6,'Набор гантелей в кейсе',8,5,2500,25,15,4,'dumbbell_15.png'),(20,'P-020','Штанга олимпийская',6,'Гриф 20кг + замки',3,4,15000,15,8,1,'barbell.png'),(22,'P-022','Беговая дорожка',7,'Складная, до 15 км/ч',3,6,45000,30,5,1,'treadmill.jpg'),(23,'P-023','Эллиптический тренажер',7,'Магнитная система нагрузки',9,6,32000,10,0,1,'elliptic.png'),(24,'P-024','Велотренажер',7,'Вертикальная посадка',3,6,28000,5,12,1,'bike.jpg'),(25,'P-025','Коврик для йоги',8,'Толщина 6мм, TPE',2,1,1200,15,200,1,'yoga_mat.jpg'),(26,'P-026','8-резинки',8,'Набор из 5 эспандеров',8,5,600,25,150,4,'bands.png'),(28,'P-028','Кроссовки беговые',2,'Амортизирующая подошва',2,7,8900,20,45,2,'nike_run.jpg'),(29,'P-029','Бутсы футбольные',2,'Шиповки для натурального газона',12,7,7500,35,25,2,'puma_boots.png'),(31,'P-031','Футболка компрессионная',9,'Отводит влагу',13,8,2500,10,60,1,'ua_shirt.png'),(33,'P-033','Костюм спортивный',9,'Хлопок + полиэстер',12,8,5500,15,30,1,'puma_suit.jpg'),(34,'P-034','Палатка 3-местная',10,'Водостойкость 3000мм',14,9,8500,25,20,1,'tent_3.png'),(35,'P-035','Спальный мешок',10,'До -5 градусов комфорт',15,9,3201,5,40,1,'sleeping_bag.jpg'),(37,'P-037','Термос 1 литр',10,'Держит тепло 24 часа',17,9,2800,10,50,1,'thermos.jpg'),(40,'P-040','Шлем боксерский',11,'С защитой скул',18,10,3500,16,18,1,'helmet.jpg'),(41,'P-041','Ракетка для 12а',12,'Легкий графит',20,4,9500,20,12,1,'racket.png'),(43,'P-043','Очки для плавания',13,'Антифог, защита от УФ',22,11,1800,5,80,1,'goggles.png'),(44,'P-044','Шапочка для плавания',13,'Силиконовая',23,11,400,30,150,1,'cap.jpg'),(46,'P-000','m',5,'-',7,6,8,9,77,2,'cap.jpg'),(48,'P-048','а',4,'-',4,6,55,4,55,3,'cap.jpg');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `idrole` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idrole`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Клиент'),(2,'Менеджер'),(3,'Админ');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status`
--

DROP TABLE IF EXISTS `status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status` (
  `idstatus` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idstatus`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status`
--

LOCK TABLES `status` WRITE;
/*!40000 ALTER TABLE `status` DISABLE KEYS */;
INSERT INTO `status` VALUES (1,'Доставлен'),(2,'Отменен'),(3,'Формируется'),(4,'Отправлен');
/*!40000 ALTER TABLE `status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `idsuppliers` int NOT NULL AUTO_INCREMENT,
  `suppliers_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idsuppliers`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'ООО СпортОпт'),(2,'ЗАО АктивЛайф'),(3,'ИП Смирнов'),(4,'ЗАО Актив'),(5,'ИП Иванов'),(6,'ООО ФитнесПро'),(7,'ООО ОбувьПро'),(8,'ООО Текстиль'),(9,'ООО ТурСнаб'),(10,'ООО Ринг'),(11,'ООО ВодаСпорт');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit`
--

DROP TABLE IF EXISTS `unit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unit` (
  `idunit` int NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idunit`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit`
--

LOCK TABLES `unit` WRITE;
/*!40000 ALTER TABLE `unit` DISABLE KEYS */;
INSERT INTO `unit` VALUES (1,'шт'),(2,'пара'),(3,'компл'),(4,'набор'),(5,'туба');
/*!40000 ALTER TABLE `unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `iduser` int NOT NULL AUTO_INCREMENT,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `role` int NOT NULL,
  PRIMARY KEY (`iduser`),
  KEY `role_idx` (`role`),
  CONSTRAINT `role` FOREIGN KEY (`role`) REFERENCES `role` (`idrole`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'client_001','hash45678',1),(2,'client_002','hash56789',1),(3,'client_003','hash67890',1),(4,'client_004','hash78901',1),(5,'client_005','hash89012',1),(6,'client_006','hash90123',1),(7,'client_007','hash01234',1),(8,'client_008','hash11234',1),(9,'client_009','hash22345',1),(10,'client_010','hash33456',1),(11,'client_011','hash44567',1),(12,'client_012','hash55678',1),(13,'client_013','hash66789',1),(14,'client_014','hash77890',1),(15,'client_015','hash88901',1),(16,'client_016','hash99012',1),(17,'client_017','hash00123',1),(18,'client_018','hash11122',1),(19,'client_019','hash22233',1),(20,'client_020','hash33344',1),(21,'client_021','hash44455',1),(22,'client_022','hash55566',1),(23,'client_023','hash66677',1),(24,'client_024','hash77788',1),(25,'client_025','hash88899',1),(26,'client_026','hash99900',1),(27,'client_027','hash00011',1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-14 20:23:04
