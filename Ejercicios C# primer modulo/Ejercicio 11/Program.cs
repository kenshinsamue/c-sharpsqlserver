using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje {
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, multiplicador = 1 ;
            Console.WriteLine("introduzca un numero");
            numero=Convert.ToInt32(Console.ReadLine());
            while (multiplicador <= 10)
            {

                Console.WriteLine(numero + " x " + multiplicador+" = " + (numero * multiplicador));
                multiplicador++;



            }
            Console.ReadLine();




        }
            }
    }

