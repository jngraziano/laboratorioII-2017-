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

            Console.Title = "Ejercicio Nro. 1";
            //class Ejercicio01;

           
            int i = 0;
            int numero1 = 0;
            int max = 0;
            int min = 0;
            int acum = 0;
            int flag = 0;

            

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero 1");
                numero1 = int.Parse(Console.ReadLine());

                if (flag == 0)
                     {
                        min = numero1;
                        flag = 1;
                     }
                
                if (numero1 > max)
                    {
                        max = numero1;
                    }

                if (numero1 < min)
                    {
                        min = numero1;
                    }

                acum += numero1;

            }

            float promedio = (float)acum / 5;

            Console.WriteLine("El promedio es:{0}",promedio);
            Console.WriteLine("El mayor fue: {0}",max);
            Console.WriteLine("El menor fue: {0}",min);
            Console.ReadLine();

        
        }
    }
}
