/*
SQLyog Ultimate v9.51 
MySQL - 5.6.26-log : Database - loan
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`loan` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `loan`;

/*Table structure for table `balack_list` */

DROP TABLE IF EXISTS `balack_list`;

CREATE TABLE `balack_list` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `member_name` varchar(30) DEFAULT NULL,
  `centrt_id` int(30) DEFAULT NULL,
  `loan_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `balack_list` */

insert  into `balack_list`(`id`,`member_name`,`centrt_id`,`loan_id`) values (1,'dddd',NULL,NULL),(2,'aaa',NULL,NULL),(3,'dddd2222',NULL,NULL),(4,'',NULL,NULL),(5,'',NULL,NULL);

/*Table structure for table `centers` */

DROP TABLE IF EXISTS `centers`;

CREATE TABLE `centers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `location` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `centers` */

insert  into `centers`(`id`,`location`) values (1,'Ella');

/*Table structure for table `centers_groups` */

DROP TABLE IF EXISTS `centers_groups`;

CREATE TABLE `centers_groups` (
  `group_id` int(11) NOT NULL AUTO_INCREMENT,
  `center_id` int(11) NOT NULL,
  `center_name` varchar(50) NOT NULL,
  `group_name` varchar(50) NOT NULL,
  PRIMARY KEY (`group_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `centers_groups` */

insert  into `centers_groups`(`group_id`,`center_id`,`center_name`,`group_name`) values (1,1,'Ella','a');

/*Table structure for table `loan_recolect` */

DROP TABLE IF EXISTS `loan_recolect`;

CREATE TABLE `loan_recolect` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `loan_id` int(11) NOT NULL,
  `mem_id` int(11) NOT NULL,
  `mem_name` varchar(50) NOT NULL,
  `caenter_id` int(11) NOT NULL,
  `date_tody` date NOT NULL,
  `installment` int(11) NOT NULL,
  `deue` int(11) DEFAULT NULL,
  `status` enum('active','inactive') NOT NULL,
  `marks` enum('very good','bad') NOT NULL DEFAULT 'very good',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `loan_recolect` */

insert  into `loan_recolect`(`id`,`loan_id`,`mem_id`,`mem_name`,`caenter_id`,`date_tody`,`installment`,`deue`,`status`,`marks`) values (1,1,1,'Achini',1,'2022-07-03',1000,0,'active','very good'),(2,1,1,'Achini',1,'2022-07-03',1000,0,'active','very good'),(3,1,1,'Achini',1,'2022-07-03',1000,0,'active','very good'),(4,1,1,'Achini',1,'2022-07-03',1000,0,'active','very good'),(5,1,1,'Achini',1,'2022-07-03',1000,0,'active','very good');

/*Table structure for table `members` */

DROP TABLE IF EXISTS `members`;

CREATE TABLE `members` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `addres` varchar(100) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `job` varchar(30) DEFAULT NULL,
  `mobile` int(10) DEFAULT NULL,
  `home_number` int(10) DEFAULT NULL,
  `center_id` int(20) NOT NULL,
  `Group_id` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `members` */

insert  into `members`(`id`,`name`,`addres`,`nic`,`job`,`mobile`,`home_number`,`center_id`,`Group_id`) values (1,'achini','Ella','997022726v','police',778675650,375732453,1,1),(2,'thathsarani','maho','997022726v','polkedima',786787654,378767654,1,1);

/*Table structure for table `reles_loan` */

DROP TABLE IF EXISTS `reles_loan`;

CREATE TABLE `reles_loan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `loan_id` int(11) NOT NULL,
  `center_id` int(11) NOT NULL,
  `center_name` varchar(50) NOT NULL,
  `group_id` int(11) NOT NULL,
  `group_name` varchar(20) NOT NULL,
  `member_id` int(11) NOT NULL,
  `memeber_name` varchar(50) NOT NULL,
  `member_nic` varchar(30) NOT NULL,
  `doc_pepar_no` int(11) NOT NULL,
  `num_of_warika` int(11) NOT NULL,
  `poli_anupathaya` int(11) NOT NULL,
  `loan_amount` int(11) NOT NULL,
  `sathi_warikaya` double NOT NULL,
  `statuse` enum('active','inactive') NOT NULL,
  `date_A` date NOT NULL,
  `over_date` date DEFAULT '1800-01-01',
  `mulu_mudala` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `reles_loan` */

insert  into `reles_loan`(`id`,`loan_id`,`center_id`,`center_name`,`group_id`,`group_name`,`member_id`,`memeber_name`,`member_nic`,`doc_pepar_no`,`num_of_warika`,`poli_anupathaya`,`loan_amount`,`sathi_warikaya`,`statuse`,`date_A`,`over_date`,`mulu_mudala`) values (1,1,1,'ella',1,'a',1,'achini','997022726v',1,11,10,10000,1000,'active','2022-07-03','1800-01-01',11000);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Addres` varchar(50) DEFAULT NULL,
  `immage` binary(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `users` */

insert  into `users`(`id`,`user_name`,`Password`,`Addres`,`immage`) values (1,'admin','123',NULL,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
