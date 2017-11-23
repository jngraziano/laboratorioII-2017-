using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Animal
    {
        #region Atributos

        protected String _nombre;
        protected Posicion _posicion;

        #endregion

        #region Propiedad

        public Posicion Posicion 
        {
            get
            {
                return this._posicion;
            }

            set
            {
                this._posicion = value;
            }
        }

        #endregion

        #region Constructor

        public Animal(String nombre, Posicion posicion)
        {
            this._nombre = nombre;
            this._posicion = posicion;
        }

        #endregion

        #region Método Virtual

        public virtual void Moverse(int x, int y)
        {
            this._posicion.PosX = x;
            this._posicion.PosY = y;
        }

        #endregion

        #region Polimorfismo ToString

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);

            sb.Append("Posición: (");
            sb.Append(this._posicion.PosX);
            sb.Append(", ");
            sb.Append(this._posicion.PosY);
            sb.AppendLine(")");

            sb.AppendLine("----------------------------");

            return sb.ToString();
        }

        #endregion
    }
}
