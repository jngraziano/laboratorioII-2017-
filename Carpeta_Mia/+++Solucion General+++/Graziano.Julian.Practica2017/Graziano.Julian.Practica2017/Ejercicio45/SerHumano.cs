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
    public abstract class SerHumano
    {
        //Tomando la clase SerHumano, diseñada en el ejercicio 41, se pide:
        //Modificarla para que sea abstracta y ‗padre‘ de las clases Alumno
        //y Profesor.

        protected string _nombre;
        protected Single _peso;
        protected Single _altura;
        protected string _sexo;

        public SerHumano()
        {
            this._sexo = "M";
        }


        public SerHumano(string Nombre, Single peso, Single Altura, string Sexo)
        {
            this._nombre = Nombre;
            this._peso = peso;
            this._altura = Altura;

        }

        public abstract bool Serializer();

    }
}
