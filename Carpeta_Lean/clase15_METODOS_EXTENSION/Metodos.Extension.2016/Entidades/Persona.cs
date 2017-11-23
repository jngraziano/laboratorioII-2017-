using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        #region #1.- Propiedades
        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public ESexo Sexo { get { return this._sexo; } }
        #endregion

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

        #region #2.- Método
        public string ObtenerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(this._apellido);
            sb.Append("Edad: ");
            sb.AppendLine(this._edad.ToString());
            sb.Append("Sexo: ");
            sb.AppendLine(this._sexo.ToString());

            return sb.ToString();
        }
        #endregion

    }
}
