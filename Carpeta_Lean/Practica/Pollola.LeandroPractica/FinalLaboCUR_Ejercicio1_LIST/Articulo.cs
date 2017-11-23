using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio1_LIST
{
    class Articulo
    {
        private int _codigoArt;

        public int CodigoArticulo { get { return this._codigoArt; } }

        public Articulo(int codigo)
        {
            this._codigoArt = codigo;
        }

    }
}
