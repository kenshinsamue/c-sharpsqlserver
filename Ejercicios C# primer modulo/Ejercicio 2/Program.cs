using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje { 
    class Program {
        static void Main(string[] args){

            int num1 = 0, num2 = 0;                                                             // declaramos dos variables , una para cada numero a solicitar

            Console.WriteLine("Introduzca el primer valor a comparar: ");                       // pedimos el primer numero
            num1 = Convert.ToInt32(Console.ReadLine());                                         //guardamos el primer numero

            Console.WriteLine("Introduzca el segundo valor: ");                                 //pedimos el segundo numero
            num2 = Convert.ToInt32(Console.ReadLine());                                         //guardamos el segundo numero

            if (num1 > num2)                                                                    // comparamos si el primer numero es mayor que el segundo
                Console.WriteLine(num1 + " Es mayor que " + num2);                              // en caso de ser cierto mostramos el resultado

            if (num2 > num1)                                                                    // comparamos si el segundo es mayor que el primero
                Console.WriteLine(num2 + " Es mayor que " + num1);                              // msotramos resultado

            else                                                                                // en otro caso ( son iguales)
                Console.WriteLine(" Los dos numeros son iguales");                              // mostramos resultado

            Console.ReadLine();                                                                 // pedimos un caracter para terminar el programa

                


        }
    }
}
