using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRecuperatorio33
{//pide que tenga nombre distinto que el program
    class Boligrafo
    {
        private int _cantidadTinta;
        private string _color;
        private string _marca;

        

        public Boligrafo()
        { this._cantidadTinta = 0; }

        public Boligrafo(string color)
            : this()
        {
            this._color = color;
        }

        public Boligrafo(string color, string marca)
            : this(color)
        { this._marca = marca; }

        public Boligrafo(string color, string marca, int cantidadtinta)
            : this(color, marca)
        {
            this._cantidadTinta = cantidadtinta;
        }



        public void Escribir(int CantidadNecesaria)
        {
            if (this._cantidadTinta < CantidadNecesaria)
            {
                Console.WriteLine("\nNo es suficiente");
                this.Mostrar();
            }

        }
        public void Mostrar()
        {
            Console.WriteLine("BOLIGRAFO:\n");
            Console.WriteLine("\nColor: {0}\nMarca: {1}\nCantidad Tinta: {2}", this._color, this._marca, this._cantidadTinta);

        }
        public void MostrarBoligrafos(List<Boligrafo> ListaBoligrafos)
        {
            foreach (Boligrafo recorre in ListaBoligrafos)
            {
                recorre.Mostrar();

            }
        }

        public static bool operator ==(Boligrafo unPen, Boligrafo otroPen)
        {
            if (unPen._marca == otroPen._marca && unPen._color == otroPen._color)
            { return true; }
            else
            { return false; }
        
        }
        public static bool operator !=(Boligrafo unPen, Boligrafo otroPen)
        {
            return !(unPen == otroPen);
        }
        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo unPen)
        {
            foreach (Boligrafo recorre in lista)
            {
                if (recorre == unPen)
                {
                    lista.Remove(unPen);
                    
                }
                else
                { Console.WriteLine("\nNo se encontró el elemento");}
            
            }
            return lista;
        }
        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo unPen)
        {   lista.Add(unPen);
            return lista;
        }

        public bool RecargarTienta()
        {
            if (this._cantidadTinta < 50)
            { this._cantidadTinta = 100; return true; }
            else
            { return false; }
        }
        public bool RecargarTinta(int cantidad)
        {
            if (this._cantidadTinta > 50)
            {
                this._cantidadTinta = this._cantidadTinta + cantidad;
                return true;
            }
            else { return false; }
        }
    }
}
