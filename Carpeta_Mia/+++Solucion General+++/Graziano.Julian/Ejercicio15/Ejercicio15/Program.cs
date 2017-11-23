using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char rta = 's';
            double num1 = 10;
            double num2 = 0;
            string operador = "/";
            double result=0;
            do
            {
                //Console.WriteLine("Calculadora");

                Console.Clear();
                Console.WriteLine("CALCULADORA\n\n");
                Console.WriteLine("Ingrese numero 1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese numero 2: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese operador: ");
                operador = Console.ReadLine();
                result=Calculadora.Calcular(num1, num2, operador);
                Calculadora.Mostrar(result);
                Console.WriteLine("\nDesea continuar?");
                rta = char.Parse(Console.ReadLine());
                //Console.ReadKey();

                
            } while (rta != 'n');



        }
    }
}
