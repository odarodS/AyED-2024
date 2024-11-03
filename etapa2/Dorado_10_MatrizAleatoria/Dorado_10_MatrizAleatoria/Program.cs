using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_10_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        { 

            /*Llenar una matriz de n×m con valores 
             * aleatorios entre un rango dado (por ejemplo, 1 a 100). */
            Console.WriteLine("Ingrese N° de filas ");
            int F = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese N° de columnas ");
            int C = int.Parse(Console.ReadLine());
            int[,] matriz = new int[F, C];
            Random aleatorio = new Random();
            for (int I = 0; I < F; I++)
            {
                for (int J = 0; J < C; J++)
                {
                    matriz[I, J] = aleatorio.Next(1, 20);
                    Console.Write(matriz[I, J] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
