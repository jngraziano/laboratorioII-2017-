using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico36
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;


        public static void Mostrar(Container Container)
        {

            //Console.WriteLine("capacidad \n{0}\nempresa: {1}\nlistaproductos: {2}", Container._capacidad, Container._empresa, Container._listaProductos);
            foreach (Producto valor in Container._listaProductos)
            {
                Console.WriteLine(valor);
            
            }

        }
        public Container(int Capacidad, string Empresa)
        {
             List<Producto> _listaProductos = new List<Producto>();
             //this._listaProductos.Add(aux);
        }
        public static bool operator ==(Container contenedor, Producto proUno)
        {
            foreach (Producto valor in contenedor._listaProductos)
            {
                if (valor == proUno)
                { return true; }
                else
                { return false; }
            
            }
            return false;
        }
        public static bool operator !=(Container contenedor, Producto proUno)
        { return !(contenedor == proUno); }


        public static List<Producto> operator -(Container ContenedorUno, eTipoComestible tipo)
        {
            List<Producto> resultado = new List<Producto>();
            foreach (Producto valor in ContenedorUno._listaProductos)
            {

                if (valor == tipo)
                {
                    resultado.Add(valor);

                }

            }
            return resultado;
        }
        public bool Agregar(Producto proUno)
        {
           
            this._listaProductos.Add(proUno);

            return true;
        
        }
   }
}
