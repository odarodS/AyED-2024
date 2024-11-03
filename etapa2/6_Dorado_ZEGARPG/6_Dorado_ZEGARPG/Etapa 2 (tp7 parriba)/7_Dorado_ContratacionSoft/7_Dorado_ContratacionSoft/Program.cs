using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Dorado_ContratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Una empresa de desarrollo de software está en proceso de contratar un nuevo equipo para un proyecto importante. Durante el proceso de selección, necesitan un programa que ordene los puntajes obtenidos en un examen de menor a mayor, y luego filtre aquellos puntajes que sean múltiplos de un número dado.

El programa solicitará al usuario que ingrese la cantidad de 
candidatos que realizaron el examen.Luego, pedirá al usuario que 
ingrese los puntajes de cada candidato, uno por uno.Una vez ingresados
todos los puntajes, el programa los ordenará de menor a mayor.
Posteriormente, el programa solicitará al usuario que ingrese 
un número entero para filtrar los puntajes múltiplos de ese número.
Finalmente, mostrará al usuario la lista de puntajes ordenados y
los puntajes que son múltiplos del número especificado. */

            Console.WriteLine(" Ingrese la cantidad de personas que realizaron el examen ");
            int Examenes = int.Parse(Console.ReadLine());
            int[] CantUsuarios = new int[Examenes];
            Console.WriteLine(" Ingrese un numero para filtrar los puntajes multiplos de ese mismo numero ");
            int Filtro = int.Parse(Console.ReadLine());
            for (int Cont = 0; Cont < CantUsuarios.Count();Cont++ )
            {
                Console.WriteLine(" iNGRESE EL PUNTAJE DEL ALUMNO N°: "+ (Cont + 1));
                int Puntaje = int.Parse(Console.ReadLine());
                CantUsuarios[Cont] = Puntaje; 

            }
            for (int Cont = 0; Cont < CantUsuarios.Count() - 1; Cont++)
            {
                for (int j = 0; j < CantUsuarios.Count() - 1 -  Cont; j++)
                {
                    
                    if (CantUsuarios[j] < CantUsuarios[j + 1])
                    {
                        int aux = CantUsuarios[j];
                          CantUsuarios[j] = CantUsuarios[j + 1];
                        CantUsuarios[j + 1] = aux;



                    } 
                   
                }
            }
            for (int Cont = 0; Cont < CantUsuarios.Count(); Cont++)
            {
                Console.WriteLine(" Puntajes: "+ CantUsuarios[Cont] );
                
            }
                Console.ReadKey();
        }
    }
}
