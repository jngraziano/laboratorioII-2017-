using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    class Persona
    {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        
        }
        //poliformismo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nNombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("\nEdad: ");
            sb.AppendLine(this.edad.ToString());
           
            return sb.ToString();
        }
    }
}
