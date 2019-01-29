using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Agenda

{
    class Program
    {
        static void Main(string[] args)
        {
            bool n = false;
            StreamWriter datos = File.AppendText("agenda.csv");
            string nuevo,consulta;

            do
            {
                datos=insert_data(datos);

                do {

                    Console.WriteLine();
                    Console.WriteLine("Desea seguir introduciendo clientes? (s/n):");
                    nuevo = Console.ReadLine().ToUpper();

                } while (nuevo != "S" && nuevo != "SI" && nuevo != "N" && nuevo != "NO");

                n = consult(Console.ReadLine());
                
            } while (n == true);

            do {

                Console.WriteLine("Desea consultar los datos introducidos? (S/N)");
                consulta = Console.ReadLine().ToUpper();

             } while (consulta != "S" && consulta != "SI" && consulta != "N" && consulta != "NO");
            if (consulta == "S" || consulta == "SI") {
                StreamReader leer = new StreamReader("agenda.csv");
                Console.WriteLine();
                Console.WriteLine(leer.ReadToEnd());
                leer.Close();
            }

            Console.WriteLine();
            Console.WriteLine("Introduzca cualquier tecla para salir ...");
            Console.ReadKey();
        }

        static bool consult(string r) {
            bool n;
            if (r == "SI" || r == "S")
                n = true;
            else
                n = false;
            return n;
        }

        static StreamWriter insert_data(StreamWriter datos) {
            string dni, nombre, apellidos, telefono, direccion;
            
            Console.WriteLine("Introduzca el Dni del cliente: ");
            dni = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente:");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca el telefono del cliente: ");
            telefono = Console.ReadLine();
            Console.WriteLine("Introduzca la direccion del cliente: ");
            direccion = Console.ReadLine();

            datos.WriteLine($"{dni};  {nombre};  {apellidos};  {telefono};  {direccion}");
            datos.Close();
            return datos;
        }
    }
}
