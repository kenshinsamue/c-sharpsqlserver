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
            int resultado = 0, m = 0, M = 0;                                     //declaramos las variables
            Console.WriteLine("introduzca un numero: ");                        // pedimos y guardamos el primer numero
            m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca el segundo numero: ");                // pedimos y guardamos el segundo numero
            M=Convert.ToInt32(Console.ReadLine());
            Console.Clear();

                
            if (M >= m) {                                           // en el caso de que el primer numero sea menor o igual que el segundo hacer 
                for (int i = m; i <= M; i++)                       // primer bucle que contendra el numero multiplicando
                {
                    for (int j = 0; j <= 10; j++)                   // segundo bucle que contendra el numero multiplicador
                    {
                        resultado = i * j;                               // guardamos el valor de la multiplicacion
                        Console.WriteLine(i + " * " + j + " = " + resultado);    //mostramos el resultado
                    }

                }
                Console.ReadLine();                                       // esperamos a que el usuario presione una tecla para salir del programa
            }



            if(m > M)                                              // en el caso de que el primer numero sea mayor que el segundo hacer 
            {
                for (int i = m; i >= M; i--)                       // primer bucle que contendra el numero multiplicando
                {
                    for (int j = 0; j <= 10; j++)                   // segundo bucle que contendra el numero multiplicador
                    {
                        resultado = i * j;                               // guardamos el valor de la multiplicacion
                        Console.WriteLine(i + " * " + j + " = " + resultado);    //mostramos el resultado
                    }

                }
                Console.ReadLine();                                       // esperamos a que el usuario presione una tecla para salir del programa

            }

        }
            }
    }

