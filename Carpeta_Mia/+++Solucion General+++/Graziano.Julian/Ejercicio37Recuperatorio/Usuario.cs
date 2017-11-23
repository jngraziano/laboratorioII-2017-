using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37Recuperatorio
{
    class Usuario
    {
        private string _apellido;
        private double _dni;
        private string _nombre;


        public double Dni { get { return this._dni; } }

        public Usuario(string apellido, string nombre, double dni)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = dni;
        
        }
        
        private string DevolverDatosFormatoString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Apellido: ");
            sb.AppendLine(this._apellido);
            sb.Append("\nNombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("\nDNI: ");
            sb.AppendLine(this._dni.ToString());
            return sb.ToString();
        
        }
        public string Mostrar(Usuario UsuarioActual)
        {
            return UsuarioActual.DevolverDatosFormatoString();
        
        }


    }
}
