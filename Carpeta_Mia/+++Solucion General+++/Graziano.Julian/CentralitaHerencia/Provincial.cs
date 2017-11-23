using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLLamada { get { return this.CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada unallamada):this(unallamada.NroOrigen,miFranja,unallamada.Duracion,unallamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen,destino,duracion)
        {
            //base._nrOrigen = origen;
            //this._franjaHoraria = miFranja;
            //base._duracion = duracion;
            //base._nroDestino = destino;
            this._franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float valorLlamada = 0;

            if (this._franjaHoraria == Franja.Franja_1)
            { valorLlamada = base.Duracion * 0.99F; }
            if (this._franjaHoraria == Franja.Franja_2)
            { valorLlamada = base.Duracion * 1.25F; }
            if (this._franjaHoraria == Franja.Franja_3)
            { valorLlamada = base.Duracion*0.66F;}



            return valorLlamada;
        }

        new public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            /*
             * base.Mostrar()
             * StringBuilder sb = new StringBuilder();
             sb.Appendline("Costo Llamada");
             * * sb.Append(this.CostoLlamada);
             * y tambien mostrar franjahoraria. 
             * y un writeline(sb);
             */
            sb.Append("\nOrigen");
            sb.AppendLine(base.NroOrigen);
            sb.Append("\nDuracion: ");
            sb.AppendLine(base.Duracion.ToString());
            sb.Append("\nDestino: ");
            sb.AppendLine(base.NroDestino);
            sb.Append("\nCosto de la LLamada Prov: ");
            sb.AppendLine(this.CostoLLamada.ToString());
            sb.Append("\nFranja Horaria: ");
            sb.AppendLine(this._franjaHoraria.ToString());
            
        
        }

        

    }
}
