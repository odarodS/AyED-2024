using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_13_ObtenerDiagonalPrinc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Usando un for y un vector se debe obtener 
             * la diagonal principal de una Matriz nxn con 
             * datos aleatorios.*/
            Console.WriteLine("ingrese un valor ");
            int valor = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int[,] matriz = new int[valor, valor];
            for (int c = 0; c < valor; c++)
            {

                for (int f = 0; f < valor; f++)
                {
                    matriz[c, f] = aleatorio.Next(0, 40);
                    Console.Write(matriz[c, f] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            int[] vector = new int[valor];
            for (int i = 0; i < valor; i++)
            {

                vector[i] = matriz[i, i];
                Console.Write(vector[i] + "\t");

            }
            
            Console.ReadKey();
        }
    }
}
