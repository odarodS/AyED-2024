using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_17_MiPrimMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa en C# que presente un menú con diversas opciones simples 
             * y permita al usuario seleccionar una de ellas.

Descripción:
Se solicita crear un programa en C# que muestre un menú con al menos tres opciones simples
y permita al usuario seleccionar una de ellas. Cada opción debe realizar una acción diferente,
como mostrar un mensaje en pantalla o realizar un cálculo básico.

Requerimientos:
Mostrar un mensaje de bienvenida al programa.
Presentar un menú con al menos tres opciones numeradas.
Permitir al usuario seleccionar una opción ingresando el número correspondiente.
Realizar una acción diferente para cada opción seleccionada.
Repetir el proceso hasta que el usuario elija una opción para salir del programa.


Ejemplo de Menú:

--- Menú ---
1. Opción 1
2. Opción 2
3. Opción 3
4. Salir*/
            Console.WriteLine("seleccione una opcion; escriba 1 para resolver una suma, 2 para que el sistema te arroje 5 numeros y presione 3 para que el sistema te de la bienvenida y por ultimo presione 4 para abandonar el programa ");
            int numero = int.Parse(Console.ReadLine()); 
            if (numero == 1)
            {
                Console.WriteLine("ingrese un numero");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese otro numero");
                int num2 = int.Parse(Console.ReadLine());
                int suma = (num1 + num2);
                Console.WriteLine("El resultado de esa suma es: " + suma);

            }
            if (numero == 2)
            {
                
            }

            Console.ReadKey();
        }
    }
}
