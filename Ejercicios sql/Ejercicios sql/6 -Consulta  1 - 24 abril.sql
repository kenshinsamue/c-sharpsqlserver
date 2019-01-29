-- 0.- Mostrar todos los datos de las 5 primeras reservas
use hotel;
select top 5 * from reserva_habitac;


-- 1.- Mostrar idRESERVA, cliente de las primeras 3 reservas

 select top 3 IDRESERVA from reserva_habitac;
-- 2.- Mostrar el 34% de las primeras reservas
select top 34 PERCENT *  from reserva_habitac;

-- 3.- Mostrar el IGIC, número de habitación y el IDCliente del 75% de las primeras reservas del cliente 44444 y también del cliente 12345
select top 75 PERCENT igic,NUMHABITACION,CLIENTE from reserva_habitac where cliente = 44444 or CLIENTE=12345;
 
--4.- Mostrar el nombre, apellido1 y apellido2 de todos los clientes renombrando las columnas por "Nombre del cliente", etc..

select nombre as 'nombre cliente',apellido1 as 'primer apellido',apellido2 as 'segundo apellido' from clientes; 
 

--5.- Listar todos los datos de los clientes (tabla Clientes) en orden ascendente según el nombre.
select nombre from CLIENTES order by nombre asc;
 

--6.- Listar el nombre, apellido1, apellido2 y teléfono de los clientes (tabla Clientes) en orden descendente según el Teléfono.

 select nombre, apellido1,apellido2,telefono from clientes order by TELEFONO desc;
--7.- Insertar en la tabla paises las nacionalidades de HOLANDA Y SUIZA
 
 insert into paises values ('Holanda','Suiza');

--8.- Actualizar la tabla clientes y para el que se llama Luis García García actualizarle el teléfono por 612345678 y el país por HOLANDA


update clientes set telefono = '612345678', pais ='Holanda' where nombre = 'luis' and apellido1 = 'Garcia' and apellido2 ='Garcia';


--9.- Eliminar la tupla donde el país es SUIZA

delete from PAISES where pais = 'Suiza';

--10.- Mostrar una lista de selección de la tabla Clientes donde solo se genere una columna de salida que se llame 'Datos de Clientes' 
--     y ésta contenga los campos: Nombre, Apellido1, Apellido2 y telefono */

select nombre + ' ' +apellido1 + ' '+ apellido2 + ' Tiene el telefono: ' + telefono as 'Datos de cliente' from CLIENTES;
 
