using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int a, int b, int c)
        {
            if (a > b && a < c)
            { return true; }
            else { return false;}
        
        }
    }
}
