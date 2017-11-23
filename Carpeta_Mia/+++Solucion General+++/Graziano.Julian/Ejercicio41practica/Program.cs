using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente1 = new Gerente("Garca",160,1.50F,"M");
            Empleado empleado1 = new Empleado("Copado", 70, 1.80F, "M");

            Console.WriteLine("GERENTE");
            Console.WriteLine(gerente1.Comer("Frito"));
            gerente1.Trabajar();
            Console.ReadKey();

            Console.WriteLine("\nEMPLEADO");
            Console.WriteLine(empleado1.Comer("Sano"));
            empleado1.Trabajar();
            Console.ReadKey();



        }
    }
}
