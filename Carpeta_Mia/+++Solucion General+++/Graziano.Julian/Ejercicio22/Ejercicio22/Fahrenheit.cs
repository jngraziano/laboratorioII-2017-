using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Fahrenheit
    {
        public double valor;
        //public Fahrenheit valor2 = new Fahrenheit();

        public static Fahrenheit operator +(Fahrenheit F, Celsius C)
        {
            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor + ((F.valor-32)*(5/9))* (9/5)+32;


            return resultado;



        }
        public static Fahrenheit operator +(Fahrenheit F, Kelvin K)
        {
            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor + (K.valor*(9/5)-459.67);


            return resultado;



        }
        public static Fahrenheit operator -(Fahrenheit F, Celsius C)
        {


            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor - ((F.valor - 32) * (5 / 9)) * (9 / 5) + 32;


            return resultado;



        }
        public static Fahrenheit operator -(Fahrenheit F, Kelvin K)
        {


            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor - (K.valor * (9 / 5) - 459.67);


            return resultado;



        }
        public static Fahrenheit operator *(Fahrenheit F, Celsius C)
        {
            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor * ((F.valor - 32) * (5 / 9)) * (9 / 5) + 32;


            return resultado;



        }
        public static Fahrenheit operator *(Fahrenheit F, Kelvin K)
        {


            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor * (K.valor * (9 / 5) - 459.67);


            return resultado;



        }
        public static Fahrenheit operator /(Fahrenheit F, Celsius C)
        {
            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor * ((F.valor - 32) * (5 / 9)) * (9 / 5) + 32;


            
            return resultado;



        }
        public static Fahrenheit operator /(Fahrenheit F, Kelvin K)
        {


            Fahrenheit resultado = new Fahrenheit();

            resultado.valor = F.valor / (K.valor * (9 / 5) - 459.67);


            return resultado;



        }

    }
}
