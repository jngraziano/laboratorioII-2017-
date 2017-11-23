using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2016
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 3; i++)
            //{
            //    Auto a = new Auto(4, ConsoleColor.Green, EMarcas.Fiat);
            //}

            Auto a1 = new Auto(4,ConsoleColor.Green, EMarcas.Fiat);

            Auto a3;
            Auto a4 = null;


            a3 = a1;

            a1.cantRuedas = 0;
            a3.cantRuedas = 8;
            a3 = a4;
            //a3.cantRuedas = 6;
            //a1.cantRuedas = 4;
            //a1.color = ConsoleColor.Cyan;
            //a1.marca = EMarcas.Ford;

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(Auto.Mostrar(a1));


            Auto a2 = new Auto(3, ConsoleColor.DarkRed, EMarcas.Ferrari);

            Auto.DiferenciaEntreInstancias();

            //a2.marca = EMarcas.Porche;
            //a2.cantRuedas = 3;
            //a2.color = ConsoleColor.White;
            //Console.WriteLine(a2.Mostrar());
            //Console.WriteLine(Auto.fechaCreacion);
            //Auto.fechaCreacion = DateTime.Now;
            //Console.WriteLine(Auto.fechaCreacion);

        }    
    }
}
