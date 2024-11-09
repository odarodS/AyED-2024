using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Dorado_TblaMult
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa en C# que pregunte al usuario por un número x y 
             * muestre el resultado de su tabla de multiplicar del 1 al 10.*/
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            int PorUno = (numero * 1);
            int PorDos = (numero * 2);
            int PorTres = (numero * 3);
            int PorCuatro = (numero * 4);
            int PorCinco = (numero * 5);
            int PorSeis = (numero * 6);
            int PorSiete = (numero * 7);
            int PorOcho = (numero * 8);
            int PorNueve = (numero * 9);
            int PorDiez = (numero * 10);
            Console.WriteLine("Su tabla de multipilicar es " + "\n " + PorUno + "\n " + PorDos + "\n " + PorTres + "\n " + PorCuatro + "\n " + PorCinco + "\n " + PorSeis + "\n " + PorSiete + "\n " + PorOcho + "\n " + PorNueve + "\n " + PorDiez); 
            Console.ReadKey();
        }
    }
}
