using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianGraziano_Final_LaboratorioII
{
    class ProdVendido:ProdExport
    {
        
        public string cliente;

        public ProdVendido()
        { }

        public ProdVendido(ProdExport prodexp, string Cliente):this()
        {
            base.nombre = prodexp.nombre;
            base.stock = prodexp.stock;
            base.pais = prodexp.pais;
            base.impuesto = prodexp.impuesto;
            this.cliente = Cliente;
        }
    }
}
