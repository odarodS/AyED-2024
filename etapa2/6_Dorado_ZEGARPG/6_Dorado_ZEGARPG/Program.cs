using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Dorado_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        { /* La compañía de videojuegos "ZEGA" está desarrollando un nuevo
            juego de rol (RPG) en el que los jugadores pueden encontrar 
            objetos con diferentes valores. Necesitan un programa
            que permita identificar en qué posición se encuentran los
            objetos cuyo valor es mayor a un número dado.

El programa solicitará al usuario que ingrese la cantidad de elementos 
(objetos) que desea analizar.Luego, pedirá al usuario que ingrese el valor
mínimo que deben tener los objetos para ser considerados en el filtro.
Seguidamente, el programa solicitará al usuario que ingrese los valores de
los objetos, uno por uno.Una vez ingresados todos los valores, 
el programa mostrará al usuario las posiciones en las que se encuentran
los objetos cuyo valor es mayor al número especificado. */

            Console.WriteLine("Ingrese la cantidad de objetos que desea analizar");
            int Objetos = int.Parse(Console.ReadLine());
            int[] CantObjetos = new int[Objetos];
            Console.WriteLine("Ingrese el valor minimo que deben tener los objetos para ser considerados en el filtro"); 
            int ValorMinimo = int.Parse(Console.ReadLine());
            for (int cont = 0; cont < CantObjetos.Count(); cont++ )
            {
                Console.WriteLine("Ingrese el Valor que debe tener el objeto N°: " + (cont + 1));
                int ValorObjetos = int.Parse(Console.ReadLine());
                if (ValorObjetos > ValorMinimo)
                {
                    CantObjetos[cont] = ValorObjetos;
                }
                
            }
            for (int cont = 0; cont < CantObjetos.Count(); cont++)
            {
                Console.WriteLine(" las posiciones son: " + CantObjetos[cont]);
            }

                Console.ReadKey();
        }
    }
}
