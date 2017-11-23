using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tempera
    {
        private ConsoleColor _color;
        private String _marca;
        private Int32 _cantidad;

        public Tempera(ConsoleColor color, String marca, Int32 cantidad)
        {
            this._cantidad = cantidad;
            this._color = color;
            this._marca = marca;
        }

        private string Mostrar()
        {
            return this._marca + " - " + this._cantidad + " - " + this._color;
        }

        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        public static Boolean operator ==(Tempera t, Tempera tt)
        {
            return t._marca == tt._marca && t._color == tt._color;
        }

        public static Boolean operator !=(Tempera t, Tempera tt)
        {
            return !(t==tt);
        }

        public static implicit operator Int32(Tempera t)
        {
            return t._cantidad;
        }

        public static explicit operator String(Tempera t)
        {
            return t.Mostrar();
        }

        public static Tempera operator +(Tempera t, Int32 d)
        {
            t._cantidad += d;
            return t;
        }

        public static Tempera operator +(Tempera t, Tempera tt)
        {
            if (t == tt)
            {
                t += tt._cantidad;
            }

            return t;
        }

        public int Cantidad { set { this._cantidad = value; } }

    }
}
