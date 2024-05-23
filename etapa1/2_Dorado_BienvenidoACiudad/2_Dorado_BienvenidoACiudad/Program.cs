using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dorado_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que sean reales o comprobarlos) y
             *  mostrar por pantalla, 
                el siguiente mensaje «Hola » < nombre > » bienvenido 
                a » < ciudad > */
            Console.WriteLine("ingrese su nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("ingrese su ciudad");
            string Ciudad = Console.ReadLine(); 
            Console.WriteLine("Hola " + Nombre + ", Bienvenido a " + Ciudad  );
                Console.ReadKey();
        }
    }
}
