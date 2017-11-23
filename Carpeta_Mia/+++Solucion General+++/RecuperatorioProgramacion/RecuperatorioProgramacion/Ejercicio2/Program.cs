using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Precio unPrecio = new Precio();

            unPrecio.PrecioDeCosto = 10;

            unPrecio.Mostrar();
            Console.ReadKey();
        }
    }
}
/* EJERCICIO 3
 * Un constructor estatico se ejecuta cuando se crea la primera instancia de clase. 
 * 
 */ 
