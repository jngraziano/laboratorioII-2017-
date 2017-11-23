using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4_operadoresSobreCargados
{
    class Program
    {
        static void Main(string[] args)
        {

            Centimetro resultado;
            Metro metro = 2;
            Centimetro centimetro = 100;
       
            
            resultado = centimetro + metro;

            metro++;
            centimetro++;

            Console.WriteLine((double)resultado);
            Console.ReadLine();

            if (metro == centimetro)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            
            } 

           

            Console.WriteLine((double)metro );
            Console.WriteLine((double)centimetro);
            Console.ReadLine();

            resultado = centimetro + 20;

            Console.WriteLine("el resultado despues de {0}",(double)resultado);
            Console.ReadLine();

            Centimetro centimetro1 = 10;
            centimetro = 20;

            resultado = centimetro / centimetro1;

            Console.WriteLine("el resultado de la division de centimetro es {0}",(double)resultado);
            Console.ReadLine();


            metro = 10;
            Metro metro1 = 2;
            Metro resultadoMetro = metro / metro1;

            Console.WriteLine("el resultado de la division de metros es {0}", (double)resultadoMetro);
            Console.ReadLine();

        }


    }
}
