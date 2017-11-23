using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i,j;
            int ok=0;
            
            Console.Title = "Ejercicio03";

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numeros primos son:");
            for (i = 1; i <= numero; i++)
            {
                for (j = numero; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        ok++;
                    }
                }

                if(ok==2)
                    {
                        Console.WriteLine("{0}", i);
                    }
                ok = 0;
                }
            
          
            Console.ReadKey();
        }
    }
}
    