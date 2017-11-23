using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Local:Llamada
    {
        #region Atributos, Propiedades y Constructores
        protected float _costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(Llamada unaLlamada, float costo)
        {
            base._duracion = unaLlamada.Duracion;
            base._nroDestino = unaLlamada.NroDestino;
            base._nroOrigen = unaLlamada.NroOrigen;
            this._costo = costo;
        }
        public Local(string origen, string destino, float duracion, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        #endregion

        #region Metodos
        
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            base.Mostrar();
            sb.Append("\nCosto Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float result = 0;
            result = base.Duracion * this._costo;
            return result;

        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
            { return true; }
            else { return false; }
            
        }

        public override string ToString()
        {
            return base.Mostrar();
        }

        #endregion
    }
}
