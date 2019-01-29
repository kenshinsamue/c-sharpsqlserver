using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int o;
            string r="Y";
            while (r == "Y")
            {
                Console.WriteLine("1.hacerlo de forma automatica");
                Console.WriteLine("2.hacerlo manual");
                o = Int32.Parse(Console.ReadLine());
                if (o == 1)
                    aya();
                if (o == 2)
                    aka();
                Console.WriteLine("Quiere repetir?(y/n)");
                r = Console.ReadLine().ToUpper();
                
            }
           
            
        }
        static void aya() {
            Random rnd = new Random();
            int v1=rnd.Next(1,7000), v2=rnd.Next(1,7000);
            
            int aux = 0;
            while (aux >= v1)
            {
                aux += v2;
                Console.WriteLine(aux);
            }
            while (aux == 0)
            {
                aux -= v2;
                Console.WriteLine(aux);
            }
        }

        static void aka() {
            int v1, v2;
            Console.WriteLine("Introduzca el primer numero");
            v1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor");
            v2 = Int32.Parse(Console.ReadLine());

            int aux = 0;
            while (aux >= v1)
            {
                aux += v2;
                Console.WriteLine(aux);
            }
            while (aux == 0)
            {
                aux -= v2;
                Console.WriteLine(aux);
            }

        }
    }

   
}
