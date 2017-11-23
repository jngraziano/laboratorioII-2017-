using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio45
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            //Desarrolle una clase llamada Asignatura que:
            //Tenga dos atributos privados, uno de tipo entero (el
            //identificador) y el otro de tipo decimal (la calificación).
            //Dicha clase tendrá un constructor con un parámetro de tipo
            //entero.
            //Tomando la clase SerHumano, diseñada en el ejercicio 41, se pide:
            //Modificarla para que sea abstracta y ‗padre‘ de las clases Alumno
            //y Profesor.
            //La clase Alumno tendrá tres atributos privados de tipo
            //Asignatura, un constructor con tres parámetros de tipo Asignatura
            //que inicialice los tres atributos.
            //La clase Profesor tendrá un método CalificarAlumno, que recibe un
            //parámetro de tipo Alumno y que no devuelve nada. Pondrá una
            //calificación aleatoria a cada una de las asignaturas del alumno,
            //para ello utilizar el método NextDouble de la clase Random.
            //Además tendrá un método llamado CalcularPromedio que recibe un
            //parámetro de tipo Alumno y devuelve un Double.
            //Por último, desarrollar una clase llamada Test, que en su método
            //Main:
            //Cree e inicialice tres Asignaturas.
            //Cree un Alumno con las tres Asignaturas.
            //Cree un Profesor que le ponga calificaciones al Alumno y
            //muestre por pantalla el promedio del Alumno.
            //Serializar a XML los objetos creados.
            #endregion

            //Cree e inicialice tres Asignaturas. LISTO
            //Cree un Alumno con las tres Asignaturas.
            //Cree un Profesor que le ponga calificaciones al Alumno y
            //muestre por pantalla el promedio del Alumno.
            //Serializar a XML los objetos creados.

            Asignatura mat = new Asignatura(20);
            Asignatura lengua = new Asignatura(11);
            Asignatura compu = new Asignatura(33);

            Alumno alumno1 = new Alumno(mat,lengua,compu);

            Profesor profe1 = new Profesor();
            profe1.CalificarAlumno(alumno1);
            Console.WriteLine("PROMEDIO:\n");
            Console.WriteLine(profe1.CalcularPromedio(alumno1));

            Console.ReadKey();

        }
    }
}
