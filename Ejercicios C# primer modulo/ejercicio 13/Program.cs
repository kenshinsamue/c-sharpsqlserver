using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje {
    class Program
    {
        static void Main(string[] args){

            double numero = 0, suma = 0;
            string terminar;
            bool fin = false;

            while (fin == false) {
                Console.WriteLine("introduzca un numero decimal");
                numero = Convert.ToDouble(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Quiere continuar? (y/n)");
                terminar=Console.ReadLine();
                if (terminar == "y")
                {
                    fin = false;
                }

                else {
                    fin = true;
                }
            }
            Console.WriteLine("el resultado de la suma es : " + suma);
            Console.ReadLine();
        }
            }
    }

