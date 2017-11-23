using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion
{
    class Cuenta
    {
        private float _saldo;
        private long  _cbu;
        

        public Cuenta(float saldo, long cbu)
        {
             
            this._saldo = saldo;
            this._cbu = cbu;
        }

        public float Saldo { get { return this._saldo; } set { this._saldo = value; } }
        public long Cbu { get { return this._cbu; } }
    
        
    
    }
        


}
