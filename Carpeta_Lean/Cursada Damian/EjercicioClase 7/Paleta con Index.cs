using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase_7
{
    class Paleta
    {
        //private Tempera[] _colores;
        private List<Tempera> _colores;
        private int _cantMaxColores;

        private Paleta()
            : this(5)
        {

        }

        public Paleta(int a)
        {

            this._colores = new List<Tempera>();
            this._cantMaxColores = a;

        }




        public Tempera this[int index]
        {

            get
            {
                if (index <= this._colores.Count && index >= 0)
                {
                    return this._colores[index];
                }
                else
                    return new Tempera(ConsoleColor.White,0,"Sin tempera");

            }

            set
            {
                if (this._colores.Count == index && index <= this._cantMaxColores)
                {
                    this._colores.Add(value);
                }
                else
                    this._colores[index] = value;
            }

            }
            
        
        
        
        
        
        //Ok.
        private string Mostrar()
        {

            string acum = "El color es ";

            for (int i = 0; i < this._colores.Count; i++)
            {

                acum = acum + Tempera.Mostrar(this._colores[i]);// String.Concat(acum,Tempera.Mostrar(this._colores[i]));

            }


            return acum;
        }

        //Para probar. 
        public static implicit operator Paleta(int a)
        {
            return new Paleta(a);
        }

        //Para probar.
        public static explicit operator string(Paleta a)
        {
            return a.Mostrar();
        }


        //Para probar.
        public static bool operator ==(Paleta a, Tempera b)
        {

            if (a._colores.Contains(b))
            {
                return true;
            }
            return false;
        }





        //ok
        public static bool operator !=(Paleta a, Tempera b)
        {
            return !(a == b);

        }


        //Para probar.
        public static Paleta operator +(Paleta a, Paleta b)
        {


            int cont = 0;

            for (int i = 0; i < b._colores.Count; i++)
            {



                if (a._colores.Contains(b._colores[i]))
                {
                    cont++;
                }



            }



            Paleta c = new Paleta(a._cantMaxColores + b._cantMaxColores - cont);



            for (int i = 0; i < a._colores.Count; i++)
            {
                c = c + a._colores[i];
            }

            for (int i = 0; i < b._colores.Count; i++)
            {
                c = c + b._colores[i];
            }





            return c;
        }


        //ok
        public static Paleta operator +(Paleta a, Tempera b)
        {
            bool aux = true;



            if (object.Equals(null, b))
            {
                aux = false;

            }





            if (a != b && aux == true)
            {
                if (a._colores.Count < a._cantMaxColores)
                {
                    a._colores.Add(b);
                }
                return a;
            }

            return a;


        }

        //ok
        public static Paleta operator -(Paleta a, Tempera b)
        {

            if (a._colores.Contains(b))
            {
                a._colores.Remove(b);
            }

            return a;

        }




    }



}

