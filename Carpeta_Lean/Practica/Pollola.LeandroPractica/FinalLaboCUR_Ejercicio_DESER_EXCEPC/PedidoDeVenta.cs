using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FinalLaboCUR_Ejercicio_DESER_EXCEPC
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

        public PedidoDeVenta() { }

        public static PedidoDeVenta Deserializar(string ruta)
        {
            PedidoDeVenta resPedido = new PedidoDeVenta();
            try
            {
                XmlTextReader read = new XmlTextReader(ruta);
                XmlSerializer ser = new XmlSerializer(typeof(PedidoDeVenta));


                resPedido = (PedidoDeVenta)ser.Deserialize(read);
                read.Close();
                return resPedido;
            }
            catch (Exception e)
            {


                StreamWriter graba = new StreamWriter(ruta);
                graba.Write("Error al deserializar el archivo {0}", ruta);

                DateTime fechaHora = new DateTime();
                graba.WriteLine("Fecha {0}", fechaHora.Date, fechaHora.Hour);

                graba.Close();
                return resPedido;

            }




        }


    }
}
