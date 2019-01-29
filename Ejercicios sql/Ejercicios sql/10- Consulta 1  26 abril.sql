-- 1.- Listar los números de las habitaciones que tienen más de 1 cama.
	 use hotel;
	 select h.numhabitacion from habitaciones as h inner join TIPO_HABITACION as th on h.TIPO_HABITACION=th.CATEGORIA where  th.CAMAS > 1; 

-- 2.- Listar todos los datos de los servicios cuyo precio sea mayor que la media de precios de dichos servicios

select * from SERVICIOS where PRECIO > (select avg(PRECIO) from servicios);


-- 3.- Listar los nombres y apellidos de los clientes que han reservado la habitación 104 o 105 con fecha de salida anterior al 25 de marzo de 2009.

select distinct c.nombre, c.apellido1,c.apellido2 
from clientes as c inner join reserva_habitac as rh on c.IDENTIFICACION=rh.CLIENTE
where (rh.NUMHABITACION=104 and rh.FECHASALIDA <'25-03-2009')or (rh.NUMHABITACION =105 and rh.FECHASALIDA<'25-03-2009');

-- 4.- Listar todos los datos de las habitaciones que tienen más de 2 camas.
select * 
from habitaciones as h inner join TIPO_HABITACION as th on h.TIPO_HABITACION=th.CATEGORIA 
where th.CAMAS>2;


-- 5.- Listar los nombres, apellidos y teléfonos de los clientes que han reservado la habitación 103 y no han reservado nunca la 101

select c.nombre,c.apellido1,c.apellido2,c.TELEFONO 
from clientes as c inner join reserva_habitac as rh on c.IDENTIFICACION=rh.CLIENTE
where rh.NUMHABITACION=103 and rh.NUMHABITACION!=101;

