using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio6
{
    class MiExcepcion : Exception
    {
        public string mensaje;

        public MiExcepcion(string mensaje) 
        {
            Console.WriteLine(mensaje);
        }

        public string Mensaje 
        {
            get { return "Propiedad Mensaje"; }
        }

    }
}
