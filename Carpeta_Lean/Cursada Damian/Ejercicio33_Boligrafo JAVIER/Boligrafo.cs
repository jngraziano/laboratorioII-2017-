using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligrafoName
{
    class Boligrafo
    {
        private int _cantidadtinta;
        private string _color;
        private string _marca;


        public Boligrafo(string color, string marca)
            : this(0, color, marca)
        {


        }

        public Boligrafo(int cantidad, string color, string marca)
        {

            this._color = color;
            this._marca = marca;
            this._cantidadtinta = cantidad;
        }
        public Boligrafo(string color, int cantidad, string marca)
            : this(cantidad, color, marca)
        {

        }
        public Boligrafo(string color, string marca, int cantidad)
            : this(color, cantidad, marca)
        {

        }

        private void Mostrar()
        {
            Console.WriteLine("MARCA:{0}\nCOLOR:{1}\nCANTIDAD:{2}", this._marca, this._color, this._cantidadtinta);

        }

        static public void MostrarBoligrafos(List<Boligrafo> lista)
        {
            foreach (Boligrafo elemento in lista)
            {
                elemento.Mostrar();
            }
        }

        public void Escribir(int CantidadNecesaria)
        {
            if (this._cantidadtinta < CantidadNecesaria)
            {
                Console.WriteLine("La cantidad de tinta no es suficiente");
                this.Mostrar();
            }
            else
            {
                this._cantidadtinta = this._cantidadtinta - CantidadNecesaria;
            }
        }

        public bool RecargarTinta()
        {
            if (this._cantidadtinta < 50)
            {
                this._cantidadtinta = 100;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RecargarTinta(int cantidad)
        {
            if (this._cantidadtinta > 50)
            {
                this._cantidadtinta = this._cantidadtinta + cantidad;
                return true;
            }

            return false;
        }

        public static bool operator ==(Boligrafo unPen, Boligrafo otroPen)
        {
            if (unPen._marca == otroPen._marca && unPen._color == otroPen._color)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Boligrafo unPen, Boligrafo otroPen)
        {
            return !(unPen == otroPen);
        }

        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo unPen)
        {
            lista.Add(unPen);

            return lista;

        }

        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo unPen)
        {
            foreach (Boligrafo elemento in lista)
            {
                if (elemento == unPen)
                {
                    lista.Remove(elemento);
                }

            }

            return lista;
        }
    }
}