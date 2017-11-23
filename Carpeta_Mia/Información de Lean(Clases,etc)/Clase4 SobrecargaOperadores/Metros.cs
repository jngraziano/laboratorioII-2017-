using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_SobrecargaOperadores
{
    class Metro
    {
        //public double valor; PRIMEA VERSION
        private double valor;

        public Metro(int numero)
        {
            this.valor = numero;
        }

        public static Metro operator +(Metro m, Centimetro c) 
        {
            //Metro r = new Metro(); PRIMERA VERSION
            Metro r = new Metro(10);
            //r.valor = m.valor + c.valor / 100; PRIMERA VERSION
            return r;
        }

        public static explicit operator double(Metro m)
        {
            return m.valor;
        } 
        
    }
}
