using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Container_Modelo_Parcial_Ej36
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;

        public Container(int capacidad, string Empresa)
        {
           

            this._capacidad=capacidad;
            this._empresa = Empresa;
            this._listaProductos = new List<Producto>();
        }


        public static  void Mostrar(Container Contenedor)
        {
            Console.WriteLine("\n-___CONTAINER___-");
            Console.WriteLine("Empresa:{0}", Contenedor._empresa);
            Console.WriteLine("Capacidad:{0}", Contenedor._capacidad);
            Console.WriteLine("Productos:");
             
            foreach (Producto elemento in Contenedor._listaProductos)
            {
                elemento.mostrar();
            }

        }


        public static bool operator ==(Container contenedor, Producto proUno)
        {
           
            
            foreach (Producto elemento in contenedor._listaProductos)
            {
               if(elemento==proUno)
               {
                   return true;
                   
               }
            }

            return false;
        }

         public static bool operator !=(Container contenedor, Producto proUno)
        {
            return !(contenedor == proUno);
        }


         public static List<Producto> operator -(Container ContenedorUno, eTipoComestible tipo)
         {

            

             foreach (Producto elemento in ContenedorUno._listaProductos)
             {
                 if (elemento == tipo)
                 {
                     ContenedorUno._listaProductos.Add(elemento);
                     break;
                 }
             }

             return ContenedorUno._listaProductos;
         }

         public bool Agregar(Producto proUno)
         {
            
             bool flag = false;



             foreach (Producto elemento in this._listaProductos)
             {
                 if (elemento == proUno)
                 {
                     flag = true;
                 }
             }

             if (flag == false && this._listaProductos.Count < this._capacidad)
             {
                 this._listaProductos.Add(proUno);
                 return true;
             }

             else
             {
                 return false;
             }

           
         }




    }
}
