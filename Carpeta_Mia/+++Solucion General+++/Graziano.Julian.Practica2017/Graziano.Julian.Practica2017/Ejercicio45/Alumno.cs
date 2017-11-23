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
    class Alumno:SerHumano
    {
        //La clase Alumno tendrá tres atributos privados de tipo
        //Asignatura, un constructor con tres parámetros de tipo Asignatura
        //que inicialice los tres atributos.

        private Asignatura _asignatura1;
        private Asignatura _asignatura2;
        private Asignatura _asignatura3;

        public Asignatura Asignatura1 { get { return this._asignatura1; } set { this._asignatura1 = value; } }
        public Asignatura Asignatura2 { get { return this._asignatura2; } set { this._asignatura2 = value; } }
        public Asignatura Asignatura3 { get { return this._asignatura3; } set { this._asignatura3 = value; } }

        public Alumno(Asignatura asig1, Asignatura asig2, Asignatura asig3)
        {
            this._asignatura1 = asig1;
            this._asignatura2 = asig2;
            this._asignatura3 = asig3;
        }

        public override bool Serializer()
        {
            XmlTextWriter xmlT = new XmlTextWriter(@"D:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian.Practica2017\Graziano.Julian.Practica2017\Ejercicio45\xmlalumno.xml", Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(typeof (Alumno));
            xmlS.Serialize(xmlT, this);
            xmlT.Close();
            return true;

        }

    }
}
