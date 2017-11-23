using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miAuto = new Vehiculo(44);
            Console.WriteLine("Km recorridos {0}",(Double) miAuto);

        }
    }
}
