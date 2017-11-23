using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {

            Tempera UnaTempera = new Tempera(ConsoleColor.Red, 5, "marca1");
            Tempera DosTempera = new Tempera(ConsoleColor.Red, 8, "marca1");
            Tempera TresTempera = new Tempera(ConsoleColor.Blue, 7, "marca3"); 

            Console.WriteLine(Tempera.Mostrar(UnaTempera));
            Console.WriteLine(Tempera.Mostrar(DosTempera));
            Console.WriteLine(Tempera.Mostrar(TresTempera));



            Console.WriteLine("****** COMPARO TEMPERA 1 CON TEMPERA 2 *********");
            if (UnaTempera == DosTempera)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("NO son iguales");
            }

            Console.WriteLine("****** COMPARO TEMPERA 1 CON TEMPERA 3 *********");
            if (UnaTempera == TresTempera)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("NO son iguales");
            }

            Console.WriteLine("**********************************************");

            Paleta PaletaUno=3;

            string prueba = (string)PaletaUno;

            Console.WriteLine(prueba);

            Console.ReadKey();
            

            


           

            //Array  de Temperas

            Tempera[] t = new Tempera[3];

            t[0] = UnaTempera;
            t[1] = DosTempera;
            t[2] = TresTempera;


            foreach (Tempera indice in t)
            {
                Console.WriteLine(Tempera.Mostrar(indice));
            }

            // Otra forma de hacerlo con un FOR comun
            //for (int i = 0; i < t.Lenght; i++)
            //{
            //    Console.WriteLine(Tempera.Mostrar(t[i]));
            //}


            Console.ReadKey();
        }
    }
}
