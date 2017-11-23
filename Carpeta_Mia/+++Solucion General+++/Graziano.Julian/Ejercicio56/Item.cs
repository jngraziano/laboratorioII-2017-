using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio56
{
    public class Item
    {
         #region Atributos, Propiedades y Constructores
        private int _codigo;
        private int _cantidad;
        private string _detalle;
        private double _precio;

        public int Codigo { get { return this._codigo; } }
        public int Cantidad { get { return this._cantidad; } }
        public string Detalle { get { return this._detalle; } }
        public double Precio { get { return this._precio; } }

        public Item()
        { }

        public Item(int codigo, int cantidad, string detalle, double precio):this()
        {
            this._codigo = codigo;
            this._cantidad = cantidad;
            this._detalle = detalle;
            this._precio = precio;
        
        }

    #endregion

        #region Metodos

        public string MostrarDetalles()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nCodigo: ");
            sb.AppendLine(this.Codigo.ToString());
            sb.Append("\nCantidad: ");
            sb.AppendLine(this.Cantidad.ToString());
            sb.Append("\nDetalle: ");
            sb.AppendLine(this.Detalle);
            sb.Append("\nPrecio: ");
            sb.AppendLine(this.Precio.ToString());

            return sb.ToString();
        
        }


        #endregion
    }
}
