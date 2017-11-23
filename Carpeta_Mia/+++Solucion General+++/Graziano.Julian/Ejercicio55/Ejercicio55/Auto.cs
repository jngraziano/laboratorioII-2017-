using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    public class Auto:Vehiculo
    {
        protected int _CantidadAsientos;

        public Auto(string patente, Marca marca, byte cantidadruedas, int cantidadasientos)
            : base(patente, cantidadruedas, marca)
        {
            this._CantidadAsientos = cantidadasientos;
        
        }

           
        public override void Mostrar()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("\nPatente: ");
            sb.AppendLine(base._patente);
            sb.Append("\nMarca: ");
            sb.AppendLine(base._marca.ToString());
            sb.Append("\nCantidad de ruedas: ");
            sb.AppendLine(base._cantRuedas.ToString());
            sb.Append("\nCantidad de Asientos: ");
            sb.AppendLine(this._CantidadAsientos.ToString());

            Console.WriteLine(sb.ToString());           
        }

    }
}
