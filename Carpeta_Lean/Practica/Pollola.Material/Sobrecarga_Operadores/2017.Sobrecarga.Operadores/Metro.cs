using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Sobrecarga.Operadores
{
    public class Metro
    {
        #region Atributos

        public double cantidad;

        #endregion

        #region Constructores

        public Metro()
        {
            this.cantidad = 0;
        }

        public Metro(double cant)
        {
            this.cantidad = cant;
        }

        #endregion

        #region Metodos

        #region Sobrecarga de Operadores

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="m">cantidad en metros</param>
        /// <param name="c">cantidad en centimetros</param>
        /// <returns>cantidad en metros</returns>
        public static Metro operator +(Metro m, Centimetro c)
        {
            Metro retValue = new Metro();

            retValue.cantidad = m.cantidad + c.cantidad / 100;

            return retValue;
        }

        public static Metro operator +(Metro m, Double d)
        {
            m.cantidad += d;
            return m;
        }

        public static bool operator ==(Metro m,double d)
        {
            return m.cantidad == d ? true : false;
            
        }
        public static bool operator !=(Metro m, double d)
        {
            return !(m == d);

        }

        //public static Metro operator +(Centimetro c, Metro m)
        //{
        //    Metro retValue = new Metro();

        //    retValue.cantidad = m.cantidad + c.cantidad / 100;

        //    return retValue;
        //}
        #endregion

        #region Conversiones

        //public static explicit operator Metro(double cant)
        //{
        //    Metro retValue = new Metro(cant);

        //    return retValue;
        //}

        //public static explicit operator double(Metro m)
        //{
        //    return m.cantidad;
        //}

        #endregion

        #endregion

    }
}
