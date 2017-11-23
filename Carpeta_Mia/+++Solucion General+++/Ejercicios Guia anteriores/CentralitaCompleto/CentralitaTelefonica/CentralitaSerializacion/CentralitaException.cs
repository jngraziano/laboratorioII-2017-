using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    class CentralitaException:Exception
    {
        #region Atributos, Propiedades y Constructores
        private Exception _excepcionInterna;
        private string _nombreClase;
        private string _nombreMetodo;
        private string _mensaje;

        public Exception ExcepcionInterna { get { return this._excepcionInterna; } }
        public string NombreClase { get { return this._nombreClase; }}
        public string NombreMetodo { get { return this._nombreMetodo; } }
        public string Mensaje { get { return this._mensaje; } }

        public CentralitaException(string mensaje, string clase, string metodo)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
            this._mensaje = mensaje;
           
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException):this(mensaje,clase,metodo)
        { this._excepcionInterna = innerException; }

        #endregion
    }
}
