using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Dorado_IngresPasword
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escribir un programa que almacene la cadena de caracteres 
             * contraseña en una variable, pregunte al usuario por la contraseña e 
             * imprima por pantalla si la contraseña introducida por el usuario coincide con
             *  la guardada en la variable 
             * sin tener en cuenta mayúsculas y minúsculas.*/
            String contraseña = "Alumno";
            Console.WriteLine("Ingrese la contraseña ");
            String contraseñaingresada = Console.ReadLine();
            if (contraseña == contraseñaingresada)
            {
                Console.WriteLine( " La contraseña es correcta ");
            }
            else
            {
                Console.WriteLine(" La contraseña es Incorrecta ");
            }

            Console.ReadKey();
        }
    }
}
