using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i,j;
            int acum=0;
            int acum2 = 0;
            Console.Title = "Ejercicio05";

            Console.Write("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros centrales son:");

            do
            {
                for (i = numero - 1; i > 0; i--)
                {
                    acum = acum + i;

                }

                for (j = numero + 1; j <= acum; j++)
                {
                    acum2 = acum2 + j;

                    if (acum == acum2)
                    {
                        Console.WriteLine("{0}", numero);
                        break;
                    }

                    if (acum2 > acum)
                    {
                        break;
                    }
                }

                numero--;
                acum = 0;
                acum2 = 0;

            } while (numero > 0);

            Console.ReadKey();

        }
    }
}
