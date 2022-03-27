CREATE TABLE `Alumno` (
	`id` INT(2) NOT NULL AUTO_INCREMENT,
	`Nombre` varchar(30),
	`Apellido` varchar(30),
	`Email` varchar(30),
	`Telefono` INT(30),
	`Universidad` INT(2) NOT NULL,
	`PromedioM1` INT(2),
	`PromedioM2` INT(2),
	`PromedioM3` INT(2),
	`PromedioM4` INT(2),
	`PromedioM5` INT(2),
	`PromedioM6` INT(2),
	`PromedioM7` INT(2),
	`PromedioM8` INT(2),
	`PromedioM9` INT(2),
	`PromedioM10` INT(2),
	`PromedioM11` INT(2),
	`PromedioM12` INT(2),
	`PromedioM13` INT(2),
	`PromedioM14` INT(2),
	`PromedioM15` INT(2),
	`PromedioM16` INT(2),
	`PromedioM17` INT(2),
	`PromedioM18` INT(2),
	`PromedioM19` INT(2),
	`PromedioM20` INT(2),
	PRIMARY KEY (`id`)
);

CREATE TABLE `Universidad` (
	`id` INT(2) NOT NULL AUTO_INCREMENT,
	`Nombre` varchar(30),
	`Localidad` varchar(30),
	`Provincia` varchar(30),
	PRIMARY KEY (`id`)
);

ALTER TABLE `Alumno` ADD CONSTRAINT `Alumno_fk0` FOREIGN KEY (`Universidad`) REFERENCES `Universidad`(`id`);



