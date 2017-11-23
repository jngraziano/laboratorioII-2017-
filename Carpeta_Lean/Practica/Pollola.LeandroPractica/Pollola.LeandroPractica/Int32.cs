using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollola.LeandroPractica
{
    class Int32
    {
        public static bool Espar(int numero) 
        {
            if   ((numero%2)==0)   {return true;} 
            else                   {return false;}

        }

        public static bool EsImpar(int numero)
        {
            return !(Int32.Espar(numero));

        }


    }
}
