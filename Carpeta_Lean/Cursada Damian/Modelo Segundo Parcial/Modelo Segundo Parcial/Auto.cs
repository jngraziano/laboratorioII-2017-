using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Segundo_Parcial
{
    class Auto:Vehiculo
    {
        protected int _cantidadAsientos;
        
        public Auto(string patente,  Marca marca,byte cantDeRuedas, int cantidadAsientos)
            : base(patente, cantDeRuedas, marca)
        {
            this._cantidadAsientos = cantidadAsientos;
            
        }

        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------");
            sb.Append("La patente es: ");
            sb.AppendLine(this._patente);
            sb.Append("La cantidad de ruedas es: ");
            sb.AppendLine(this._cantDeRuedas.ToString());
            sb.Append("La marca es: ");
            sb.AppendLine(this._marcas.ToString());
            sb.Append("La cantidad de asientos: ");
            sb.AppendLine(this._cantidadAsientos.ToString());
            

            Console.WriteLine(sb.ToString());

        }

        public override void AcelerarHasta(byte a)
        {
            Console.WriteLine("Acelerara hasta " + a.ToString());

        }


    }
}
