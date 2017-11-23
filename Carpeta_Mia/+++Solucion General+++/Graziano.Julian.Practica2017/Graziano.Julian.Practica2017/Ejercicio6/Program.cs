using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100
            no son bisiestos, salvo si ellos también son múltiplos de 400.
            Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Nota: Utilizar estructuras repetitivas, selectivas y la función
            módulo (%).
          */
            int año;
            int flag = 0 ;
            int flag2 = 0;

            Console.Title = "Ejercicio 6";
            Console.WriteLine("Ingrese año: ");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
            {
                flag = 1;
            }
            else { flag = 0; }
            
            if (año % 100 == 0 && año % 400 == 0 || flag == 1)
            {
                flag2 = 1;
            
            }
            else { flag2 = 0; }
            
            if (flag == 1 && flag2 == 1)
            {
                Console.WriteLine("\nEl año es bisiesto");

            }
            else { Console.WriteLine("\nEl año no es bisiesto"); }

            Console.ReadKey();
        }
    }
}
