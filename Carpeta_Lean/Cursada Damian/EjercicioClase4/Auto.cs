using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4
{
    class Auto
    {
        private string _marca;
        private string _color;
        private ETipoCombustible _tipoCombustible;
        private float _precio;



        public Auto()
        {
            this._marca = "---";
            this._color = "---";
            this._tipoCombustible = ETipoCombustible.Sin_tipo;
            this._precio = 0;
        }
        
        
        
        public Auto (string a): this()
        {
            this._marca = a;
        }

        public Auto(string a, string b): this(a)
        {
            //this._marca = a;
            this._color = b;
        }
    

        public Auto (string a, string b, ETipoCombustible c):this(a,b)
        {
            //this._marca = a;
            //this._color = b;
            this._tipoCombustible = c;
        }


        public Auto(string a, string b, ETipoCombustible c, float d):this(a,b,c)
        {
            //this._marca = a;
            //this._color = b;
            //this._tipoCombustible = c;
            this._precio = d;   
        }

        private string Mostrar()
        {
            return this._color + this._marca + this._precio + this._tipoCombustible;
        }

        public static string Mostrar (Auto a)
        {
            return a.Mostrar();
        }
    
    
    
    }






}
