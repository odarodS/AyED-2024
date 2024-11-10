using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3_Dorado_Puchimoones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pochidex = new int[75, 6]; // Matriz para almacenar los Pochimons
            string[] nombresPochimons = new string[75]; // Array para almacenar los nombres de los Pochimons
            int pochimons = 0;
            bool band = true;
            Random random = new Random();

            while (band)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Pochimones Encontrados: " + pochimons + "/75" + "\n");
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ingrese la opción deseada: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (pochimons >= 75)
                        {
                            Console.WriteLine("Ya no queda espacio en el Pochidex.");
                            break;
                        }
                        Console.Write("Ingrese el nombre del Pochimon: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                        char tipo = char.Parse(Console.ReadLine());

                        Console.Write("Ingrese el nivel del Pochimon: ");
                        int nivel = int.Parse(Console.ReadLine());

                        pochidex[pochimons, 0] = pochimons;
                        nombresPochimons[pochimons] = nombre;
                        pochidex[pochimons, 2] = tipo;
                        pochidex[pochimons, 3] = nivel;
                        pochidex[pochimons, 4] = 0; // Estado inicial
                        pochidex[pochimons, 5] = 0; // Investigador no asignado
                        Console.WriteLine("El Pochimon se ha registrado.");
                        Console.ReadLine();
                        pochimons++;
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("|Fila|   Nombre   | Tipo   | Nivel   |Estado|Investigador Asignado| \n");
                        for (int i = 0; i < pochimons; i++)
                        {
                            Console.WriteLine(
                                i + "\t" +
                                nombresPochimons[i] + "\t" +
                                (char)pochidex[i, 2] + "\t" +
                                pochidex[i, 3] + "\t" +
                                pochidex[i, 4] + "\t" +
                                pochidex[i, 5]
                            );
                        }

                        Console.Write("Ingrese el ID del Pochimon al que desea asignar un investigador: ");
                        int idAsignar = int.Parse(Console.ReadLine());

                        if (idAsignar >= 0 && idAsignar < pochimons && pochidex[idAsignar, 4] == 0)
                        {
                            Console.Write("Ingrese el código del Investigador: ");
                            int investigador = int.Parse(Console.ReadLine());
                            pochidex[idAsignar, 4] = 1; // Cambia estado a "En investigación"
                            pochidex[idAsignar, 5] = investigador;
                            Console.WriteLine(nombresPochimons[idAsignar] + " ha sido asignado al Investigador " + investigador + ".");
                        }
                        else
                        {
                            Console.WriteLine("ID inválido o el Pochimon ya está siendo investigado.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("|Fila|   Nombre   | Tipo   | Nivel   |Estado|Investigador Asignado| \n");
                        for (int i = 0; i < pochimons; i++)
                        {
                            Console.WriteLine(
                                i + "\t" +
                                nombresPochimons[i] + "\t" +
                                (char)pochidex[i, 2] + "\t" +
                                pochidex[i, 3] + "\t" +
                                pochidex[i, 4] + "\t" +
                                pochidex[i, 5]
                            );
                        }

                        Console.Write("Ingrese el ID del Pochimon al que desea aumentar el nivel: ");
                        int idActualizar = int.Parse(Console.ReadLine());

                        if (idActualizar >= 0 && idActualizar < pochimons)
                        {
                            int incremento = random.Next(1, 4); // Aumenta el nivel en un número aleatorio entre 1 y 3
                            pochidex[idActualizar, 3] += incremento;
                            Console.WriteLine("El nivel de " + nombresPochimons[idActualizar] + " ha sido aumentado en " + incremento + ".");
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Pochimons en estado de investigación:");
                        for (int i = 0; i < pochimons; i++)
                        {
                            if (pochidex[i, 4] == 1) // Filtra por Pochimons en investigación
                            {
                                Console.WriteLine(
                                    i + "\t" +
                                    nombresPochimons[i] + "\t" +
                                    (char)pochidex[i, 2] + "\t" +
                                    pochidex[i, 3] + "\t" +
                                    pochidex[i, 4] + "\t" +
                                    pochidex[i, 5]
                                );
                            }
                        }

                        Console.Write("Ingrese el ID del Pochimon que desea marcar como investigado: ");
                        int idMarcar = int.Parse(Console.ReadLine());

                        if (idMarcar >= 0 && idMarcar < pochimons && pochidex[idMarcar, 4] == 1)
                        {
                            pochidex[idMarcar, 4] = 2; // Cambia estado a "Investigado"
                            Console.WriteLine("El Pochimon " + nombresPochimons[idMarcar] + " ha sido marcado como investigado.");
                        }
                        else
                        {
                            Console.WriteLine("ID inválido o el Pochimon no está en investigación.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("|Fila|   Nombre   | Tipo   | Nivel   |Estado|Investigador Asignado| \n");
                        for (int i = 0; i < pochimons; i++)
                        {
                            Console.WriteLine(
                                i + "\t" +
                                nombresPochimons[i] + "\t" +
                                (char)pochidex[i, 2] + "\t" +
                                pochidex[i, 3] + "\t" +
                                pochidex[i, 4] + "\t" +
                                pochidex[i, 5]
                            );
                        }
                        break;

                    case 6:
                        Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
                        char tipoBuscar = char.Parse(Console.ReadLine().ToUpper());

                        Console.WriteLine("Pochimons de tipo " + tipoBuscar + ":");
                        Console.WriteLine("|Fila|   Nombre   | Tipo   | Nivel   |Estado|Investigador Asignado| \n");
                        for (int i = 0; i < pochimons; i++)
                        {
                            if (pochidex[i, 2] == tipoBuscar)
                            {
                                Console.WriteLine(
                                    i + "\t" +
                                    nombresPochimons[i] + "\t" +
                                    (char)pochidex[i, 2] + "\t" +
                                    pochidex[i, 3] + "\t" +
                                    pochidex[i, 4] + "\t" +
                                    pochidex[i, 5]
                                );
                            }
                        }
                        break;

                    case 7:
                        Console.Write("Ingrese el código del Investigador: ");
                        int investigadorBuscar = int.Parse(Console.ReadLine());

                        Console.WriteLine("Pochimons asignados al Investigador " + investigadorBuscar + ":");
                        Console.WriteLine("|Fila|   Nombre   | Tipo   | Nivel   |Estado|Investigador Asignado| \n");
                        for (int i = 0; i < pochimons; i++)
                        {
                            if (pochidex[i, 5] == investigadorBuscar)
                            {
                                Console.WriteLine(
                                    i + "\t" +
                                    nombresPochimons[i] + "\t" +
                                    (char)pochidex[i, 2] + "\t" +
                                    pochidex[i, 3] + "\t" +
                                    pochidex[i, 4] + "\t" +
                                    pochidex[i, 5]
                                );
                            }
                        }
                        break;

                    case 8:
                        Console.WriteLine("Pochimons con nivel mayor a 30:");
                        Console.WriteLine("|Fila|   Nombre   | Tipo   | Nivel   |Estado|Investigador Asignado| \n");
                        for (int i = 0; i < pochimons; i++)
                        {
                            if (pochidex[i, 3] > 30) // Filtrar por nivel mayor a 30
                            {
                                Console.WriteLine(
                                    i + "\t" +
                                    nombresPochimons[i] + "\t" +
                                    (char)pochidex[i, 2] + "\t" +
                                    pochidex[i, 3] + "\t" +
                                    pochidex[i, 4] + "\t" +
                                    pochidex[i, 5]
                                );
                            }
                        }
                        break;

                    case 9:
                        band = false;
                        Console.WriteLine("Aprete cualquier tecla para terminar el programa.");
                        Console.ReadKey();
                        break;


                }
            }
        }
    }
}
