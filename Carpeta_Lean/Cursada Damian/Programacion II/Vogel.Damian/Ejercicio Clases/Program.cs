using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
        if(!Validadora.ValidarNumeros(5,-50,100))
            {
                Console.Write("Fuera de rango");
            }
        else
        {
            Console.Write("Dentro del rango");
        }
        Console.ReadKey();
        }
    }
}