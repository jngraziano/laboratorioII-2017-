using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga_de_Metodos
{
    class Metro
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
        public static Metro operator + (Metro m, Centimetro c)
        {
            Metro retValue = new Metro();
            
            retValue.cantidad = m.cantidad + c.cantidad / 100;
 
            return retValue;
        }
            #endregion

            #region Conversiones

        public static explicit operator Metro(double cant)
        {
            Metro retValue = new Metro(cant);

            return retValue;
        }

        public static explicit operator double(Metro m)
        {
            return m.cantidad;
        }
        
        #endregion

        #endregion

    }
}
