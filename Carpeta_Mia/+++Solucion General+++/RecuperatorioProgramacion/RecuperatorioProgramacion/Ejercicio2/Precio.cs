using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Precio
    {
        private float _precioDeCosto;
        private float _precioDeVenta;

        
        public float PrecioDeCosto { set { this._precioDeCosto= value; this._precioDeVenta=this.CambiarElPrecio(); } }

        public float CambiarElPrecio()
        {
            this._precioDeVenta = this._precioDeCosto * 1.27F;
           return _precioDeVenta;
        }

        public void Mostrar()
        {
            
            Console.WriteLine("\nPrecio costo: ");
            Console.WriteLine(this._precioDeCosto.ToString());
            Console.WriteLine("\nPrecio venta: ");
            Console.WriteLine(this._precioDeVenta.ToString());
        
        }


    }
}
