using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9__Transporte_
{
    class Caballo:Transporte
    {
        public string color;
        public string raza;



        public Caballo(eVelocidad velocidad, string tiempodeuso,string color, string raza):base(velocidad, tiempodeuso)
        { 
                    this.color=color;
                    this.raza=raza;    
        
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.Append("Color: ");
            sb.AppendLine(this.color);
            sb.Append("Raza: ");
            sb.AppendLine(this.raza);

            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override string TiempoDeUso
        {
            get { return this._tiempoDeUso; }
        }

        public override void Frenar()
        {
            Console.WriteLine("El caballo despacio");
        }
    }
}
