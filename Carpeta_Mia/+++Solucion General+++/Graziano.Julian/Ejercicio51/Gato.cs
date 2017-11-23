using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public class Gato:Mascota
    {
        public bool Maulla;

        
        public Gato(string nombreGato, ERaza razaGato):base(nombreGato,razaGato)
        {
            this.Maulla = true;
        
        }

        public Gato(string nombreGato, int edadGato, ERaza razaGato):base(nombreGato,edadGato,razaGato)
        { }

       
        public static ERaza RetornarRaza(Gato gatito)
        { return gatito._raza; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nNombre: ");
            sb.AppendLine(base._nombre);
            sb.Append("\nEdad: ");
            sb.AppendLine(base._edad.ToString());
            sb.Append("\nRaza: ");
            sb.AppendLine(base._raza.ToString());
            sb.Append("\nLadra: ");
            sb.AppendLine(this.Maulla.ToString());

            return sb.ToString();

        }
        public override void Jugar(string conQueJuego)
        {
            Console.WriteLine("\n{0}", conQueJuego);
        }

    }
}
