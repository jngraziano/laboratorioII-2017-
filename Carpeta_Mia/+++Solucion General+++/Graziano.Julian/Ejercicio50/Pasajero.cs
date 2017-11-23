using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class Pasajero
    {
        private eTipoPasajero _TipoDePasajero;
        public eTipoPasajero TipoDePasajero { get { return this._TipoDePasajero; } set { this._TipoDePasajero = value; } }

        public Pasajero(eTipoPasajero TipoDePasajero)
        {
            //El constructor inicializa los campos _TipoDePasajero con los
            //parámetros solicitados por el mismo (Enum eTipoPasajero, ver
            //grafico).
            this.TipoDePasajero = TipoDePasajero;
        
        }
    }
}
