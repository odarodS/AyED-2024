using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorado_18_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que pregunte una y 
             * otra vez si desea terminar el programa, salvo si 
             * se contesta exactamente SI (en mayúsculas y sin tilde).*/
            string Respuesta = "SI";
            bool Consola = true;
            while (Consola == true  )
            {
                Console.WriteLine(" ¿Quiere cerrar el programa?(SI para confirmar) ");
                string Cerrar = Console.ReadLine();
                if ( Cerrar == Respuesta)
                {
                    Consola = false;
                    
                }
              
                

            }
            
        }
    }
}
