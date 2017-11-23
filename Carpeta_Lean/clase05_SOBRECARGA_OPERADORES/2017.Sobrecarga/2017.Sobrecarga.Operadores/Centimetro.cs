using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Sobrecarga.Operadores
{
    public class Centimetro
    {
        #region Atributos

        public double cantidad;

        #endregion

        #region Constructores

        public Centimetro()
        {
            this.cantidad = 0;
        }

        public Centimetro(double cant)
        {
            this.cantidad = cant;
        }

        #endregion

        #region Metodos

        #region Sobrecarga de Operadores

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="m">cantidad en centimetros</param>
        /// <param name="c">cantidad en metros</param>
        /// <returns>cantidad en centimetros</returns>
        public static Centimetro operator +(Centimetro c, Metro m)
        {
            Centimetro retValue = new Centimetro();

            retValue.cantidad = c.cantidad + m.cantidad * 100;

            return retValue;
        }

        #endregion

        #region Conversiones

        //public static explicit operator Centimetro(double cant)
        //{
        //    Centimetro retValue = new Centimetro(cant);

        //    return retValue;
        //}

        //public static explicit operator double(Centimetro c)
        //{
        //    return c.cantidad;
        //}

        #endregion

        #endregion

    }
}
