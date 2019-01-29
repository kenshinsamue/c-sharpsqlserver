
 --0.- Usar la base de datos HOTEL
 use hotel;
 --1.- Mostrar los nombres y las nacionalidades de los clientes cuyo nombre contenga "TI", o alguno de sus apellidos acabe o empiece en "A"
 select nombre,pais from clientes where (nombre like '%ti%') or (apellido1 like 'A%' or '%A') or (apellido2 like 'A%' or '%A') ;
 --2.- Mostrar el nombre, apellido1 y apellido2 de todos los clientes renombrando las columnas por "Nombre del cliente", etc..

 select nombre as 'Nombre del Cliente',apellido1 as 'Primer Apellido',apellido2 as 'Segundo Apellido' from clientes;
 --3.- Insertar un tupla en la tabla Precio de habitación, con un precio=90, temporada = 3 y tipo_habitacion=4
  
  insert into PRECIO_HABITACION values (21,90,3,4);
 --4.- Mostrar el precio de la habitación más cara.
 select MAX(precio) as 'precio mas alto' from PRECIO_HABITACION;

 --5.- Mostrar el precio de la habitación más barata.
 select min (precio) as 'precio mas bajo' from PRECIO_HABITACION; 
 --6.- Mostrar el país de los clientes cuya dirección contenga un 4 y no sea ni al principio ni al final.
 select pais from clientes where (direccion like '%4%' )and (DIRECCION  not like '4%' or direccion not like '%4');
 --7.- Mostrar el nombre y los apellidos de los clientes cuyo nombre tenga al menos una "A" pero no sea la segunda letra, ni la cuarta sea una E.

 select nombre,apellido1,apellido2 from clientes where (nombre like '%A%')and (nombre not like '_A%') or (nombre not like '_E');

