using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class CuentaBancaria
    {
        private string _nombreDelCliente;
        private Int32 _numeroCuenta;
        private double _saldo;

        public CuentaBancaria(Int32 numerocuenta, string nombrecliente)
        {this._numeroCuenta=numerocuenta;
        this._nombreDelCliente=nombrecliente;
        }
        public CuentaBancaria(Int32 numerocuenta,double saldo)
        { this._numeroCuenta=numerocuenta;
          this._saldo=saldo;
        }

        public void Mostrar()
        {
            Console.WriteLine("\nNombre del Cliente: {0}\nNumero de Cuenta: {1}\nSaldo: {2}", this._nombreDelCliente, this._numeroCuenta, this._saldo);
        }
        public static CuentaBancaria operator -(CuentaBancaria primeracuenta, double num)
        {
            CuentaBancaria resta = new CuentaBancaria(primeracuenta._numeroCuenta,primeracuenta._saldo);
            if (primeracuenta._saldo >= num)
            {
                resta._saldo = primeracuenta._saldo - num;
                Console.WriteLine("\nSe pudo realizar la resta");
                return resta;
            }
            else
            {
                Console.WriteLine("\nNo posee saldo suficienta en la cuenta");
                return resta;
            }
        }
        public static double operator +(CuentaBancaria cuenta1, CuentaBancaria cuenta2)
        {


            if (cuenta1._numeroCuenta == cuenta2._numeroCuenta)
            {
                Double importeDouble = cuenta1._saldo + cuenta2._saldo;
                return importeDouble;
            }
            else
            {Console.WriteLine("No son los mismos clientes");
                return 0;
            }
            
        }
        public static CuentaBancaria operator +(CuentaBancaria primeracuenta, double num)
        {
            CuentaBancaria suma=new CuentaBancaria(primeracuenta._numeroCuenta,primeracuenta._saldo);
            suma._saldo=primeracuenta._saldo+num;
            return suma;
        /*
         * EJEMPLO:
         * 
         *  public static Metro operator + (Metro m, Centimetro c)
        {
            Metro retValue = new Metro();
            
            retValue.cantidad = m.cantidad + c.cantidad / 100;
 
            return retValue;
        }
         * 
         */ }


    }
}
