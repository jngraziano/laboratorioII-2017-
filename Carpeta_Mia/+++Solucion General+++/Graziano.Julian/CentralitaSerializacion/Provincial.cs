using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionPractica
{
    [Serializable]
     public class Provincial:Llamada
    {
        private Franja _franjaHoraria;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial()
        { }
        
        public Provincial(Franja miFranja, Llamada unaLLamada)
        {
            this._franjaHoraria = miFranja;
            base._duracion = unaLLamada.Duracion;   
            base._nroDestino = unaLLamada.NroDestino;
            base._nroOrigine = unaLLamada.NroOrigen;
            
        }

        public Provincial(string Origen, Franja miFranja, float Duracion, string destino):base(Origen,destino,Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float result = 0;

            if (this._franjaHoraria == Franja.Franja_1)
            {
                result = base.Duracion * 0.99F;
              
                            
            }
            else if (this._franjaHoraria == Franja.Franja_2)
            {
                result = base.Duracion * 1.25F;
               
            
            }
            else if (this._franjaHoraria == Franja.Franja_3)
            {
                result = base.Duracion * 0.66F;
                
            
            }
            return result;
        
        }
        protected override string Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.Append("\nFranja Horaria: ");
            sb.AppendLine(this._franjaHoraria.ToString());
            sb.Append("\nCosto Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());

            return sb.ToString();
        }

        //agregado por el Ejercicio 53

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
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
