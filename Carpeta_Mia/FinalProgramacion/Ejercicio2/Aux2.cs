using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Aux2
    {

        private int _precioDeCosto;
        private float _precioDeVenta;

        public int PrecioDeCosto
        {
            set 
                {
                    this._precioDeCosto = value;
                    this._precioDeVenta= this.CambiarElPrecio();
                }

        }

        public float CambiarElPrecio ()
        {
            return this._precioDeCosto * 1.27f;
        }


    }
}
