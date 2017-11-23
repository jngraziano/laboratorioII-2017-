using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Vehiculo
    {
        public int km;

        public Vehiculo(int val) 
        {
            this.km = val;
        }

        public static explicit operator Double(Vehiculo vehic)
        {
            return vehic.km;
        }
    }
}
