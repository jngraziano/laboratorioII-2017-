using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    class Bicicleta:Transporte
    {
        public double rodado;
        //ESTO DEBO COLOCARLO EN TODAS LAS CLASES
        public override void Frenar()
        {
            Console.WriteLine("Se frena con frenos de bici");
        }
        //tres parametros
        public Bicicleta(eVelocidad veloMax, string tiempoUso, double Rodado):base(veloMax,tiempoUso)
        { this.rodado = Rodado; }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nBICICLETA");
            sb.AppendLine(base.Mostrar());
            sb.Append("\nRodado: ");
            sb.AppendLine(this.rodado.ToString());

            return sb.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
