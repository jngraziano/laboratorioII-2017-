using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5_y_6
{
    public abstract class Producto
    {
        protected string _nombre;

        public Producto(string nombre)
        {
            this._nombre = nombre;
        }

        public abstract string Mostrar();
    }
}
