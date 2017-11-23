using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionPractica
{
    [Serializable]
    public class Local:Llamada
    {
        private float _costo;

        public override float CostoLlamada { get { return this._costo; } }

        public Local()
        { }

        public Local(Llamada unaLLamada, float costo)
        {
            base._duracion = unaLLamada.Duracion;
            base._nroDestino = unaLLamada.NroDestino;
            base._nroOrigine = unaLLamada.NroOrigen;
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("\nCosto Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());
            return sb.ToString();
        }        
        
        private float CalcularCosto()
        {
            float result = 0;

            result = this._costo * base.Duracion;

            return result;
 
        }

        //agregado ejercicio 54

        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                return true;

            }
            else
            { return false; }
        }

        public override string ToString()
        {
            return base.Mostrar();
        }

    }
}
