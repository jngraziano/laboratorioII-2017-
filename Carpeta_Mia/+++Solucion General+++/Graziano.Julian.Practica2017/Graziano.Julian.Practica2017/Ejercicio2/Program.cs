using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";
            int num;
            Console.WriteLine("INGRESE UN NUMERO: ");
            num = int.Parse(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("\nDebe ser mayor a cero. Reingrese: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\nCUADRADO Y CUBO: ");
            Console.WriteLine("\nCuadrado de {0}: {1}",num,Math.Pow(num,2));
            Console.WriteLine("\nCubo de {0}: {1}",num,Math.Pow(num,3));
            Console.ReadKey();

        }
    }
}
