using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        public Camion(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        /// <summary>
        /// Los camiones tienen 8 ruedas
        /// </summary>
        protected override short CantidadRuedas //quitar override
        {
            get
            {
                return 8;
            }
        }

        public override string Mostrar() // cambiar visibiliadd
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
            sb.Append(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); //quitar tostring
        }

    }

       
}
