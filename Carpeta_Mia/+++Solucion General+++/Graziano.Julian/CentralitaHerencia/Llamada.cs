using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        
        protected float _duracion;
        protected string _nroDestino;
        protected string _nrOrigen;

        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get {return this._nroDestino;} }
        public string NroOrigen { get {return this._nrOrigen;} }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nrOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nOrigen");
            sb.AppendLine(this.NroOrigen);
            sb.Append("\nDuracion: ");
            sb.AppendLine(this.Duracion.ToString());
            sb.Append("\nDestino: ");
            sb.AppendLine(this.NroDestino);
            
            

        
        }
        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            //Si la duracion de la llamada uno es mas grande que la dos, 
            //indica 1 porque es la llamada con mas duracion y viceversa
            int rta=0;
            if (uno.Duracion > dos.Duracion)
            { rta = 1; }
            else { rta = 2; }
            return rta;
            //indica en el ejercicio lo siguiente:
            //El método de clase OrdenarPorDuracion será utilizado en el
            //método Sort de la lista genérica de objetos del mismo tipo (en la
            //clase Centralita).
        }


    }
}
