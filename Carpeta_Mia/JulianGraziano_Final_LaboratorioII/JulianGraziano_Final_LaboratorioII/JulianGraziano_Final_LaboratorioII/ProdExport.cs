using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianGraziano_Final_LaboratorioII
{
    class ProdExport:Prodimpuesto
    {
        

        public string pais;

        public ProdExport()
        { }

        public ProdExport(Prodimpuesto prodimp, string pais):this()
        {
            base.nombre = prodimp.nombre;
            base.stock = prodimp.stock;
            base.impuesto = prodimp.impuesto;
            this.pais = pais;
        }
    }
}
