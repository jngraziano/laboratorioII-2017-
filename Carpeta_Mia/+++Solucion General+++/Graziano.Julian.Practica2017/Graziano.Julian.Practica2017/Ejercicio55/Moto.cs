using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    class Moto:Vehiculo
    {
         public Moto(string patente, Emarcas marca, byte cantidadruedas)
        {
            base._patente = patente;
            base._cantRuedas = cantidadruedas;
            base._marcas = marca;
        }
        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: ");
            sb.AppendLine(base._marcas.ToString());
            sb.Append("Pantente: ");
            sb.AppendLine(base._cantRuedas.ToString());
            sb.Append("Cantidad de Ruedas: ");
            sb.AppendLine(base._cantRuedas.ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
