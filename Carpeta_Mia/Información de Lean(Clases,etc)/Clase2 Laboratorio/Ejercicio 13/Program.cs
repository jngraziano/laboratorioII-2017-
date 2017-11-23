using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        static void Main(string[] args)
        {
            double resultado = BinarioDecimal("10000");
            Console.WriteLine("El valor es {0}", resultado);
            Console.ReadLine();
        }

        public static string DecimalBinario(double valor)
        {
            string cadenaresultado="";
            do
            {
                cadenaresultado = int.Parse((valor % 2).ToString()) + cadenaresultado;
                valor = int.Parse( Math.Floor(valor / 2).ToString());             
            }
            while (valor > 1);

            cadenaresultado = valor + cadenaresultado;

            return cadenaresultado;
        }

        public static double BinarioDecimal(string cadena)
        {
             int longitudcadena = cadena.Length;
             double acumulador = 0;
             int potencia = 0;

             for (int i= longitudcadena; i > 0; i--)
             {            
                 double valor = double.Parse(cadena.Substring(i - 1, 1))* Math.Pow(2,potencia);
                 acumulador = acumulador + valor;
                 potencia = potencia+ 1;
             }

             return acumulador;
        }
    }
}