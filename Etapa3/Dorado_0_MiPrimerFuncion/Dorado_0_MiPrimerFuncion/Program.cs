using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_0_MiPrimerFuncion
{
    class Program
    {
        static void Main(string[] args)
        { /*Escribir una función a la que se le pase una cadena <nombre> 
            y
            muestre por pantalla el saludo ¡hola <nombre>!*/
            saludar("carlos");
            Console.ReadKey();

        }
        static void saludar(string nombre)
        {
            Console.WriteLine("hola " +  nombre);

        }
        
    }
}
