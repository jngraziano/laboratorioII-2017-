using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligrafoNameSpace
{
    class Boligrafo
    {
        private int _cantidadDeTinta;
        private string _color;
        private string _marca;

        public Boligrafo(string color)
        {
            this._color = color;
        }

        public Boligrafo(string color, string marca):this(color)
        {   
            this._marca = marca;    
        
        }    
        
        public Boligrafo(string color, string marca, int cantidadDeTinta):this(color, marca)
        {
            this._cantidadDeTinta=cantidadDeTinta;
        }

        public Boligrafo(int cantidadDeTinta, string marca, string color)
            : this(color, marca, 0)        
        {
            
        
        }

        private void Mostrar()
        {
            Console.WriteLine("Color: {0}", this._color);
            Console.WriteLine("Marca: {0}", this._marca);
            Console.WriteLine("Cantidad de Tinta: {0}", this._cantidadDeTinta);      
        }
    
        public static void MostrarBoligrafos (List<Boligrafo> a)
        {
                for (int i = 0; i < a.Count; i++)
			        {
			            a[i].Mostrar();
			        }
              
        }

        public void Escribir(int a)
        {
            if (a > this._cantidadDeTinta)
            {
                Console.WriteLine("No hay tinta suficiente en:");
                this.Mostrar();
            }
            else
            {
                this._cantidadDeTinta = this._cantidadDeTinta - a;
            }
        }

        public bool RecargarTinta()
        {
            if (this._cantidadDeTinta < 50)
            {
                this._cantidadDeTinta = 100;
                return true;
            }
            else
                return false;
        }

        public bool RecargarTinta(int a)
        {
            if (this._cantidadDeTinta > 50)
            {
                this._cantidadDeTinta = a;
                return true;
            }
            else
            {
                return false;
            }
        
        }
    
    
        public static bool operator == (Boligrafo a, Boligrafo b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if (String.Compare(a._marca, b._marca) == 0 && String.Compare(a._color, b._color) == 0)
                {
                    return true;
                }
                return false;
            
            }

         
                return false;
             
        
        }

        public static bool operator !=(Boligrafo a, Boligrafo b)
        {
            return !(a == b);
        
        }

        public static List<Boligrafo> operator +(List<Boligrafo> a, Boligrafo b)
        {
            a.Add(b);

            return a;
        }

        public static List<Boligrafo> operator -(List<Boligrafo> a, Boligrafo b)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b)
                {
                    a.Remove(b);
                }
            }

            return a;
        }




    
    
    
    }
}
