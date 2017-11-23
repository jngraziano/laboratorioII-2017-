using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Paleta
    {
        private Tempera[] _colores;
        //private List<Tempera> _colores;
        private int _cantMaxColores;

        private Paleta()
            : this(5)
        {

        }

        public Paleta(int a)
        {

            this._colores = new Tempera[a];
            this._cantMaxColores = this._colores.Length;

        }

        //ok
        private string Mostrar()
        {

            string acum = "El color es ";

            for (int i = 0; i < this._cantMaxColores; i++)
            {
                if (this._colores.GetValue(i) != null)
                {
                    acum = acum + Tempera.Mostrar(this._colores[i]);// String.Concat(acum,Tempera.Mostrar(this._colores[i]));
                }
            }


            return acum;
        }

        //ok
        public static implicit operator Paleta(int a)
        {
            return new Paleta(a);
        }

        //ok
        public static explicit operator string(Paleta a)
        {
            return a.Mostrar();
        }


        //ok
        public static bool operator ==(Paleta a, Tempera b)
        {
            bool flag = false;

            for (int i = 0; i < a._cantMaxColores; i++)
            {
                if (a._colores.GetValue(i) != null)
                {

                    if (a._colores[i] == b)
                    {
                        flag = true;
                    }

                }

            }

            return flag;
        }


        //ok
        public static bool operator !=(Paleta a, Tempera b)
        {
            return !(a == b);

        }


        //ok
        public static Paleta operator +(Paleta a, Paleta b)
        {


            int cont = 0;

            for (int i = 0; i < a._cantMaxColores; i++)
            {
                for (int j = 0; j < b._cantMaxColores; j++)
                {
                    if (a._colores.GetValue(i) != null && b._colores.GetValue(j) != null)
                    {
                        if (a._colores[i] == b._colores[j])
                        {
                            cont++;
                        }
                    }

                }
            }



            Paleta c = new Paleta(a._cantMaxColores + b._cantMaxColores - cont);



            for (int i = 0; i < a._cantMaxColores; i++)
            {
                c = c + a._colores[i];
            }

            for (int i = 0; i < b._cantMaxColores; i++)
            {
                c = c + b._colores[i];
            }
            

            


            return c;
        }


        //ok
        public static Paleta operator +(Paleta a, Tempera b)
        {
            bool aux = true;
          
            
			
			    if(object.Equals(null, b))
                {
                    aux = false;
                   
                }
            
            
          
            
            
            if (a != b && aux == true)
            {
                for (int i = 0; i < a._cantMaxColores; i++)
                {


                    if (a._colores.GetValue(i) == null)
                    {
                        a._colores[i] = b;
                        break;
                    }

                } 
                return a;
            }

            return a;


        }

        //OK
        public static Paleta operator -(Paleta a, Tempera b)
        {

            
            
            
            
            
            
            
            for (int i = 0; i < a._cantMaxColores; i++)
            {

                    if (a._colores.GetValue(i) == b)
                    {
                        a._colores[i] = null;
                    }
                }
                return a;

            }

            


        }



    }


//Ejercicio 36.