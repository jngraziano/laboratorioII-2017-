using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pollola.LeandroPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPrueba = 4;
            if      (Int32.Espar(numeroPrueba))     { Console.WriteLine("Es Par"); }
            else if (Int32.EsImpar(numeroPrueba))   {Console.WriteLine("Es impar");}
        }
    }
}

