using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    class CentralitaException:Exception
    {

        #region Atributos
        protected Exception _excepcionInterna;
        protected string _nombreClase;
        protected string _nombreMetodo;
        #endregion

        #region Propiedades
        public Exception ExcepcionInterna { get { return this._excepcionInterna; } }
        public string NombreClase { get { return this._nombreClase; } }
        public string NombreMetodo { get { return this._nombreMetodo; } }
        #endregion

        public CentralitaException(string mensaje, string clase, string metodo)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException):this(clase, metodo, mensaje)
        {
            this._excepcionInterna = innerException;
        }

    }
}
