using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_8_VectorRandomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El objetivo de este ejercicio es crear un programa que 
             * utilice un vector, números aleatorios generados con 
             * la función Random y una estructura de control switch para 
             * realizar las siguientes acciones:

1)  Se crea un vector de tamaño n, donde n es un valor ingresado por el
usuario.
2)  Se utiliza la función Random para generar números aleatorios entre 
un rango definido y se llenan las posiciones del vector con estos valores.
3)  Se presenta al usuario un menú con las siguientes opciones:
Imprime en pantalla todos los elementos del vector.
El usuario ingresa un número y el programa busca si este se encuentra en el
vector. Si lo encuentra, se indica la posición en la que se encuentra.
Se ordena el vector de forma ascendente o descendente, 
según la elección del usuario.
Termina la ejecución del programa.
El programa utiliza la estructura de control switch para evaluar la
opción seleccionada por el usuario y ejecutar la acción correspondiente. */

            Console.WriteLine(" Ingrese un valor para el vector");
            int n = int.Parse(Console.ReadLine());
            int[] ValorN = new int[n];
            Random aleatorio = new Random();
            for (int cont = 0; cont < ValorN.Count(); cont++)
            {
                ValorN[cont] = aleatorio.Next(1, 10);
            }
            Console.WriteLine("\n  seleccionar una opcion:");
            Console.WriteLine("1) imprimir todos los elementos del vector ");
            Console.WriteLine("2) buscar un numero en el vector");
            Console.WriteLine("3) Ordenar el vector");
            Console.WriteLine("4) TERMINAR EL PROGRAMA");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("imprimir todos los elementos del vector");
                    for (int cont = 0; cont < ValorN.Count(); cont++)
                    {
                        Console.WriteLine(ValorN[cont]);
                    }
                    break;
                case 2:
                    Console.WriteLine("ingrese el numero que busca en el vector");
                    int Numero = int.Parse(Console.ReadLine());
                    for (int cont = 0; cont < ValorN.Count(); cont++)
                    {
                        if (Numero == ValorN[cont])
                        {
                            Console.WriteLine("Ese numero si esta en el vector en casilla " + (cont+1));
                        }
                        else
                        {
                            Console.WriteLine("Ese numero no esta en el vector en casilla " + cont);

                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("ingrese el tipo de orden ascendente o descendente");
                    string Orden = Console.ReadLine();
                    if (Orden == "ascendente")
                    { 
                        for (int cont = 0; cont < ValorN.Count() - 1; cont++)
                        {
                           for ( int j = 0; j < ValorN.Count() - cont - 1 ; j++)
                            {
                                if (ValorN[j] < ValorN[j + 1]);
                                {
                                    int aux = ValorN[j];
                                    ValorN[j] = ValorN[j + 1];
                                    ValorN[j + 1] = aux;
                                    
                                }
                                
                            }
                            
                        }
                        for (int cont = 0; cont < ValorN.Count(); cont++)
                        {
                            Console.WriteLine(ValorN[cont]);
                        }


                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
