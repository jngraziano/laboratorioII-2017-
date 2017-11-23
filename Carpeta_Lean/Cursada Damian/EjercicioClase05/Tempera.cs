using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Tempera
    {
        private ConsoleColor _color;
        private int _cantidad;
        private string _marca;


        //Constructor de Tempera.
        public Tempera(ConsoleColor a, int b, string c)
        {
           
            string aux = c.ToLower();
            string mayuscula = aux.Substring(0,1);

            this._color = a;
            this._cantidad = b;
            this._marca = String.Concat(mayuscula.ToUpper(),aux.Substring(1,aux.Length-1));
        }

        //OK
        private string Mostrar ()
        {
             return this._marca + this._color + this._cantidad;  
        }
        
        //OK
        public static string Mostrar(Tempera a)
        {
            return a.Mostrar();           
        }

        //OK
        public static bool operator ==(Tempera a, Tempera b)
        {


            if (!object.Equals(null, b)&&!object.Equals(null,a))
            {
        
                if ((String.Compare(a._marca, b._marca) == 0) && (a._color == b._color))
                {
                    return true;
                }
                else
                {
                    return false;
                }

               
              }
            
             else
                {
                    return false;
                }
        
        
        }


        //OK
            public static bool operator !=(Tempera a,Tempera b)
            {
                return !(a==b);
            }

        //OK
            public static Tempera operator +(Tempera a, Tempera b)
            {
                if (a == b)
                {
                    return new Tempera(a._color, a._cantidad + b._cantidad, a._marca);
                }

                return a;//Devuelve la Paleta original a;
            }
    }
}
