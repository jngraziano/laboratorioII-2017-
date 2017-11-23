using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double acum;
            bool rta;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                num2 = double.Parse(Console.ReadLine());
                
                acum = num1 + num2;
                Console.WriteLine("\n\nSuma: {0}", acum);
                rta=ValidarRespuesta.ValidaS_N();


            } while (rta != false);

            Console.ReadKey();
        }
    }
}
