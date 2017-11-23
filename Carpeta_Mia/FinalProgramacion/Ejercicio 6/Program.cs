using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> lista = new List<Persona>();

            lista.Add(new Persona("Tito"));
            lista.Add(new Persona("Pepe"));
            lista.Add(new Persona("Roberto"));
            lista.Add(new Persona("Juan"));

            foreach (Persona item in lista)
            {
                if (item.nombre == "Tito")
                {
                    lista.Remove(item);
                }
            }
            // ARROJA UNA EXCEPCION EN TIEMPO DE EJECUCION
        }
    }
}
