using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Producto proDos = new Producto("Arroz", 1);
            Producto proUno = proDos + 22;

            Console.ReadLine();

        }
    }
}
