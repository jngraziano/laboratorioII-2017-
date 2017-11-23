using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    class Valor1
    {
        public static int Validar(int a)
        {
            while (a == 0)
            {
                Console.WriteLine("\nReingrese: ");
                a = int.Parse(Console.ReadLine());
            }
            return a;
        
        }

    }
}
