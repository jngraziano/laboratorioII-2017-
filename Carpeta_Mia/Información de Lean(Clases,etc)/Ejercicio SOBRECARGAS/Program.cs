using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SOBRECARGAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto soloMarca = new Auto("Ford");
            Auto marcaYcolor = new Auto("Fiat", "Blanco");
            Auto marcaColorTcombustible = new Auto("Renault", "Negro", ETipoCombustible.GNC);
            Auto marcaColorTcombustiblePrecio = new Auto("VW", "Azul", ETipoCombustible.NAFTA, 180000);

            Console.WriteLine(Auto.Mostrar(soloMarca));
            Console.WriteLine(Auto.Mostrar(marcaYcolor));
            Console.WriteLine(Auto.Mostrar(marcaColorTcombustible));
            Console.WriteLine(Auto.Mostrar(marcaColorTcombustiblePrecio));

            Console.ReadKey();
        }
    }
}
