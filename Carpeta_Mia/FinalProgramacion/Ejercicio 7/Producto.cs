using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Producto
    {
        private string _nombre;
        private int _cantidad;

        public Producto(string nombre, int cantidad)
        {
            this._cantidad = cantidad;
            this._nombre = nombre; 
        }


        public static Producto operator +(Producto p, int e)
        {
            Producto c = new Producto(p._nombre, p._cantidad);
            c._cantidad += e;
            return c;
        }
    }
}
