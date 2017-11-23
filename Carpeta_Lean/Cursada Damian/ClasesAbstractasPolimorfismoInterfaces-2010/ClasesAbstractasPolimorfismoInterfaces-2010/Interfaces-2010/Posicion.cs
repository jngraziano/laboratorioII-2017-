using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Posicion
    {
        #region Atributos

        private int _x;
        private int _y;

        #endregion

        #region Propiedades

        public int PosX 
        {
            get { return this._x; }
            set { this._x = value; } 
        }
        
        public int PosY 
        {
            get { return this._y; }
            set { this._y = value; }
        }

        #endregion

        #region Constructor

        public Posicion(int x, int y)        
        {
            this._x = x;
            this._y = y;
        }

        #endregion
    }
}
