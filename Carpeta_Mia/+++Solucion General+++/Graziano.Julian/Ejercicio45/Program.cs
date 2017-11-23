using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio45
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lo que pide
            //Cree e inicialice tres Asignaturas. LISTO
            //Cree un Alumno con las tres Asignaturas.
            //Cree un Profesor que le ponga calificaciones al Alumno y
            //muestre por pantalla el promedio del Alumno.
            //Serializar a XML los objetos creados.
            #endregion

            Asignatura Matematica = new Asignatura();
            Asignatura Lengua = new Asignatura();
            Asignatura EducacionFisica = new Asignatura();

            Alumno unAlumno = new Alumno(Matematica, Lengua, EducacionFisica);
            Profesor unProfe = new Profesor();

            
            unProfe.CalificarAlumno(unAlumno);
            Console.WriteLine("El Promedio es de: \n");
            Console.WriteLine(unProfe.CalcularPromedio(unAlumno));

           
            SerializadorXML(unAlumno.Asignatura1);
            SerializadorXML(unAlumno.Asignatura2);
            SerializadorXML(unAlumno.Asignatura3);
            
            SerializadorXML(unAlumno);
            SerializadorXML(unProfe);

            /*-----IMPORTANTE------
             * Si se realiza una interfaz no se debe colocar override ya que esta implicitamente
             * (solo se debe colocar la misma firma)
             * Si realizo abstracta la clase "padre", colocando un motod abstracto, obligo a las hijas que realicen lo mismo.
             * En este caso, la clase padre SerHumano tiene una interface para que no tenga que realizar en el main los metodos de 
             * cada tipo de objeto. 
             * Estariamos sumandole cosas a la clase Padre para asi que las hereden las hijas
             * DEBO TENER SI O SI UN CONSTRUCTOR SIN PARAMETROS LAS CLASES HIJAS si la clase padre es abstracta
             * TODAS LAS CLASES DEBEN SER PUBLIC SI TENGO LA PADRE ABSTRACTA
             * EN INTERFACES NO SE DEBE AGREGAR OVERRIDE NI MODIFICADORES
            */

            
            
        }

        public static bool SerializadorXML(Serializar s)
        {
            s.Serializer();
            return true;        
        }
    }
}
