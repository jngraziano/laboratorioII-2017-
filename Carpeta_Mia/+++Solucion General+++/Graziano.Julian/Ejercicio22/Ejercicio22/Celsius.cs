using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Celsius
    {
        public double valor;

        public static Celsius operator +(Celsius C, Fahrenheit F)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor + (F.valor*(9/5)+35);
            
            return resultado;



        }
        public static Celsius operator +(Celsius C, Kelvin K)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor + ((K.valor*(9/5)+32)+459.67*(5/9));
            return resultado;



        }
        public static Celsius operator -(Celsius C, Fahrenheit F)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor - (C.valor * (9 / 5) + 32);

            return resultado;



        }
        public static Celsius operator -(Celsius C, Kelvin K)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor - ((K.valor * (9 / 5) + 32) + 459.67 * (5 / 9));
            return resultado;



        }
        public static Celsius operator *(Celsius C, Fahrenheit F)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor * (C.valor * (9 / 5) + 32);

            return resultado;



        }
        public static Celsius operator *(Celsius C, Kelvin K)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor * ((K.valor * (9 / 5) + 32) + 459.67 * (5 / 9));
            return resultado;



        }
        public static Celsius operator /(Celsius C, Fahrenheit F)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor / (C.valor * (9 / 5) + 32);

            return resultado;



        }
        public static Celsius operator /(Celsius C, Kelvin K)
        {
            Celsius resultado = new Celsius();

            resultado.valor = C.valor / ((K.valor * (9 / 5) + 32) + 459.67 * (5 / 9));
            return resultado;



        }
    }
}
