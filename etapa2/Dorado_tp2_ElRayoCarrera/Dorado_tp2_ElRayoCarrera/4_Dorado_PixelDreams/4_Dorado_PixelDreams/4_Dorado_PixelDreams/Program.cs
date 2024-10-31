using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Dorado_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            /* En la empresa de videojuegos "Pixel Dreams", 
             * se está organizando un torneo en línea de su juego más 
             * popular, "Galaxy Quest". Para determinar los ganadores, 
             * necesitan un programa que ordene los puntajes de los 
             * jugadores de mayor a menor.
El programa solicitará al usuario que ingrese la cantidad de participantes
en el torneo.Luego, pedirá al usuario que ingrese los puntajes de 
cada participante, uno por uno.Una vez ingresados todos los puntajes, 
el programa los ordenará de mayor a menor.Finalmente,
mostrará la lista de puntajes ordenados, indicando el primer lugar 
(mayor puntaje) y el último lugar (menor puntaje). */
            Console.WriteLine("Ingrese la cantidad de participantes");
            int CantParticipantes = int.Parse(Console.ReadLine());
            int [] Participantes = new int[CantParticipantes];
            for (int cont = 0; cont < Participantes.Count(); cont++)
            {
                Console.WriteLine("Ingrese el puntaje del participante N° " + (cont + 1));
                int Puntaje = int.Parse(Console.ReadLine());
                Participantes[cont] = Puntaje;
                
            }
                for (int cont = 0; cont < CantParticipantes - 1 - cont; cont++)
                { 
                    for (int j = 0; j < CantParticipantes - 1 - cont; j++)
                   {
                    if (Participantes[j] < Participantes[j + 1])
                    {
                        
                        int temp = Participantes[j];
                        Participantes[j] = Participantes[j + 1];
                        Participantes[j + 1] = temp; Console.ReadKey();
                    }  
                   }
                }
            Console.WriteLine("\nPuntajes ordenados de mayor a menor:");
            for (int cont = 0; cont < CantParticipantes; cont++)
            {
                Console.WriteLine("Lugar " + (cont + 1) + " " + (Participantes[cont]) + "puntos");
            }
            Console.WriteLine("\n" + " Primer lugar: " + (Participantes[0]) + " puntos");
            Console.WriteLine("Último lugar:" + (Participantes[CantParticipantes - 1]) + " puntos");
            Console.ReadKey();
        }
    }
}
        
