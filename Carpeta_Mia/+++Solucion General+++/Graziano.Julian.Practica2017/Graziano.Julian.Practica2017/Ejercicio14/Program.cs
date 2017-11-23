using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //14.Realizar una clase llamada ‗CalculoDeArea‘ que posea 3 métodos de
            //clase (estáticos), double CalcularCuadrado(double), double
            //CalcularTriangulo(double, double) y double
            //CalcularCirculo(double), que realicen el cálculo del área que
            //corresponda.
            //El ingreso de los datos como la visualización se deberán realizar
            //desde el método Main()
            int op;
            char rta = 's';
            double aux, aux1;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU de AREAS");
                Console.WriteLine("\n1 - Area de un Cuadrado.");
                Console.WriteLine("\n2 - Area de un Triangulo.");
                Console.WriteLine("\n3 - Area de un Circulo.");
                Console.WriteLine("\n4 - Salir.");
                Console.WriteLine("\n\nIngrese opción deseada: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("AREA de un CUADRADO");
                        Console.WriteLine("\nIngrese valor del lado: ");
                        aux = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nResultado: ");
                        Console.WriteLine(CalculoDeArea.CalcularCuadrado(aux));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("AREA de un TRIANGULO");
                        Console.WriteLine("\nIngrese valor de base: ");
                        aux = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIngrese valor de altura: ");
                        aux1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nResultado: ");
                        Console.WriteLine(CalculoDeArea.CalcularTriangulo(aux, aux1));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("AREA DE UN CIRCULO");
                        Console.WriteLine("\nIngrese valor de radio: ");
                        aux = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\nResultado: ");
                        Console.WriteLine(CalculoDeArea.CalcularCirculo(aux));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n\n\nDesea Salir (S/N): ");
                        rta = char.Parse(Console.ReadLine());
                        break;
                    default: break;
                }


            } while (rta != 'n');
            Console.ReadKey();
        }
    }
}
