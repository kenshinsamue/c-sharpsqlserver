-- 1.- Insertar los pa�ses siguientes: BRASIL, ARGENTINA, NORUEGA, HOLANDA, ITALIA Y COLOMBIA.
	INSERT INTO PAISES VALUES ('BRASIL'),('ARGENTINA'),('NORUEGA'),('HOLANDA'),('ITALIA'),('COLOMBIA');

-- 2.- Insertar 6 nuevos clientes, uno para cada nacionalidad nueva creada en el apartado anterior.
	INSERT INTO CLIENTES VALUES ('2345','BRASIL','PACO','MENDOZA','MENDOZA','CALLLE LA CALLE','48371294',NULL);
	INSERT INTO CLIENTES VALUES ('2346','ARGENTINA','PEDRO','MENDOZA','MENDOZA','CALLE LA CERA','145674325',NULL);
	INSERT INTO CLIENTES VALUES ('2347','NORUEGA','PEPE','MENDOZA','MENDOZA','CALLE APARCAMIENTO','649381754',NULL);
	INSERT INTO CLIENTES VALUES ('2348','HOLANDA','PASCUAL','MENDOZA','MENDOZA','CALLE BACHE','4839174',NULL);
	INSERT INTO CLIENTES VALUES ('2349','ITALIA','PELAYO','MENDOZA','MENDOZA','MENDOZA','CALLE SEMAFORO','183674954',NULL);
	INSERT INTO CLIENTES VALUES ('1250','COLOMBIA','PAULINO','MENDOZA','MENDOZA','CALLE ','CALLE CAMELLO','597483740',NULL);

-- 3.- Listar todos los clientes existentes hasta ahora.
	
	SELECT * FROM CLIENTES;

-- 4.- Insertar 1 nueva reserva para el usuario brasile�o creado anteriormente, con fecha de entrada ma�ana s�bado y de salida el lunes en la habitaci�n 103.

	INSERT INTO RESERVA_HABITAC (FECHAENTRADA,FECHASALIDA,IGIC,NUMHABITACION,CLIENTE) VALUES 
	('2018-04-21','2018-04-23',0.07,103,'2345');

-- 5.- Comprobar que la reserva se ha creado correctamente.
	
	SELECT * FROM RESERVA_HABITAC;


