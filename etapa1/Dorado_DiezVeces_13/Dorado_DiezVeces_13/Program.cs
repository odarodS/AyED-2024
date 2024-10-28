using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_DiezVeces_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al usuario una palabra y 
             * la muestre por pantalla 10 veces.*/
            Console.WriteLine("Ingrese una palabra");
            string Palabra = Console.ReadLine();
            int contador = 0;
            while(contador <=  9) {
                Console.WriteLine( "\n" + Palabra);
                contador += 1;
            }

        Console.ReadKey();
        }
    }
}
