USE `mysql`;
CREATE DATABASE if NOT EXISTS `bob`;
USE `bob`;
DROP TABLE if EXISTS `bob`;
CREATE TABLE  `bob`(
    `id` INT (11) NOT NULL AUTO_INCREMENT,
    `name` VARCHAR (50) NOT NULL,
    PRIMARY KEY (`id`)
);
