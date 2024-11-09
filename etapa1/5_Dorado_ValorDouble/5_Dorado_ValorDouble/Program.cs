using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dorado_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escriba un programa en C# que solicite el ancho (x) y la altura (y) de un rectángulo y
             *  calcule el perímetro, el área y la diagonal.
Perímetro= suma de los cuatro lados.
Área= base x altura.
Diagonal= Teorema de Pitágoras.*/
            Console.WriteLine("ingrese el ancho del rectangulo");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el alto del rectangulo");
            int y = int.Parse(Console.ReadLine());
            int Area = (x * y);
            int Perimetro = (x * x) + (y * y);
            double diagonal = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("El area es: " + Area + "y El perimetro es: " + Perimetro + "Por ultimo la diagonal da: " + diagonal);
            


            Console.ReadKey();

        }
    }
}
