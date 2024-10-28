using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al usuario 
             * un número entero y
             *  muestre por pantalla si es par o impar.*/
            Console.WriteLine("Inserte un numero cualquiera");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)

            {
                Console.WriteLine("El numero es par");
            } 
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
