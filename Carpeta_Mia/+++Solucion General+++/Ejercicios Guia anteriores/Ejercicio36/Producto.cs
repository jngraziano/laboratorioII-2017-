using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Container_Modelo_Parcial_Ej36
{
    class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;


        

        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo):this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }
       
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio):this(codigoDeBarra,nombre,tipo)
        {
            this._precio = precio;
        }

        public void mostrar()
        {
            Console.WriteLine("****PRODUCTO*****");
            Console.WriteLine("Nombre:{0}", this._nombre);

            Console.WriteLine("Tipo:{0}", this._tipo);
            Console.WriteLine("Codigo de Barra:{0}",this._codigoDeBarra);
           
            Console.WriteLine("Precio:{0}", this._precio);
            
        }

        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            if (proUno._tipo == tipo)
            {
                return true;
            }

            return false;

        }

        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        {
            return !(proUno._tipo == tipo);
        }

        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno._codigoDeBarra == proDos._codigoDeBarra && proUno._nombre == proDos._nombre && proUno._tipo == proDos._tipo)
            {
                return true;
            }

            return false;

        }

        public static bool operator !=(Producto proUno, Producto proDos)
        {
               return !(proUno==proDos);
        }

        //public List<Producto> getProducto()
        //{
        //    return this.
        //}

    }
}
