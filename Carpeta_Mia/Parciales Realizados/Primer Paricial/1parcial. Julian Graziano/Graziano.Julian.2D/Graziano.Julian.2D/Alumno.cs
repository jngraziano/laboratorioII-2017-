using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graziano.Julian._2D
{
    class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        
        public string Apellido
        {
            get { return this._apellido; }
            set{this._apellido=value;}

        }
        public int Legajo
        {
            get { return this._legajo; }
            set{this._legajo=value;}

        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }

        }
        public float Nota
        {
            get { return this._nota; }
            set { this._nota = value; }

        }

        public Alumno()
        {

            this.Nota = this._nota;
        
        }
               
        public Alumno(string apellido):this()
        { this.Apellido = apellido; }

        public Alumno(string nombre, string apellido):this(apellido)
        { this.Nombre = nombre; }

        public Alumno(int legajo, string nombre, string apellido):this(nombre, apellido)
        {this.Legajo = legajo;}

        private string Mostrar()
        {
            string aux = this._apellido + this._nombre + this._legajo + this._nota;
            //aux=Console.Write("\n Apellido: {0}\nNombre: {2}\nLegajo: {3}\nNota: {4}", this.Apellido, this.Nombre, this.Legajo, this.Nota);
            
            return aux;
        
        }
        public static string Mostrar(Alumno alumno)
        {
            return (alumno.Mostrar());
        
        }
        public static bool operator ==(Alumno a1, Alumno a2)
        { if(a1 == a2)
        {
            return true;
        }
        else
        {return false;}
        
        
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        { return !(a1 == a2); }



    }
}
