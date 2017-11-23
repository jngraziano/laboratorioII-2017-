using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tempera
    {
        private ConsoleColor _color;
        private int _cantidad;
        private string _marca;

        public Tempera(ConsoleColor col, int cant, string marc)
        {
            this._color = col;
            this._cantidad = cant;
            this._marca = marc;
        }

        private string Mostrar()
        {
            return this._color.ToString() + " " + this._cantidad.ToString() + " " + (this._marca.Substring(0, 1)).ToUpper() + (this._marca.Substring(1, this._marca.Length - 1)).ToLower();
        }

        
      public static string Mostrar (Tempera temp) 
       {

           return temp.Mostrar();
       }

      
        //Sobrecarga de operador igual, en color y en Marca
        public static bool operator ==(Tempera temp, Tempera t)
      {
          if (temp._marca == t._marca && temp._color == t._color)
          {
              return true;
          }
          else
          {
              return false;
          }
                          
      }

        public static bool operator !=(Tempera temp, Tempera t)
        {
            return !(temp==t);
        }
    }
}
