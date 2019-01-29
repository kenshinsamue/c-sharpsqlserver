using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje { 
    class Program {
        static void Main(string[] args){

            int num1 = 0, num2 = 0, num3 = 0, mayor = 0, menor = 0;                                                 // declaramos las variables

            Console.WriteLine("introduzca el primer numero : ");                                                    // pedimos el primer valor para posteriormente guardarlo
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introduzca el segundo numero : ");                                                   // pedimos el segundo valor para posteriormente guardarlo
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2){                                                                                       // comparamos de una vez a ver si son iguales , y en caso de que ocurra terminamos el programa

                Console.WriteLine("Los dos numero son iguales . Saliendo de la aplicacion");                        // mensaje de error
                Console.ReadLine();              
            }
            else {                                                                                                  // en caso de que no sean iguales hacemos :

                Console.WriteLine("introduzca el tercer numero :");                                                 // pedimos el tercer numero y lo guardamos 
                num3 = Convert.ToInt32(Console.ReadLine());

                if(num3 == num2 || num3 == num2){                                                                   // hacemos una ultima comparacion para verificar que ninguno es igual, y en tal caso terminamos
                    Console.WriteLine("Alguno de los numeros son iguales. Saliendo del programa");                  // el programa
                    Console.ReadLine();
                }
                else                                                                                                // en caso de que sean todos distintos hacemos
                {
                    if (num1 > num2 && num1 > num3){                                                                // en caso de que el primer numero sea mayor que el resto 
                        mayor = num1;                                                                               // lo declaramos como mayor
                        if (num2 > num3){                                                                           // en caso de que el segundo sea mayor que el tercero, declaramos el tercero como menor
                            menor = num3;
                            Console.WriteLine("El numero mayor es : " + mayor + " y el menor es :" + menor);        // mostramos el resultado
                            Console.ReadLine();
                        }
                        else{                                                                                       // en caso de que sea el segundo el menor , guardamos este en menor
                            menor = num2;
                            Console.WriteLine("El numero mayor es: " + mayor + " y el menor es :" + menor);         // y mostramos resultado
                            Console.ReadLine();
                        }
                    }
                    else{
                        if (num2 > num3){                                                                          // en otro caso, en el que sea el segundo mayor que el primero y el tercero
                            mayor = num2;                                                                          // guardamos el segundo como mayor
                            if (num1 > num3)                                                                       // en caso de que el primero sea mayor que el tercero entonces guardamos el tercero como menor
                            {
                                menor = num3;
                                Console.WriteLine("El numero mayor es: " + mayor + " y el menor es :" + menor);    // mostramos el resultado
                                Console.ReadLine();
                            }

                        }
                        else                                                                                       // en el ultimo caso , en el que sea el tercero el mayor , guardamos este como mayor 
                        {
                            mayor = num3;
                            if (num1 > num2)                                                                        // vemos si el primero es mayor que el segundo, en ese caso, lo guardamos como menor 
                            {
                                menor = num2;
                                Console.WriteLine("El numero mayor es: "+mayor+" y el menor es: "+menor);           // y mostramos resultado
                                Console.ReadLine();
                            }
                            else                                                                                    // por ultimo si no se cumple , entonces es el primero el menor, y lo guardamos como menor
                            {
                                menor = num1;
                                Console.WriteLine("El numero mayor es: " + mayor + " y el menor es: " + menor);     // mostramos el resultado
                                Console.ReadLine();
                            }
                                
                        }
                    }
                }
            }
        }
    }
}
