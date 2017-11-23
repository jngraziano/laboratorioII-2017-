using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio01";

            int numero;
            int max=0;
            int min=0;
            int flag = 0;
            int flag2=0;
            int acum=0;
            float promedio;
            int i = 0;

            for ( i = 0; i < 5; i++)
            {

                Console.Write("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());


                if (flag == 0 || numero > max)
                {
                    max = numero;
                    flag = 1;
                }


                if (flag2 == 0 || numero < min)
                {
                    min = numero;
                    flag2 = 1;
                }

                acum = acum + numero;
            }

              promedio=(float)acum/i;

              Console.WriteLine("El maximo es:{0}\nEl minimo es:{1}\nEl promedio es:{2:#,###.00}", max, min, promedio);
            
            Console.ReadLine();
            

        }
    }
}
