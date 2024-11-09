using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Dorado_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escriba un programa en C# que solicite 
             * al usuario tres letras y los muestre al revés.*/
            Console.WriteLine("ingrese SOLO 1 letra");
            Char letra = Char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra letra");
            Char letra2 = Char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra letra");
            Char letra3 = Char.Parse(Console.ReadLine());
            Console.WriteLine("Las letras AlReves son " + letra3 + letra2 + letra);
            Console.ReadKey();
        }
    }
}
