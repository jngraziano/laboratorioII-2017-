using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return a._color == b._color && a._marca == b._marca;
        }
        
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "Marca: "+this._marca+" - Color: "+this._color;
        }

        public override bool Equals(object obj)
        {
            return obj is Auto && this == (Auto)obj;
        }

    }
}
