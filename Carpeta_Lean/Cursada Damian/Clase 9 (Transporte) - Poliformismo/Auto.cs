using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9__Transporte_
{
    class Auto:Transporte
    {
        public int cantRuedas;
        public string patente;
       
        public override eVelocidad velocidadMaxima
        {
            get
            {
                Console.WriteLine("Estoy en propiedad sobre escrita Auto");
                return base.velocidadMaxima;
            }
        }

        public Auto(eVelocidad velocidad, string tiempodeuso, int cantruedas, string patente)
            : base(velocidad, tiempodeuso)
        {
            this.cantRuedas = cantruedas;
            this.patente = patente;
        }

        public override string TiempoDeUso
        {
            get { return this._tiempoDeUso; }
        }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.Append("Cantidad de Ruedas: ");
            sb.AppendLine(this.cantRuedas.ToString());
            sb.Append("Patente: ");
            sb.AppendLine(this.patente);


            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override void Frenar()
        {
            Console.WriteLine("Frena con el pedal del medio");
        }


    }
}
