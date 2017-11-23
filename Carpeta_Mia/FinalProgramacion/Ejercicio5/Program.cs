using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            G a = new G();
            G b;
            a.K = "A";
            b = a ;
            b.K = "E";
            a.K = "i";
            Console.WriteLine(b.K);
            Console.ReadKey();

        }
    }
}
