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
    class Profesor:SerHumano
    {
        //La clase Profesor tendrá un método CalificarAlumno, que recibe un
        //parámetro de tipo Alumno y que no devuelve nada. Pondrá una
        //calificación aleatoria a cada una de las asignaturas del alumno,
        //para ello utilizar el método NextDouble de la clase Random.
        //Además tendrá un método llamado CalcularPromedio que recibe un
        //parámetro de tipo Alumno y devuelve un Double.

        public void CalificarAlumno(Alumno alumno1)
        {
            Random ram = new Random();
            alumno1.Asignatura1.Calificación = ram.NextDouble();
            
        }

        public double CalcularPromedio(Alumno alumno1)
        {
            return (alumno1.Asignatura1.Calificación + alumno1.Asignatura2.Calificación + alumno1.Asignatura3.Calificación) / 3;
        }
        public override bool Serializer()
        {
            XmlTextWriter xmlT = new XmlTextWriter(@"D:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian.Practica2017\Graziano.Julian.Practica2017\Ejercicio45\xmlprofe.xml", Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(typeof(Profesor));
            xmlS.Serialize(xmlT, this);
            xmlT.Close();
            return true;

        }

    }
}
