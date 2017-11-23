using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int alt = 0;
            int i;
            int  j;
            int vCantAstericos = 1;
            string asteris = "*";

            Console.WriteLine("Ingrese alt: ");
            alt = int.Parse(Console.ReadLine());
            //alt = 5;
            //Console.ReadKey();
            Console.Clear();

            for (i = 1; i < alt; i++)
            {
                vCantAstericos += 2;
            }

            for (j = 1; j < vCantAstericos; j+=2)
            {
                if (j == 1) { Console.WriteLine(asteris);  }
                asteris += "**"; //cantidad de asteriscos representados en j//;
                Console.WriteLine("{0}", asteris);
            }

            
            Console.ReadKey();
        }
    }
}
