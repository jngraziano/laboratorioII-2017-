using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(c);
                return true;
            }

            return false;
        }

        private int GetIndice(Cocina c)
        {
            int i = 0;
            bool esta = false;
            for (i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(c))
                {
                    esta = true;
                    break;
                }
            }

            return esta == true ? i : -1;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            int i = d.GetIndice(c);
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
            sb.AppendLine("Listado de Cocinas");
            if (this._lista.Count == 0)
            {
                sb.AppendLine("------------");
            }
            else
            {
                foreach (Cocina item in this._lista)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }
    }
}
