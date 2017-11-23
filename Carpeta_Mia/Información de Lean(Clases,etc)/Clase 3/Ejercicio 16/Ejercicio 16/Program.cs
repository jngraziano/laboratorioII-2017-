using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno miAlumnoUno = new Alumno();
            Alumno miAlumnoDos = new Alumno();
            Alumno miAlumnoTres = new Alumno();

            miAlumnoUno.nombre = "Pedro";
            miAlumnoUno.apellido = "Perez";
            miAlumnoUno.legajo = 123;
            miAlumnoUno.Estudiar(1, 3);
            miAlumnoUno.CalcularFinal();

            miAlumnoDos.nombre = "Juan";
            miAlumnoDos.apellido = "Lopez";
            miAlumnoDos.legajo = 456;
            miAlumnoDos.Estudiar(4, 6);
            miAlumnoDos.CalcularFinal();

            miAlumnoTres.nombre = "Pablo";
            miAlumnoTres.apellido = "Picapiedra";
            miAlumnoTres.legajo = 789;
            miAlumnoTres.Estudiar(7, 9);
            miAlumnoTres.CalcularFinal();

            miAlumnoUno.Mostrar();
            miAlumnoDos.Mostrar();
            miAlumnoTres.Mostrar();

            Console.ReadKey();
        }
    }
}
