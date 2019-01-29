using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje { 
    class Program {
        static void Main(string[] args){
            bool t = false;                                                                                                 // declaramos una variable booleana para controlar el bucle
            int mes = 0;                                                                                                    // declaramos la variable para guardar el numero introducido
            while (t == false) {                                                                                            // creamos un bucle, para en caso de error, vuelva a pedir el numero
                Console.Clear();                                                                                            // limpiamos la pantalla 
                Console.WriteLine("introduzca un numero del 1 al 12: ");                                                    // pide el numero
                mes = Convert.ToInt32(Console.ReadLine());                                                                  // guarda el numero

                switch (mes)                                                                                                //compara el numero, y muestra el resultado correspondiente, ademas indica t=true , para acabar con el bucle
                {
                    case 1:Console.WriteLine("el numero conresponde con el mes de Enero");                                 
                           t = true; break;

                    case 2: Console.WriteLine(" el numero corresponde con el mes de Ferbrero");
                           t = true; break;

                    case 3:Console.WriteLine("el numero corresponde con el mes Marzo");
                           t = true; break;
                        
                    case 4:Console.WriteLine("el numero corresponde con el mes Abril");
                           t = true; break;

                    case 5:Console.WriteLine("el numero corresponde con el mes Mayo");
                           t = true; break;

                    case 6:Console.WriteLine("el numero corresponde con el mes de Junio");
                           t = true; break;

                    case 7:Console.WriteLine("el numero corresponde con el mes Julio");
                            t = true; break;

                    case 8:Console.WriteLine("el numero corresponde con el mes de Agosto");
                            t = true; break;

                    case 9:Console.WriteLine("el numero corresponde con el mes Septiembre");
                            t = true; break;

                    case 10:Console.WriteLine("el numero corresponde con el mes Octubre");
                            t = true; break;

                    case 11:Console.WriteLine("el numero corresponde con el mes de Noviembre");
                             t = true; break;

                    case 12:Console.WriteLine("El numero corresponde con el mes de Diciembre");
                             t = true; break;

                    default:Console.WriteLine("Error el numero introducido no esta comprendido dentro de (1-12)");              // caso de error en el que el usuario introdujo un numero no valido, en este caso vuelve a pedir el numero
                            break;


                }
                Console.ReadLine();
            }
            


        } 
    }
}
