using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[20];
            bool h,t;
            int r, vidas = 3;
            Random rnd = new Random();
            for (int i = 0; i < 20; i++) {
         
                n[i] = rnd.Next(1, 50);
            
            }


            while (vidas != 0) {
                Console.WriteLine("Introduzca un numero del 1 al 50");
                r = Int32.Parse(Console.ReadLine());
                h = check(n, r);
                if (h == false)
                    vidas--;
                if (vidas == 0) {
                    Console.WriteLine("Has perdido, prueba otra vez");
                }
                t=Isempty(n);
                if (t == true)
                {
                    Console.WriteLine("Has ganado, ya puedes proseguir con tu vida :)");
                    vidas = 0;
                }

            }
            Console.Clear();
            Console.WriteLine("Saliendo del programa, pulse una tecla");
            Console.ReadKey();

        }
        static bool Isempty(int[] n) {
            int cont = 0;
            for(int i = 0; i < 20; i++)
            {
                if (n[i] != 0)
                    cont++;
            }
            if (cont > 0)
                return false;
            else
                return true;
        }
        static bool check(int[] n,int c)
        {
            for (int i = 0; i < 20; i++) {

                if (c == n[i])
                {

                    n[i] = 0;
                    return true;
                }
     
            }
            return false;

        }


    }
}
