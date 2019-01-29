using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje {
    class Program
    {
        static void Main(string[] args){
            int suma = 0,resta=0,mult = 1;
            int[] vector = new int[10];
          
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("introduzca un numero entero");
                vector[i] = Convert.ToInt32(Console.ReadLine());


            }
            resta = vector[0];
            Console.Clear();
            for(int i = 0; i < 10; i++) {
                
                suma += vector[i];
                
                mult = mult * vector[i];
                if (i+1< vector.Length) {
                    resta -= vector[i + 1];
                }
            }

            Console.WriteLine("el resultado de la suma es " + suma);
            Console.WriteLine("el resultado de la resta es  " + resta);
            Console.WriteLine("el resultado de la multiplicacion es " + mult);
            Console.ReadLine();


        }
            }
    }

