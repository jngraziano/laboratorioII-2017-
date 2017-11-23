using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private EtipoInteres _tipoInteres;

        #region Getters
        //nombre
        public string getNombre()
        {
            return this._nombre;
        }
        //nrocuenta
        public long getNroCuenta()
        {
            return this._nroCuenta;
        }
        //saldo
        public double getSaldo()
        {
            return this._saldo;
        }
        //TipoInteres
        public EtipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }
        #endregion

        #region Setters
        //nombre
        public void setNombre(string valorNombre)
        {
            if (!string.IsNullOrEmpty(valorNombre))
            this._nombre = valorNombre;
        }
        //nrocuenta
        public void setNroCuenta(long valorCuenta)
        {
            if( valorCuenta >0)
            this._nroCuenta = valorCuenta;
        }
        //saldo
        public void setSaldo(double valorSaldo)
        {
            if(valorSaldo >0)
            this._saldo = valorSaldo;
        }
        //tipo interes
        public void setTipoInteres(EtipoInteres tipoInteres)
        {
            this._tipoInteres = tipoInteres;
        }
        
        #endregion
    }
}
