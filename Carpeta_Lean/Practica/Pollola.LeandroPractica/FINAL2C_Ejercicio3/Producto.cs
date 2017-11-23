using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL2C_Ejercicio3
{
    class Producto
    {
        public string Nombre;
        public int Stock;

        public Producto() { }

        public Producto(string nombreParam, int stockParam) 
        {
            this.Nombre = nombreParam;
            this.Stock = stockParam;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.Nombre == p2.Nombre) { return true; }
            else { return false;  }
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
