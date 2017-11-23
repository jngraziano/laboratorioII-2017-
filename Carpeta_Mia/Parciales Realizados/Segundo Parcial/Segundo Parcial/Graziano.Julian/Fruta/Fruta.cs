using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    public abstract class Fruta
    {
        #region atributos, prop y Constructores
        protected ConsoleColor _color;
        protected float _peso;

        public abstract bool TieneCarozo { get; }
       
        public Fruta(float peso, ConsoleColor color)
        {
            this._peso = peso;
            this._color = color;
        
        }
        #endregion

        #region Metodos
        public virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nColor: ");
            sb.AppendLine(this._color.ToString());
            sb.Append("\nPeso: ");
            sb.AppendLine(this._peso.ToString());

            return sb.ToString();
        
        }

        public static int OrdenarPorPesoAsc(Fruta f1, Fruta f2)
        {
           
            if(f1._peso>f2._peso)
            {
                return 1;
            }
            else if (f1._peso < f2._peso)
            { return -1; }
            else { Console.WriteLine("\nAmbos tienen el mismo peso. Se envia el primero por default.");
            return 1;
            }

           
        
        }

        public static int OrdenarPorPesoDesc(Fruta f1, Fruta f2)
        {
            int aux = 0;
            
            if (OrdenarPorPesoAsc(f1, f2) == 1) { aux = -1;  }
            return aux;
        }


        #endregion



    }
}
