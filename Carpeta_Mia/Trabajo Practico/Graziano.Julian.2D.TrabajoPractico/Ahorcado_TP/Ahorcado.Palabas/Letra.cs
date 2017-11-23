using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahorcado.Palabras;

namespace Ahorcado.Palabras
{
    class Letra
    {
         private char _caracter;
        private bool _estaVisible;

        public char caracter
        {
            get { return this._caracter; }
            set { this._caracter = value; }
    
        }
        public bool EstaVisible
        {
            get { return this._estaVisible; }
            set { this._estaVisible = value; }
        
        }

        public Letra()
        {
            this.caracter = 'a';
            this.EstaVisible = false;
        }

        public Letra(char caracter, bool estaVisible):this()
        {

            this.caracter = caracter;
            if (this.caracter == ' ' )
            {
                this.EstaVisible = true;
            }
            else 
            {
                this.EstaVisible = estaVisible;
            }
                

        }
    }
}
