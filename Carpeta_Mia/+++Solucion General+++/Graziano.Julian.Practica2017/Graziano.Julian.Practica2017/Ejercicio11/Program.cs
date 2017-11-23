using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            /*11.Ingresar 10 números enteros que pueden estar dentro de un rango
                de entre 100 y -100.
                Para ello realizar una clase llamada ‗Validacion‘ que posea un
                método estático llamado Validar, que posea la siguiente firma:
                bool Validar(int, int, int).
                Terminado el ingreso mostrar el valor mínimo, el valor máximo y
                el promedio.
                Nota: Utilizar variables escalares, NO utilizar vectores.*/

            int aux = 5;//debe ser 10
            //int aux2 = -5; //debe ser -100
            bool devu;
            int rta=0,ax;
            int max=0;
            int min=999;

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine("\nIngrese un numero {0}: ", i + 1);
                ax=int.Parse(Console.ReadLine());
                devu=Validacion.Validar(ax,-100,100);
                if (devu == true)
                {
                    rta = ax;

                }
                else { Console.WriteLine("\nDebe ser mayor a -100 y menor a 100.");}
                Console.WriteLine("\n{0}", devu);
                if (rta > max)
                {
                    max = rta;
                
                }
                else if (rta < min)
                { min = rta; }
            }
           
                Console.WriteLine("\nmax: {0}", max);
                Console.WriteLine("\nmin: {0}", min);
            
            Console.ReadKey();
        }
    }
}
