using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cocina
    {
        private double _precio;
        private bool _esIndustrial;
        private int _codigo;

        public double Precio
        {
            get { return this._precio; }
        }

        public bool EsIndustrial
        {
            get { return this._esIndustrial; }
        }

        public int Codigo
        {
            get { return this._codigo; }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return a._codigo == b._codigo;
        }
        
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "Código: "+this._codigo+" - Precio: "+this._precio.ToString()+" - Es industrial? "+this._esIndustrial.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Cocina && this == (Cocina)obj;
        }

    }
}
