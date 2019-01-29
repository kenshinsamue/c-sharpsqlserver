using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje { 
    class Program {
        static void Main(string[] args){

            int cont = 0, numero = 0;                                                                  //declaramos variables
            for(int i = 0; i < 10; i++)                                                                // bucle for de 1 al 10
            {

                Console.WriteLine("Introduzca un entero");                                              // mensaje por pantalla

                numero =numero + Convert.ToInt32(Console.ReadLine());                                   // operacion....

            }
            numero = numero / 10;                                                                       // calcula la media
            Console.WriteLine("La media es : " + numero);                                               // muestra resultado
            Console.ReadLine();



            }
            


        
    }
}
