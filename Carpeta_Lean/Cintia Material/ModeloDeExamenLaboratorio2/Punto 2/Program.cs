using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Realizar la clase fabrica un constructor estatico que inicialice un articulo de la clase 
            //y un constructor que modifique el mismo atributo.
        }
    }
    public class fabrica
    {
        public static string nombre;

        static fabrica()
        {
            nombre = "";
        }

        public fabrica(string nombre)
        {
            fabrica.nombre = nombre;
        }
    }
}
