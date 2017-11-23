using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio56
{
    public class FacturaC:Factura
    {

        #region Atributos y Constructor
        private double _total;
        private List<Item> _listaItem;

        public FacturaC(long Numero, DateTime Fecha, string DatosImprenta, double Total)
            : base(Numero, Fecha, DatosImprenta)
        {
            this._total = Total;
            List<Item> list = new List<Item>();
            this._listaItem = list;

        }
        #endregion

        #region Metodos

        public List<Item> AgregarItem(Item unItem)
        {
            this._listaItem.Add(unItem);

            return this._listaItem;
        }
        

        public override double CalcularTotal()
        {
            double result = 0;
            //El método CalcularTotal(), calculará el costo de todos los ítems de la factura
            //(precio * cantidad) 
            foreach (Item recorre in this._listaItem)
            {
                
                result=recorre.Cantidad*recorre.Precio;

            }

            return result;


        }

        public override string Mostrar()
        {
           Console.WriteLine(base.Mostrar());
           StringBuilder sb = new StringBuilder();
           sb.Append("\nTotal: ");
           sb.AppendLine(this._total.ToString());
           foreach (Item recorre in this._listaItem)
           {
               sb.Append("\nLista Items: ");
               sb.AppendLine(this._listaItem.ToString());
               Console.WriteLine(recorre.MostrarDetalles().ToString());
           
           }
           return sb.ToString();
        

        }


        #endregion

    }
}
