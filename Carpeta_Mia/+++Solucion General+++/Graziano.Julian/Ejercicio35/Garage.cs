using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Garage
    {
        private string _razonSocial;
        private Double _precioPorHora;
        private Auto[] _autos=new Auto[5];
        /*EJEMPLO: 
         * ARRAY:
         * tipo[] nombre;
         * CADENA DE CARACTERES:
         * int[] n = new int[num];
         */

        public Garage(string razonsocial, Double precioporhora)
        {for(int i=0;i<5;i++)
        {
            this._razonSocial=razonsocial;
            this._precioPorHora=precioporhora;
            
        }
        
        }
        public Garage(string razonsocial, Double precioporhora)
        { }
        //public Garage(string 

    }
}
