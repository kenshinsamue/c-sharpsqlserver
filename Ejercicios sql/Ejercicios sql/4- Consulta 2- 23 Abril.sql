
 --0.- Usar la base de datos HOTEL
 use hotel;
 --1.- Mostrar los nombres y las nacionalidades de los clientes cuyo nombre empiece por "L"
 select nombre,pais from CLIENTES where nombre like 'L%';
 --2.- Mostrar todos los datos de los clientes cuyo nombre contenga al menos una "V"
 select * from clientes where nombre like '%v%';
 --3.- Mostrar los apellidos y la dirección de los clientes cuyo segundo apellido contenga las letras "QUI" seguidas
 select apellido1,apellido2 from CLIENTES where apellido2 like '%qui%';
 --4.- Mostrar todos los datos de los clientes cuyo primer apellido termine en "Y"
 select * from CLIENTES where APELLIDO1 like '%Y';
 --5.- Mostrar todos los datos de los clientes cuyo segundo apellido contenga al menos una "Z"
 select * from clientes where APELLIDO2 like '%z%';
 --6.- Mostrar el nombre,los apellidos y observaciones de los clientes que tengan escrita alguna observación.
 select nombre,apellido1,apellido2,observaciones from clientes where OBSERVACIONES is not null;
 --7.- Mostrar el nombre y los apellidos de los clientes que tengan como tercera letra en su nombre una "L".
 select nombre,apellido1,apellido2 from clientes where nombre like '__L';
 --8.- Mostrar el nombre y los apellidos de los clientes cuyo nombre contenga al menos 5 caracteres.
 select nombre, apellido1,apellido2 from clientes where nombre like '%_____%';
 --9.- Mostrar el nombre y los apellidos de los clientes cuyo nombre tenga al menos una "A" pero no sea ni la primera letra ni la última.
 select nombre, apellido1,apellido2 from clientes where nombre like '_%A%_';
