using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_tp2_AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir una función que calcule el área 
             * de un círculo(pi.(R.R)) y otra que calcule el volumen de un 
             * cilindro (pi . h . (R.R)) usando la primera función.*/
            Console.WriteLine("ingrese un Radio para calcular el area del circulo");
            int Radio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una altura para calcular el volumen del cilindro");
            int Altura = int.Parse(Console.ReadLine());
            double sumaV = CuentaVol(Altura, Altura);
            Console.WriteLine("El Area del circulo es " + CuentaA(Radio) + " Y El volumen de un cilindro es " + CuentaVol(Altura,Radio) );
            Console.ReadKey();
            

        }
        static double CuentaVol(int V, int R)
        {

            double VolCuenta = (CuentaA(R) * V);
            return VolCuenta;
        }
        static double CuentaA(int R)
        {
            double cuenta = (3.14 * (R*R));
            return cuenta; 
            //Return 0 devuelve la funcion arriba 
        }
        
    }
}
