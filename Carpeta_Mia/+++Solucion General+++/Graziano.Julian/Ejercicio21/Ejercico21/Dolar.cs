using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico21
{
    class Dolar
    {
       
        public double valor;
        

        public static Dolar operator +(Dolar D, Euro E)
        {
            Dolar resultado = new Dolar();

            resultado.valor = D.valor + (E.valor * 1.3642);


            return resultado;



        }
        public static Dolar operator -(Dolar D, Euro E)
        {
            Dolar resultado = new Dolar();

            resultado.valor = D.valor - (E.valor * 1.3642);


            return resultado;



        }
        public static Dolar operator *(Dolar D, Euro E)
        {
            Dolar resultado = new Dolar();

            resultado.valor = D.valor * (E.valor * 1.3642);


            return resultado;



        }

        public static Dolar operator /(Dolar D, Euro E)
        {
            Dolar resultado = new Dolar();

            resultado.valor = D.valor / (E.valor * 1.3642);


            return resultado;



        }
        public static double ValidarDolar(double a)
        {
            while (a == 0)
            {
                Console.WriteLine("\nError. No puede ser 0. Reingrese: ");
                a = double.Parse(Console.ReadLine());

            }

            return a;

        }

    }
}
