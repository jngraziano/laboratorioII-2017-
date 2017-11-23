using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial:Llamada
    {
        #region Atributos, Propiedades y Constructores

        protected Franja _franjaHoraria;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada unallamada)
        {
            base._duracion = unallamada.Duracion;
            base._nroOrigen = unallamada.NroOrigen;
            base._nroDestino = unallamada.NroDestino;
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            //CalcularCosto (Privado. Retornará el valor de la
            //llamada a partir de la duración y el costo de la misma.
            //Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y
            //Franja_3: 0.66)
            float result = 0;

            if(this._franjaHoraria == Franja.Franja_1)
            {
                result = base.Duracion * 0.99F;
            }
            else if (this._franjaHoraria == Franja.Franja_2)
            { result = base.Duracion * 1.25F; }
            else if (this._franjaHoraria == Franja.Franja_3)
            { result = base.Duracion * 0.66F; }

            return result;

        }
        public override void Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.Append("\nFranja Horaria: ");
            sb.AppendLine(this._franjaHoraria.ToString());
            sb.Append("\nCosto Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());

            Console.WriteLine(sb.ToString());
            
        }
        #endregion
    }
}
