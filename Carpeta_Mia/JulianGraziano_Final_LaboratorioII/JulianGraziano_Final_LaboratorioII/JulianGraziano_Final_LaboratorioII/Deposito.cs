using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianGraziano_Final_LaboratorioII
{
    class Deposito
    {
        //Modifique el array a lista para el punto 9
        public List<Producto> lista;

        //public Deposito(Producto prod1)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        array[i] = prod1;
        //    }
        //}

        public Deposito(Producto unProducto)
        {
            this.lista.Add(unProducto);
        }

        //public static Producto[] operator + (Producto[] array1, Producto[] array2)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        array1.Concat(array2);
 
        //    }

        //    return array1;
 
        //}


 
    }
}
