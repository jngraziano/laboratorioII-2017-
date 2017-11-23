using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9__Transporte_
{
    class Cohete : Transporte
    {
        public string modelo;
        public int tiempoDeVidaUtil;


        public Cohete(eVelocidad velocidad, string tiempodeuso, string modelo, int tiempodevidautil)
            : base(velocidad, tiempodeuso)
        {
            this.modelo = modelo;
            this.tiempoDeVidaUtil = tiempodevidautil;
        }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.Append("Modelo: ");
            sb.AppendLine(this.modelo);
            sb.Append("Tiempo de vida util: ");
            sb.AppendLine(this.tiempoDeVidaUtil.ToString());


            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    
    
    
    }
}