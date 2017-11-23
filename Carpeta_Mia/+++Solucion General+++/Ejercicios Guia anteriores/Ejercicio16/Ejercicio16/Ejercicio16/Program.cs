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
            Console.Title = "Ejercicio 16";

            Alumno miAlumno=new Alumno();
            Alumno miAlumnoDos = new Alumno();
            Alumno miAlumnoTres = new Alumno();

            miAlumno.nombre = "Carlos";
            miAlumno.apellido = "Perez";
            miAlumno.legajo = 123;
            miAlumno.Estudiar(5, 3);
            miAlumno.CalcularFinal();

            miAlumnoDos.nombre = "QUACA";
            miAlumnoDos.apellido = "Pq";
            miAlumnoDos.legajo = 987;
            miAlumnoDos.Estudiar(1, 7);
            miAlumnoDos.CalcularFinal();

            miAlumnoTres.nombre = "Pedro";
            miAlumnoTres.apellido = "Pez";
            miAlumnoTres.legajo = 456;
            miAlumnoTres.Estudiar(2, 9);
            miAlumnoTres.CalcularFinal();

            miAlumno.Mostrar();
            miAlumnoDos.Mostrar();
            miAlumnoTres.Mostrar();

            Console.ReadKey();
        }
    }
}
