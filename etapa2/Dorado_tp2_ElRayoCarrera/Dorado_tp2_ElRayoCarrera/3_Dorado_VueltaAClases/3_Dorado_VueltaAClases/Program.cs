using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Dorado_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Después de unas largas vacaciones llenas de aventuras, 
             * Phineas y Ferb regresan a la escuela. Sin embargo, 
             * como no estudiaron durante las vacaciones, 
             * necesitan un sistema que les ayude a determinar 
             * si podrán aprobar la materia.
El sistema debe permitir a Phineas y Ferb ingresar la cantidad de trabajos prácticos (TPs)
 y exámenes que tienen en la materia
. Luego, deben ingresar las notas de cada TP y examen.
Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:
El promedio de las notas de los exámenes debe ser mayor o igual a 6.
Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
El sistema debe calcular el promedio de los exámenes y verificar
si se cumplen las condiciones para aprobar la materia. Finalmente,
debe mostrar en pantalla un mensaje indicando si Phineas y Ferb 
pueden aprobar la materia o no.
Permitir al usuario especificar la cantidad de TPs y exámenes.
Permitir al usuario ingresar las notas de cada TP y examen.
Calcular el promedio de las notas de los exámenes.
Verificar si se cumplen las condiciones para aprobar la materia.
Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia. */
            Console.WriteLine("Ingrese la cantidad de trabajos que hay en la materia");
            int CantTrabajos = int.Parse(Console.ReadLine());
            int[] Trabajos = new int[CantTrabajos];
            for (int cont = 0; cont < Trabajos.Count(); cont++)
            {
                Console.WriteLine("Ingrese la nota que saco en los trabajos ");
                Console.WriteLine("Trabajo N° " + (cont + 1));
                int NotaTrabajos = int.Parse(Console.ReadLine());
                if (NotaTrabajos >= 1 && NotaTrabajos <= 10)
                {
                    Trabajos[cont] += NotaTrabajos;
                }
                else
                {
                    Console.WriteLine("Error, Por favor ingrese un numero entre 1 y 10");
                    cont--;
                }

            }
            Console.WriteLine("Ingrese la cantidad de examenes que hay");
            int CantExamenes = int.Parse(Console.ReadLine());
            int[] Examenes = new int[CantExamenes];
            for (int cont = 0; cont < Examenes.Count(); cont++)
            {
                Console.WriteLine("Ingrese la nota que saco en los examenes ");
                Console.WriteLine("Examen N° " + (cont + 1));
                int NotaExamenes = int.Parse(Console.ReadLine());
                if (NotaExamenes >= 1 && NotaExamenes <= 10)
                {
                    Examenes[cont] += NotaExamenes;
                }
                else
                {
                    Console.WriteLine("Error, Por favor ingrese un numero entre 1 y 10");
                    cont--;
                }
            }
            int TpsAprobados = 0;
            for (int cont = 0; cont < Trabajos.Count(); cont++)
            {

                if (Trabajos[cont] >= 6)
                {
                    TpsAprobados ++;
                }

            }

            int NotaExamTotal = 0;
            for (int cont = 0; cont < Examenes.Count(); cont++)
            {
                  NotaExamTotal += Examenes[cont] ;
            }
            double promedioExamenes = (NotaExamTotal / CantExamenes);
            double NotaTps = (TpsAprobados * 100 / CantTrabajos);


            

             
            if (promedioExamenes >= 6 && NotaTps >= 75)
            {
                Console.WriteLine(promedioExamenes);
                Console.WriteLine(NotaTps+"%");
                Console.WriteLine("Usted ha aprobado, sacó 6 o más");
            }
            else
            {
                Console.WriteLine(promedioExamenes);
                Console.WriteLine(NotaTps+"%");
                Console.WriteLine("Usted no ha aprobado, sacó menos de 6");
            }

            
            Console.ReadKey();
        }
    }
}
