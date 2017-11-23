using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico21
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro resultado = new Euro();
            Dolar resultado2 = new Dolar();

            Euro E = new Euro();
            //E.valor = 10;
            Dolar D = new Dolar();
            //D.valor = 5;
            char rta = 's';
            char OP;
            do
            {
                Console.Clear();
                Console.WriteLine("CALCULO");
                //Euros
                Console.WriteLine("\n\nIngrese valor en Euros: ");
                E.valor = double.Parse(Console.ReadLine());
                E.valor = Euro.ValidarEuro(E.valor);

                //Dolares
                Console.WriteLine("\n\nIngrese valor en Dolares: ");
                D.valor = double.Parse(Console.ReadLine());
                D.valor = Dolar.ValidarDolar(D.valor);
                
                //Operadores
                Console.WriteLine("\n\nIngrese operador: ");
                OP = char.Parse(Console.ReadLine());
                switch(OP)
                {
                    case '+':
                        resultado = E + D;

                        resultado2 = D + E;

                       Console.Write("El resultado de la suma en Euros: {0}", resultado.valor);
                       Console.Write("\n\nEl resultado de la suma en Dolares: {0}", resultado2.valor);
                       Console.ReadKey();
                       break;
                    case '-':
                       resultado = E - D;
                       resultado2 = D - E;
                       
                       Console.Write("El resultado de la resta en Euros: {0}", resultado.valor);
                       Console.Write("\n\nEl resultado de la resta en Dolares: {0}", resultado2.valor);
                       Console.ReadKey();
                       break;
                    case '*':
                       resultado = E * D;
                       resultado2 = D * E;
                        Console.Write("El resultado de la multiplicacion en Euros: {0}", resultado.valor);
                        Console.Write("\n\nEl resultado de la multiplicacion en Dolares: {0}", resultado2.valor);
                       Console.ReadKey();
                       break;
                    case '/':
                        resultado = E / D;
                        resultado2 = D / E;
                        Console.Write("El resultado de la division en Euros: {0}", resultado.valor);
                        Console.Write("\n\nEl resultado de la division en Dolares: {0}", resultado2.valor);
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
