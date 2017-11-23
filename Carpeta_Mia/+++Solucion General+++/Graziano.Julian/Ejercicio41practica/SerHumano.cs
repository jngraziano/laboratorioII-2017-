using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41practica
{
    class SerHumano
    {
        protected string _nombre;
        protected Single _peso;
        protected Single _altura;
        protected string _sexo;

        public SerHumano(string Nombre, Single peso, Single Altura, string Sexo)
        {
            this._nombre = Nombre;
            this._peso = peso;
            this._altura = Altura;
            this._sexo = Sexo;
        
        }


        #region Metodos
        public string Comer(string comida)
        {
            if (comida == "Frito")
            {
                this._peso = 150;
                StringBuilder sb = new StringBuilder();
                sb.Append("\nEl peso es de: ");
                sb.AppendLine(this._peso.ToString());
                sb.Append("\nDebería bajar de peso");
                return sb.ToString();
            }
            else
            {
                this._peso = 75;
                StringBuilder sb = new StringBuilder();
                sb.Append("\nEl peso es de: ");
                sb.AppendLine(this._peso.ToString());
                sb.Append("\nSe encuentra optimas condiciones.");
                return sb.ToString();
            }
            
        }
       
        #endregion

    }
}
