using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje
{
    class Program
    {
        static void Main(string[] args){

            int numero;                 // declaramos una variable para almacenar el numero a introducir
            Console.WriteLine("introduzca un numero: ");    // pedimos el numero por pantalla
            numero = Convert.ToInt32(Console.ReadLine());   //leemos el numero introducido 
            if (numero % 2 == 0)                // condicion
                Console.WriteLine("El numero " + numero + " es par");   //si la cumple mostramos que es par
            else
                Console.WriteLine("El numero " + numero + " es impar"); // si no, que es impar

            Console.ReadLine();     // esperamos a que pulse una tecla para salir 



        }
    }
}
