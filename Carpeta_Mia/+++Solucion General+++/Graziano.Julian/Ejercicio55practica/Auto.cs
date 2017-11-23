using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55practica
{
    public class Auto:Vehiculo
    {
        #region Atributos, Propiedades y Constructores
        protected int _cantidadAsientos;

        
        public Auto(string patente, Marca marca, byte cantidadruedas, int cantidaddeAsientos)
            : base(patente,cantidadruedas,marca)
        {
            this._cantidadAsientos = cantidaddeAsientos;
        
        }

        #endregion

        #region Metodos

        public override void Mostrar()
        {
            Console.WriteLine("\nDatos: ");
            StringBuilder sb = new StringBuilder();
            sb.Append("\nPatente: ");
            sb.AppendLine(base.Patente);
            sb.Append("\nCantidad de Ruedas: ");
            sb.AppendLine(base._cantRuedas.ToString());
            sb.Append("\nMarca: ");
            sb.AppendLine(base._marca.ToString());

            sb.Append("\nCantidad Asientos: ");
            sb.AppendLine(this._cantidadAsientos.ToString());

            Console.WriteLine(sb.ToString());
            
        }

        #endregion
    }
}
