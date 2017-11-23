using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                return true;
            }

            return false;
        }

        private int GetIndice(T a)
        {
            int i = 0;
            bool esta = false;
            for (i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    esta = true;
                    break;
                }
            }

            return esta == true ? i : -1;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            int i = d.GetIndice(a);
            if (i > -1)
            {
                d._lista.RemoveAt(i);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima.ToString());
            sb.AppendLine("Listado de "+typeof(T).Name+":");
            if (this._lista.Count == 0)
            {
                sb.AppendLine("------------");
            }
            else
            {
                foreach (T item in this._lista)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }
    }
}
