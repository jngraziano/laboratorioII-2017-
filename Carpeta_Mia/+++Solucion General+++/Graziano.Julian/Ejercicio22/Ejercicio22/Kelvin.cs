using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Kelvin
    {
        public double valor;

        public static Kelvin operator +(Kelvin K, Fahrenheit F)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor =K.valor + (F.valor+459.67)*(5/9);

            return resultado;



        }
        public static Kelvin operator +(Kelvin K, Celsius C)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor + ((C.valor*(9/5)+32)+459.67)*(5/9);

            return resultado;



        }
        public static Kelvin operator -(Kelvin K, Fahrenheit F)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor - (F.valor + 459.67) * (5 / 9);

            return resultado;



        }
        public static Kelvin operator -(Kelvin K, Celsius C)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor - ((C.valor * (9 / 5) + 32) + 459.67) * (5 / 9);

            return resultado;



        }
        public static Kelvin operator *(Kelvin K, Fahrenheit F)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor * (F.valor + 459.67) * (5 / 9);

            return resultado;



        }
        public static Kelvin operator *(Kelvin K, Celsius C)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor * ((C.valor * (9 / 5) + 32) + 459.67) * (5 / 9);

            return resultado;



        }
        public static Kelvin operator /(Kelvin K, Fahrenheit F)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor / (F.valor + 459.67) * (5 / 9);

            return resultado;



        }
        public static Kelvin operator /(Kelvin K, Celsius C)
        {
            Kelvin resultado = new Kelvin();

            resultado.valor = K.valor / ((C.valor * (9 / 5) + 32) + 459.67) * (5 / 9);

            return resultado;



        }

    }
}
