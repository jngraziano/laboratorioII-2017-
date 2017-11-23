using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36recuperatorio
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;

        #region Constructores
        public Container(int capacidad, string empresa)
        {
                       
            this._capacidad = capacidad;
            this._empresa = empresa;
            List<Producto> aux = new List<Producto>();
            this._listaProductos=aux;
            }
        #endregion

        #region Metodos
        public static void Mostrar(Container Contenedor)
        {
            //Console.WriteLine("\nMostrar:\n");
            //Console.WriteLine("\nCapacidad: {0}\nEmpresa: {1}", Contenedor._capacidad, Contenedor._empresa);
            foreach (Producto recorre in Contenedor._listaProductos)
            {
                recorre.mostrar();
                //Console.WriteLine(recorre);

            }
        
        }
        /*
         * 7) Crear el método de instancia Agregar (Producto) que agregue a la lista de productos del contenedor el
producto pasado por parámetro sólo si la capacidad lo permite y el producto no se encuentra ya en la lista.
         * */

        public bool Agregar(Producto proUno)
        {
            //foreach (Producto recorre in this._listaProductos)
            //{
            //    if( recorre != proUno && this._capacidad>recorre
            //        {
            //        this._listaProductos.Add(proUno);
            //        return true;
            //        }
            //else
            //{return false;}
            //}
            this._listaProductos.Add(proUno);
            return true;
            
        }



        public static List<Producto> operator -(Container contenedorUno, eTipoComestible tipo)
        {
            List<Producto> obj = new List<Producto>();
            foreach (Producto recorre in contenedorUno._listaProductos)
            {
                if(recorre == tipo)
                {   
                    obj.Add(recorre);
                
                }
            
            }
            return obj;
        }
        public static bool operator ==(Container contenedor, Producto proUno)
        {
            bool devu = false;
            foreach (Producto recorre in contenedor._listaProductos)
            {
                if (recorre == proUno)
                { devu=true;; }
                else
                { devu=false; }
            }
            return devu;
        }
        public static bool operator !=(Container contenedor, Producto proUno)
        { return !(contenedor == proUno); }
        #endregion
    }
}
