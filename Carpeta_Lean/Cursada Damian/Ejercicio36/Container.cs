using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;


        public Container(int _capacidad, string _empresa)
        {
            this._capacidad = _capacidad;
            this._empresa = _empresa;
            _listaProductos = new List<Producto>();


        }


        public static void Mostrar(Container a)
        {
            Console.WriteLine("-__-__Container__-__-");
            Console.WriteLine("Empresa: {0}", a._empresa);
            Console.WriteLine("Capacidad: {0}", a._capacidad);

            Console.WriteLine("Productos");
            for (int i = 0; i < a._listaProductos.Count; i++)
            {
                a._listaProductos[i].Mostrar();
            }

        }

        public static bool operator ==(Container a, Producto b)
        {
            bool aux = true;

            if (Object.Equals(null, b))
            {
                aux = false;
            }

            if (a._listaProductos.Count > 0 && aux == true)
            {
                for (int i = 0; i < a._listaProductos.Count; i++)
                {
                    if (a._listaProductos[i] == b)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Container a, Producto b)
        {
            return !(a == b);
        }

        public static List<Producto> operator -(Container a, eTipoComestible etipo)
        {
            List<Producto> lista = new List<Producto>();

            for (int i = 0; i < a._listaProductos.Count; i++)
            {
                if (a._listaProductos[i] == etipo)
                {
                    lista.Add(a._listaProductos[i]);

                }


            }

            return lista;
        }

        public bool Agregar(Producto a)
        {

            if (this._listaProductos.Count == 0)
            {
                this._listaProductos.Add(a);
                return true;
            }
            else
            {
                for (int i = 0; i < this._listaProductos.Count; i++)
                {
                    if (this._listaProductos[i] == a)
                    {
                        return false;
                    }

                    if (this._listaProductos.Count < this._capacidad)
                    {
                        this._listaProductos.Add(a);
                        return true;
                    }

                }


            }

            return false;


        }
    }
}