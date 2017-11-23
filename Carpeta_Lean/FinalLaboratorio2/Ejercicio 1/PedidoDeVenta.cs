using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class PedidoDeVenta
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

        public static bool operator -(PedidoDeVenta pedido, int codArt) 
        {
            bool retorno = false;

            foreach (Articulo art in pedido._items) 
            {
                if (art.CodigoArticulo == codArt)
                {
                    pedido._items.Remove(art);
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator -(int codArt, PedidoDeVenta pedido) 
        {
            return (pedido - codArt);
        }




    }
}
