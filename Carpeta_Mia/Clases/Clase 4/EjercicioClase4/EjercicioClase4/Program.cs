using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto marca1 = new Auto("CHEVY");
            Auto marcaColor = new Auto("FORD","ROJO");
            Auto marcaColorTipoCombustible = new Auto("CHERRY","BLANCO",ETipoCombustible.GNC);
            Auto marcaColorTipoCombustiblePrecio = new Auto("VW","GRIS",ETipoCombustible.NAFTA,90000);


            marca1.Mostrar();
            marcaColor.Mostrar();
            marcaColorTipoCombustible.Mostrar();
            marcaColorTipoCombustiblePrecio.Mostrar();
            

            Console.ReadKey();



        }
    }
}
