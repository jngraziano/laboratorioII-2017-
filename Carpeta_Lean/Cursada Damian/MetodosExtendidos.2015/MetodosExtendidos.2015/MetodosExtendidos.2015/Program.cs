using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosExtendidos._2015
{
    class Program
    {
        static void Main(string[] args)
        {

            string varString = "hola";
            Persona p = new Persona("Juan", 25);

            Console.WriteLine(varString.MetodoExtendido());

            Console.WriteLine(varString.MetodoExtendido2());

            Console.WriteLine(p.MetodoExtendido3());

            Console.ReadLine();

        }
    }
}
