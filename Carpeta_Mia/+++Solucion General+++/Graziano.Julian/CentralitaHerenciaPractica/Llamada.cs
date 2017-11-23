using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerenciaPractica
{
    class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigine;

        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get { return this._nroDestino; } }
        public string NroOrigen { get { return this._nroOrigine; } }

        public Llamada()
        { }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigine = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
                    
        }

        public virtual void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nNumero de Origen; ");
            sb.AppendLine(this.NroOrigen);
            sb.Append("\nNumero de Destino: ");
            sb.AppendLine(this.NroDestino);
            sb.Append("\nDuracion: ");
            sb.AppendLine(this.Duracion.ToString());

            Console.WriteLine(sb.ToString());

 
        
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            //El método de clase OrdenarPorDuracion será utilizado en el
            //método Sort de la lista genérica de objetos del mismo tipo (en la
            //clase Centralita)

            if (uno.Duracion > dos.Duracion)
            {
                return -1;

            }
            else if (uno.Duracion < dos.Duracion)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("\nTienen La misma duración. Se coloca la 1er llamada por defecto.");
                return 0;
            
            }
            
 
        
        }
    }
}
