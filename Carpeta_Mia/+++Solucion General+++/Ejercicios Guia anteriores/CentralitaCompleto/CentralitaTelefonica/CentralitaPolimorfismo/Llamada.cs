using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        #region Atributos, Propiedades y Constructores
        protected float _duracion;
        protected string _nroOrigen;
        protected string _nroDestino;

        public float Duracion { get { return this._duracion; } }
        public string NroOrigen { get { return this._nroOrigen; } }
        public string NroDestino { get { return this._nroDestino; } }
        public abstract float CostoLlamada { get;}

        public Llamada()
        { }

        public Llamada(string Origen, string Destino, float Duracion)
        {
            this._nroOrigen = Origen;
            this._nroDestino = Destino;
            this._duracion = Duracion;

        }

        #endregion

        #region Metodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("\nDATOS DE LLAMADA: ");
            sb.Append("\nDuracion: ");
            sb.AppendLine(this.Duracion.ToString());
            sb.Append("\nOrigen: ");
            sb.AppendLine(this.NroOrigen);
            sb.Append("\nDestino: ");
            sb.AppendLine(this.NroDestino);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
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
                return 0;

            }
        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if (uno.Equals(dos) && uno.NroDestino == dos.NroDestino && uno.NroOrigen == dos.NroOrigen)
            {

                return true;
            }
            else { return false; }
        
        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        #endregion
    }
}
