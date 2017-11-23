using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4_operadoresSobreCargados
{
    class Metro
    {

       private double _valor;

       private Metro(double a)
       {
           this._valor = a;
       }


        public static Metro operator +(Metro m, Centimetro c)
        {
            Metro r = new Metro(m._valor);


            r._valor = m._valor + ((double)c)/100;

            return r;
        }

        public static explicit operator double(Metro a)
        {
            return a._valor;

        }

        public static  implicit operator Metro (double a)
        {
            Metro r = new Metro(a);

            return r;
        }

        public static bool operator ==(Centimetro c, Metro m)
        {
            return ((double)m) == ((double)c)/100;
        }


        public static bool operator != (Centimetro c,Metro m)
        {
            //return  ((double)m) / 100 != ((double)c);
            return !(m == c);

        }

        public static Metro operator ++(Metro m)
        {
            m._valor += 1;

            return m;
        }

        public static Metro operator +(Metro m, double d)
        {
            m._valor = (double)m + d;

            return m;
        }

        public static double operator /(Metro a, Metro b)
        {
            return a._valor / b._valor;
        
        }


        public static MetroCuadrado operator *(Metro a, Metro b)
        {
            return new MetroCuadrado(a._valor * b._valor);
        
        }

    }
}
