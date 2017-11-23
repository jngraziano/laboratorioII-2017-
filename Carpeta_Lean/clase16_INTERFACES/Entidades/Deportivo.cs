using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp)
        {
            this._caballosFuerza = hp;
        }

    }
}
