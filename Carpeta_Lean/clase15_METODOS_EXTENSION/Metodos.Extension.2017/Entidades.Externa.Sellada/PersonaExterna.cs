using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Externa.Sellada
{
    public sealed class PersonaExternaSellada
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private ESexo _sexo;

        public PersonaExternaSellada(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public ESexo Sexo { get { return this._sexo; } }

    }
}
