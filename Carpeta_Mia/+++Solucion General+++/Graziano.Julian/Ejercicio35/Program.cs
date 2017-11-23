using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto AutoUno = new Auto(EMarcas.Ferrari, "azul");
            Auto AutoDos = new Auto(EMarcas.Ferrari, "azul");

            Auto auto3 = new Auto(EMarcas.Ford, "negro", 1600);
            Auto auto4 = new Auto(EMarcas.Ford, "negro", 7000);
            
            Auto auto5 = new Auto(EMarcas.Lotus,"blanco",new DateTime(1978,01,01));
            Auto auto6 = new Auto(EMarcas.Lotus, "granate", 9000);
            Auto auto7 = new Auto(EMarcas.Ford,"violeta",2000,new DateTime(1992,03,02));

            auto5.AgregarImpuestos(1000D);
            auto6.AgregarImpuestos(1000D);
            auto7.AgregarImpuestos(1000D);

            double importeDouble = auto3 + auto4;
            Console.WriteLine("\nViene la suma de importe entre dos autos:");
            Console.WriteLine("IMPORTE DOUBLE: {0}", importeDouble);
            Console.WriteLine("\n\nAca informa si son iguales auto 1 con 2 y 5");
            if (AutoUno == AutoDos && AutoUno == auto5)
            {
                Console.WriteLine("\nSON IGUALES.");
            }
            else
            { Console.WriteLine("\nNO SON IGUALES."); }

            AutoUno.MostrarAuto(AutoUno);
            auto3.MostrarAuto(auto3);
            auto5.MostrarAuto(auto5);
            auto7.MostrarAuto(auto7);

            Console.ReadKey();

        }
    }
}
