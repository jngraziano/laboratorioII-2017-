using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Segundo_Parcial
{
    class Moto:Vehiculo
    {
        
        protected int _cilindrada;

        public Moto(string patente, Marca marca,byte cantDeRuedas,  int cilindrada)
            : base(patente, cantDeRuedas, marca)
        {
            
            this._cilindrada = cilindrada;
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
            sb.Append("La cantidad de cilindrada es: ");
            sb.AppendLine(this._cilindrada.ToString());

            Console.WriteLine(sb.ToString());
            
        }

        public override void AcelerarHasta(byte a)
        {
            Console.WriteLine("Acelerara hasta " + a.ToString());

        }


    }
}
