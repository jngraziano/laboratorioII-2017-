using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            MiClase obj = new MiClase("Chau");

            obj.PropiedadSE = 98;
            Console.WriteLine(obj.PropiedadSL);
            Console.WriteLine(obj.PropiedadLE);

            double a = obj.MetodoConParametros(2, 8);

            obj.MetodoSinRetornoNiParametros();


            IMiInterface miI;

            miI = obj;

            Program.Mostrar(obj);
            Program.Mostrar(miI);
           // Program.Mostrar("asdfasd");

            Console.ReadLine();



        }

        static void Mostrar(IMiInterface algo)
        {
            Console.WriteLine(algo.PropiedadSL);
            Console.WriteLine(((MiClase)algo).atributo);
        }
    }
}
