using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55practica
{
    public abstract class Vehiculo
    {
        #region Atributos, Propiedades y Constructores
        protected string _patente;
        protected byte _cantRuedas;
        protected Marca _marca;

        public string Patente { get { return this._patente; } }

        public Vehiculo()
        { }
        public Vehiculo(string patente, byte cantidadruedas, Marca marca):this()
        {
            this._patente = patente;
            this._cantRuedas = cantidadruedas;
            this._marca = marca;
        }
         

        #endregion

        #region Metodos

        public abstract void Mostrar();

        public void AcelerarHasta(byte acelerahastacuanto)
        { }

        #endregion
    }
}
