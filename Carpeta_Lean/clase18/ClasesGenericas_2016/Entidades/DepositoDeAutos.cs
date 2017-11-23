using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                return true;
            }

            return false;
        }

        private int GetIndice(Auto a)
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

        public static bool operator -(DepositoDeAutos d, Auto a)
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
            sb.AppendLine("Listado de Autos:");
            if (this._lista.Count == 0)
            {
                sb.AppendLine("------------");
            }
            else
            {
                foreach (Auto item in this._lista)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }
    }
}
