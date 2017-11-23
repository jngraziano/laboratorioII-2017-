using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class Program
    {
        static void Main(string[] args)
        {


            Tempera tem1 = new Tempera(ConsoleColor.Black,  3,"     COLORSHOP");
            Tempera tem2 = new Tempera(ConsoleColor.Blue,   4,"     PINTUSA");
            Tempera tem3 = new Tempera(ConsoleColor.Cyan,  55,"     ALBA");

            Console.WriteLine(Tempera.Mostrar(tem1));
            Console.WriteLine(Tempera.Mostrar(tem2));
            Console.WriteLine(Tempera.Mostrar(tem3));

            Console.ReadLine();


            Tempera[] t = new Tempera[3];

            //instanciado con SetValue
            t.SetValue(tem1, 0);
            t.SetValue(tem2, 1);
            t.SetValue(tem3, 2);

            for (int i = 0; i < t.Length ; i++)
            { 
                Console.Write(Tempera.Mostrar(t[i]));
            }
            
            Console.ReadLine();


            foreach (Tempera cosa in t)
            {
                Console.Write(Tempera.Mostrar(cosa));
            }

        }
    }
}
