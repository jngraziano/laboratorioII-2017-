using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria._2016;

namespace Lampara
{
    class DepositoPintura
    {
        List<Pintura> _pinturas;
        int _cantMax;

        public List<Pintura> ListaPinturas { get{return this._pinturas;}  }



        public DepositoPintura(int cantidad)
        {
            _pinturas = new List<Pintura>();
            this._cantMax = cantidad;     
        }

        public static bool operator +(DepositoPintura deposito, Pintura pintura)
        {
            
                if (!deposito.ElElementoYaExiste(pintura) && !deposito.EstaCompleto())
                {
                    deposito._pinturas.Add(pintura);
                    return true;
                }
            
            return false;
        
        }

        public bool Agregar(Pintura pintura)
        {
            return this + pintura;
        }



        private bool EstaCompleto()
        {
            if (this._pinturas.Count == this._cantMax)
                return true;
            else
                return false;     
        }

        private bool ElElementoYaExiste(Pintura pint1)
        {
            foreach(Pintura item in this._pinturas)
            {
                if(pint1.Equals(item))
                {
                    return true;
                }
            }
            
            return false;
        
        }
    }
}
