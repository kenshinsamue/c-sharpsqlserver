using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace aprendizaje {
    class Program
    {

       
        static void Main(string[] args){
            int  opcion = 0;                                                            // creamos una variable para la opcion que iremos a elegir
            int[] vector = new int[10];                                                 // creamos el array con los elementos a introducir
            List<double> resultados = new List<double>();                               // declaramos una lista de elementos double que contendra todos los resultados de las diversas operaciones que haremos
            bool opt = false;                                                           // creamos una variable booleana para los bucles
            for(int i = 0; i < 10; i++)                                                 // bucle para pedir los elementos del array, y los introduce de forma consecutiva
            {
                Console.WriteLine("introduzca un numero entero");
                vector[i] = Convert.ToInt32(Console.ReadLine());
                
                
            }
            Console.Clear();                                                            // limpiamos pantalla
            do                                                                          // bucle do-while
            {
                Console.WriteLine("introduzca la opcion a elegir: ");                   // menu en el que pedimos la opcion
                Console.WriteLine("1) Suma de todos los elementos");
                Console.WriteLine("2) Resta de todos los elementos");
                Console.WriteLine("3) Multiplicacion de todos los elementos");
                Console.WriteLine("4) Division de todos los elementos");
                Console.WriteLine("5) Elegir dos elementos ");
                Console.WriteLine("6) Mostrar todos los resultados");
                Console.WriteLine("0) Salir");
                opcion = Convert.ToInt32(Console.ReadLine());                           // guardamos la opcion

                switch (opcion)                                                         // switch con el que evaluaremos que haremos con la opcion
                {
                    case 1: resultados=Suma(0, vector.Length, vector,resultados); break;                      // en caso de 1 va al metodo suma
                    case 2: resultados=Resta(0, vector.Length, vector,resultados); break;                     // en caso de 2 va al metodo resta
                    case 3: resultados=Multi(0, vector.Length, vector,resultados); break;                     // en caso de 3 va al metodo multiplicacion
                    case 4: resultados=Div(0, vector.Length, vector,resultados); break;                       // en caso de 4 va al metodo division
                    case 5: resultados=Elegir(vector,resultados); break;                                      // en caso de 5 va al metodo que nos permite elegir la operacion de 2 elementos concretos
                    case 6: Mostrar(resultados);break;
                    case 0: opt = true;break;                                           // salimos
                    default: Console.WriteLine("error, opcion no valida");Console.Clear(); break;       // en caso de erro , muestra mensaje y limpia pantalla


                }


            } while (!opt);                                                             // el bucle se repetira hasta que se seleccione la opcion "0" en la que ponemos opt en valor "true"
            Console.WriteLine("pulse enter para salir");                                // mensaje de salida 
            Console.ReadLine();
            
        }
        /////////////////////////////////////////////////////////////  Funcion Suma  //////////////////////////////////////////////////
        static List<double> Suma (int a, int b,int [] vector, List <double> resultados){
            int suma=0;                                                                 // iniciamos la variable suma , que contendra el resultado
            
            for (int i = a; i < b; i++)                                                 // bucle en el que hacemos las operaciones de sumar y guardar el resultado
            {

                suma += vector[i];

            }

            Console.WriteLine("El resultado de la suma es : " + suma);                  // mostramos el resultado
            resultados.Add(Convert.ToDouble(suma));                                     // guardamos el resultado dentro de la lista
            return resultados;
            
            
        }
        /////////////////////////////////////////////////////////////  Funcion Resta  //////////////////////////////////////////////////
        static List<double> Resta (int a, int b, int [] vector, List<double> resultados)
        {    
            int resta = vector[0];                                                      // iniciamos la variable resta con el primer valor del array, que contendra el resultado

            for (int i = a; i < b; i++)                                                 // hacemos el bucle que hara las operaciones y guardara el resultado
            {
                if (i + 1 < vector.Length)                                              // bucle para evitar un segmentation fault
                {
                    resta -= vector[i + 1];
                }
            }
            Console.WriteLine("El resultado de la resta es : " + resta);                // mostramos el resultado
            resultados.Add(Convert.ToDouble(resta));                                    // guardamos el resultado en la lista
            return resultados;
        }
        /////////////////////////////////////////////////////////////  Funcion Multi  //////////////////////////////////////////////////
        static List<double> Multi (int a , int b, int [] vector, List<double> resultados)
        {
            int multi = 1;                                                              // iniciamos la variable a 1 , esta contendra el resultado de la multiplicacion
            

            for (int i = a; i < b; i++) {                                               // bucle en el que se hacen las operaciones y se guarda el resultado
      
                multi = multi * vector[i];                                      
               
            }
            Console.WriteLine("El resultado de la multiplicacion es : " + multi);      // mostramos el resultado
            resultados.Add(Convert.ToDouble(multi));                                   // guardamos el resultado en la lista
            return resultados;
        }
        /////////////////////////////////////////////////////////////  Funcion Div  //////////////////////////////////////////////////


            // the division bell -----> high hopes   |m|
        static List<double> Div(int a, int b, int[] vector, List<double> resultados) 
        {
            double total = Convert.ToDouble(vector[0]);                                // iniciamos la variable a el primer valor del array, y la declaramos como double para poder tener decimales
                                                                                       // convertimos ademas el valor del array en double para poder guardarlo dentro de la variable "total"


            for (int i = a; i < b; i++)                                                // bucle en el que hacemos las operaciones y se guarda el resultado
            {
                if(i+1<vector.Length)                                                   // condicion para evitar el segmentation fault
                    total = total / Convert.ToDouble(vector[i+1]);

            }
            Console.WriteLine("El resultado de la division es : " + total);             // mostramos el resultado
            resultados.Add(total);                                                      // guardamos el resultado en la lista
            return resultados;
        }

        /////////////////////////////////////////////////////////////  Funcion Mostrar  //////////////////////////////////////////////////

            static void Mostrar(List <double> resultados)                               // metodo en el que veremos todos los resultados 
        {

            foreach(int total in resultados)                                            // buscara todos los elementos dentro de la lista
            {
                Console.WriteLine(total);                                               // muestra dichos elementos
            }


        }

        /////////////////////////////////////////////////////////////  Funcion Elegir  //////////////////////////////////////////////////
        static List<double> Elegir(int [] vector,List<double> resultados){
            int index1=0, index2=0, opcion;                                             // declaramos los index, que contendran los indices de los dos valores a pedir, y la opcion que vamos a pedri
            bool opt = false;                                                           // booleano para los bucles
            Console.Clear();
            while (!opt)                                                                // bucle while para pedir el primer indice y asegurarnos de que esta dentro de rango
            {
                Console.Write("Introduzca la primera posicion: ");
                index1 = Convert.ToInt32(Console.ReadLine());
                opt = true;
                if (index1 < 0 || index1 >= vector.Length)
                    opt = false;
                Console.Clear();
            }
            opt = false;                                                                // volvemos a poner opt a false para poder re-utilizar la variable
            while (!opt)                                                                // bucle while para poder pedir el segundo indice y asegurarnos que esta dentro de rango
            {
                Console.Write("Introduzca la primera posicion: ");
                index2 = Convert.ToInt32(Console.ReadLine());
                opt = true;
                if (index2 < 0 || index2 >= vector.Length)
                    opt = false;
                Console.Clear();
            }
            opt = false;                                                                // volvemos a poner opt en false para poder re-utilizar la variable
            do                                                                          // bucle do-while para el menu y su respuesta
            {
                Console.WriteLine("introduzca la opcion a elegir: ");                   // mostramos el menu con las opciones
                Console.WriteLine("1) Suma de los elementos");
                Console.WriteLine("2) Resta de los elementos");
                Console.WriteLine("3) Multiplicacion de los elementos");
                Console.WriteLine("4) Division de los elementos");
                opcion = Convert.ToInt32(Console.ReadLine());                           // guardamos la opcion elegida
                switch (opcion)                                                         // dependiendo de la opcion elegida mostramos el resultado de las diversas operaciones
                {
                    case 1: Console.WriteLine("El resultado de la suma es : "+ (vector[index1]+vector[index2]));
                        resultados.Add(Convert.ToDouble((vector[index1] + vector[index2])));
                        opt = true; break;
                    case 2: Console.WriteLine("El resultado de la resta es : " + (vector[index1] - vector[index2]));
                        resultados.Add(Convert.ToDouble((vector[index1] - vector[index2]))) ;
                        opt = true; break;
                    case 3: Console.WriteLine("El resultado de la multiplicacion es : " + (vector[index1] * vector[index2]));
                        resultados.Add(Convert.ToDouble((vector[index1] * vector[index2]))) ;
                        opt = true; break;
                    case 4: Console.WriteLine("El resultado de la divisiones : " + ((Convert.ToDouble(vector[index1])/ Convert.ToDouble(vector[index2]))));
                        resultados.Add((Convert.ToDouble(vector[index1]) / Convert.ToDouble(vector[index2])));
                        opt = true; break;
                    default: Console.WriteLine("Error, no ha introducido una opcion valida");Console.Clear();break;
                }
            } while (!opt);                                                            // fin de bucle si se establece opt a true
            return resultados;
        }

            }

}

