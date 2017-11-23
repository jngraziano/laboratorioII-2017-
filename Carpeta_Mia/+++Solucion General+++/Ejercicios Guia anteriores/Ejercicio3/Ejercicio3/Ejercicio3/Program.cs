using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";

            
            //Console.Write("Ingrese numero: ");
            //int nro=Console.real

        int n, divisor, cont = 0;
        Console.Write("\n\nNúmeros primos del 2 al 100\n\n");
        for (n = 2; n <= 100; n++)
        {
            for (divisor = 2; n%divisor != 0; divisor++)
            {
                if (divisor == n)
                {
                    Console.Write("|{0}|", n);
                }

            }
        }
        Console.ReadKey();
        }
    }
}
