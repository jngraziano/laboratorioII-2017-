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
        private  double _saldo;
        private ETipoInteres _tipoInteres;


       
        public string getNombre()
        {              
            return this._nombre;
        }
        
        
        public long getNroCuenta()
        {
            return this._nroCuenta;
        }
            
        
        public double getSaldo()
        {
            return this._saldo;
        }
        
       
        public ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setNombre (string nombre)
        {
            this._nombre = nombre;
        }

        public void setNroCuenta (long nroCuenta)
        {
            this._nroCuenta = nroCuenta;
        }

        public void setSaldo (double saldo)
        {
            this._saldo = saldo;
        }

        public void setTipoInteres (ETipoInteres tipoInteres)
        {
            this._tipoInteres = tipoInteres;
        }


        

    
    
    }
}
