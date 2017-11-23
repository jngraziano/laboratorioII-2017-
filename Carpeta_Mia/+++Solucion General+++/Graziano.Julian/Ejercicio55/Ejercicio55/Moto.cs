using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    public class Moto: Vehiculo
    {
        protected int _Cilindrada;

        public Moto(string patente, Marca marca, byte cantidadruedas, int cilindrada)
            : base(patente, cantidadruedas, marca)
        {
            this._Cilindrada = cilindrada;
        
        }
       

        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPatente: ");
            sb.AppendLine(base._patente);
            sb.Append("\nMarca: ");
            sb.AppendLine(base._marca.ToString());
            sb.Append("\nCantidad de ruedas: ");
            sb.AppendLine(base._cantRuedas.ToString());
            sb.Append("\nCantidad de Cilindrada: ");
            sb.AppendLine(this._Cilindrada.ToString());

            Console.WriteLine(sb.ToString()); 

        }
    }
}
