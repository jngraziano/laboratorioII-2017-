using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Producto
    {
        #region Variables y constructores
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        public Producto(int codigoDeBarra)
        { this._codigoDeBarra = codigoDeBarra; }
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo)
            : this(codigoDeBarra)
        { this._nombre = nombre;
          this._tipo = tipo;
        }
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio)
            : this(codigoDeBarra, nombre, tipo)
        { this._precio = precio; }
        #endregion

#region Metodos de la clase
        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nCodigo de barra: ");
            sb.AppendLine(this._codigoDeBarra.ToString());
            sb.Append("\nNombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("\nPrecio: ");
            sb.AppendLine(this._precio.ToString());
            sb.Append("\nTipo: ");
            sb.AppendLine(this._tipo.ToString());

            Console.WriteLine(sb.ToString());
        }
        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            if (proUno._tipo == tipo)
            { return true; }
            else { return false; }
        }
        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        { return !(proUno == tipo); }
        public static bool operator ==(Producto proUno, Producto proDos)
        {
            //devuelva verdadero
            //sólo cuando estos sean iguales
            if (proUno._codigoDeBarra == proDos._codigoDeBarra && proUno._nombre == proDos._nombre && proUno._precio == proDos._precio && proUno._tipo == proDos._tipo)
            {
                return true;

            }
            else { return false; }
        }
        public static bool operator !=(Producto proUno, Producto proDos)
        { return !(proUno == proDos); }


        #endregion
    }
}
