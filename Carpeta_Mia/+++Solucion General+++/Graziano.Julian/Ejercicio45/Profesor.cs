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
    public class Profesor:SerHumano
    {
        #region Metodos
        public void CalificarAlumno(Alumno unAlumno)
        { 
//        tendrá un método CalificarAlumno, que recibe un
////parámetro de tipo Alumno y que no devuelve nada. 
            //Pondrá una
        //calificación aleatoria a cada una de las asignaturas del alumno,
        //para ello utilizar el método NextDouble de la clase Random.

           unAlumno.CalificarAlumno(); 
                  
        }
        public double CalcularPromedio(Alumno unAlumno)
        {
 //Además tendrá un método llamado CalcularPromedio que recibe un
//parámetro de tipo Alumno y devuelve un Double.

            return unAlumno.CalcularPromedio();

        }

        public override bool Serializer()
        {
            XmlTextWriter xml = new XmlTextWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio45\XmlProfesor.xml", Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(typeof(Profesor));
            xmlS.Serialize(xml, this);
            xml.Close();

            return true;
        }
        #endregion
    }
}
