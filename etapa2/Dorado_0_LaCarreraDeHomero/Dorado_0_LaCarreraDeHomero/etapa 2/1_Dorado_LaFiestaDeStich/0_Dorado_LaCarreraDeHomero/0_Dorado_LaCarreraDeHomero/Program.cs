using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Dorado_LaCarreraDeHomero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homero Simpson está participando en una carrera 
                        * de obstáculos.
                        *  Cada obstáculo tiene una dificultad diferente 
                        *  (representada por un número entero). 
                        *  Ayuda a Homero a calcular su puntaje total.
             El usuario ingresa la cantidad de obstáculos.
             Homero debe superar cada obstáculo y sumar los puntos correspondientes,
             cada obstáculo superado suma 10 puntos, cada obstáculo NO superado resta 5.
           (Debe aparecer un mensaje por cada obstáculo diciendo "OBSTACULO X, 
           lo supera?" y el usuario debe responder si o no) */

            Console.WriteLine(" Ingrese la cantidad de obstaculos ");
            int tamaño = int.Parse(Console.ReadLine());
            int[] CantObstac = new int[tamaño];
            for (int cont = 0; cont < CantObstac.Count(); cont++)
            {
                Console.WriteLine("Obstaculo " + (cont + 1) + " lo supera?");
                string respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    CantObstac[cont] = 10;
                    Console.WriteLine(CantObstac[cont]);
                }
                else if (respuesta == "no")
                {
                    CantObstac[cont] = -5;
                    Console.WriteLine(CantObstac[cont]);
                }
                else
                {
                    Console.WriteLine("ERROR");
                    cont-- ;
                }

                




            }
            int acumulador = 0;
            for (int cont = 0; cont < CantObstac.Count(); cont++)
            {
                acumulador += CantObstac[cont];
            }
            Console.WriteLine("Puntaje total " + acumulador);
            Console.ReadKey();
        }
    }
}
