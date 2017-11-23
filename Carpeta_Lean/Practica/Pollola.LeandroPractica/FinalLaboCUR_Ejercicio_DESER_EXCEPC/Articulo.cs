using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio_DESER_EXCEPC
{
    class Articulo
    {
        private int _codigoArt;
        private float valor;

        public float Valor { get { return this.valor; } set { this.valor = value; } }

        public int CodigoArticulo { get { return this._codigoArt; } }



        public Articulo(int codigo, float valor)
        {
            this._codigoArt = codigo;
            this.Valor = valor;
        }

    }
}
