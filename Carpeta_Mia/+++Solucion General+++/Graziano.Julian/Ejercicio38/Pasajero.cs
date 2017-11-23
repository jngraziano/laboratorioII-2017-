using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Pasajero
    {
        private string _apellido;
        private string _nombre;
        private string _dni;
        private bool _esPlus;

        public bool esPlus { get { return this._esPlus; } }

        public string InfoPasajero { 
            get {

                return this._apellido + this._nombre + this._dni + this._esPlus.ToString();
                
                } 
        
        
          }

        public Pasajero(string apellido, string nombre, string dni, bool esplus)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = dni;
            this._esPlus = esplus;
        
        }
        public Pasajero( bool esplus,string apellido, string dni, string nombre)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = dni;
            this._esPlus = esplus;
        }

        public static bool operator ==(Pasajero pas1, Pasajero pas2)
        {
            if (pas1._dni == pas2._dni)
            { return true; }
            else
            { return false; }
 
        
        }
        public static bool operator !=(Pasajero pas1, Pasajero pas2)
        { return !(pas1 == pas2); }

        public void MostrarPasajero()
        { Console.WriteLine(this.InfoPasajero); }


    }
}
