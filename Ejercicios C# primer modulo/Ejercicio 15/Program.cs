using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje {
    class Program
    {
        static void Main(string[] args){
            int numero = 0;
            int[] vector = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("introduzca un numero entero");
                vector[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.Clear();
            for(int i = 0; i < 10; i++)
            {
                Console.Write(vector[i]+" ");

            }
            Console.ReadLine();
            
        }
            }
    }

