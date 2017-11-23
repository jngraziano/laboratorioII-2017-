using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaxColores;

        private Paleta ():this(5)
        {

        }

        public  Paleta (int n) 

        {
            this._colores = new Tempera[n];
            this._cantMaxColores = this._colores.Length;// o igual a n
        }

       
        
        private string Mostrar()
        {
           string acum = "";

                 for (int i = 0; i < _cantMaxColores ; i++)
            {
                
                    
                    String.Concat(acum + Tempera.Mostrar(_colores[i])) ;
            } 

            return acum;
            
        }

        public static implicit operator Paleta(int n)
        {
            return new Paleta(n);
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }
        //Comparo las colores de las temperas con los colores de la paleta
        public static bool operator == (Paleta p, Tempera t)
        {
            

            for (int i = 0; i < p._cantMaxColores; i++)
            {
                if (p._colores[i] == t)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p== t);
        }


        //Metodos
        //    (-) Mostrar():string Retorna string con el contenido complpeto de
        //        la Paleta(incluyendo detalles de los colores)

        //SObrecarga de operadores

        //    == (Paleta,Tempera)
        //   true . Si la tempera esta en la paleta  (utilizar == de tempera)


        //       + (Paleta , Tempera): Paleta
        //           Agrega la tempera a la pleta si y solo si la tempera NO esta en la paleta y
        //               si tiene lugar para guardar dicha tempera

        //        - (Paleta , Tempera): Paleta, Quita, Coloca en NULL la tempera siempre y cuando la tempera este
        //            en la paleta(==)

        //explicit
        //(Paleta): String
        //    Ej: string v=(string)p;

        //implicit

        //(int ):Paleta

        // Ej; Paleta P=5










    }
}
