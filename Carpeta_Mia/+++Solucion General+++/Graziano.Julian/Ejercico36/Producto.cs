using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico36
{
    class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;



        public Producto(int codigoDeBarra)
        {
            Random objetram = new Random();

            this._codigoDeBarra = objetram.Next();
        }


        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo)
            : this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;

        }
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio)
            : this(codigoDeBarra, nombre, tipo)
        {
            this._precio = precio;
        }

        public void mostrar()
        {
            Console.WriteLine("Codigo de Barra: {0}\nNombre: {1}\nTipo: {2}\nPrecio: {3}", this._codigoDeBarra, this._nombre, this._tipo, this._precio);

        }



        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno == proDos)
            {
                return true;
            }
            else
            { return false; }

        }
        public static bool operator !=(Producto proUno, Producto proDos)
        {
            return !(proUno == proDos);
            
        }
        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            if (proUno._tipo == tipo)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        {
            return !(proUno._tipo == tipo);
            
        }


    }



}