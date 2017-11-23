using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianGraziano_Final_LaboratorioII
{
    class Prodimpuesto:Producto
    {

        public double impuesto;

        public Prodimpuesto()
        { }

        public Prodimpuesto(string nombre, int stock, double impuesto):this()
        {
            base.nombre = nombre;
            base.stock = stock;
            this.impuesto = impuesto;
        }
    }
}
