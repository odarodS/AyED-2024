using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_19_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Recorre los números del 1 al N. 
             * (N lo tiene que ingresar el usuario).
Muestra solamente los números pares.*/

            Console.WriteLine("Ingrese cualquier numero");
            int Nume = int.Parse(Console.ReadLine());
            int Contador = 0;
            while (Contador < Nume)
            {
                Contador++;
                if (Contador % 2 == 0)
                {
                    Console.WriteLine(Contador);
                }




            }

            Console.ReadKey();
        }
    }
}
