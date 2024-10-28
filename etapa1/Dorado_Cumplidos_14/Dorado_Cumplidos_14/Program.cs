using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_Cumplidos_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escribir un programa que pregunte al usuario su edad y 
             * muestre por pantalla 
             * todos los años que ha cumplido (desde 1 hasta su edad).*/
            Console.WriteLine("decime tu edad");
            int  edad = int.Parse(Console.ReadLine());
            int edad2 = edad;
            int contador = 0;
            while (contador < edad) {
                Console.WriteLine((edad2 - edad +1) );
            edad2 += 1;
            contador += 1;
            }

        Console.ReadKey();
        }
    }
}
