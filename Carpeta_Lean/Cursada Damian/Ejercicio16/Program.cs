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

            Alumno juanPerez = new Alumno();

            juanPerez.apellido = "Perez";
            juanPerez.legajo = 1;
            juanPerez.nombre = "Juan";

            juanPerez.Estudiar(5, 8);

            juanPerez.CalcularFinal();

            juanPerez.Mostrar();


            Alumno julianLopez = new Alumno();

            julianLopez.apellido = "Lopez";
            julianLopez.legajo = 2;
            julianLopez.nombre = "Julian";

            julianLopez.Estudiar(4, 7);

            julianLopez.CalcularFinal();

            julianLopez.Mostrar();



            Alumno diegoMilito = new Alumno();

            diegoMilito.apellido = "Milito";
            diegoMilito.legajo = 3;
            diegoMilito.nombre = "Diego";

            diegoMilito.Estudiar(8, 3);

            diegoMilito.CalcularFinal();

            diegoMilito.Mostrar();





        
        }
    }
}
