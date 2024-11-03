using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_12_RotarMatriz90
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rotar una matriz cuadrada n×n 90 grados en sentido horario.*/

            int[,] matriz = new int[3, 3];
            Random aleatorio = new Random();
            for (int I = 0; I < 3; I++)
            {
                for (int J = 0; J < 3; J++)
                {
                    matriz[I, J] = aleatorio.Next(1, 20);
                    Console.Write(matriz[I, J] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine(" rotada");
            for (int I = 0; I < 3; I++)
            {
                for (int J = 0; J < 3; J++)
                {
                    
                    Console.Write(matriz[I, J] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
