using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9__Transporte_
{
    abstract class Transporte
    {
        protected eVelocidad _velocidadMax;
        protected string _tiempoDeUso;


        public Transporte(eVelocidad velocidad, string tiempodeuso)
        {
            this._tiempoDeUso = tiempodeuso;
            this._velocidadMax = velocidad;
            
        }

        public virtual eVelocidad velocidadMaxima
        { get { return this._velocidadMax; } }

        public abstract string TiempoDeUso
        {
            get;

        }

        public abstract void Frenar();


        //Parcial -------------> base....
        //Total ---------------> sin base...
        //Sin modificador ------> sin override
        protected virtual string  Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**********************************");
            sb.Append("Tiempo de uso: ");
            sb.AppendLine(this._tiempoDeUso);
            sb.Append("Velocidad Maxima: ");
            sb.AppendLine(this._velocidadMax.ToString());

            return sb.ToString();


        }




    }
}
