using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Fabrica
    {
        public static String c;

        static Fabrica()
        {
            c = "Prueba";
        }

        public Fabrica(String b)
        {
            
            c = b;
        }

    }
}
