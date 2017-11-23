using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosExtendidos._2015
{
    public class Persona
    {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return this.nombre+" - "+this.edad.ToString();
        }
    }
}
