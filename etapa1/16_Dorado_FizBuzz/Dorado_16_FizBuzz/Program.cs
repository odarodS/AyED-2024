using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_16_FizBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre por consola 
             * (con un print) los  números de 1 a 100 (ambos incluidos y 
             * con un salto de línea entre  cada impresión), 
             * sustituyendo los siguientes: 
 - Múltiplos de 3 por la palabra "fizz". 
 - Múltiplos de 5 por la palabra "buzz". 
 - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".*/

            int i;
            i = 0;
                while(i < 100)
            {
                i++;
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    if (i % 3 != 0 && i % 5 != 0)
                {
                        Console.WriteLine(i);
                    }
                }
            
        

        Console.ReadKey();

        }
    }
}
