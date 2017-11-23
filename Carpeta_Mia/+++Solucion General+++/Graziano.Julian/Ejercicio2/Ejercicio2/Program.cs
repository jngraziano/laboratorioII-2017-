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
            double num;
            double cubo=0;
            double cuadr=0;

            Console.WriteLine("ingrese: ");
            num=int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Error. Debe ser mayor igual a 0: ");
                num = double.Parse(Console.ReadLine());
            }
            else
            {
                cuadr = Math.Pow(num, 2);
                cubo = Math.Pow(num, 3);
            
            }

            //Console.WriteLine("Hasta cargo los resultados");
            //Console.ReadKey();
            Console.WriteLine("Cuadrado: {0}", cuadr);
            Console.WriteLine("\nCubo: {0}", cubo);
            Console.ReadKey();
        }
    }
}
