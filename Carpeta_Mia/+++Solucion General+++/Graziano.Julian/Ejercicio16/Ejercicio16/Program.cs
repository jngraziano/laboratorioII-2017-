using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Alum = new Alumno();
            Alumno Alum2 = new Alumno();
            Alumno Alum3 = new Alumno();

            Alum.Estudiar(3,10);
            Alum2.Estudiar(5, 5);
            Alum3.Estudiar(3, 2);

            Alum.apellido = "Garcia";
            Alum.nombre = "Juan";
            Alum.legajo = 123;

            Alum2.apellido = "Garca";
            Alum2.nombre = "pedro";
            Alum2.legajo = 321;

            Alum3.apellido = "Nostradamus";
            Alum3.nombre = "perico";
            Alum3.legajo = 567;

            Alum.CalcularFinal();
            Alum2.CalcularFinal();
            Alum3.CalcularFinal();

            Alum.Mostrar();
            Console.ReadKey();
            Alum2.Mostrar();
            Console.ReadKey();
            Alum3.Mostrar();
            Console.ReadKey();
            
        }
    }
}
