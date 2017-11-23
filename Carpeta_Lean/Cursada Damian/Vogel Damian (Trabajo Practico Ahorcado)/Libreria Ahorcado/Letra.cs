using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Ahorcado
{
    public class Letra
    {
        private char _caracter;
        private bool _estaVisible;

        public bool EstaVisible
        {
            get { return _estaVisible; }
            set { _estaVisible = value; }
        }
        


        public char Caracter
        {
            get { return _caracter; }
            set { _caracter = value; }
        }

        public Letra(char caracter, bool estaVisible)
        {
            this._caracter = caracter;
            this._estaVisible = estaVisible;
        
        }
    
    
    
    }
}
