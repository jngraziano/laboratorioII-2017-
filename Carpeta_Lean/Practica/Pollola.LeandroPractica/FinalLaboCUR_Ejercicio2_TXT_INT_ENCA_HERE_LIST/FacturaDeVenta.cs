using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio2_TXT_INT_ENCA_HERE_LIST
{
    class FacturaDeVenta:Factura
    {
        private decimal valorFactura;

        public FacturaDeVenta(decimal valor)
        {
            this.valorFactura = valor;
        }

        public override decimal TotalFacturado
        {
            get { return this.valorFactura; }
        }

    }
}
