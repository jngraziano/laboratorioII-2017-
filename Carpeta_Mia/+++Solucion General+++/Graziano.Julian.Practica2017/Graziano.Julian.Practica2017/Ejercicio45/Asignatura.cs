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
    class Asignatura
    {
        //Desarrolle una clase llamada Asignatura que:
        //Tenga dos atributos privados, uno de tipo entero (el
        //identificador) y el otro de tipo decimal (la calificación).
        //Dicha clase tendrá un constructor con un parámetro de tipo
        //entero.

        private int _identificador;
        private double _calificacion;

        public double Calificación
        {
            get { return this._calificacion; }
            set { this._calificacion = value; }
        }
        public int ID
        {
            get { return this._identificador; }
            set { this._identificador = value; }
        }


        public Asignatura(int identif)
        { ID = identif; }
    }
}
