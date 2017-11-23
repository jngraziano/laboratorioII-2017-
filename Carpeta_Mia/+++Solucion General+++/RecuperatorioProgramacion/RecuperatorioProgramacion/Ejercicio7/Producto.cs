using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Producto
    {
        public string nombre;
        public int cant;

        public Producto(string NOMBRE, int CANT)
        {
            this.nombre = NOMBRE;
            this.cant = CANT;
        
        }

        public static Producto operator +(Producto produc, int cantidad)
        {
            Producto aux = new Producto(produc.nombre, produc.cant);
                        
            aux.cant = produc.cant + cantidad;

            return aux;
        
        }
    }
}
