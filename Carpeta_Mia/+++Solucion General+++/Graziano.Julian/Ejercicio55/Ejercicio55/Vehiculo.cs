using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    public abstract class Vehiculo
    {
        #region Atributos Propiedades y Constructor
        protected string _patente;
        protected byte _cantRuedas;
        protected Marca _marca;


        protected string Patente { get { return this._patente; } }
        public Vehiculo()
        { }
        public Vehiculo(string patente, byte cantidadRuedas, Marca marca)
        {
            this._patente = patente;
            this._cantRuedas = cantidadRuedas;
            this._marca = marca;

        }
        #endregion

        #region Metodos de Vehiculo

        public abstract void Mostrar();
        public virtual void AcelerarHasta(byte hastacuanto)
        { 
        
        }
        
        #endregion


    }
}
