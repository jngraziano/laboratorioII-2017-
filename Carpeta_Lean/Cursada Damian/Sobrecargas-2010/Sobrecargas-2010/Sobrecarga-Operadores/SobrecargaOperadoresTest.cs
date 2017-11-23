using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga_de_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREO UN OBJETO DE TIPO METRO
            Metro metros = new Metro(10);

            //CREO UN OBJETO DE TIPO CENTIMETRO
            Centimetro centimetros = new Centimetro(10);

            //UTILIZO LA SOBRECARGA DEL OPERADOR + EN LA CLASE METRO
            Metro SumaMetros = metros + centimetros;

            //UTILIZO LA SOBRECARGA DEL OPERADOR + EN LA CLASE CENTIMETRO
            Centimetro SumaCentimetros = centimetros + metros;
            
            //MUESTRO LOS RESULTADOS EN METROS Y CENTIMETROS
            Console.WriteLine("{0} mts. + {1} cms. = {2} mts.",metros.cantidad, 
                                centimetros.cantidad, SumaMetros.cantidad);
            Console.ReadLine();

            Console.WriteLine("{0} cms. + {1} mts. = {2} cms.", centimetros.cantidad,
                                metros.cantidad, SumaCentimetros.cantidad);
            Console.ReadLine();

            Console.WriteLine("CONVERSIONES EXPLÍCITAS");

            //UTILIZO CONVERSION EXPLICITA DE UN DOUBLE A METRO
            metros = (Metro)10;

            //UTILIZO CONVERSION EXPLICITA DE UN DOUBLE A CENTIMETRO
            centimetros = (Centimetro)10;

            SumaMetros = metros + centimetros;
            SumaCentimetros = centimetros + metros;

            //MUESTRO LOS RESULTADOS UTILIZANDO UNA
            //CONVERSION EXPLICITA DE METRO A DOUBLE.
            Console.WriteLine((double)SumaMetros);


            //MUESTRO LOS RESULTADOS UTILIZANDO UNA
            //CONVERSION EXPLICITA DE CENTIMETRO A DOUBLE.
            Console.WriteLine((double)SumaCentimetros);

            Console.ReadKey();

        }
    }
}
