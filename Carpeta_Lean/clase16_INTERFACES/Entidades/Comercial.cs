using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial : Avion
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros)
        {
            this._capacidadPasajeros = pasajeros;
        }

    }
}
