using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_14_CalificacionesEstudian
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una matriz Nx3 donde cada fila representa 
             * un estudiante y cada columna contiene 
             * información como el nombre, la edad y la calificación.*/
            Console.WriteLine("Dime la cantidad de estudiantes hay ");
            int N = int.Parse(Console.ReadLine()); 
            string [,] matriz = new string[3,N];
            Console.WriteLine("ingrese el nombre, la edad y la calificacion");
            for (int c = 0; c < 3; c++)
            {
                for (int f = 0; f < N; f++)
                {
                    matriz[f, c] = Console.ReadLine();
                    
                }
            }
            Console.Clear();
            Console.WriteLine("nombre - edad - calificacion");
            for (int c = 0; c < 3; c++)
            {
                for (int f = 0; f < N; f++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
