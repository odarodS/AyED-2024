using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dorado_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Durante el evento de ventas "Hot Sale", 
             * una tienda en línea desea conocer cuál fue el producto más 
             * caro y 
             * el más económico que se vendió durante el evento.

El programa solicitará al usuario que ingrese la 
cantidad de productos vendidos durante el Hot Sale.
Luego, pedirá al usuario que ingrese el precio de cada producto, 
uno por uno.Una vez ingresados todos los precios, 
el programa determinará cuál fue el precio más alto y 
cuál fue el precio más bajo.Finalmente, 
mostrará al usuario los precios más alto y 
más bajo registrados durante el evento.*/
            Console.WriteLine(" Ingrese la cantidad de productos vendidos ");
            int ProductosVendidos = int.Parse(Console.ReadLine());
            int[] Productos = new int[ProductosVendidos];
            for(int contador = 0; contador < Productos.Count(); contador++ )
            {
                Console.WriteLine("Ingrese el precio del producto n° " +(contador+1));
                int PrecioProduc = int.Parse(Console.ReadLine());
                Productos[contador] = PrecioProduc;
            }
            for (int contador = 0; contador < Productos.Count()-1; contador++)
            {
                for (int j = 0; j < Productos.Count() - 1 - contador; j++)
                {
                    if (Productos[j] < Productos[j + 1])
                    {
                        int aux = Productos[j];
                        Productos[j] = Productos[j + 1];
                        Productos[j + 1] = aux;
                    }
                }
            }

            for (int contador = 0; contador < Productos.Count(); contador++)
            {
                Console.WriteLine("  " + Productos[contador]+"$");
            }
            Console.WriteLine("El producto mas caro es: " + Productos[0]);
            Console.WriteLine("El producto mas barato es: " + Productos[Productos.Count() - 1]);
                Console.ReadKey();
        }
    }
}
