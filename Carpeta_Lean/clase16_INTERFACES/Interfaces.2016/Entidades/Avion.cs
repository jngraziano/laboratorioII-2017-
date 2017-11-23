using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion:Vehiculo, IAFIP/*, IARBA*/
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            :base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public double IAFIP.CalcularImpuesto()
        {
            throw new NotImplementedException();
        }
        /*
        public double IARBA.CalcularImpuesto()
        {
            throw new NotImplementedException();
        }*/
    }
}
