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
    public class Alumno:SerHumano
    {

        #region Atributos y Constructor
        private Asignatura _asignatura1;
        private Asignatura _asignatura2;
        private Asignatura _asignatura3;

        public Asignatura Asignatura1 { get { return this._asignatura1; } set { this._asignatura1 = value; } }
        public Asignatura Asignatura2 { get { return this._asignatura2; } set { this._asignatura2 = value; } }
        public Asignatura Asignatura3 { get { return this._asignatura3; } set { this._asignatura3 = value; } }

        public Alumno()
        { }

        public Alumno(Asignatura asig1, Asignatura asig2, Asignatura asig3)
        {
            this._asignatura1 = asig1;
            this._asignatura2 = asig2;
            this._asignatura3 = asig3;
        
        }       
        #endregion

        #region Metodos
        public void CalificarAlumno()
        {
            this._asignatura1 = new Asignatura();
            this._asignatura2 = new Asignatura();
            this._asignatura3 = new Asignatura();
        }

        public double CalcularPromedio()
        {
            return (double)((this._asignatura1.Calificacion + this._asignatura2.Calificacion + this._asignatura3.Calificacion) / 3);

        }

        public override bool Serializer()
        {
            XmlTextWriter xml = new XmlTextWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio45\XmlAlumno.xml",Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(typeof(Alumno));
            xmlS.Serialize(xml, this);
            xml.Close();

            return true;
        }


        #endregion
    }
}
