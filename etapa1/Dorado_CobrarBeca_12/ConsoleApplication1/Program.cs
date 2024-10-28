using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Para poder cobrar la beca JuanPedro 
             * se debe ser mayor de 19 años y tener unos ingresos 
             * iguales o superiores a $100.000 mensuales. 
             * Escribir un programa que pregunte al usuario su edad 
             * y sus ingresos mensuales y 
             * muestre por pantalla si el usuario puede cobrar o no.
*/
            Console.WriteLine("Cual es tu edad");
            int Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sus ingresos mensuales");
            int ingresos = int.Parse(Console.ReadLine());
            if ((Edad > 19) && (ingresos >= 100000))
            {
                Console.WriteLine("Usted puede cobrar la beca");
            }
            else
            {
                Console.WriteLine("Usted no puede cobrar la beca edad o ingresos insuficientes");
            }
            Console.ReadKey();
        }
    }
}
