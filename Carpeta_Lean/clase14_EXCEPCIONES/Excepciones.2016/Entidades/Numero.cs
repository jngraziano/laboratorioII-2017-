using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        protected int _numero;
        public int Number { get { return this._numero; } }

        public Numero(int numero)
        {
            this._numero = numero;
        }

        public static int operator +(Numero n1, Numero n2)
        {
            return n1.Number + n2.Number;
        }
        public static int operator -(Numero n1, Numero n2)
        {
            return n1.Number - n2.Number;
        }
        public static int operator *(Numero n1, Numero n2)
        {
            return n1.Number * n2.Number;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.Number / n2.Number;
        }
    }
}
