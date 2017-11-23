using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP/*, IARBA*/
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp)
            : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        double IAFIP.CalcularImpuesto()
        {
            throw new NotImplementedException();
        }
/*
        double IARBA.CalcularImpuesto()
        {
            throw new NotImplementedException();
        }
 */
    }
}
