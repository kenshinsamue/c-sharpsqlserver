using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje {
    class Program
    {
        static void Main(string[] args){

            int numero = 0, cont = 1;
            bool terminado = false;
            string respuesta;
            Console.WriteLine("Introduzca un numero");
            numero=Convert.ToInt32(Console.ReadLine());

            while(terminado == false)
            {
                Console.WriteLine(numero + " x " + cont + " = " + (numero*cont));
                cont++;
                if (cont == 11)
                {
                    Console.WriteLine(" Va a buscar otra tabla de multiplicar?(y/n) ");
                    respuesta = Console.ReadLine();
                    if (respuesta == "y")
                    {
                        cont = 0;
                        Console.WriteLine("introduzca el numero");
                        numero = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("saliendo del programa");
                        Console.ReadLine();
                        terminado = true;
                    }
                }
            }

        }
            }
    }

