using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int acum=0;
            int cont = 0;

            Console.Title = "Ejercicio04";

            for (i = 1; cont < 5; i++)
            {
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acum = acum + j;
                    }
                }
                    if (acum == i && cont<=4)
                    {
                        cont++;
                        Console.WriteLine("{0}", acum);
                    }
                
                acum = 0;
            }

            Console.ReadKey();


        }
    }
}
