using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2C_Ejercicio4
{
    class ProdVendido : ProdExport
    {
        public string Cliente;

        public ProdVendido(ProdExport prod, string cliente)
            : base(new ProdImpuesto(prod.Nombre, prod.Stock, prod.Impuesto), prod.Pais)
        {
            this.Cliente = cliente;
        }
    
    }
}
