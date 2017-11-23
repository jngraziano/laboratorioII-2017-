using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Cuenta
    {
        #region Variables
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;
        #endregion

        #region Getters y Setters
        //Se pide crear los métodos públicos (getters y setters) necesarios
        //para poder manipular un objeto de tipo Cuenta, sabiendo que
        //dichos métodos deberán de realizar las validaciones
        //correspondientes (en ningún caso se deberá pedir el reingreso de
        //datos dentro del método).

        public void SetNombre(string nombre)
        {this._nombre = nombre;}
        public string GetNombre()
        { return this._nombre; }

        public void SetNumCuenta(long numerocuenta)
        { this._nroCuenta = numerocuenta; }
        public long GetNumCuenta()
        { return this._nroCuenta; }

        public void SetSaldo(double saldo)
        { this._saldo = saldo; }
        public double GetSaldo()
        { return this._saldo; }

        public void SetTipoInteres(ETipoInteres tipointeres)
        { this._tipoInteres = tipointeres; }
        public ETipoInteres GetTipoInteres()
        { return this._tipoInteres; }

        #endregion


    }
}
