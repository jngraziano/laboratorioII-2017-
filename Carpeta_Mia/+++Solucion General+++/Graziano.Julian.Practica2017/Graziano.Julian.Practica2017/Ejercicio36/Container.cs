using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Container
    {
        #region variables y contructor de la clase
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;
        public Container(int capacidad, string Empresa)
        {
            List<Producto> lista = new List<Producto>();
            this._capacidad = capacidad;
            this._empresa = Empresa;
            this._listaProductos = lista;
        }
        #endregion


        #region metodos

        public bool Agregar(Producto proUno)
        {
            //Crear el método de instancia Agregar (Producto) que agregue a la lista de productos del contenedor el
            //producto pasado por parámetro sólo si la capacidad lo permite y el producto no se encuentra ya en la lista.
            //foreach (Producto recorre in this._listaProductos)
            //{
            //    if(this._capacidad
            //}
            this._listaProductos.Add(proUno);
            return true;
        }
        public static void Mostrar(Container Contenedor)
        {
        StringBuilder sb = new StringBuilder();
        sb.Append("\nCapacidad: ");
        sb.AppendLine(Contenedor._capacidad.ToString());
        sb.Append("\nEmpresa: ");
        sb.AppendLine(Contenedor._empresa.ToString());
        sb.Append("\nLista: ");
        foreach (Producto recorre in Contenedor._listaProductos)
        {

            recorre.mostrar();
        }
        Console.WriteLine(sb.ToString());
        
        }


        public static List<Producto> operator -(Container ContenedorUno, eTipoComestible tipo)
        // Sobrecargar el operador “-“ para que retorne una lista con todos los productos que pertenecen al tipo
        //  indicado.
        {
            List<Producto> obj = new List<Producto>();
            foreach (Producto recorre in ContenedorUno._listaProductos)
            {
                if (recorre == tipo)
                {
                    obj.Add(recorre);

                }

            }
            return obj;
        }
        public static bool operator ==(Container contenedor, Producto proUno)
        { 
             //devuelva verdadero sólo si el producto se encuentra
             //en la lista.
            bool booleano = true;
            foreach (Producto recorre in contenedor._listaProductos)
            {
                if (recorre == proUno)
                {
                    booleano= true;

                }
                else { booleano= false; }
            
            }
            return booleano;
        }
        public static bool operator !=(Container contenedor, Producto proUno)
        { return !(contenedor == proUno); }
        #endregion
    }
}
