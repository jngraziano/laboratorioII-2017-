using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Usuario
    {
        private string _apellido;
        private double _dni;
        private string _nombre;

       
        //public Usuario()
        //{ 
        //   //aca se inicializaria la variable que quiera, en caso de que me den el valor fijo 
        //    Usuario uno = new Usuario("Agua", "Rogelio", 111);
        //    Usuario dos = new Usuario("Mercurio", "Alfredo", 222);

        //}

        
        public Usuario(double dni)
        {
            this._dni = dni;
        }
        
        
        public Usuario(string nombre, double dni):this(dni)
        {
            this._nombre = nombre;
        }
        
        public Usuario(string apellido,string nombre,double dni):this(nombre,dni)
        {
            this._apellido = apellido;
        }
        
        public double Dni
        {
            get { return this._dni; }
    
        }

        private string DevolverDatosFormatoString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Apellido: ");
            sb.AppendLine(this._apellido);
            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Dni: ");
            sb.AppendLine(this.Dni.ToString());
            
            return sb.ToString();
        
        
        }
        public string Mostrar(Usuario UsuarioActual)
        {
            return UsuarioActual.DevolverDatosFormatoString();

        
        }




    }
}
