using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    class Cohete:Transporte
    {
        public string Modelo;
        public int TiempoDeVidaUtil;
        
        public override void Frenar()
        {
            Console.WriteLine("Se frena con paracaidas");
        }

        public Cohete(eVelocidad veloMax, string tiempoUso, string modelo, int tiempodevidaUtil)
            : base(veloMax, tiempoUso)
        {
            this.Modelo = modelo;
            this.TiempoDeVidaUtil = tiempodevidaUtil;
        
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nCOHETE");
            sb.AppendLine(base.Mostrar());
            sb.Append("\nModelo: ");
            sb.AppendLine(this.Modelo);
            sb.Append("\n Tiempo de Vida Util: ");
            sb.AppendLine(this.TiempoDeVidaUtil.ToString());

            return sb.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
    }

