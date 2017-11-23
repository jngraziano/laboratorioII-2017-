using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Segundo_Parcial
{
    abstract class Vehiculo
    {
        protected string _patente;
        protected byte _cantDeRuedas; 
        protected Marca _marcas;


        public abstract void Mostrar();
        public virtual void AcelerarHasta(byte a)
        {
            Console.WriteLine("Acelerara hasta " + a.ToString());
               
        }

        public Vehiculo(string patente, byte cantDeRuedas, Marca marca)
        {
            this._patente = patente;
            this._cantDeRuedas = cantDeRuedas;
            this._marcas = marca;
        
        }
        
        
    
    }
}
