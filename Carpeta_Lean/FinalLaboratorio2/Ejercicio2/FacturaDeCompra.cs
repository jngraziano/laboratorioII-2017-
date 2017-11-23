using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class FacturaDeCompra:Factura
    {
        private decimal valorFactura;

        public FacturaDeCompra(decimal valor) 
        {
            this.valorFactura = valor;
        }

        public override decimal TotalFacturado
        {
            get { return this.valorFactura; }
        }



    }
}
