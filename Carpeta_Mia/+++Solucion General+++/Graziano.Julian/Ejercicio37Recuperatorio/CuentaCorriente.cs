using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37Recuperatorio
{
    class CuentaCorriente
    {
        private Usuario _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Usuario Dueño { get { return this._dueño; } }
        public double Saldo { get { return this._saldo; } set { this._saldo += value; } }
        public int numeroCuenta { get { return this._numeroCuenta; } }

        public CuentaCorriente(string apellido, string nombre, double dni, int numero, double saldo)
        {
            Usuario auxdueño =new Usuario(apellido,nombre,dni);
            this._numeroCuenta=numero;
            this._saldo=saldo;

        
        }
        public CuentaCorriente(Usuario miDueño, int numero, double saldo)
        { 
            this._dueño=miDueño;
            this._numeroCuenta=numero;
            this._saldo=saldo;
        }

        public static explicit operator double(CuentaCorriente CC)
        { return CC.Saldo; }
       
        public static implicit operator CuentaCorriente(Usuario unUsuario)
        {


            CuentaCorriente cuentaaux = new CuentaCorriente(unUsuario, 0, 0);

            return cuentaaux;

        }
        
        public static bool operator ==(CuentaCorriente CC1, CuentaCorriente CC2)
        {
            if (CC1._dueño.Dni == CC2._dueño.Dni)
            {
                return true;
            }
            else { return false; }
               
        }
        public static bool operator !=(CuentaCorriente CC1, CuentaCorriente CC2)
        { return !(CC1 == CC2); }


    }
}
