using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 02"; 
            double nro;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese numero: ");
            nro =int.Parse(Console.ReadLine());
            
            while (nro == 0)
            {
                Console.Write("El numero debe ser mayor a 0. Reintente: ");
                nro =int.Parse(Console.ReadLine());
                
            }


            cuadrado = Math.Pow(nro, 2);
            cubo = Math.Pow(nro, 3);

            Console.Write("El numero seleccionado fue: {0}", nro);
            Console.Write("\n\nEl cuadrado del mismo es: {0}", cuadrado);
            Console.Write("\n\nEl cubo del mismo es: {0}", cubo);

            Console.ReadLine();
        }
    }
}

        
