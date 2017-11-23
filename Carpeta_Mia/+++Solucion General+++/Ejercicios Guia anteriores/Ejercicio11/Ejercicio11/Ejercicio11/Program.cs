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
            bool valido;
            valido = Validacion.Validar(-900, -700,-110);


            Console.WriteLine(valido);
            Console.ReadLine();
            
        }
    }
}
