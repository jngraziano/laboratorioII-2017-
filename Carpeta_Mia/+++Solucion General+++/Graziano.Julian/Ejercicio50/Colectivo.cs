using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public abstract class Colectivo
    {
        protected List<Pasajero> _listaPasajeros;
        protected int _numeroDelinea;
        protected int _numeroDeMovil;

        public Colectivo()
        {
            List<Pasajero> list = new List<Pasajero>();
            this._listaPasajeros = list;
        }

        public Colectivo(int NumeroDeLinea, int NumeroDeMovil)
        {
            this._numeroDelinea = NumeroDeLinea;
            this._numeroDeMovil = NumeroDeMovil;
            List<Pasajero> list = new List<Pasajero>();
            this._listaPasajeros = list;
            
        
        }
        //El constructor inicializa los campos _numeroDeLinea y
        //_numeroDeMovil e instancia _listPasajeros.
        //Métodos SacarBoleto y SolicitanBajar, deben ser métodos
        //abstractos y requieren como parámetro un Pasajero.
        //Sobre escribir el Método ToString.

        public abstract void SacarBoleto(Pasajero unPasajero);
        public abstract void SolicitanBajar(Pasajero unPasajero);


        public override string ToString()
        {
            StringBuilder sw = new StringBuilder();

            sw.Append("\nNumero de Linea: ");
            sw.AppendLine(this._numeroDelinea.ToString());
            sw.Append("\nNumero de Movil: ");
            sw.AppendLine(this._numeroDeMovil.ToString());
            foreach (Pasajero recorre in this._listaPasajeros)
            {
                sw.Append("\nCantidad de Pasajeros");
                sw.AppendLine(this._listaPasajeros.Count().ToString());
            }

            return sw.ToString();
        }


    }
}
