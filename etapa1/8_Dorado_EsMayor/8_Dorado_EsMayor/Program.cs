﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Dorado_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escribir un programa que pregunte al usuario su edad
             *  y muestre por pantalla si es mayor de edad o no.*/
            Console.WriteLine("Ingrese su edad para comprobar si es mayor ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine(" Sos mayor de edad ");
            }
            
                else
            {
                Console.WriteLine(" Sos menor de edad ");
            }
             
            Console.ReadKey();
        }
    }
}
