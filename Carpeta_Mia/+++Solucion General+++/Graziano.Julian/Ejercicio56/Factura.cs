using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio56
{
    public abstract class Factura
    {
        #region Atributos Propiedades y Constructores
        protected long _numero;
        protected DateTime _fecha;
        protected string _datosImprenta;

        public Factura(long Numero, DateTime Fecha, string DatosImprenta)
        {
            this._numero = Numero;
            this._fecha = Fecha;
            this._datosImprenta=DatosImprenta;
        
        }

        #endregion


        #region Metodos

        public abstract double CalcularTotal();

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nNumero: ");
            sb.AppendLine(this._numero.ToString());
            sb.Append("\nFecha: ");
            sb.AppendLine(this._fecha.ToString());
            sb.Append("\nDatos Imprenta: ");
            sb.AppendLine(this._datosImprenta);

            return sb.ToString();
        
        }

        #endregion


    }
}
