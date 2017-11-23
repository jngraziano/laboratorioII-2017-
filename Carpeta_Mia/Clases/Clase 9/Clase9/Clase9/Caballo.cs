using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    class Caballo:Transporte
    {
        public string color;
        public string raza;

        public override void Frenar()
        {
            Console.WriteLine("Se frena con las patas");
        }

        public Caballo(eVelocidad veloMax, string tiempoUso, string Color, string Raza)
            : base(veloMax, tiempoUso)
        {
            this.color = Color;
            this.raza = Raza;
        
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nCABALLO");
            sb.AppendLine(base.Mostrar());
            sb.Append("\nColor: ");
            sb.AppendLine(this.color);
            sb.Append("\nRaza: ");
            sb.AppendLine(this.raza);

            return sb.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
