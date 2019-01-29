using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        private static int[] inversa =new int [10];
        private static int[] data = new int[data.Length];

        static void Main(string[] args)
        {

            bool e = false;

            do {
                e=menu_();
                //inversa = make_inverse(data);
            } while (e==false);

            // sale programa
        }

        static bool menu_() {
            //int[] data = new int[10];
           // int[] inversa = new int[data.Length];
            
            byte menu = 0;
            bool e = false;
            Console.WriteLine("1.Introducir datos");
            Console.WriteLine("2.Visualizar los datos");
            Console.WriteLine("3.Operaciones");
            Console.WriteLine("4.Salir");

            while (byte.TryParse(Console.ReadLine(), out menu) == false || menu > 4 || menu < 1)
            {
                Console.WriteLine("Operacion no Valida");
            }

            switch (menu) {

                case 1: data = datain(data, inversa);
                    inversa = make_inverse(data);
                    break;
                case 2: show_m(data, inversa);
                    break;

                case 3:op(data,inversa);
                    break;

                case 4:e = true;break;
            }
            Console.Clear();
            return e;
        }

        static void op(int[] data,int[] inversa) {
            bool osalir;
            byte operacion;
            do {
                osalir = false;
                Console.Clear();
                Console.WriteLine("Suma");
                Console.WriteLine("Resta");
                Console.WriteLine("Multiplicacion");
                Console.WriteLine("Division");

                while (Byte.TryParse(Console.ReadLine(), out operacion) == false || operacion < 1 || operacion > 5) {

                    Console.WriteLine("opcion no valida, intente de nuevo: ");
                }

                switch (operacion) {
                    case 1:suma(data, inversa);
                           break;
                    case 2: resta(data,inversa);
                            break;
                    case 3: multi(data, inversa);
                            break;
                    case 4: divi(data, inversa);
                            break;
                    case 5: osalir = true;break;
                    
                }
            } while (osalir == false);


        }

        static void divi(int[] data, int[] inversa) {

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 0 || inversa[i] == 0)
                    Console.Write("(ERROR:DIVISION POR 0) ");
                else
                    Console.Write(Math.Round((double)data[i] / (double)inversa[i], 2) + " ");
            }
            Console.Write("Presiona una tecla para salir");
            Console.ReadKey();
        }
        static void multi(int[] data, int[] inversa) {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write((data[i] * inversa[i]) + " ");
            }
            Console.Write("Presiona una tecla para salir");
            Console.ReadKey();

        }
        static void resta(int[] data, int[] inversa) {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write((data[i] - inversa[i]) + " ");
            }
            Console.Write("Presiona una tecla para salir");
            Console.ReadKey();
        }
        static void suma(int[] data,int[] inversa) {

            for (int i = 0; i < data.Length; i++) {
                Console.Write((data[i] + inversa[i]) + " ");
            }
            Console.Write("Presiona una tecla para salir");
            Console.ReadKey();

        }
        static void show_m(int[] data, int[] inversa) {

            for (int i = 0; i < data.Length; i++) {

                Console.Write(data[i] + " ");
            }
            Console.Write("\t\t");
            for (int i = 0; i < inversa.Length; i++) {
                Console.Write(inversa[i]+" "); 
            }

            Console.Write ("presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
        static int[] datain(int[] data,int[] inversa)
        {
            int contador = inversa.Length;
            for(int i=0; i < data.Length; i++)
            {
                Console.WriteLine("Introduce el valor {0}",i);
                while(Int32.TryParse(Console.ReadLine(),out data[i])== false)
                {
                    Console.WriteLine("No has introducido un numero correcto. Intentalo de nuevo: ");

                }
                inversa[contador - 1] = data[i];
                contador--;
            }
            return data;
        }
        static int[] make_inverse(int[] data) {
            int[] inversa = new int[data.Length];
            int contador = inversa.Length;
            for (int i = 0; i < data.Length; i++)
            {
                inversa[contador - 1] = data[i];
                contador--;
            }
                return inversa;
        }
    }
}
