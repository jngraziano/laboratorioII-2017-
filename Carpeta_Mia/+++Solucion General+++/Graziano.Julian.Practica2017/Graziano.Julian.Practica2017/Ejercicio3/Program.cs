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
            /*
             * Mostrar por pantalla todos los números primos que haya hasta el
               número que ingrese el usuario por consola.
               Nota: Utilizar estructuras repetitivas, selectivas y la función
               módulo (%)
             */
            int num;
            Console.WriteLine("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
                if (i % 3 == 0)
                    Console.Write("{0}\t", i);
            Console.ReadKey();
        }
    }
}
