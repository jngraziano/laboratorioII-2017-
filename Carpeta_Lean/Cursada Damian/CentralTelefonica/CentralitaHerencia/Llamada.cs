using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    [Serializable]
    abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Constructor

                public Llamada(string origen, string destino, float duracion)
                {
                    this._nroOrigen = origen;
                    this._nroDestino = destino;
                    this._duracion = duracion;
        
                }
                #endregion

        #region Propiedades
        public abstract float CostoLlamada { get; }
        
        public float Duracion
                {
                     get {return this._duracion;}                                       
                }
              
        public string NroDestino
                { 
                    get { return this._nroDestino; } 
                }

        public string NroOrigen
                { 
                    get { return this._nroOrigen; } 
                }
        
        
        #endregion

        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------------");
            sb.Append("Nro de Origen: ");
            sb.AppendLine(this.NroOrigen);
           
            sb.Append("Nro de Destino: ");
            sb.AppendLine(this.NroDestino);
            
            sb.Append("Duracion: ");
            sb.AppendLine(this.Duracion.ToString());

           // Console.WriteLine(sb);


            return sb.ToString();



        }

        public static int OrdenarPorDuracion(Llamada a, Llamada b)
        {
            int valor = 0;

            if (a.Duracion < b.Duracion)
            {
                valor = -1;
            }

            if (a.Duracion > b.Duracion)
            {
                valor = 1;
            }

            return valor;
        }


        #endregion
        
        #region Sobre carga de operadores

        public static bool operator ==(Llamada a, Llamada b)
        {
            bool aux = false;
            
            if (a.Equals(b))
            {
                if (OrdenarPorDuracion(a,b)==0) 
                {
                    aux = true;                
                }
            
            }

            return aux;
        
        
        }

        public static bool operator !=(Llamada a, Llamada b)
        {
            return !(a == b);
        
        }


        #endregion


    }
}
