using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{

    // Quitar marcadores
    [Serializable]
    [XmlInclude(typeof(Automovil))]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Camion))]
    public abstract class Vehiculo
    {
        public enum EMarca //quitar public
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }
        EMarca _marca;
        string _patente;
        ConsoleColor _color;

        #region QUITAR
        public Vehiculo()
        { }

        public EMarca Marca
        {
            get
            {
                return this._marca;
            }
            set
            {
                this._marca = value;
            }
        }
        public string Patente
        {
            get
            {
                return this._patente;
            }
            set
            {
                this._patente = value;
            }
        }
        public ConsoleColor Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        #endregion

        #region Constructores
        public Vehiculo(string patente, EMarca marca, ConsoleColor color) //quitar constructor
        {
            this._patente = patente;
            this._marca = marca;
            this._color = color;
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
        protected abstract short CantidadRuedas { get; /*set;*/ } //quitar protected

        public virtual string Mostrar() //quitar virtual y poner sealed  // quitar protected
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente); // Modificar FORMAT por LINE
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString()); // Modificar FORMAT por LINE
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString()); // Modificar FORMAT por LINE
            sb.AppendLine("---------------------");

            return sb.ToString(); //quitar tostring
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            // Quitar completo
            if (v1.Patente == v2.Patente)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            // Quitar completo
            return !(v1._patente == v2._patente);
        }
        #endregion
    }
}
