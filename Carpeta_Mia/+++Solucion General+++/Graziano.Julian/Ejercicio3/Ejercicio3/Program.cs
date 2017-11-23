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
            int alt = 0;
            int i, j;

            
            Console.WriteLine("ingrese altura: ");
            alt = int.Parse(Console.ReadLine());
            for (i = 0; i < alt; i++)
            
            {
                Console.WriteLine("Numero ingresado: {0}", alt);
                Console.ReadKey();

                Console.WriteLine("*\n");
            
            }
            Console.ReadKey();
        }
    }
}
