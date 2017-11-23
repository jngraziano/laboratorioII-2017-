using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio3
{
    class ProdImpuesto
    {
        public string Nombre;

        public ProdImpuesto(string nombre) 
        {
            this.Nombre = nombre;
        }

        public static explicit operator ProdImpuesto(string nombre)
        {
            return new ProdImpuesto(nombre);
        }


    }
}
