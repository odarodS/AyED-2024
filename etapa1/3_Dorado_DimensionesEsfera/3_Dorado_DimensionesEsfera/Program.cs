using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Dorado_DimensionesEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa en C# para calcular la superficie y 
             * el volumen de una esfera, dado su radio.
superficie = 4 * pi * radio al cuadrado
volumen = 4/3 * pi * radio al cubo */

            Console.WriteLine("Ingrese un valor para el radio");
            double radio = double.Parse(Console.ReadLine());
            double radiocuadrado = 4 * Math.PI * (radio * radio);
            double radiocubo = (4  * Math.PI) / Math.PI * (radio * radio * radio); 
            Console.WriteLine("La superficie de la esfera es: " + radiocuadrado + " y el volumen es: " + radiocubo  );
            Console.ReadKey();
        }
    }
}
