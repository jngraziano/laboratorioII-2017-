using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMER EJERCICIO HERENCIA
            Console.Title = "Ejercico 41";
            Empleado aux1 = new Empleado();
            Gerente aux2 = new Gerente();
            SerHumano aux3 = new SerHumano();
            char rta = 's';
            do
            {
                aux1.peso = 100;
                aux1.nombre = "Juan";
                aux1.cargaHoraria = 56;
                aux1.altura = 1.90F;
                aux1.sexo = "Hombre";
                Console.WriteLine("\nDetalles segùn datos: \n");
                aux1.MostrarDatos();
                Console.WriteLine("\nSueldo:");
                Console.WriteLine(aux1.Trabajar() + "\n");
                aux1.dormir();



                Console.WriteLine(aux1.comer());
                Console.ReadKey();
                Console.Clear();

                aux2.peso = 10;
                aux2.nombre = "Carla";
                aux2.cargaHoraria = 10;
                aux2.altura = 1.13F;
                aux2.sexo = "Mujer";
                Console.WriteLine("\nDetalles segùn datos: \n");
                aux2.MostrarDatos();
                Console.WriteLine("\nSueldo:");
                Console.WriteLine(aux2.Trabajar() + "\n");
                aux2.dormir();
                Console.WriteLine(aux2.comer());
                Console.ReadKey();

                Console.WriteLine("\nContinuar? ");
                rta = aux3.validaCHAR(char.Parse(Console.ReadLine()));



            } while (rta != 'n');


        }
    }
}
