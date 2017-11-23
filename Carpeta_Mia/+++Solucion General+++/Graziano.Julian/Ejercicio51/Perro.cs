using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    sealed class Perro:Mascota
    {
        public bool Ladra;

        public Perro()
        { }

        public Perro(string NombrePerro, ERaza razaPerro):base(NombrePerro,razaPerro)
        {
            this.Ladra = true;
        }

        public Perro(string NombrePerro, int edadPerro, ERaza razaPerro):base(NombrePerro,edadPerro,razaPerro)
        { }

        public static ERaza RetornarRaza(Perro perrito)
        {
            return perrito._raza;
        
        }

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
            sb.AppendLine(this.Ladra.ToString());

            return sb.ToString();
            
        }

        public override void Jugar(string conQueJuego)
        {
            Console.WriteLine("\n{0}",conQueJuego);
        }




    }
}
