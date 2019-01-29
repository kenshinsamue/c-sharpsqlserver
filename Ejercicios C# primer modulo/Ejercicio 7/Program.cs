using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendizaje { 
    class Program {
        static void Main(string[] args){
            int suma = 0;

            for(int i = 1000; i >= 1; i--)
            {
                suma = suma + i;


            }
            Console.WriteLine("la suma de los numeros es: " + suma);
            Console.ReadLine();
            }
            


        
    }
}
