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
            int n_notas, n_md = 0, n_i = 0, n_s = 0, n_n = 0, n_b = 0, n_sb = 0, n_mh = 0;          // declaramos variables
            Console.WriteLine("Cuantas notas va a introducir ?");                                   // pedimos numero de notas
            n_notas = Convert.ToInt32(Console.ReadLine());                                          //declaramos variables tipo double
            double valor, numero = 0;                                                                  // bucle 
            for (int i = 0; i < n_notas; i++)
            {
                Console.WriteLine("introduzca la nota " + (i + 1) + " : ");                         // pedimos nota
                valor = Convert.ToDouble(Console.ReadLine());                                       // guardamos nota

                switch (valor)                                                                      // switch
                {
                    case double n when (0 <= n && n <= 1.99):                                       // cuando el valor este entre 0 y 2
                        Console.WriteLine("La nota es muy deficiente");                             // la nota sera deficiente
                        n_md++; numero += n; break;                                                  // guardamos , y aumentamos el contador

                    case double n when (2 <= n && 4.99 >= n):                                       // cuando el valor este entre 2 y 5
                        Console.WriteLine("La nota es insuficiente");                               // la nota sera insuficiente
                        n_i++; numero += n; break;                                                   // guardamos y aumentamos el contador

                    case double n when (5 <= n && 5.99 >= n):                                       // cuando el valor este entre 5 y 6
                        Console.WriteLine("La nota es sufuciente");                                 //la nota sera suficiente
                        n_s++; numero += n; break;                                                   // guardamos y aumentamos el contador

                    case double n when (6 <= n && 6.99 >= n):                                       // cuando el valor este entre 6 y 7
                        Console.WriteLine("La nota es Bien");                                       // la nota sera bien
                        n_b++; numero += n; break;                                                   // guardamos y aumentamos el contador

                    case double n when (7 <= n && 7.99 >= n):                                       // cuando el valor este entre 7 y 8 
                        Console.WriteLine("La nota es Notable");                                    // la nota sera notable
                        n_n++; numero += n; break;                                                   // guardamos y aumentamos el contador

                    case double n when (8 <= n && 8.99 >= n):                                           //cuando el valor este entre 8 y 9
                        Console.WriteLine("La nota es Sobresaliente");                              //  la nota sera sobresaliente
                        n_sb++; numero += n; break;                                                  // guardamos y aumentamos el contador

                    case double n when (9 <= n && 10 >= n):                                         // cuando el valor este entre 9 y 10 
                        Console.WriteLine("La nota es Matricula de Honor");                         // la nota sera matricula de honor
                        n_mh++; numero += n; break;                                                  //guardamos y aumentamos el contador
                    default:
                        Console.WriteLine("Error la nota no es aceptable, vuelva a intentar");      // en el caso de que meta una nota que no este en esos casos
                        i--; break;                                                                  // vuelve a repetir el ciclo del bucle

                }
            }
            numero = numero / n_notas;                                                              // calculamos media
            Console.WriteLine("Hay un numero total de : " + n_md + " Muy deficiente, " + n_i + " Insuficiente, " + n_s + " Suficiente," + n_b + " Bien," + n_n + " Notable, " + n_mh + " Sobresaliente, " + n_mh + " Matricula de Honor");
            Console.WriteLine("La media de las notas es : " + Math.Round(numero, 2));                // mostramos media

            Console.ReadLine();
        }
            }
    }

