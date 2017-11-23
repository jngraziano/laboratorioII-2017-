using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria._2016;

namespace Lampara
{
    class Lampara
    {
        protected string _tipo;
        protected string _codigo;
        protected string _marca;


        #region
        public string Tipo { get { return this._tipo; } set { this._tipo = value;} }
        public string Codigo { get { return this._codigo; } set { this._codigo = value; } }
        public string Marca { get { return this._marca; } set { this._marca = value; } }
        #endregion


        #region Constructor

        public Lampara(string tipo, string codigo, string marca)
        {
            this._tipo = tipo;
            this._codigo = codigo;
            this._marca = marca;        
        }

        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Lampara a, Lampara b)
        {
            if (String.Compare(a._codigo, b._codigo)==0 && String.Compare(a._tipo,b._tipo)== 0)
            {
                return true;
            }

            return false;
        }


        
        public static bool operator !=(Lampara a, Lampara b)
        {
            return !(a == b);
        }
        #endregion

        #region Poliformismo

        public override string ToString()
        {
            return this._marca;
        }

        //public override bool Equals(object obj)
        //{
        //    return 
        //}

        #endregion

    }
}
