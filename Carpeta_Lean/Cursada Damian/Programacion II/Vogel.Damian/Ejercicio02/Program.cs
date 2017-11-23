using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro. 2";

            
            double numero1 = 0.00;
            double numero2 = 0.00;
            double potencia = 0;



            Console.WriteLine("Ingrese numero para elevar: ");
            numero1 = Double.Parse(Console.ReadLine());

            while (numero1 == 0)
                {
                    Console.WriteLine("ERROR. Reingresar número!!!");
                    numero1 = Double.Parse(Console.ReadLine());
                }

            Console.WriteLine("Elija a que potencia sera elevado:");
            potencia = Double.Parse(Console.ReadLine());

            numero2 = Math.Pow(numero1,potencia);

            Console.WriteLine("El resultado es: {0}", numero2);
            Console.ReadLine();
        



        }
    }
}
