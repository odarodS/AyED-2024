using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_15_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al usuario un 
             * número entero positivo y muestre por pantalla
             * la cuenta atrás desde ese número hasta cero. */
            Console.WriteLine("ingrese un numero entero postivo");
            int numero = int.Parse(Console.ReadLine());
            int contador = -1;
            int CuentaAtras = numero;
            while (contador < numero)
            {
                Console.WriteLine( CuentaAtras - 1 + 1   );

                contador += 1;
                CuentaAtras -= 1;

            }
            Console.ReadKey();
        }
    }
}
