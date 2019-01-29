--1.-   Mostrar los servicios cuyo precio est�n entre 1.5 y 8  sin usar > ni <.
use hotel;
select * from servicios where precio between 1.5 and 8;

--2.- Mostrar los servicios cuyo precio son exactamente 2 o 10 sin usar <,>,=, etc

  select * from SERVICIOS where precio in (2,10);
--3.- Mostrar todos los datos de los tipos de habitaciones que tienen el mismo n�mero de camas que el de la categor�a 4
select * from TIPO_HABITACION where CAMAS in (select camas from TIPO_HABITACION where CATEGORIA=4);

--4.- Mostrar el nombre y los dos apellidos de los clientes cuyo nombre empiece por 'LU'
select nombre, apellido1, apellido2 from CLIENTES where nombre like 'LU%';

--5.- Mostrar el nombre y los dos apellidos de los clientes cuyo primer apellido contenga al menos una 'a' en cualquier posici�n
select nombre,apellido1,apellido2 from clientes where apellido1 like '%a%';

--6.- Mostrar una lista de los clientes que a�n no tengan observaciones, es decir que ese campo es NULL
 select nombre,apellido1,apellido2 from clientes where OBSERVACIONES is null;

--7.- Calcular la suma total de las cantidades de los gastos, es decir la suma del atributo cantidad de la tabla gastos
	select sum(precio) from gastos;

--8.- Calcular la suma de los gastos totales, es decir la suma de las cantidades por los precios de los gastos
	select sum(PRECIO*CANTIDAD) as 'Gasto total' from GASTOS;

--9.- Calcular la media de los precios de las habitaciones
	select AVG(PRECIO) from PRECIO_HABITACION;

--10.- Calcular el precio de la habitaci�n m�s cara poni�ndole a la columna resultado 'Habitaci�n m�s cara'
	select max (precio) as 'habitacion mas cara'from PRECIO_HABITACION;

--11.- Calcular el precio de la habitaci�n m�s barata poni�ndole a la columna resultado 'Habitaci�n m�s barata'
	select min(precio)as 'habitacion mas barata' from PRECIO_HABITACION;

--12.- Obtener el n�mero de habitaciones (filas) existentes.
	select count (*) as 'numero de habitaciones' from PRECIO_HABITACION;

--13.-Liste las suma de los gastos ( precio *cantidad) , clasific�ndolas por tipo reserva (idReserva)
	select sum(precio*cantidad) from gastos group by IDRESERVA;

--14.-Listar todos los  datos de los clientes que vivan en una "CALLE" y el n�mero de la casa sea '67' 
	select * from clientes where DIRECCION like '%calle%' and  direccion like '%67%';

--15.-Listar los n�meros de habitaciones y su tipo de las habitaciones 
--que son del mismo tipo de habitaci�n que la habitaci�n con n�mero 103

	select NUMHABITACION,TIPO_HABITACION from habitaciones where TIPO_HABITACION in (select TIPO_HABITACION from habitaciones where numhabitacion = 103);



