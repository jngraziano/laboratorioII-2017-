using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2C_Ejercicio2
{
    class MiPila : Stack<Double>
    {
        public  Stack<Double> sPilaInversa
        {
            get { return ( Stack<Double>) this.Reverse(); }
        }

    }
}
