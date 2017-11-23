using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2C_Ejercicio4
{
    class ProdExport : ProdImpuesto
    {
        public string Pais;

        public ProdExport(ProdImpuesto prod, string pais) :base(prod.Nombre,prod.Stock,prod.Impuesto)
        {
            this.Pais = pais;
        }

    }
}
