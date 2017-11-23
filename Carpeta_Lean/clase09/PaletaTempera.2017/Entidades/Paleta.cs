using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paleta
    {
        private List<Tempera> _colores;
        private Int32 _cantidadMaximaDeColores;

        private Paleta()
            : this(5)
        { }

        private Paleta(Int32 cantidad)
        {
            this._cantidadMaximaDeColores = cantidad;
            this._colores = new List<Tempera>();
        }

        public static implicit operator Paleta(Int32 d)
        {
            return new Paleta(d);
        }

        public static Boolean operator ==(Paleta p, Tempera t)
        {
            Boolean rta = false;
            foreach (Tempera item in p._colores)
            {
                if (item == t)
                {
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public static Boolean operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            if (p == t)
            {
                Int32 i = p.ObtenerIndice(t);
                if (i != -1)
                {
                    p._colores[i] += t;
                }
            }
            else
            {
                if (p._colores.Count < p._cantidadMaximaDeColores)
                {
                    p._colores.Add(t);
                }
            }

            return p;
        }

        private Int32 ObtenerIndice(Tempera t)
        {
            for (int i = 0; i < this._colores.Count; i++)
            {
                if (this._colores[i] == t)
                {
                    return i;
                }
            }
            return -1;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            if (p==t)
            {
                Int32 cant = p._colores[p.ObtenerIndice(t)] - t;

                if (cant>0)
                {                    
                    p._colores[p.ObtenerIndice(t)].Cantidad = t;
                    //p._colores[i] += (-t);
                }
                else
                {
                    p._colores.RemoveAt(p.ObtenerIndice(t));
                }
            }
            return p;
        }

        public static Paleta operator +(Paleta p, Paleta pp) 
        {
            Paleta aux = p._cantidadMaximaDeColores + pp._cantidadMaximaDeColores;

            aux._colores = p._colores;

            for (int i = 0; i < pp._colores.Count; i++)
            {
                aux += pp._colores[i];
            }

            return aux;
        }
    }
}
