using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_tp2_ElRayoCarrera
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El Rayo McQueen está compitiendo en una carrera de alta 
             * velocidad. Necesita un programa en C# que le ayude a 
             * registrar los 
             * tiempos de cada vuelta y calcular algunas estadísticas 
             * importantes. 

El programa debe:
Permitir a Rayo McQueen ingresar los tiempos de cada vuelta de la carrera 
en segundos. Utiliza un array para almacenar estos tiempos.
Calcular y mostrar en pantalla el tiempo total de la carrera.
Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, 
la vuelta con el menor tiempo registrado.
El programa debe permitir al usuario ingresar la cantidad de vueltas 
que completó Rayo McQueen y luego ingresar los tiempos de cada vuelta. 
Al finalizar, mostrará las estadísticas calculadas. */
            Console.WriteLine("ingrese la cantidad de vueltas");
            int vueltas = int.Parse(Console.ReadLine());
            int[] CantVueltas = new int[vueltas];
            for (int cont = 0 ; cont < CantVueltas.Count(); cont++)
            {
                Console.WriteLine("Ingrese el tiempo de cada una de las vueltas " + (cont+1));
                int tiempo  = int.Parse(Console.ReadLine());
                CantVueltas[cont] = tiempo; 
            }
            int Total = 0;
            int mejorvuelta = 100;
            for (int cont = 0; cont < CantVueltas.Count(); cont++)
            {

                Total += CantVueltas[cont];
               

            }
            for (int cont = 0; cont < CantVueltas.Count(); cont++)
            {
                if (CantVueltas[cont] < mejorvuelta)

                {
                    mejorvuelta = CantVueltas[cont];
                }
            }

                Console.WriteLine("El tiempo total de la carrera es " + Total + " segundos");
            Console.WriteLine(" La mejor vuelta por el menor tiempo fue " + mejorvuelta);
            Console.WriteLine("El promedio de tiempo por vuelta es " + (Total / vueltas + " segundos"));
                Console.ReadKey();
        }
    }
}
