using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local:Llamada
    {
        protected float _costo;

        public float CostoLLamada { get { return this.CalcularCosto(); } }

        #region Metodos

        public Local(Llamada unaLLamada, float costo):this(unaLLamada.NroOrigen,unaLLamada.Duracion,unaLLamada.NroDestino,costo)
        {
            //se inicializa ya que son de instancia
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            //base._nrOrigen = origen;
            //base._duracion = duracion;
            //base._nroDestino = destino;
            this._costo = costo;
        }

        private float CalcularCosto()
        { 
            
            return this._costo * base.Duracion;
        }

        new public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            //esto tambien se puede hacer con la funcion de Llamada Mostrar
            sb.Append("\nOrigen");
            sb.AppendLine(base.NroOrigen);
            sb.Append("\nDuracion: ");
            sb.AppendLine(base.Duracion.ToString());
            sb.Append("\nDestino: ");
            sb.AppendLine(base.NroDestino);
            sb.Append("\nCosto de la LLamada Local: ");
            sb.AppendLine(this.CostoLLamada.ToString());   
        }

        #endregion

    }
}
