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

        public override string TiempoDeUso
        {
            get { return this._tiempoDeUso; }
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

       public override void Frenar()
         {
             Console.WriteLine("El cohete frena con paracaidas");       
         }
    
    
    }
}