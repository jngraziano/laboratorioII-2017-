using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05_con_Lista

{
    class Program
    {
        static void Main(string[] args)
        {

            Tempera tempera1 = new Tempera(ConsoleColor.Black, 1, "Pelikan");
            Tempera tempera2 = new Tempera(ConsoleColor.Blue, 2, "Pinturita");

            Paleta paleta1 = 3;

            paleta1 = paleta1 + tempera1;
            paleta1 = paleta1 + tempera2;

            paleta1 = paleta1 - tempera2;


            Paleta paleta2 = 2;

            Tempera tempera3 = new Tempera(ConsoleColor.Green, 3, "DuraAlba");

            paleta2 = paleta2 + tempera3;

            Paleta paleta3 = paleta1 + paleta2;

            string muestra = (string)paleta3;

            Console.WriteLine(muestra);

            Console.ReadKey();
        }
    }
}
