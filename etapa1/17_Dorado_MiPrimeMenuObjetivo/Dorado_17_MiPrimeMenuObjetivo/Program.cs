using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_17_MiPrimeMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa en C# que presente un menú con
             *  diversas opciones simples y permita al usuario 
             *  seleccionar una de ellas.

Descripción:
Se solicita crear un programa en C# que muestre un menú con 
al menos tres opciones simples y permita al usuario seleccionar
una de ellas. Cada opción debe realizar una acción diferente, como mostrar un mensaje en pantalla o realizar un cálculo básico.

Requerimientos:
Mostrar un mensaje de bienvenida al programa.
Presentar un menú con al menos tres opciones numeradas.
Permitir al usuario seleccionar una opción ingresando 
el número correspondiente.
Realizar una acción diferente para cada opción seleccionada.
Repetir el proceso hasta que el usuario elija una opción 
para salir del programa.


Ejemplo de Menú:

--- Menú ---
1. Opción 1
2. Opción 2
3. Opción 3
4. Salir*/

            bool consola = true;
            while (consola != false) {
                Console.WriteLine("Toque 1 para hacer una suma" + "\n" + "toque 2 para que la consola te salude" + "\n" + "toque 3 para generar una palabra con la letra A" + "\n" +  "toque 4 para salir ");
                int numero = int.Parse(Console.ReadLine());
                Console.Clear();
                if (numero == 1)
                {
                    Console.Write("ingrese un numero ");
                    int Nume1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese otro numero ");
                    int Nume2 = int.Parse(Console.ReadLine());
                    int SumaNume = (Nume1 + Nume2);
                    Console.WriteLine("La suma de esos 2 numeros ingresados es: " + SumaNume + "\n");
                    Console.WriteLine("Toque enter para volver al menú");
                    string volver = Console.ReadLine();
                   
                }
                Console.Clear();
                if (numero == 2)
                {
                    Console.WriteLine("Bienvenido Usuario. " + "\n");
                    Console.WriteLine("Toque enter para volver al menú");
                    string volver = Console.ReadLine();
                    Console.Clear();
                }
                if (numero == 3)
                {
                    Console.WriteLine( "Palabra generada = Camaleon. " + "\n");
                    Console.WriteLine("Toque enter para volver al menú");
                    string volver = Console.ReadLine();
                    Console.Clear();
                }
                if (numero == 4)
                {
                    Console.WriteLine("Toque enter para cerrar");
                     consola = false;
        
                }
            }


            Console.ReadKey();
        }
    }
}
