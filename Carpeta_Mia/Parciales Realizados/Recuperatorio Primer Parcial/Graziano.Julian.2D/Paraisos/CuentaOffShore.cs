using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraisos
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Cliente Dueño { get { return this._dueño; } }
        public double Saldo { get { return this._saldo; } set { this._saldo = value; } }

        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this._saldo = saldoInicial;
        
        }
        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial)
        {
            Cliente aux = new Cliente(tipo, nombre);
            this._dueño = aux;
            //this._numeroCuenta = numero;
            //this._saldo = saldoInicial;

            //CHEQUEAR DE DAR LA VUELTA A ESTO
        
        }


        #region Metodos
       
        public static explicit operator int(CuentaOffShore cos)
        {
            
            return cos._numeroCuenta;
        
        }
        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            if (cos1._numeroCuenta == cos2._numeroCuenta && cos1._dueño.GetAlias() == cos2._dueño.GetAlias())
            {
                return true;
            }
            else
            { return false; }
        
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        { return !(cos1 == cos2); }
        

        #endregion
    }
}
