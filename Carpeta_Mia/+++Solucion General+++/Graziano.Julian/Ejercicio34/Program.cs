using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria primeraCuenta = new CuentaBancaria(555, 5000D);
            CuentaBancaria segundaCuenta = new CuentaBancaria(555, "Juan Perez");

            
            Console.WriteLine("\nCUENTA UNO:");
            primeraCuenta.Mostrar();
            Console.WriteLine("\nCUENTA DOS:");
            segundaCuenta.Mostrar();

            Double importeDouble = primeraCuenta + segundaCuenta;
            Console.WriteLine("\nImporteDouble (Mostrara 0, si no son iguales): {0}", importeDouble);
            
            
            Console.WriteLine("\nPulse para mostrar luego de la suma y resta.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("PRIMERA CUENTA:");
            Console.WriteLine("\nSUMA: ");
            primeraCuenta = primeraCuenta + 1600;
            primeraCuenta.Mostrar();
            Console.WriteLine("\nRESTA: ");
            primeraCuenta = primeraCuenta - 1000;
            primeraCuenta.Mostrar();

            
           

            Console.ReadKey();

        }
    }
}
