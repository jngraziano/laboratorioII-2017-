using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerenciaPractica
{
    class Local:Llamada
    {
        private float _costo;

        public float CostoLlamada { get { return this._costo; } set { this._costo = this.CalcularCosto(); } }

        public Local(Llamada unaLLamada, float costo)
        {
            base._duracion = unaLLamada.Duracion;
            base._nroDestino = unaLLamada.NroDestino;
            base._nroOrigine = unaLLamada.NroOrigen;
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this.CostoLlamada = costo;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();

            sb.Append("\nCosto Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());
        }        
        
        private float CalcularCosto()
        {
            float result = 0;

            result = this._costo * base.Duracion;

            return result;
 
        }


    }
}
