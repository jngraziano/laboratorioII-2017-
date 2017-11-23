using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalLaboCUR_Ejercicio3_TXT_INTERF_LIST_EXC
{
    class PedidoDeVenta : IGrabacion
    {
        private List<Articulo> _items;
        private DateTime _fecha;
        private int nroCliente;

        public List<Articulo> Items { get { return this._items; } }

        public PedidoDeVenta(DateTime fecha, int nroCliente)
        {
            this._fecha = fecha;
            this.nroCliente = nroCliente;
            this._items = new List<Articulo>();
        }

        public bool GrabarTxt(string ruta)
        {
            float acumulador = 0;
            bool retorno;

            foreach (Articulo art in this._items)
            {
                acumulador += art.Valor;
            }

            if (acumulador > 1000)
            {
                foreach (Articulo art in this._items)
                {
                    art.Valor = art.Valor * 1.20f;
                }
            }

            try
            {
                StreamWriter stream = new StreamWriter(ruta);
                stream.WriteLine(this.nroCliente.ToString());
                stream.WriteLine(this._fecha.ToString());
                foreach (Articulo art in this._items)
                {
                    stream.WriteLine(art.CodigoArticulo.ToString());
                    stream.WriteLine(art.Valor.ToString());
                }
                stream.Close();
                retorno = true;
                return retorno;
            }
            catch (Exception e)
            {
                retorno = false;
                return retorno;
            }
        }
    }
}
