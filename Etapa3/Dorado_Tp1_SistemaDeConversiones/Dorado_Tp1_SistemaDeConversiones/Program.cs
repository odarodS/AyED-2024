using System;

namespace Dorado_Tp1_SistemaDeConversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número decimal para convertir a binario:");

            // Leer y convertir la entrada del usuario a un número entero.
            int decim = int.Parse(Console.ReadLine());

            // Llamar al método para convertir el número decimal a binario.
            string binario = DecimToBinario(decim);

            // Imprimir el resultado de la conversión.
            Console.WriteLine("La conversión es: " + binario);

            Console.ReadKey();
            Console.WriteLine("Ingrese un número binario para convertir a decimal:");
            string binari = Console.ReadLine();
            Console.WriteLine(decil(binari));
                Console.ReadKey();
        }

        static string DecimToBinario(int numero)
        {
            // Manejar el caso especial en el que el número es 0.
            if (numero == 0)
                return "0";

            // Inicializar la cadena para el número binario.
            string binario = "";

            // Realizar la conversión.
            while (numero > 0)
            {
                int division = numero % 2;
                binario = division + binario;
                numero = numero / 2;
            }

            return binario;
        }
        static int decil (string nume)
        {
            return Convert.ToInt32(nume, 2);
        }
    }
}
