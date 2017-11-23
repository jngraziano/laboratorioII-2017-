using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9__Transporte_
{
    class Bicicleta:Transporte
    {

        public double rodado;


        public Bicicleta(double rodado, eVelocidad velocidad, string tiempodeuso):base(velocidad,tiempodeuso)
        {
            this.rodado = rodado;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.Append("Rodado: ");
            sb.AppendLine(this.rodado.ToString());

            return sb.ToString();
        
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

        public override void Frenar()
        {
            Console.WriteLine("Estoy frenando");      
        }

        public override string TiempoDeUso
        {
            get { return this._tiempoDeUso; }
        }

    }
}
