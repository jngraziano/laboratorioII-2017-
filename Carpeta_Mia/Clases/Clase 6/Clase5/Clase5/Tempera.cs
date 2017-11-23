using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class Tempera
    {
        private ConsoleColor _color;
        private int _cantidad;
        private string _marca;

        public Tempera(ConsoleColor a, int b, string c)
        {
            this._color = a;
            this._cantidad = b;
            this._marca = c;
        
        }
        //metodo de instancia
        private string Mostrar()
        {
            return this._color.ToString() + this._cantidad.ToString() + this._marca;

        }
        //metodo de clase
        public static string Mostrar(Tempera d)
        {
            return d.Mostrar();
        }



    }
}
