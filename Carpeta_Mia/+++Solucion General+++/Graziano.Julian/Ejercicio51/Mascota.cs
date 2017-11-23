using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public abstract class Mascota
    {
        protected int _edad;
        protected string _nombre;
        protected ERaza _raza;

        public Mascota()
        { }

        public Mascota(string Nombre, ERaza Raza)
        {
            this._nombre = Nombre;
            this._raza = Raza;
        }
        public Mascota(string Nombre, int edad, ERaza Raza):this(Nombre,Raza)
        {
            this._edad = edad;
        }

        public virtual void Jugar(string conQueJuego)
        {
            Console.WriteLine("\nEste animal juega con: ");       
        }

        public abstract string Mostrar();

       
    }
}
