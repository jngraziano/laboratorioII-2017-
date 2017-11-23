using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
  
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]
    public class Persona:humano
    {
        public string nombre;
        public string apellido;

        public Persona()
        { //solo para serializar
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}
