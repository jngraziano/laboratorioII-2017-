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
        private ETipoCombustible _tipocombustible;
        private float _precio;

        public Auto(string a)
        {
            this._marca = a;
            
        
        }

        public Auto(string b, string c)
        {
            this._marca= b;
            this._color = c;

        }

        public Auto(string d, string e, ETipoCombustible f)
        {
            this._marca = d;
            this._color = e;
            this._tipocombustible = f;

        
        }

        public Auto(string g, string h, ETipoCombustible i, float j)
        {
            this._color = g;
            this._marca = h;
            this._tipocombustible = i;
            this._precio = j;
        }

        public void Mostrar()
        {
            Console.WriteLine("Marca: {0}\nColor: {1}\nTipo Combustible: {2}\nPrecio: {3}", this._marca, this._color, this._tipocombustible, this._precio);
                       
            
        }



        
    }
}
