
-- 1.- Crear una base de datos que se llame Academia
create database academia;
use academia;
-- 2.- Crear una tabla llamada Aulas con los atributos siguientes:
--   Id: Clave Primaria, entero, autoincrementable que empiece en 10 y vaya de 2 en 2,
--   Nombre:  12 caracteres, no admite nulos,
--   Capacidad: entero, no admite nulos
	create table aulas(
	id int identity(10,2),
	nombre char (12) not null,
	capacidad int not null,
	primary key (id) );
 --3.- Insertar 3 tuplas en la tabla creada anteriormente
	insert into aulas (nombre,capacidad) values ('1.1',30),('1.2',45),('1.3',70);
	
 -- 4.- Agregar un atributo que se llame Lugar:  20 caracteres, no admite nulos
	alter table aulas add  lugar char (20);
	update aulas set lugar = 'mikasa' where nombre ='1.1';
	update aulas set lugar = 'michozo' where nombre ='1.2';
	update aulas set lugar = 'micueva' where nombre = '1.3';
	alter table aulas add lugar char (20) not null;
	
 -- 5.- Insertar 3 nuevas tuplas en dicha tabla
	insert into aulas (nombre,capacidad,lugar) values ('2.1',15,'somebody'),
													  ('2.2',20,'once'),
												      ('2.3',10,'told me');

 -- 6.- Modificar el atributo Lugar para que se llame Localizac y sea de 30 caracteres
	SP_Rename 'aulas.Lugar', 'localizac';
	alter table aulas column localizac char (30) not null;
 
 -- 7.- Borrar el atributo creado anteriormente
 alter table aulas drop column localizac;


 -- 8.- Borrar la tabla creada anteriormente.
	use master;
	drop table aulas;

 -- 9.-  Borrar la base de datos creada anteriormente.
	drop database academia;
