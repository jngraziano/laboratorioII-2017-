using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resp=true;
            bool resp2 = true;
            Boligra.Boligrafo tintaazul = new Boligra.Boligrafo(ConsoleColor.Blue,100);
            Boligra.Boligrafo tintaroja = new Boligra.Boligrafo(ConsoleColor.Red, 100);

            resp=tintaazul.Pintar(100);
            resp2=tintaroja.Pintar(50);

            if (resp == true)
            {
                tintaazul.Recargar();

            }
            else
            { Console.WriteLine("No hace falta recargar"); }
            if (resp2 == true)
            {
                tintaroja.Recargar();

            }
            else
            { Console.WriteLine("No hace falta recargar"); }

            Console.ReadKey();
        }
    }
}
