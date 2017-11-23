using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4_operadoresSobreCargados
{
    class Centimetro
    {
        private double _valor;

       
        
        private Centimetro(double a)
        {
            this._valor = a;
        
        }


        public static Centimetro operator +(Centimetro c, Metro m)
        {
            double aux = ((double)m)*100+ c._valor;
       
            Centimetro r = new Centimetro(aux);
             

            return r;
        }

        public static explicit operator double(Centimetro a)
        {
            return a._valor;
        
        }

        
        public static implicit operator Centimetro(double a)
        {
            Centimetro r = new Centimetro(a);

            return r;
        }


        public static  bool operator == (Metro m, Centimetro c)
        {
              return  ((double)m)*100==((double)c);               
        }


        public static bool operator !=(Metro m, Centimetro c)
        {
            //return  ((double)m) / 100 != ((double)c);
            return !(m == c);
        
        }

        public static Centimetro operator ++(Centimetro c)
        {
             c._valor+= 1;

            return c;
        }

        public static Centimetro operator +(Centimetro c, double d)
        {
            c._valor = c._valor + d;

            return c;
        }

        public static double operator /(Centimetro a, Centimetro b)
        {

            return a._valor / b._valor;
          
        }



    }
}