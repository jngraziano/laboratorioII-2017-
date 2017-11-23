using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Paleta
    {

        List<Tempera> _colores = new List<Tempera>();
        //Tempera[] _colores;
        int _cantMaxColores;

        private Paleta()
            : this(5)
        {

        }

        public Paleta(int a)
        {

            //this._colores = new Tempera[a];
            this._cantMaxColores = _colores.

        }


        private string Mostrar()
        {
            string acum = "";

            for (int i = 0; i < _cantMaxColores; i++)
            {
                String.Concat(acum, " ", Tempera.Mostrar(this._colores[i]));
            }


            return acum;
        }

        public static implicit operator Paleta(int a)
        {
            return new Paleta(a);
        }

        public static explicit operator string(Paleta a)
        {
            return a.Mostrar();
        }

        public static bool operator ==(Paleta a, Tempera b)
        {
            bool flag = false;

            for (int i = 0; i < a._cantMaxColores; i++)
            {
                if (a._colores[i] == b)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public static bool operator !=(Paleta a, Tempera b)
        {
            return !(a == b);

        }








        public static Paleta operator +(Paleta a, Paleta b)
        {


            int cont = 0;

            for (int i = 0; i < a._cantMaxColores; i++)
            {
                for (int j = 0; j < b._cantMaxColores; j++)
                {
                    if (a._colores[i] == b._colores[j])
                    {
                        cont++;
                    }
                }
            }



            Paleta c = new Paleta(a._cantMaxColores + b._cantMaxColores - cont);



            for (int i = 0; i < a._cantMaxColores; i++)
            {
                c._colores[i] = a._colores[i];
            }



            for (int i = 0; i < c._cantMaxColores; i++)
            {
                int j = 0;

                if (c._colores[i] == b._colores[j])
                {
                    c._colores[i] += b._colores[j];
                    j++;

                }

                if (c._colores[i] == null)
                {
                    c._colores[i] = b._colores[j];
                    j++;
                }


            }


            return c;
        }

        public static Paleta operator +(Paleta a, Tempera b)
        {
            bool control = false;


            for (int i = 0; i < a._cantMaxColores; i++)
            {
                if (a._colores[i] == b)
                {
                    control = true;
                }

            }

            int aux = a._colores.Length;

            if (aux < a._cantMaxColores && control == false)
            {
                for (int i = 0; i < a._cantMaxColores; i++)
                {
                    if (a._colores[i] == null)
                    {
                        a._colores[i] = b;
                        control = true;
                    }

                    if (control == true)
                    {
                        break;
                    }


                }

            }

            return a;


        }

        public static Paleta operator -(Paleta a, Tempera b)
        {
            for (int i = 0; i < a._cantMaxColores; i++)
            {
                if (a._colores[i] == b)
                {
                    a._colores[i] = null;

                }
            }

            return a;
        }




    }

}




// Sobre carga Operadores
// + (Paleta, Paleta): Paleta
// Combina los colores de ambas paletas en una nueva. Si un color se repite, se suman sus cantidades.
// Comentario de Damian: Sobre cargare





// +  (Paleta, Tempera) : Paleta
//Agrega la tempera a la paleta si y solo si la tempera no esta en la Paleta y si tiene lugar para guardar dicha tempera.

// -  (Paleta, Tempera) : Paleta
//Quita (coloca en Null) la tempera siempre y cuando la tempera este en la paleta ( ==  de tempera ).