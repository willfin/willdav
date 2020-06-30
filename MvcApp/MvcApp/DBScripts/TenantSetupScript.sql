	CREATE TABLE `vehicle` (
	  `id` bigint NOT NULL AUTO_INCREMENT,
	  `version` bigint NOT NULL,
	  `year` int NOT NULL,
	  `model` varchar(255) NOT NULL,
	  PRIMARY KEY (`id`)
	);
    
	CREATE TABLE `Product` (
	  `id` bigint NOT NULL AUTO_INCREMENT,
	  `version` bigint NOT NULL,
	  `year` int NOT NULL,
	  `model` varchar(255) NOT NULL,
	  PRIMARY KEY (`id`)
	);
    
	CREATE TABLE `Order` (
	  `id` bigint NOT NULL AUTO_INCREMENT,
	  `version` bigint NOT NULL,
	  `year` int NOT NULL,
	  `model` varchar(255) NOT NULL,
	  PRIMARY KEY (`id`)
	);