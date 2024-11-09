using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa en C# 
             * que calcule el resultado de sumar, restar,
             *  multiplicar y dividir dos números introducidos 
             *  por el usuario.
    Además también debería calcular el resto de la división
    en la última linea. */
            Console.WriteLine("introduzca 1 numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de los dos numeros es " + (n1 + n2) );
            Console.WriteLine("la resta de los dos numeros es " + (n1 - n2));
            Console.WriteLine("la multiplicacion de los dos numeros es " + (n1 * n2));
            Console.WriteLine("la division de los dos numeros es " + (n1 / n2));
            Console.WriteLine("el resto de los dos numeros en la division " + (n1 % n2));
            Console.ReadKey();



        }
    }
}
