using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2C_Ejercicio4
{
    class ProdImpuesto : Producto
    {
        public double Impuesto;

        public ProdImpuesto(string Nombre, int Stock, double impuesto) : base(Nombre,Stock)
        {
            this.Impuesto = impuesto;
        }

    }
}
