using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local:Llamada
    {

        #region Atributos, Propiedades y Constructores
        protected float _costo;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

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
        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            base.Mostrar();
            sb.Append("\nCosto Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());

            Console.WriteLine(sb.ToString());
        }

        private float CalcularCosto()
        {
           float result=0;
           result= base.Duracion * this._costo;
           return result;
        
        }

        #endregion
    }
}
