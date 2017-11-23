using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_SobrecargaOperadores
{
    class Centimetro
    {
        //public double valor; PRIMERA VERSION
        private double valor;

         public Centimetro(int numero)
        {
            this.valor = numero;
        }

        public static Centimetro operator +(Centimetro c, Metro m) 
        {
            //Centimetro r2 = new Centimetro(); PRIMERA VERSION
            Centimetro r2 = new Centimetro(10);
            //r2.valor = c.valor + m.valor * 100; PRIMERA VERSION
            return r2;
        }

    }
}
