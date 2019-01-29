
-- COMO EJEMPLO PARA RESOLVER ESTAS CONSULTAS:

SELECT nombre, apellido1,APELLIDO2 FROM CLIENTES 
where nombre = 'LARA' and apellido1 = 'Sousa';


-- 0.- Escribir la sentencia para usar la base de datos HOTEL.

use hotel;

-- 1.- Mostrar todos los datos de los pa�ses.

select * from paises;

-- 2.- Mostrar el nombre del servicio, el precio y el IGIC de todos los servicios
 select nombreservicio,precio,igic from servicios;

-- 3.- Mostrar la categor�a y n�mero de camas de todos los tipos de habitaciones 
 select categoria,camas from tipo_habitacion;

-- 4.- Mostrar todos los datos  de todos los tipos de habitaciones que tienen m�s de 1 cama
  select * from TIPO_HABITACION where CAMAS > 1;

-- 5.- Mostrar todos los datos  de todos los tipos de habitaciones que tienen 1 � 3 camas
  select * from TIPO_HABITACION where camas =1 or camas =3;

-- 6.- Mostrar el n�mero de habitaci�n de aquellas que son de tipo 2
  select numhabitacion from HABITACIONES where TIPO_HABITACION =2;

-- 7.- Mostrar todos los datos  de los tipos de habitaciones que tienen m�s de 1 cama y no tienen sal�n
   select * from TIPO_HABITACION where camas >1 and SALON='NO';

-- 8.- Mostrar todos los datos  de los tipos de habitaciones que tienen 1 cama, dan al exterior, tienen sal�n y no tienen terraza
	select * from TIPO_HABITACION where CAMAS >1 and TERRAZA='NO' and EXTERIOR='SI' and SALON='SI'; 

-- 9.- Mostrar todos los datos  de los tipos de habitaciones que tienen 1 cama y NO tienen NI sal�n NI terraza, o que tienen 1 cama y SI TIENEN EXTERIOR pero no terraza
	select * from TIPO_HABITACION where (camas>1 and salon='NO' and TERRAZA='NO') or (camas =1 and exterior='SI'and terraza='NO');
 