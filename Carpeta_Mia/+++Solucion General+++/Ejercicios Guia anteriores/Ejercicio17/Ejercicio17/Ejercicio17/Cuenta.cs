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
        private ETipoInteres _tipoInteres;

        //getters (para llegar a la variable privada)  | setters (para setear un valor a una variable privada)
        public string Get_Nombre()
        {
            return this._nombre;

        }
        public long Get_nroCuenta()
        {
            return this._nroCuenta;
        }
        public double Get_saldo()
        {
            return this._saldo;
        }
        public ETipoInteres GetTipoInteres()
        {
            return this._tipoInteres;
        }
        public void SetNombre(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                Console.WriteLine("Debe completar el campo.");
                //nota, si se coloca ! adelante de la funcion estaria negando la funcion.
            }
            else
            {
                this._nombre = v;
            }
        }
        public void SetNroCuenta(long cuen)
        {
            if (cuen <= 0)
            {
                Console.WriteLine("Debe ser mayor a 0");
            }
            else
            {
                this._nroCuenta = cuen;
            }
        }
        public void SetSaldo(double sald)
        {
            if (sald < 0)
            {
                Console.WriteLine("No puede ser negativo.");
            }
            else
            {
                this._saldo = sald;
            }

            
        }
        public void SetTipoInteres(ETipoInteres tipoIn)
        {
            
            this._tipoInteres = tipoIn;
        }
        

    
    
    
    
    }


}
