using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado, cubo;
            
            Console.Title = "Ejercicio02";

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero == 0)
            {
                Console.WriteLine("ERROR, Reingrese un numero distinto de 0:");
                numero = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado es:{0:#.###}\nEl cubo es:{1:#.###}", cuadrado, cubo);

            Console.ReadKey();




        }
    }
}
