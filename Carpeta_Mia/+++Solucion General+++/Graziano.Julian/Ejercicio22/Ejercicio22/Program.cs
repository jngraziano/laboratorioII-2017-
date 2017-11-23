using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            //resultados
            Fahrenheit resultado = new Fahrenheit();
            Fahrenheit aux = new Fahrenheit();
            Celsius resultado2 = new Celsius();
            Celsius aux2 = new Celsius();
            Kelvin resultado3 = new Kelvin();
            Kelvin aux3 = new Kelvin();

            Fahrenheit F = new Fahrenheit();
            //se puede dar valores ingresando sino
            Celsius C = new Celsius();
            Kelvin K = new Kelvin();

            char rta = 's';
            char OP;
            do
            {
                Console.Clear();
                Console.WriteLine("CALCULO");
                //Fahrenheit
                Console.WriteLine("\n\nIngrese valor en Fahrenheit: ");
                F.valor = double.Parse(Console.ReadLine());
                //validacion

                //Celcius
                Console.WriteLine("\n\nIngrese valor en Celsius: ");
                C.valor= double.Parse(Console.ReadLine());
                //validacion
                Console.WriteLine("\n\nIngrese valor en Kelvin: ");
                K.valor=double.Parse(Console.ReadLine());
                //validacion
                //Operadores
                Console.WriteLine("\n\nIngrese operador: ");
                OP = char.Parse(Console.ReadLine());
                switch (OP)
                {
                    case '+':

                        
                         aux= F + C;
                         resultado = F + K;

                         aux2 = C + F;
                         resultado2 = C + K;

                         aux3 = K + F;
                         resultado3 = K + C;


                        Console.Write("El resultado de la suma en Fahreheit: {0}", resultado.valor);
                        Console.Write("\n\nEl resultado de la suma en Celsius: {0}", resultado2.valor);
                        Console.Write("\n\nEl resultado de la suma en Kelvin: {0}", resultado3.valor);
                        Console.ReadKey();
                        break;
                    case '-':
                        aux= F - C;
                         resultado = F - K;

                         aux2 = C - F;
                         resultado2 = C - K;

                         aux3 = K - F;
                         resultado3 = K - C;

                        Console.Write("El resultado de la suma en Fahreheit: {0}", resultado.valor);
                        Console.Write("\n\nEl resultado de la suma en Celsius: {0}", resultado2.valor);
                        Console.Write("\n\nEl resultado de la suma en Kelvin: {0}", resultado3.valor);
                        Console.ReadKey();
                        break;
                    case '*':
                        aux= F * C;
                         resultado = F * K;

                         aux2 = C * F;
                         resultado2 = C * K;

                         aux3 = K * F;
                         resultado3 = K * C;

                        Console.Write("El resultado de la suma en Fahreheit: {0}", resultado.valor);
                        Console.Write("\n\nEl resultado de la suma en Celsius: {0}", resultado2.valor);
                        Console.Write("\n\nEl resultado de la suma en Kelvin: {0}", resultado3.valor);
                        Console.ReadKey();
                        break;
                    case '/':
                        aux= F / C;
                         resultado = F / K;

                         aux2 = C / F;
                         resultado2 = C / K;

                         aux3 = K / F;
                         resultado3 = K / C;

                        Console.Write("El resultado de la suma en Fahreheit: {0}", resultado.valor);
                        Console.Write("\n\nEl resultado de la suma en Celsius: {0}", resultado2.valor);
                        Console.Write("\n\nEl resultado de la suma en Kelvin: {0}", resultado3.valor);
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No es un operador. ");
                        break;
                }
                Console.WriteLine("\n\nDesea continuar?: ");
                rta = char.Parse(Console.ReadLine());
            } while (rta != 'n');
        }
    }
}
