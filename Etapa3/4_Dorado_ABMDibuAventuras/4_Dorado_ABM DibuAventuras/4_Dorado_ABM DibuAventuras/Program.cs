using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Dorado_ABM_DibuAventuras
{
    internal class Program
    {
        static string CrearPersonaje(object[,] personajes)
        {
            Console.Clear();
            bool esValido = false;
            int slot = 0;

            while (!esValido)
            {
                Console.Write("Elige el N° de Espacio (0-19): ");
                string inputSlot = Console.ReadLine();
                esValido = int.TryParse(inputSlot, out slot);

                if (esValido)
                {
                    if (slot >= 0 && slot < 20 && personajes[slot, 0] == null)
                    {
                        esValido = true;
                    }
                    else
                    {
                        esValido = false;
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                }
            }

            Console.Write("\nNombre del personaje: ");
            string nombre = Console.ReadLine().Trim();
            Console.Write("\nSerie del personaje: ");
            string serie = Console.ReadLine().Trim();

            int fuerza = 0;
            bool fuerzaOk = false;
            while (!fuerzaOk)
            {
                Console.Write("\nNivel de fuerza: ");
                string inputFuerza = Console.ReadLine().Trim();
                fuerzaOk = int.TryParse(inputFuerza, out fuerza);

                if (!fuerzaOk)
                {
                    Console.Clear();
                }
            }

            int defensa = 0;
            bool defensaOk = false;
            while (!defensaOk)
            {
                Console.Write("\nNivel de defensa: ");
                string inputDefensa = Console.ReadLine().Trim();
                defensaOk = int.TryParse(inputDefensa, out defensa);

                if (!defensaOk)
                {
                    Console.Clear();
                }
            }

            bool esHeroe = false;
            bool respuestaOk = false;
            while (!respuestaOk)
            {
                Console.Write("\n¿Es un héroe? (Sí/No): ");
                string inputHeroe = Console.ReadLine().ToLower().Trim();

                if (inputHeroe == "si" || inputHeroe == "no")
                {
                    respuestaOk = true;
                    esHeroe = inputHeroe == "si";
                }
                else
                {
                    Console.Clear();
                }
            }

            personajes[slot, 0] = nombre;
            personajes[slot, 1] = serie;
            personajes[slot, 2] = fuerza;
            personajes[slot, 3] = defensa;
            personajes[slot, 4] = esHeroe;

            Console.Clear();
            return "Personaje agregado con éxito!";
        }

        static void MostrarEncabezado()
        {
            Console.WriteLine("Nombre\t\t| Serie\t| Fuerza\t| Defensa\t| Héroe\t|");
        }

        static void MostrarPersonaje(object[,] personajes, int i)
        {
            Console.WriteLine($"{personajes[i, 0]}\t| {personajes[i, 1]}\t | {personajes[i, 2]}\t | {personajes[i, 3]}\t | {personajes[i, 4]}");
        }

        static string ConsultarPersonaje(object[,] personajes)
        {
            Console.Write("Buscar personaje por nombre: ");
            string nombreBuscado = Console.ReadLine().Trim();
            Console.Clear();

            MostrarEncabezado();
            for (int i = 0; i < 20; i++)
            {
                if (personajes[i, 0] != null && personajes[i, 0].ToString() == nombreBuscado)
                {
                    MostrarPersonaje(personajes, i);
                }
            }
            Console.WriteLine("\nPresiona cualquier tecla para continuar");
            Console.ReadKey();
            return "";
        }

        static string ModificarPersonaje(object[,] personajes)
        {
            bool encontrado = false;
            int posicion = 0;

            while (!encontrado)
            {
                Console.Clear();
                MostrarEncabezado();
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null)
                    {
                        MostrarPersonaje(personajes, i);
                    }
                }

                Console.Write("\nNombre del personaje a modificar: ");
                string nombre = Console.ReadLine().Trim();
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null && personajes[i, 0].ToString() == nombre)
                    {
                        posicion = i;
                        encontrado = true;
                        break;
                    }
                }
            }

            int nuevaFuerza = 0;
            bool fuerzaValida = false;
            while (!fuerzaValida)
            {
                Console.Write("Nueva fuerza: ");
                string inputFuerza = Console.ReadLine().Trim();
                fuerzaValida = int.TryParse(inputFuerza, out nuevaFuerza);
            }

            int nuevaDefensa = 0;
            bool defensaValida = false;
            while (!defensaValida)
            {
                Console.Write("Nueva defensa: ");
                string inputDefensa = Console.ReadLine().Trim();
                defensaValida = int.TryParse(inputDefensa, out nuevaDefensa);
            }

            personajes[posicion, 2] = nuevaFuerza;
            personajes[posicion, 3] = nuevaDefensa;
            return "";
        }

        static string EliminarPersonaje(object[,] personajes)
        {
            int posicion = 0;
            bool encontrado = false;

            while (!encontrado)
            {
                Console.Clear();
                MostrarEncabezado();
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null)
                    {
                        MostrarPersonaje(personajes, i);
                    }
                }

                Console.Write("\nNombre del personaje a eliminar: ");
                string nombre = Console.ReadLine().Trim();
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null && personajes[i, 0].ToString() == nombre)
                    {
                        posicion = i;
                        encontrado = true;
                        break;
                    }
                }
            }

            for (int j = 0; j < 5; j++)
            {
                personajes[posicion, j] = null;
            }
            return "";
        }

        static string OrdenarAlfabeticamente(object[,] personajes)
        {
            List<string> nombres = new List<string>();

            for (int i = 0; i < 20; i++)
            {
                if (personajes[i, 0] != null)
                {
                    nombres.Add(personajes[i, 0].ToString());
                }
            }

            nombres.Sort();
            int index = 0;

            foreach (string nombre in nombres)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (personajes[i, 0] != null && nombre == personajes[i, 0].ToString())
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            object temp = personajes[i, j];
                            personajes[i, j] = personajes[index, j];
                            personajes[index, j] = temp;
                        }
                        index++;
                    }
                }
            }
            return "";
        }

        static void Main(string[] args)
        {
            object[,] personajes = new object[20, 5];
            bool ejecutando = true;

            while (ejecutando)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Agregar Personaje");
                Console.WriteLine("2. Buscar Personaje");
                Console.WriteLine("3. Modificar Personaje");
                Console.WriteLine("4. Eliminar Personaje");
                Console.WriteLine("5. Mostrar Personajes");
                Console.WriteLine("--------------------------------------");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine().Trim();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine(CrearPersonaje(personajes));
                        break;
                    case "2":
                        Console.Clear();
                        ConsultarPersonaje(personajes);
                        break;
                    case "3":
                        ModificarPersonaje(personajes);
                        break;
                    case "4":
                        Console.Clear();
                        EliminarPersonaje(personajes);
                        break;
                    case "5":
                        Console.Clear();
                        OrdenarAlfabeticamente(personajes);
                        MostrarEncabezado();
                        for (int i = 0; i < 20; i++)
                        {
                            if (personajes[i, 0] != null)
                            {
                                MostrarPersonaje(personajes, i);
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
