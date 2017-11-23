using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            char seguir;

            do
            {

                Console.Title = "Ejercicio06";

                Console.Write("Ingrese un anio:");
                anio = int.Parse(Console.ReadLine());

                if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 100 == 0 && anio % 400 == 0))
                {
                    Console.WriteLine("El anio {0} es bisiesto", anio);
                }
                else
                {
                    Console.WriteLine("El anio {0} NO es bisiesto", anio);
                }

                Console.WriteLine("Sigue? (s/n)");
                seguir = char.Parse(Console.ReadLine());

            } while (seguir == 's');

            Console.ReadKey();

        }
    }
}
