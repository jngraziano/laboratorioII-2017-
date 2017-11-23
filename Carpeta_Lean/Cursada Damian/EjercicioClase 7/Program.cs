using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Tempera tempera1 = new Tempera(ConsoleColor.Blue, 3, "Pato feo");


            Paleta paleta1 = new Paleta(3);

            paleta1[0] = tempera1;

            Console.WriteLine((string)paleta1);

            Console.WriteLine(Tempera.Mostrar(paleta1[0]));

            Console.ReadKey();

            Console.WriteLine(Tempera.Mostrar(paleta1[5]));

            Console.ReadKey();
        }
    }
}
