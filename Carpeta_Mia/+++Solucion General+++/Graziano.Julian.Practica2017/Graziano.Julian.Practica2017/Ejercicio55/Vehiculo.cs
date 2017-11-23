using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    public abstract class Vehiculo
    {
        //Realizar la clase abstracta Vehiculo que posea como atributos protegidos:
        //patente (string - sólo lectura)
        //cantRuedas (Byte)
        //marca (enum Marcas, con los siguientes enumerados: Honda, Ford, Zanella y Fiat)
        //Y los siguientes métodos:
        //void Mostrar (abstracto)
        //void AcelerarHasta(Byte) (virtual)
        //Vehiculo(string, Byte, Marcas) (sin sobrecargas)
        protected string _patente; public string Patente { get { return this._patente; } }
        protected byte _cantRuedas; public byte CantRuedas { get { return this._cantRuedas; } set { this._cantRuedas = value; } }
        protected Emarcas _marcas; public Emarcas Marcas{get {return this._marcas;}set{this._marcas= value;}}

        public Vehiculo()
        { }

        public Vehiculo(string patente,  Emarcas marca, byte cantidadruedas)
        {
            this._patente = patente;
            this._cantRuedas = cantidadruedas;
            this._marcas = marca;
        }


        public abstract void Mostrar();

        public virtual void AcelerarHasta(byte h)
        { }


    }
}
