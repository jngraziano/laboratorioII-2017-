using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class CuentaCorriente
    {
        private Usuario _dueño;
        private int _numeroCuenta;
        private double _saldo;

        

        //public CuentaCorriente()
        //{
        //    Usuario uno = new Usuario();
        //    Usuario dos = new Usuario();
            
        //    CuentaCorriente objCC1 = new CuentaCorriente(uno, 789, 1000);
        //    CuentaCorriente objCC2 = new CuentaCorriente("Jorge", "Miguel", 333, 798, 5000);
        //    CuentaCorriente objCC3 = new CuentaCorriente(uno, 799, 1000);
        //    CuentaCorriente objCC4 = dos;
        //}


        public CuentaCorriente(string apellido, string nombre, double dni, int numero, double saldo)
        {
            Usuario nuevUs = new Usuario(apellido, nombre, dni);
            this._dueño = nuevUs;
            this._numeroCuenta = numero;
            this.Saldo = saldo;

        }
        public CuentaCorriente(Usuario miDueño, int numero, double saldo)
        {
            this._dueño = miDueño;
            this._numeroCuenta = numero;
            this.Saldo = saldo;

        }

        public Usuario Dueño
        {
            get { return this._dueño; }

        }
        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo += value; }

        }
        public int numeroCuenta
        {
            get { return this._numeroCuenta; }
            set { this._numeroCuenta = value; }

        }

        public static explicit operator double(CuentaCorriente CC)
        {
            return (CC.Saldo);
        }
        public static implicit operator CuentaCorriente(Usuario unUsuario)
        {


            CuentaCorriente cuentaaux = new CuentaCorriente(unUsuario, 0, 0);

            return cuentaaux;

        }
        public static bool operator ==(CuentaCorriente CC1, CuentaCorriente CC2)
        {
            if (CC1.Dueño.Dni == CC2.Dueño.Dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(CuentaCorriente CC1, CuentaCorriente CC2)
        { return !(CC1== CC2); }
    }
}