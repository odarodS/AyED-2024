using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_9_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        { /*Crear una matriz de n×m con todos sus elementos inicializados 
            a cero.  Imprimirla por pantalla
n y m son datos que ingresa el usuario*/

            Console.WriteLine("Ingrese N° de filas ");
            int F = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese N° de columnas ");
            int C = int.Parse(Console.ReadLine());
            int[,] matriz = new int[F, C];
            for(int I = 0; I < F; I++)
            {
                for(int J=0; J < C; J++)
                {
                    Console.Write(matriz[I, J] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
